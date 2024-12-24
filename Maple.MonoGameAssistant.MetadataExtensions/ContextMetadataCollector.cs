using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public abstract partial class ContextMetadataCollector(ILogger logger, MetadataCollectorSearchService searchService, MonoRuntimeContext runtimeContext)
    {
        public ILogger Logger { get; } = logger;
        public MetadataCollectorSearchService SearchService { get; } = searchService;
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        public MonoObjectNameDTO[] ImageNames { get; } = [.. runtimeContext.EnumMonoImageNames()];

        public bool TryGetImageMetadata(MonoSearchClassDTO searchClassDTO, [MaybeNullWhen(false)] out MonoObjectNameDTO imageNameDTO)
        {
            Unsafe.SkipInit(out imageNameDTO);
            foreach (var data in this.ImageNames)
            {
                if (data.EqualImageName(searchClassDTO))
                {
                    imageNameDTO = data;
                    return true;
                }
            }
            return false;


        }

        public bool TryGetClassMetadata(long code, [MaybeNullWhen(false)] out MonoClassMetadataCollection classMetadataCollection)
        {
            Unsafe.SkipInit(out classMetadataCollection);
            if (!this.SearchService.TryGetClass(code, out var searchClassDTO))
            {
                return false;
            }
            if (!this.TryGetImageMetadata(searchClassDTO, out var imageNameDTO))
            {
                return false;
            }
            return this.RuntimeContext.TryGetFirstClassInfo(imageNameDTO, searchClassDTO, out classMetadataCollection);
        }

        public bool TryGetMethodMetadata(long code, MonoClassMetadataCollection classMetadataCollection, [MaybeNullWhen(false)] out MonoMethodInfoDTO methodInfoDTO)
        {
            Unsafe.SkipInit(out methodInfoDTO);
            if (!this.SearchService.TryGetMethod(code, out var searchMethodDTO))
            {
                return false;
            }

            foreach (var method in classMetadataCollection.MethodInfos)
            {
                if (method.EqualMethodName(searchMethodDTO)
                    && method.EqualMethodReturnType(searchMethodDTO)
                    && method.EqualMethodParameterTypes(searchMethodDTO))
                {
                    methodInfoDTO = method;
                    return true;
                }
            }
            return false;

        }


        public bool TryGetFieldMetadata(long code, MonoClassMetadataCollection classMetadataCollection, [MaybeNullWhen(false)] out MonoFieldInfoDTO fieldInfoDTO)
        {
            Unsafe.SkipInit(out fieldInfoDTO);
            if (!this.SearchService.TryGetField(code, out var searchFieldDTO))
            {
                return false;
            }
            IEnumerable<MonoFieldInfoDTO> fieldInfoDTOs =
                searchFieldDTO.IsStatic
                ? classMetadataCollection.EnumStaticFieldInfos()
                : classMetadataCollection.EnumMemberFieldInfos();
            foreach (var field in fieldInfoDTOs)
            {
                if (field.EqualFieldName(searchFieldDTO)
                    && field.EqualFieldType(searchFieldDTO))
                {
                    fieldInfoDTO = field;
                    return true;
                }
            }
            return false;
        }
        public nint GetMonoStaticFieldPointer(MonoFieldInfoDTO fieldInfoDTO) 
        {
            return this.RuntimeContext.GetMonoStaticFieldPointer(fieldInfoDTO.SourceClass, fieldInfoDTO.Pointer);
        }
    }
}

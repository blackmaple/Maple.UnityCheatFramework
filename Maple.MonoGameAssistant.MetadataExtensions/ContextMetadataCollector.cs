using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public abstract partial class ContextMetadataCollector(ILogger logger, MetadataCollectorSearchService searchService, MonoRuntimeContext runtimeContext)
    {
        public ILogger Logger { get; } = logger;
        public MetadataCollectorSearchService SearchService { get; } = searchService;
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        public MonoObjectNameDTO[] ImageNames { get; } = [.. runtimeContext.EnumMonoImageNames()];

        public bool TryGetImageMetadata(long code, [MaybeNullWhen(false)] out MonoObjectNameDTO imageNameDTO, [MaybeNullWhen(false)] out MonoSearchClassDTO searchClassDTO)
        {
            Unsafe.SkipInit(out imageNameDTO);
            if (!this.SearchService.TryGetClass(code, out searchClassDTO))
            {
                return false;
            }
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
        public bool TryGetClassMetadata(MonoObjectNameDTO imageNameDTO, MonoSearchClassDTO searchClassDTO, [MaybeNullWhen(false)] out MonoClassMetadataCollection classMetadataCollection)
        {
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
        public bool TryGetMethodPointer(MonoMethodInfoDTO methodInfoDTO, out nint pointer)
        {
            pointer = this.RuntimeContext.RuntiemProvider.GetMonoMethodAddress(methodInfoDTO.Pointer);
            return pointer != nint.Zero;

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






        public MonoClassMetadataCollection GetClassMetadataCollection(long code)
        {
            if (false == this.TryGetImageMetadata(code, out var imageNameDTO, out var searchClassDTO))
            {
                return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(TryGetImageMetadata)}:{code}");
            }
            if (false == this.TryGetClassMetadata(imageNameDTO, searchClassDTO, out var classMetadataCollection))
            {
                return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(TryGetClassMetadata)}:{code}");
            }
            return classMetadataCollection;
        }
        public nint GetMethodPointer(long code, MonoClassMetadataCollection classMetadataCollection)
        {
            MonoStaticMethodDelegate methodDelegate = GetStaticMethodDelegate(code, classMetadataCollection);
            return methodDelegate.PtrMethod;
        }
        public MonoStaticMethodDelegate GetStaticMethodDelegate(long code, MonoClassMetadataCollection classMetadataCollection)
        {
            if (false == this.TryGetMethodMetadata(code, classMetadataCollection, out var methodInfoDTO))
            {
                return MetadataCollectorException.Throw<MonoStaticMethodDelegate>($"{nameof(TryGetMethodMetadata)}:{code}");
            }
            if (false == this.TryGetMethodPointer(methodInfoDTO, out var pointer))
            {
                return MetadataCollectorException.Throw<MonoStaticMethodDelegate>($"{nameof(TryGetMethodPointer)}:{code}");
            }
            return new(methodInfoDTO.Pointer, pointer);

        }
        public int GetMemberFieldOffset(long code, MonoClassMetadataCollection classMetadataCollection)
        {
            if (false == this.TryGetFieldMetadata(code, classMetadataCollection, out var fieldInfoDTO))
            {
                return MetadataCollectorException.Throw<int>($"{nameof(TryGetFieldMetadata)}:{code}");
            }
            return fieldInfoDTO.Offset;
        }
        public T_PtrMetadata GetStaticFieldValue<T_PtrMetadata>(long code, MonoClassMetadataCollection classMetadataCollection)
            where T_PtrMetadata : unmanaged
        {
            if (false == this.TryGetFieldMetadata(code, classMetadataCollection, out var fieldInfoDTO))
            {
                return default;
            }
            return this.RuntimeContext.GetMonoStaticFieldValueAsUnmanaged<T_PtrMetadata>(fieldInfoDTO.SourceClass, fieldInfoDTO.Pointer);

        }
    }
}

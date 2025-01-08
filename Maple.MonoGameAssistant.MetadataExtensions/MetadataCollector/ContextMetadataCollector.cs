using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataService;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector
{
    public abstract partial class ContextMetadataCollector(ILogger logger, MetadataCollectorSearchService searchService, MonoRuntimeContext runtimeContext) : IMonoMetadataCollector
    {
        public ILogger Logger { get; } = logger;
        public MetadataCollectorSearchService SearchService { get; } = searchService;
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        public EnumMonoRuntimeType TypeVersion => RuntimeContext.RuntimeType;
        public abstract string ApiVersion { get; }
        public MonoObjectNameDTO[] ImageNames { get; } = [.. runtimeContext.EnumMonoImageNames()];

        public bool DefaultTryGetImageMetadata(MonoDescriptionClassDTO descriptionClassDTO, [MaybeNullWhen(false)] out MonoObjectNameDTO imageNameDTO)
        {
            Unsafe.SkipInit(out imageNameDTO);
            foreach (var data in ImageNames)
            {
                if (data.EqualImageName(descriptionClassDTO))
                {
                    imageNameDTO = data;
                    return true;
                }
            }
            return false;
        }
        public virtual bool CustomTryGetImageMetadata(MonoDescriptionClassDTO descriptionClassDTO, [MaybeNullWhen(false)] out MonoObjectNameDTO imageNameDTO)
        {
            Unsafe.SkipInit(out imageNameDTO);
            return false;
        }
        public bool TryGetImageMetadata(MonoDescriptionClassDTO descriptionClassDTO, [MaybeNullWhen(false)] out MonoObjectNameDTO imageNameDTO)
        {
            return CustomTryGetImageMetadata(descriptionClassDTO, out imageNameDTO) || DefaultTryGetImageMetadata(descriptionClassDTO, out imageNameDTO);
        }


        public bool DefaultTryGetClassMetadata(
            MonoObjectNameDTO imageNameDTO, MonoDescriptionClassDTO descriptionClassDTO,
            [MaybeNullWhen(false)] out MonoClassMetadataCollection classMetadataCollection)
        {
            Unsafe.SkipInit(out classMetadataCollection);
            if (RuntimeContext.TryGetFirstMonoClass(imageNameDTO.Pointer, descriptionClassDTO.Utf8Namespace, descriptionClassDTO.Utf8ClassName, out var pMonoClass)
              || RuntimeContext.TryGetFirstMonoClass(imageNameDTO.Pointer, descriptionClassDTO.Utf8Name, out pMonoClass))
            {
                var classInfoDTO = RuntimeContext.GetMonoClassInfoDTO(pMonoClass);
                classMetadataCollection = new MonoClassMetadataCollection()
                {
                    ClassInfo = classInfoDTO,
                    MethodInfos = [.. RuntimeContext.EnumMonoMethods(pMonoClass, classInfoDTO.IsValueType)],
                    FieldInfos = [.. RuntimeContext.EnumMonoFields(pMonoClass, EnumMonoFieldOptions.None)],
                };

                return true;
            }
            return false;
        }
        public virtual bool CustomTryGetClassMetadata(
            MonoObjectNameDTO imageNameDTO, MonoDescriptionClassDTO descriptionClassDTO,
            [MaybeNullWhen(false)] out MonoClassMetadataCollection classMetadataCollection)
        {
            Unsafe.SkipInit(out classMetadataCollection);
            return false;
        }
        public bool TryGetClassMetadata(
            MonoObjectNameDTO imageNameDTO, MonoDescriptionClassDTO descriptionClassDTO,
            [MaybeNullWhen(false)] out MonoClassMetadataCollection classMetadataCollection)
        {
            return CustomTryGetClassMetadata(imageNameDTO, descriptionClassDTO, out classMetadataCollection)
              || DefaultTryGetClassMetadata(imageNameDTO, descriptionClassDTO, out classMetadataCollection);
        }

        public MonoClassMetadataCollection GetClassMetadataCollection(ulong code)
        {
            if (false == SearchService.TrySearchClass(code, out var descriptionClassDTO))
            {
                return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(MetadataCollectorSearchService.TrySearchClass)}:{code}");
            }
            if (false == TryGetImageMetadata(descriptionClassDTO, out var imageNameDTO))
            {
                return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(TryGetImageMetadata)}:{code}");
            }
            if (false == TryGetClassMetadata(imageNameDTO, descriptionClassDTO, out var classMetadataCollection))
            {
                return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(TryGetClassMetadata)}:{code}");
            }
            return classMetadataCollection;
        }


    }
}

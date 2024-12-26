using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.Common;
using Maple.MonoGameAssistant.MetadataExtensions.Service;
using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.Metadata
{
    public abstract partial class ContextMetadataCollector : IContextMetadataCollectorBase
    {
        public static ContextMetadataCollector? Default { get; private set; }


        public ILogger Logger { get; }
        public MetadataCollectorSearchService SearchService { get; }
        public MonoRuntimeContext RuntimeContext { get; }
        public MonoObjectNameDTO[] ImageNames { get; }
        protected ContextMetadataCollector(ILogger logger, MetadataCollectorSearchService searchService, MonoRuntimeContext runtimeContext)
        {
            this.Logger = logger;
            this.SearchService = searchService;
            this.RuntimeContext = runtimeContext;
            this.ImageNames = [.. runtimeContext.EnumMonoImageNames()];
            Default = this;
        }


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
            if (this.RuntimeContext.TryGetFirstMonoClass(imageNameDTO.Pointer, descriptionClassDTO.Utf8Namespace, descriptionClassDTO.Utf8ClassName, out var pMonoClass)
              || this.RuntimeContext.TryGetFirstMonoClass(imageNameDTO.Pointer, descriptionClassDTO.Utf8Name, out pMonoClass))
            {
                var classInfoDTO = this.RuntimeContext.GetMonoClassInfoDTO(pMonoClass);
                classMetadataCollection = new MonoClassMetadataCollection()
                {
                    ClassInfo = classInfoDTO,
                    MethodInfos = [.. this.RuntimeContext.EnumMonoMethods(pMonoClass, classInfoDTO.IsValueType)],
                    FieldInfos = [.. this.RuntimeContext.EnumMonoFields(pMonoClass, EnumMonoFieldOptions.None)],
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

        object IContextMetadataCollectorBase.GetClassMetadataCollection(ulong code) => GetClassMetadataCollection(code);

    }
}

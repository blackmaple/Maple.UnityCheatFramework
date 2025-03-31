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

        #region Class
        public bool TryGetImageMetadata(MonoDescriptionClassDTO descriptionClassDTO, [MaybeNullWhen(false)] out MonoObjectNameDTO imageNameDTO)
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

        public bool TryGetClassMetadata(
            MonoObjectNameDTO imageNameDTO, MonoDescriptionClassDTO descriptionClassDTO,
            [MaybeNullWhen(false)] out MonoClassMetadataCollection classMetadataCollection)
        {
            Unsafe.SkipInit(out classMetadataCollection);
            if (RuntimeContext.TryGetFirstMonoClass(imageNameDTO.Pointer, descriptionClassDTO.Utf8Namespace, descriptionClassDTO.Utf8ClassName, out var pMonoClass)
              || RuntimeContext.TryGetFirstMonoClass(imageNameDTO.Pointer, descriptionClassDTO.Utf8Name, out pMonoClass))
            {
                classMetadataCollection = RuntimeContext.GetMonoClassMetadataCollection(pMonoClass);
                return true;
            }
            return false;
        }

        public virtual MonoClassMetadataCollection GetClassMetadataCollection(ulong code)
        {
            if (false == SearchService.TrySearchClass(code, out var descriptionClassDTO))
            {
                return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(MetadataCollectorSearchService.TrySearchClass)}:{code:X8}");
            }
            if (false == TryGetImageMetadata(descriptionClassDTO, out var imageNameDTO))
            {
                return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(TryGetImageMetadata)}:{code:X8}");
            }
            if (false == TryGetClassMetadata(imageNameDTO, descriptionClassDTO, out var classMetadataCollection))
            {
                return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(TryGetClassMetadata)}:{code:X8}");
            }
            return classMetadataCollection;
        }
        #endregion

        #region Field
        public static MonoFieldInfoDTO GetFieldMetadata(MonoClassMetadataCollection classMetadataCollection, MonoDescriptionFieldDTO descriptionFieldDTO)
        {
            if (false == classMetadataCollection.TryGetFieldMetadata(descriptionFieldDTO, out var fieldInfoDTO))
            {
                return MetadataCollectorException.Throw<MonoFieldInfoDTO>($"{nameof(MetadataCollectorExtensions.TryGetFieldMetadata)}:{descriptionFieldDTO.Code}");
            }
            return fieldInfoDTO;
        }
        public virtual MonoFieldInfoDTO GetFieldMetadata(ulong code, MonoClassMetadataCollection classMetadataCollection)
        {
            if (false == SearchService.TrySearchField(code, out var descriptionFieldDTO))
            {
                return MetadataCollectorException.Throw<MonoFieldInfoDTO>($"{nameof(MetadataCollectorSearchService.TrySearchField)}:{code}");
            }
            return GetFieldMetadata(classMetadataCollection, descriptionFieldDTO);
        }
        #endregion

        #region Method
        public static MonoMethodDelegate GetMethodDelegate(MonoRuntimeContext runtimeContext, MonoClassMetadataCollection classMetadataCollection, MonoDescriptionMethodDTO descriptionMethodDTO)
        {
            if (false == classMetadataCollection.TryGetMethodMetadata(descriptionMethodDTO, out var methodInfoDTO))
            {
                return MetadataCollectorException.Throw<MonoMethodDelegate>($"{nameof(GetMethodDelegate)}:{descriptionMethodDTO.Code}");
            }
            if (false == runtimeContext.TryGetMethodPointer(methodInfoDTO, out var pointer))
            {
                return MetadataCollectorException.Throw<MonoMethodDelegate>($"{nameof(GetMethodDelegate)}:{descriptionMethodDTO.Code}");
            }
            return new(methodInfoDTO.Pointer, pointer);
        }
        public virtual MonoMethodDelegate GetMethodDelegate(ulong code, MonoClassMetadataCollection classMetadataCollection)
        {
            if (false == SearchService.TrySearchMethod(code, out var descriptionMethodDTO))
            {
                return MetadataCollectorException.Throw<MonoMethodDelegate>($"{nameof(MetadataCollectorSearchService.TrySearchClass)}:{code}");
            }
            return GetMethodDelegate(this.RuntimeContext, classMetadataCollection, descriptionMethodDTO);
        }
        #endregion
    }
}

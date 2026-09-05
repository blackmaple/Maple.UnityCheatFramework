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
using System.Text;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector
{
    public abstract partial class ContextMetadataCollector(ILogger logger, MetadataCollectorSearchService searchService, MonoRuntimeContext runtimeContext) : IMonoMetadataCollector
    {
        static MonoFieldInfoDTO ErrorFieldInfo { get; } = new MonoFieldInfoDTO() { FieldType = new MonoFieldTypeDTO() };
        static MonoClassMetadataCollection ErrorClassMetadataCollection { get; } = new MonoClassMetadataCollection()
        {
            IsEmpty = true,
            ClassInfo = new MonoClassInfoDTO(),
            FieldInfos = [],
            MethodInfos = [],
        };


        public ILogger Logger { get; } = logger;
        public MetadataCollectorSearchService SearchService { get; } = searchService;
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;
        public EnumMonoRuntimeType TypeVersion => RuntimeContext.RuntimeType;
        public abstract string ApiVersion { get; }
        public MonoObjectNameDTO[] ImageNames { get; } = [.. runtimeContext.EnumMonoImageNames()];

        public StringBuilder Exceptions { get; } = new(1024);
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
                return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(MetadataCollectorSearchService.TrySearchClass)}:{code:X}");
            }
            if (false == TryGetImageMetadata(descriptionClassDTO, out var imageNameDTO))
            {
                return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(TryGetImageMetadata)}:{Encoding.UTF8.GetString(descriptionClassDTO.Utf8ImageName ?? [])}");
            }
            if (false == TryGetClassMetadata(imageNameDTO, descriptionClassDTO, out var classMetadataCollection))
            {
                return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(TryGetClassMetadata)}:{Encoding.UTF8.GetString(descriptionClassDTO.Utf8Namespace ?? [])}.{Encoding.UTF8.GetString(descriptionClassDTO.Utf8ClassName ?? [])}");
            }
            return classMetadataCollection;
        }


        public MonoClassMetadataCollection GetClassMetadataCollection_SG(ulong code)
        {
            try
            {
                return GetClassMetadataCollection(code);
            }
            catch (Exception ex)
            {
                this.Exceptions.AppendLine(ex.ToString());
            }
            return ErrorClassMetadataCollection;
        }
        #endregion

        #region Field
        public static MonoFieldInfoDTO GetFieldMetadata(MonoClassMetadataCollection classMetadataCollection, MonoDescriptionFieldDTO descriptionFieldDTO)
        {
            if (false == classMetadataCollection.TryGetFieldMetadata(descriptionFieldDTO, out var fieldInfoDTO))
            {
                return MetadataCollectorException.Throw<MonoFieldInfoDTO>($"{nameof(MetadataCollectorExtensions.TryGetFieldMetadata)}:{Encoding.UTF8.GetString(descriptionFieldDTO.Utf8FieldType ?? [])} {Encoding.UTF8.GetString(descriptionFieldDTO.Utf8Name ?? [])}");
            }
            return fieldInfoDTO;
        }
        public virtual MonoFieldInfoDTO GetFieldMetadata(ulong code, MonoClassMetadataCollection classMetadataCollection)
        {
            if (false == SearchService.TrySearchField(code, out var descriptionFieldDTO))
            {
                return MetadataCollectorException.Throw<MonoFieldInfoDTO>($"{nameof(MetadataCollectorSearchService.TrySearchField)}:{code:X}");
            }
            return GetFieldMetadata(classMetadataCollection, descriptionFieldDTO);
        }


        public MonoFieldInfoDTO GetFieldMetadata_SG(ulong code, MonoClassMetadataCollection classMetadataCollection)
        {
            if (classMetadataCollection.IsEmpty)
            {
                return ErrorFieldInfo;
            }
            try
            {
                return GetFieldMetadata(code, classMetadataCollection);
            }
            catch (Exception ex)
            {
                this.Exceptions.AppendLine(ex.ToString());
            }
            return ErrorFieldInfo;
        }
        #endregion

        #region Method
        public static MonoMethodDelegate GetMethodDelegate(MonoRuntimeContext runtimeContext, MonoClassMetadataCollection classMetadataCollection, MonoDescriptionMethodDTO descriptionMethodDTO)
        {
            if (false == classMetadataCollection.TryGetMethodMetadata(descriptionMethodDTO, out var methodInfoDTO))
            {
                return MetadataCollectorException.Throw<MonoMethodDelegate>($"{nameof(GetMethodDelegate)}:{Encoding.UTF8.GetString(descriptionMethodDTO.Utf8Name ?? [])}");
            }
            if (false == runtimeContext.TryGetMethodPointer(methodInfoDTO, out var pointer))
            {
                return MetadataCollectorException.Throw<MonoMethodDelegate>($"{nameof(GetMethodDelegate)}:{Encoding.UTF8.GetString(descriptionMethodDTO.Utf8Name ?? [])}");
            }
            return new(methodInfoDTO.Pointer, pointer);
        }
        public virtual MonoMethodDelegate GetMethodDelegate(ulong code, MonoClassMetadataCollection classMetadataCollection)
        {
            if (false == SearchService.TrySearchMethod(code, out var descriptionMethodDTO))
            {
                return MetadataCollectorException.Throw<MonoMethodDelegate>($"{nameof(MetadataCollectorSearchService.TrySearchClass)}:{code:X}");
            }
            return GetMethodDelegate(this.RuntimeContext, classMetadataCollection, descriptionMethodDTO);
        }

        public MonoMethodDelegate GetMethodDelegate_SG(ulong code, MonoClassMetadataCollection classMetadataCollection)
        {
            if (classMetadataCollection.IsEmpty)
            {
                return default;
            }
            try
            {
                return GetMethodDelegate(code, classMetadataCollection);
            }
            catch (Exception ex)
            {
                this.Exceptions.AppendLine(ex.ToString());
            }
            return default;
        }
        #endregion
    }
}

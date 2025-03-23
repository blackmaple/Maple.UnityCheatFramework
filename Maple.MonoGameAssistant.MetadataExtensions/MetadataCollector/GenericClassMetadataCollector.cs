using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataObject;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataService;
using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector
{
    public abstract partial class GenericClassMetadataCollector(MonoRuntimeContext runtimeContext, MonoClassMetadataCollection classMetadataCollection)
        : AbstractClassMetadataCollector(runtimeContext, classMetadataCollection)
    {


        public MonoMethodDelegate<TFUNC> GetMethodDelegate<TFUNC>(MonoDescriptionMethodDTO descriptionMethodDTO) where TFUNC : unmanaged
            => GetMethodDelegate(descriptionMethodDTO);
        public nint GetMethodPointer(MonoDescriptionMethodDTO descriptionMethodDTO)
        {
            MonoMethodDelegate methodDelegate = GetMethodDelegate(descriptionMethodDTO);
            return methodDelegate.MethodPointer;

        }

        public MonoMemberFieldSource GetMemberFieldMetadata(MonoDescriptionFieldDTO descriptionFieldDTO)
        {
            var fieldInfoDTO = GetFieldMetadata(descriptionFieldDTO);
            return new MonoMemberFieldSource(fieldInfoDTO.Pointer, fieldInfoDTO.Offset);

        }
        public MonoStaticFieldSource GetStaticFieldMetadata(MonoDescriptionFieldDTO descriptionFieldDTO)
        {
            var fieldInfoDTO = GetFieldMetadata(descriptionFieldDTO);
            return new MonoStaticFieldSource(fieldInfoDTO.Pointer, fieldInfoDTO.SourceClass);
        }
        public int GetMemberFieldOffset(MonoDescriptionFieldDTO descriptionFieldDTO)
        {
            var fieldSource = GetFieldMetadata(descriptionFieldDTO);
            return fieldSource.Offset;
        }

    }

    public abstract partial class GenericClassMetadataCollector<T_Self, T_PtrMetadata>(MonoRuntimeContext runtimeContext, MonoClassMetadataCollection classMetadataCollection)
        : AbstractClassMetadataCollector(runtimeContext, classMetadataCollection), IPtrMetadataCollector<T_PtrMetadata>
        where T_PtrMetadata : unmanaged, IPtrMetadata
        where T_Self : GenericClassMetadataCollector<T_Self, T_PtrMetadata>
    {

        #region Static
        protected static T_Self? Self { get; set; }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static T_Self LoadMetadata(T_PtrMetadata ptrMetadata, Func<MonoRuntimeContext, MonoClassMetadataCollection, T_Self> func)
        {
            if (Self is not null)
            {
                return Self;
            }
            if (false == ptrMetadata.TryLoadMetadata(out var runtimeContext, out var classMetadataCollection))
            {
                return MetadataCollectorException.Throw<T_Self>($"{nameof(ClassMetadataCollectorExtensions.TryLoadMetadata)}:{typeof(T_Self).FullName} ERROR");
            }
            Self = func(runtimeContext, classMetadataCollection);
            return Self;
        }


        #endregion


    }
}

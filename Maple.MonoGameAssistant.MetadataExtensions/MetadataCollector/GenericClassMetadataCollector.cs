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
    public abstract partial class GenericClassMetadataCollector(MonoRuntimeContext runtimeContext, PMonoObject pMonoObject)
        : AbstractClassMetadataCollector(runtimeContext, GetMonoClassMetadataCollectionThrowIfNull(runtimeContext, pMonoObject))
    {


        public MonoMethodDelegate<TFUNC> GetMethodDelegate<TFUNC>(MonoJsonMethodDTO descriptionMethodDTO) where TFUNC : unmanaged
            => GetMethodDelegate(descriptionMethodDTO);
        public nint GetMethodPointer(MonoJsonMethodDTO descriptionMethodDTO)
        {
            MonoMethodDelegate methodDelegate = GetMethodDelegate(descriptionMethodDTO);
            return methodDelegate.MethodPointer;

        }

        public MonoMemberFieldSource GetMemberFieldMetadata(MonoJsonFieldDTO descriptionFieldDTO)
        {
            var fieldInfoDTO = GetFieldMetadata(descriptionFieldDTO);
            return new MonoMemberFieldSource(fieldInfoDTO.Pointer, fieldInfoDTO.Offset);

        }
        public MonoStaticFieldSource GetStaticFieldMetadata(MonoJsonFieldDTO descriptionFieldDTO)
        {
            var fieldInfoDTO = GetFieldMetadata(descriptionFieldDTO);
            return new MonoStaticFieldSource(fieldInfoDTO.Pointer, fieldInfoDTO.SourceClass);
        }
        public int GetMemberFieldOffset(MonoJsonFieldDTO descriptionFieldDTO)
        {
            var fieldSource = GetFieldMetadata(descriptionFieldDTO);
            return fieldSource.Offset;
        }


        protected static MonoRuntimeContext GetGlobalInstanceThrowIfNull()
        {
            return MonoRuntimeContext.GlobalInstance ?? MetadataCollectorException.Throw<MonoRuntimeContext>($"{nameof(MonoRuntimeContext)}.{nameof(MonoRuntimeContext.GlobalInstance)} IS NULL");
        }

        protected static MonoClassMetadataCollection GetMonoClassMetadataCollectionThrowIfNull(MonoRuntimeContext runtimeContext, PMonoObject pMonoObject)
        {
            if (runtimeContext.TryGetClassMetadata(pMonoObject, out var classMetadataCollection))
            {
                return classMetadataCollection;
            }
            return MetadataCollectorException.Throw<MonoClassMetadataCollection>($"{nameof(MetadataObjectExtensions.TryGetClassMetadata)} ERROR");

        }

    }

    public abstract partial class GenericClassMetadataCollector<T_Self, T_PtrMetadata>(T_PtrMetadata ptrMetadata)
        : GenericClassMetadataCollector(GetGlobalInstanceThrowIfNull(), ptrMetadata.Ptr), IPtrMetadataCollector<T_PtrMetadata>
        , IGenericClassMetadataCollector
        where T_PtrMetadata : unmanaged, IPtrMetadata
        where T_Self : GenericClassMetadataCollector<T_Self, T_PtrMetadata>
    {

        #region Static
        protected static T_Self? Self { get; set; }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static T_Self LoadMetadata(T_PtrMetadata ptrMetadata, Func<T_PtrMetadata, T_Self> func)
        {
            if (Self is not null)
            {
                return Self;
            }
            Self = func(ptrMetadata);
            return Self;
        }


        //public static T_Self1 LoadMetadata<T_Self1, T_PtrMetadata1>(T_PtrMetadata1 ptrMetadata)
        //    where T_Self1 : class
        //    where T_PtrMetadata1 : unmanaged, IPtrMetadata
        //{
        //    throw new NotImplementedException();
        //}


        #endregion


    }
}

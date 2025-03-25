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

        public static bool TryGetMonoClassMetadataCollection(MonoRuntimeContext runtimeContext, PMonoObject pMonoObject, [MaybeNullWhen(false)] out MonoClassMetadataCollection classMetadataCollection)
        {
            return runtimeContext.TryGetClassMetadata(pMonoObject, out classMetadataCollection);
        }
    }

    public abstract partial class GenericClassMetadataCollector<T_PtrMetadata>(MonoRuntimeContext runtimeContext, MonoClassMetadataCollection classMetadataCollection)
        : GenericClassMetadataCollector(runtimeContext, classMetadataCollection), IPtrMetadataCollector<T_PtrMetadata>
        , IGenericClassMetadataCollector
        where T_PtrMetadata : unmanaged, IPtrMetadata
    {

    }
}

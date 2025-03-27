using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataObject;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataService;
using Maple.MonoGameAssistant.Model;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector
{

    public abstract partial class GenericClassMetadataCollector(MonoRuntimeContext runtimeContext, MonoClassMetadataCollection classMetadataCollection)
        : AbstractClassMetadataCollector(runtimeContext, classMetadataCollection)
    {
        protected static ConcurrentDictionary<string, GenericClassMetadataCollector> CacheClassMetadataCollector { get; } = [];

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



    }

    public abstract partial class GenericClassMetadataCollector<T_PtrMetadata>(MonoRuntimeContext runtimeContext, MonoClassMetadataCollection classMetadataCollection)
        : GenericClassMetadataCollector(runtimeContext, classMetadataCollection)
        , IPtrMetadataCollector<T_PtrMetadata>
        , IGenericClassMetadataCollector
        where T_PtrMetadata : unmanaged, IPtrMetadata
    {

        static TSelf LoadMetadataImp<TSelf>(MonoRuntimeContext runtimeContext, T_PtrMetadata ptrMetadata, Func<MonoRuntimeContext, MonoClassMetadataCollection, TSelf> func)
           where TSelf : GenericClassMetadataCollector<T_PtrMetadata>
        {

            if (!runtimeContext.TryGetOrAddClassMetadata(ptrMetadata.Ptr, out var classMetadataCollection))
            {
                return MetadataCollectorException.Throw<TSelf>($"{typeof(TSelf).FullName}.{nameof(LoadMetadataImp)}:ERROR");
            }
            return func(runtimeContext, classMetadataCollection);
        }

       // [MethodImpl(MethodImplOptions.Synchronized)]
        public static TSelf LoadMetadata<TSelf>(MonoRuntimeContext runtimeContext, T_PtrMetadata ptrMetadata, Func<MonoRuntimeContext, MonoClassMetadataCollection, TSelf> func)
            where TSelf : GenericClassMetadataCollector<T_PtrMetadata>
        {
            if (CacheClassMetadataCollector.GetOrAdd(typeof(TSelf).FullName!, p => LoadMetadataImp(runtimeContext, ptrMetadata, func)) is TSelf self)
            {
                return self;
            }
            return MetadataCollectorException.Throw<TSelf>($"{typeof(TSelf).FullName}.{nameof(LoadMetadata)}:ERROR");

        }


    }




}

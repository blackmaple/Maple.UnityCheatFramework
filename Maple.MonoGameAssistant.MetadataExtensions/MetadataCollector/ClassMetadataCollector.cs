using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataService;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector
{
    public abstract partial class AbstractClassMetadataCollector(MonoRuntimeContext runtimeContext, MonoClassMetadataCollection classMetadataCollection)
        : IAbstractClassMetadataCollector
    {
        public MonoClassMetadataCollection ClassMetadata { get; } = classMetadataCollection;
        public MonoRuntimeContext RuntimeContext { get; } = runtimeContext;



        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T_FieldValue GetStaticFieldValue<T_FieldValue>(in MonoStaticFieldSource staticFieldSource)
            where T_FieldValue : unmanaged
        {
            var context = MonoRuntimeContext.GlobalInstance;
            if (context is null)
            {
                return default;
            }
            return context.GetMonoStaticFieldValueAsUnmanaged<T_FieldValue>(staticFieldSource.SourceClass, staticFieldSource.RuntimeField);
        }
        [DoesNotReturn]
        public static void SetStaticFieldValue<T_FieldValue>(in MonoStaticFieldSource staticFieldSource, in T_FieldValue value)
            where T_FieldValue : unmanaged
        {
            throw new NotImplementedException();
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T_FieldValue GetMemberFieldValue<T_FieldValue>(nint @this, int fieldOffset) where T_FieldValue : unmanaged
        {
            ref var ref_Buffer = ref @this.AsRefStruct<byte>();
            ref var ref_Member = ref Unsafe.Add(ref ref_Buffer, fieldOffset);
            ref var ref_Value = ref Unsafe.As<byte, T_FieldValue>(ref ref_Member);
            return ref ref_Value;

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMemberFieldValue<T_FieldValue>(nint @this, int fieldOffset, in T_FieldValue value)
            where T_FieldValue : unmanaged
        {
            ref var ref_Value = ref GetMemberFieldValue<T_FieldValue>(@this, fieldOffset);
            ref_Value = value;
        }

    }

    public abstract partial class ClassMetadataCollector(ContextMetadataCollector contextMetadata, MonoClassMetadataCollection classMetadataCollection)
        : AbstractClassMetadataCollector(contextMetadata.RuntimeContext, classMetadataCollection), IClassMetadataCollector
    {

        public ContextMetadataCollector ContextMetadata { get; } = contextMetadata;

        public MonoMethodDelegate GetMethodDelegate(ulong code)
        {
            return ContextMetadata.GetMethodDelegate(code, ClassMetadata);
        }
        public MonoMethodDelegate<TFUNC> GetMethodDelegate<TFUNC>(ulong code) where TFUNC : unmanaged
            => GetMethodDelegate(code);
        public nint GetMethodPointer(ulong code)
        {
            MonoMethodDelegate methodDelegate = GetMethodDelegate(code);
            return methodDelegate.MethodPointer;
        }


        public MonoFieldInfoDTO GetFieldMetadata(ulong code)
        {
            return ContextMetadata.GetFieldMetadata(code, ClassMetadata);
        }
        public MonoMemberFieldSource GetMemberFieldMetadata(ulong code)
        {
            var fieldInfoDTO = GetFieldMetadata(code);
            return new MonoMemberFieldSource(fieldInfoDTO.Pointer, fieldInfoDTO.Offset);
        }
        public MonoStaticFieldSource GetStaticFieldMetadata(ulong code)
        {
            var fieldInfoDTO = GetFieldMetadata(code);
            return new MonoStaticFieldSource(fieldInfoDTO.Pointer, fieldInfoDTO.SourceClass);
        }
        public int GetMemberFieldOffset(ulong code)
        {
            var fieldSource = GetFieldMetadata(code);
            return fieldSource.Offset;
        }


    }

    public abstract partial class ClassMetadataCollector<T_RefMetadata, T_PtrMetadata>(ContextMetadataCollector metadataCollector, ulong code)
        : ClassMetadataCollector<T_PtrMetadata>(metadataCollector, code)
        , IRefMetadataCollector<T_RefMetadata>
        , IPtrMetadataCollector<T_PtrMetadata>
        where T_RefMetadata : unmanaged, IRefMetadata
        where T_PtrMetadata : unmanaged, IPtrMetadata
    {
    }

    public abstract partial class ClassMetadataCollector<T_PtrMetadata>(ContextMetadataCollector metadataCollector, ulong code)
        : ClassMetadataCollector(metadataCollector, metadataCollector.GetClassMetadataCollection(code))
        , IPtrMetadataCollector<T_PtrMetadata>
        where T_PtrMetadata : unmanaged, IPtrMetadata
    {


    }
}

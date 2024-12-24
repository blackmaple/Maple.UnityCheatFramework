using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public abstract partial class ClassMetadataCollector(ContextMetadataCollector metadataCollector, MonoClassMetadataCollection collection) : IClassMetadataCollectorCode
    {
        public ContextMetadataCollector MetadataCollector { get; } = metadataCollector;
        public ILogger Logger => MetadataCollector.Logger;
        public MetadataCollectorSearchService SearchService => MetadataCollector.SearchService;
        public MonoRuntimeContext RuntimeContext => MetadataCollector.RuntimeContext;
        public MonoClassMetadataCollection Collection { get; } = collection;



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
}

using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataObject;
using static Maple.MonoGameAssistant.MetadataCollections.SystemStackGeneric<T>;

namespace Maple.MonoGameAssistant.MetadataCollections
{
    partial class SystemDictionaryGeneric<TKey, TValue>
    {
        public static SystemDictionaryGeneric<TKey, TValue> LoadMetadata(MonoRuntimeContext runtimeContext, Ptr_SystemDictionaryGeneric ptr)
        {
            return LoadMetadata<SystemDictionaryGeneric<TKey, TValue>>(runtimeContext, ptr, static (r, c) => new(r, c));
        }

        partial struct Ptr_SystemDictionaryGeneric : ISysPtrDictionary<TKey, TValue>
        {
            public int Count => _COUNT;

            public int FreeCount => _FREE_COUNT;

            public int Size => Count - FreeCount;

            public PMonoArray<Ref_MonoEntry<TKey, TValue>> Entries => _ENTRIES;

            public PMonoEntry<Ref_MonoEntry<TKey, TValue>, TKey, TValue>[] AsRefArray() => this.PtrDictionaryAsRefArray<Ptr_SystemDictionaryGeneric, TKey, TValue>();

        }
    }
}

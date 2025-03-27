using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataObject;

namespace Maple.MonoGameAssistant.MetadataCollections
{
    partial class SystemDictionaryGeneric<TKey, TValue>
    {
        public static SystemDictionaryGeneric<TKey, TValue> LoadMetadata(MonoRuntimeContext runtimeContext, Ptr_SystemDictionaryGeneric ptr)
        {
            return LoadMetadata<SystemDictionaryGeneric<TKey, TValue>>(runtimeContext, ptr, static (r, c) => new(r, c));
        }

        public static Ptr_SystemDictionaryGeneric LoadSelf(MonoRuntimeContext runtimeContext, Ptr_SystemDictionaryGeneric ptr)
        {
            _ = LoadMetadata<SystemDictionaryGeneric<TKey, TValue>>(runtimeContext, ptr, static (r, c) => new(r, c));
            return ptr;
        }

        partial struct Ptr_SystemDictionaryGeneric : ISysPtrDictionary<TKey, TValue>
        {
            public int Count => _COUNT;

            public int FreeCount => _FREE_COUNT;

            public int Size => Count - FreeCount;

            public PMonoArray<Ref_MonoEntry<TKey, TValue>> Entries => _ENTRIES;

            public PMonoEntry<Ref_MonoEntry<TKey, TValue>, TKey, TValue>[] AsRefArray() => this.PtrDictionaryAsRefArray<Ptr_SystemDictionaryGeneric, TKey, TValue>();

            public IEnumerable<PMonoEntry<Ref_MonoEntry<TKey, TValue>, TKey, TValue>> AsRefEnumerable() => this.PtrDictionaryAsRefEnumerable<Ptr_SystemDictionaryGeneric, TKey, TValue>();


            
        }
    }



}

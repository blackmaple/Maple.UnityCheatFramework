using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataObject;

namespace Maple.MonoGameAssistant.MetadataCollections
{
    partial class SystemHashSetGeneric<T>
    {
        public static SystemHashSetGeneric<T> LoadMetadata(MonoRuntimeContext runtimeContext, Ptr_SystemHashSetGeneric ptr)
        {
            return LoadMetadata<SystemHashSetGeneric<T>>(runtimeContext, ptr, static (r, c) => new(r, c));
        }

        partial struct Ptr_SystemHashSetGeneric : ISysPtrHashSet<T>
        {
            public int Count => _COUNT;

            public int LastIndex => _LAST_INDEX;

            public PMonoArray<Ref_MonoSlot<T>> Slots => _SLOTS;

            public PMonoSlot<Ref_MonoSlot<T>, T>[] AsRefArray() => this.PtrHashSetAsRefArray<Ptr_SystemHashSetGeneric, T>();
        }
    }
}

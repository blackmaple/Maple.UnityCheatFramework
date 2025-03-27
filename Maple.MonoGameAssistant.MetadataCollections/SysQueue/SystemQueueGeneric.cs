using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataObject;

namespace Maple.MonoGameAssistant.MetadataCollections
{
    partial class SystemQueueGeneric<T>
    {
        public static SystemQueueGeneric<T> LoadMetadata(MonoRuntimeContext runtimeContext, Ptr_SystemQueueGeneric ptr)
        {
            return LoadMetadata<SystemQueueGeneric<T>>(runtimeContext, ptr, static (r, c) => new(r, c));
        }

        partial struct Ptr_SystemQueueGeneric : ISysPtrQueue<T>
        {
            public int Size => _SIZE;

            public PMonoArray<T> Array => _ARRAY;

            public int Head => _HEAD;

            public Ptr_MonoItem<T>[] AsRefArray() => this.PtrQueueAsRefArray<Ptr_SystemQueueGeneric, T>();

            public IEnumerable<Ptr_MonoItem<T>> AsRefEnumerable() => this.PtrQueueAsRefEnumerable<Ptr_SystemQueueGeneric, T>();
        }
    }

}

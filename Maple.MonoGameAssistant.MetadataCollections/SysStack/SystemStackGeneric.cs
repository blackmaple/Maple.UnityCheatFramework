using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataObject;

namespace Maple.MonoGameAssistant.MetadataCollections
{

    partial class SystemStackGeneric<T>
    {

        public static SystemStackGeneric<T> LoadMetadata(MonoRuntimeContext runtimeContext, Ptr_SystemStackGeneric ptr)
        {
            return LoadMetadata<SystemStackGeneric<T>>(runtimeContext, ptr, static (r, c) => new(r, c));
        }

        partial struct Ptr_SystemStackGeneric : ISysPtrStack<T>
        {
            public int Size => _SIZE;

            public PMonoArray<T> Array => _ARRAY;

            public Ptr_MonoItem<T>[] AsRefArray() => this.PtrStackAsRefArray<Ptr_SystemStackGeneric, T>();

            public IEnumerable<Ptr_MonoItem<T>> AsRefEnumerable() => this.PtrStackAsRefEnumerable<Ptr_SystemStackGeneric, T>();
        }
    }


}

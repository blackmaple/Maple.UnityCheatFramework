using Maple.MonoGameAssistant.Core;
 
namespace Maple.MonoGameAssistant.MetadataCollections
{
    partial class SystemListGeneric<T>
    {
        public static SystemListGeneric<T> LoadMetadata(MonoRuntimeContext runtimeContext, Ptr_SystemListGeneric ptr)
        {
            return LoadMetadata<SystemListGeneric<T>>(runtimeContext, ptr, static (r, c) => new(r, c));
        }
        public static Ptr_SystemListGeneric LoadSelf(MonoRuntimeContext runtimeContext, Ptr_SystemListGeneric ptr)
        {
            _ = LoadMetadata<SystemListGeneric<T>>(runtimeContext, ptr, static (r, c) => new(r, c));
            return ptr;
        }
        partial struct Ptr_SystemListGeneric : ISysPtrList<T>
        {
            public PMonoArray<T> Items => _ITEMS;

            public int Size => _SIZE;

            public ReadOnlySpan<T> AsReadOnlySpan() => this.PtrListAsReadOnlySpan<Ptr_SystemListGeneric, T>();

            public Span<T> AsSpan() => this.PtrListAsSpan<Ptr_SystemListGeneric, T>();

            public IEnumerable<T> AsEnumerable() => this.PtrListAsEnumerable<Ptr_SystemListGeneric, T>();

            public T[] ToArray() => this.PtrListToArray<Ptr_SystemListGeneric, T>();

            public ref T this[int index] => ref this.PtrListRefElementAt<Ptr_SystemListGeneric, T>(index);

            public IEnumerable<Ptr_MonoItem<T>> AsRefEnumerable() => this.PtrListAsRefEnumerable<Ptr_SystemListGeneric, T>();

 
        }
    }
}

using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using static Maple.MonoGameAssistant.Core.MonoRuntimeContext;

namespace Maple.MonoGameAssistant.MetadataExtensions.Metadata
{
    public static class ClassMetadataCollectorExtensions
    {
        public static T_PtrMetadata CreateInstance<T_PtrMetadata>(this ClassMetadataCollector<T_PtrMetadata> @this, bool execDefCtor)
            where T_PtrMetadata : unmanaged, IPtrMetadata
        {
            return @this.RuntimeContext.CreateMonoClass<T_PtrMetadata>(@this.ClassMetadata.ClassInfo.Pointer, execDefCtor);
        }

        public static T_PtrMetadata New<T_PtrMetadata>(this ClassMetadataCollector<T_PtrMetadata> @this)
            where T_PtrMetadata : unmanaged, IPtrMetadata
            => @this.CreateInstance(false);

        public static T_PtrMetadata NewPin<T_PtrMetadata>(this ClassMetadataCollector<T_PtrMetadata> @this, out MonoGCHandle<T_PtrMetadata> gchandle)
            where T_PtrMetadata : unmanaged, IPtrMetadata
        {
            var ptr = @this.New();
            gchandle = new(@this.RuntimeContext, ptr);
            return ptr;
        }


        public static T_PtrMetadata Ctor<T_PtrMetadata>(this ClassMetadataCollector<T_PtrMetadata> @this)
            where T_PtrMetadata : unmanaged, IPtrMetadata
            => @this.CreateInstance(true);
        public static T_PtrMetadata CtorPin<T_PtrMetadata>(this ClassMetadataCollector<T_PtrMetadata> @this, out MonoGCHandle<T_PtrMetadata> gchandle)
            where T_PtrMetadata : unmanaged, IPtrMetadata
        {
            var ptr = @this.Ctor();
            gchandle = new(@this.RuntimeContext, ptr);
            return ptr;
        }

        public static Span<T_PtrMetadata> NewArray<T_PtrMetadata>(this ClassMetadataCollector<T_PtrMetadata> @this, int count, out PMonoArray ptrRawArray)
            where T_PtrMetadata : unmanaged, IPtrMetadata
        {
            return @this.RuntimeContext.CreateMonoArray<T_PtrMetadata>(@this.ClassMetadata.ClassInfo.Pointer, count, out ptrRawArray);
        }
        public static Span<T_PtrMetadata> NewArrayPin<T_PtrMetadata>(this ClassMetadataCollector<T_PtrMetadata> @this, int count, out MonoGCHandle<PMonoArray> gchandle)
            where T_PtrMetadata : unmanaged, IPtrMetadata
        {
            var spanArray = @this.NewArray(count, out var ptrRawArray);
            gchandle = new MonoGCHandle<PMonoArray>(@this.RuntimeContext, ptrRawArray);
            return spanArray;
        }

    }


}

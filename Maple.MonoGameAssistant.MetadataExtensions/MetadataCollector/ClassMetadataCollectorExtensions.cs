using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using System.Runtime.CompilerServices;
using static Maple.MonoGameAssistant.Core.MonoRuntimeContext;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector
{
    public static class ClassMetadataCollectorExtensions
    {
        public static bool IsNotNull<T_PtrMetadata>(this T_PtrMetadata @this) where T_PtrMetadata : unmanaged, IPtrMetadata
            => @this.Ptr != nint.Zero;
        public static bool IsNull<T_PtrMetadata>(this T_PtrMetadata @this) where T_PtrMetadata : unmanaged, IPtrMetadata
            => @this.Ptr == nint.Zero;
        public static string ToString<T_PtrMetadata>(this T_PtrMetadata @this) where T_PtrMetadata : unmanaged, IPtrMetadata
            => @this.Ptr.ToString("X8");

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


        public static bool TryConvert<T_PtrMetadata>(this ClassMetadataCollector<T_PtrMetadata> @this, PMonoObject pMonoObject, out T_PtrMetadata ptrMetadata)
            where T_PtrMetadata : unmanaged, IPtrMetadata
        {

            Unsafe.SkipInit(out ptrMetadata);
            var pMonoClass = @this.ContextMetadata.RuntimeContext.RuntiemProvider.GetMonoClass(pMonoObject);
            if (pMonoClass == @this.ClassMetadata.ClassInfo.Pointer)
            {
                ptrMetadata = pMonoObject.To<T_PtrMetadata>();
                return true;
            }
            return false;
        }
        public static bool TryConvert<T_PtrMetadata>(this ClassMetadataCollector<T_PtrMetadata> @this, nint ptr, out T_PtrMetadata ptrMetadata)
            where T_PtrMetadata : unmanaged, IPtrMetadata
        {
            Unsafe.SkipInit(out ptrMetadata);
            if (ptr == nint.Zero)
            {
                return false;
            }
            return @this.TryConvert(new PMonoObject(ptr), out ptrMetadata);
        }

    }


}

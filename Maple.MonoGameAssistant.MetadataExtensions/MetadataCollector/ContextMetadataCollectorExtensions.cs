using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;
using System.Runtime.InteropServices;
using static Maple.MonoGameAssistant.Core.MonoRuntimeContext;
using static System.Net.Mime.MediaTypeNames;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector
{
    public static class ContextMetadataCollectorExtensions
    {
        public static PMonoString T(this ContextMetadataCollector @this, scoped in ReadOnlySpan<char> str) => @this.RuntimeContext.GetMonoString(str);
        public static PMonoString TPin(this ContextMetadataCollector @this, scoped in ReadOnlySpan<char> str, out MonoGCHandle<PMonoString> gchandle)
        {
            var pString = @this.T(str);
            gchandle = @this.RuntimeContext.CreateMonoGCHandle(pString);
            return pString;
        }

        public static PMonoString T(this ContextMetadataCollector @this, string str) => @this.T(str.AsSpan());
        public static PMonoString TPin(this ContextMetadataCollector @this, string str, out MonoGCHandle<PMonoString> gchandle)
            => @this.TPin(str.AsSpan(), out gchandle);

        public static IEnumerable<PMonoClass> EnumSingletonClasses(this ContextMetadataCollector @this,
            Func<MonoObjectNameDTO, bool> searchImage, Func<PMonoClass, bool> searchClsses)
        {
            return @this.ImageNames.Where(searchImage)
                 .SelectMany(p => @this.RuntimeContext.RuntiemProvider.EnumMonoClasses(p.Pointer))
                 .Where(searchClsses);
        }

        public static IEnumerable<PMonoClass> EnumSingletonClasses(this ContextMetadataCollector @this, Func<MonoObjectNameDTO, bool> searchImage)
        {
            return @this.EnumSingletonClasses(searchImage, p => @this.HasStaticField(p) || @this.HasSingletonClass(p));
        }

        public static bool HasStaticField(this ContextMetadataCollector @this, PMonoClass pMonoClass)
        {
            foreach (var f in @this.RuntimeContext.EnumMonoFields(pMonoClass, EnumMonoFieldOptions.Static))
            {
                if (f.FieldType.Pointer == pMonoClass)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasSingletonClass(this ContextMetadataCollector @this, PMonoClass pMonoClass)
        {
            foreach (var parent in @this.RuntimeContext.RuntiemProvider.EnumMonoParentClasses(pMonoClass))
            {
                var className = @this.RuntimeContext.RuntiemProvider.GetMonoClassName(parent);
                if (className.AsReadOnlySpan().StartsWith("Singleton"u8))
                {
                    return true;
                }
            }
            return false;

        }

    }
}

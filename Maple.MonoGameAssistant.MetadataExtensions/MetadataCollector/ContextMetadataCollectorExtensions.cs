using Maple.MonoGameAssistant.Core;
using System.Runtime.InteropServices;
using static Maple.MonoGameAssistant.Core.MonoRuntimeContext;

namespace Maple.MonoGameAssistant.MetadataExtensions.Metadata
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


    }
}

using Maple.MonoGameAssistant.Core;
using static Maple.MonoGameAssistant.Core.MonoRuntimeContext;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public static class ContextMetadataCollectorExtensions
    {
        public static PMonoString T(this ContextMetadataCollector @this, string str) => @this.RuntimeContext.GetMonoString(str);
        public static MonoGCHandle<PMonoString> T2(this ContextMetadataCollector @this, string str) => @this.RuntimeContext.CreateMonoGCHandle(@this.RuntimeContext.GetMonoString(str));
        public static PMonoString T(this ContextMetadataCollector @this, in ReadOnlySpan<char> str) => @this.RuntimeContext.GetMonoString(str);
        public static MonoGCHandle<PMonoString> T2(this ContextMetadataCollector @this, in ReadOnlySpan<char> str) => @this.RuntimeContext.CreateMonoGCHandle(@this.RuntimeContext.GetMonoString(str));

    }
}

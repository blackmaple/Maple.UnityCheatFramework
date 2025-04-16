using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    internal readonly unsafe partial struct PMONO_LOOKUP_INTERNAL_CALL(nint ptr)
    {
        public const string mono = "mono_lookup_internal_call";

        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PDelegatePointer> _func = (delegate* unmanaged[Cdecl, SuppressGCTransition]<PMonoMethod, PDelegatePointer>)ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly PDelegatePointer Invoke(PMonoMethod pMonoMethod) => _func(pMonoMethod);

    }

}
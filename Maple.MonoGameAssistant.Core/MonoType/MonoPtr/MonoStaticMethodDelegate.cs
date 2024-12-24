using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.Core
{
    public readonly struct MonoStaticMethodDelegate(nint monoMethod, nint func)
    {
        public readonly nint MonoMethod = monoMethod;
        public readonly nint PtrMethod = func;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TFUNC GetInvoker<TFUNC>() where TFUNC : unmanaged
        {
            return Unsafe.As<IntPtr, TFUNC>(ref Unsafe.AsRef(in PtrMethod));
        }
    }

}

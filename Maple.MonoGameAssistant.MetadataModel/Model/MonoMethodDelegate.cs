using System;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataModel.Model
{
    public readonly struct MonoMethodDelegate(nint monoMethod, nint func)
    {
        public readonly nint RuntimeMethod = monoMethod;
        public readonly nint MethodPointer = func;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TFUNC GetInvoker<TFUNC>() where TFUNC : unmanaged
        {
            return Unsafe.As<nint, TFUNC>(ref Unsafe.AsRef(in MethodPointer));
        }
    }

}

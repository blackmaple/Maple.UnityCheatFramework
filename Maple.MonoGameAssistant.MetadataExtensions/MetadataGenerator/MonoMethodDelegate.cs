using System;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif
readonly struct MonoMethodDelegate(nint monoMethod, nint func)
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly nint RuntimeMethod = monoMethod;

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly nint MethodPointer = func;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TFUNC GetInvoker<TFUNC>() where TFUNC : unmanaged
        {
            return Unsafe.As<nint, TFUNC>(ref Unsafe.AsRef(in MethodPointer));
        }
    }


    [Obsolete("REMOVE")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
    readonly struct MonoMethodDelegate<TFUNC>(nint monoMethod, nint func)
        where TFUNC : unmanaged
    {
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        public readonly nint RuntimeMethod = monoMethod;

        public readonly TFUNC MethodPointer = Unsafe.As<nint, TFUNC>(ref func);

        public static implicit operator MonoMethodDelegate<TFUNC>(MonoMethodDelegate methodDelegate)
            => new(methodDelegate.RuntimeMethod, methodDelegate.MethodPointer);
    }


}

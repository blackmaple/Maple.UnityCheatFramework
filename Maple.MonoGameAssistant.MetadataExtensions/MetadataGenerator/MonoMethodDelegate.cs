﻿using System;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
#if MetadataSourceGenerator
    internal
#else
    public
#endif 
    readonly struct MonoMethodDelegate(nint monoMethod, nint func)
    {
        public readonly nint RuntimeMethod = monoMethod;
        public readonly nint MethodPointer = func;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TFUNC GetInvoker<TFUNC>() where TFUNC : unmanaged
        {
            return Unsafe.As<nint, TFUNC>(ref Unsafe.AsRef(in MethodPointer));
        }
    }

#if MetadataSourceGenerator
    internal
#else
    public
#endif 
    readonly struct MonoMethodDelegate<TFUNC>(nint monoMethod, nint func)
        where TFUNC : unmanaged
    {
        public readonly nint RuntimeMethod { get; } = monoMethod;
        public readonly TFUNC MethodPointer { get; } = Unsafe.As<nint, TFUNC>(ref func);

        public static implicit operator MonoMethodDelegate<TFUNC>(MonoMethodDelegate methodDelegate)
            => new(methodDelegate.RuntimeMethod, methodDelegate.MethodPointer);
    }


}

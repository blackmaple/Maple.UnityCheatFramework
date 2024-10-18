﻿using Maple.MonoGameAssistant.AndroidCore.Extension;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Reference
{
    [StructLayout(LayoutKind.Sequential)]
    public   struct JGLOBAL(nint ptr) : IJNIReferenceInterface
    {
        [MarshalAs(UnmanagedType.SysInt)]
        nint _ptr = ptr;

        public nint Ptr { readonly get => _ptr; set => _ptr = value; }

        public static implicit operator JGLOBAL(nint val) => new(val);
        public static implicit operator nint(JGLOBAL val) => val._ptr;
        public static implicit operator bool(JGLOBAL val) => val.IsNullPtr();
        public static implicit operator JOBJECT(JGLOBAL val) => new(val._ptr);

    }

}
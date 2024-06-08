﻿using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [DebuggerDisplay("{_ptr}")]
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PMonoUserData(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoUserData ptr) => ptr._ptr;
        public static implicit operator PMonoUserData(nint ptr) => new(ptr);
        public override string ToString()
        {
            return _ptr.ToString();
        }
    }

}

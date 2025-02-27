using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [DebuggerDisplay("{_ptr}")]
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PMonoType(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PMonoType ptr) => ptr._ptr;
        public static implicit operator PMonoType(nint ptr) => new(ptr);
        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        public bool Valid() => _ptr != IntPtr.Zero;
    }



    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PRuntimeType(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PRuntimeType ptr) => ptr._ptr;
        public static implicit operator PRuntimeType(nint ptr) => new(ptr);
        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        public bool Valid() => _ptr != IntPtr.Zero;

        public PMonoType GetMonoType() => _ptr.AsRefStruct<REF_RUNTIME_TYPE>()._impl.MonoType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct REF_RUNTIME_TYPE
    {
        public readonly REF_MONO_OBJECT _obj;

        public readonly REF_RUNTIME_TYPE_HANDLE _impl;

        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint _type_info;

        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint _cache;

        [MarshalAs(UnmanagedType.SysInt)]
        public readonly nint _mCtor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct REF_RUNTIME_TYPE_HANDLE
    {
        public readonly PMonoType MonoType;
    }
}

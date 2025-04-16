using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct RefMonoMethod
    {
        [MarshalAs(UnmanagedType.U2)]
        public ushort flags;  /* method flags */

        [MarshalAs(UnmanagedType.U2)]
        public ushort iflags; /* method implementation flags */

        [MarshalAs(UnmanagedType.U4)]
        public uint token;

        public PMonoObject<RefMonoClass> klass; /* To what class does this method belong */

        public PMonoObject<RefMonoMethodSignature> signature;

        /* name is useful mostly for debugging */
        public PMonoUtf8Char name;

        [MarshalAs(UnmanagedType.SysInt)]
        public IntPtr method_pointer;

        [MarshalAs(UnmanagedType.SysInt)]
        public IntPtr invoke_pointer;

        /* this is used by the inlining algorithm */
        [MarshalAs(UnmanagedType.U2)]
        public ushort bitfield;

        [MarshalAs(UnmanagedType.I4)]
        public int slot;

        public RefInlineArray array;

    }



}

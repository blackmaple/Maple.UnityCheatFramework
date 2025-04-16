using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.Core
{

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct RefMonoMethodSignature
    {
        [MarshalAs(UnmanagedType.SysInt)]
        public IntPtr ret;

        [MarshalAs(UnmanagedType.U2)]
        public ushort param_cout;
    }
}

﻿using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidCore.JNI.Primitive
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JDOUBLE(double val)
    {
        [MarshalAs(UnmanagedType.R8)]
        readonly double _value = val;
        public static implicit operator JDOUBLE(double val) => new(val);
        public static implicit operator double(JDOUBLE val) => val._value;

    }

}
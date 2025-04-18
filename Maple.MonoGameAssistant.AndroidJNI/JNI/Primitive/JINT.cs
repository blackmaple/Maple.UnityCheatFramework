﻿using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct JINT(int val)
    {
        [MarshalAs(UnmanagedType.I4)]
        readonly int _value = val;
        public static implicit operator JINT(int val) => new(val);
        public static implicit operator int(JINT val) => val._value;
        public static implicit operator JRESULT(JINT val) => (JRESULT)val._value;
        public static implicit operator JVALUE(JINT val) => new(val);

    }

}

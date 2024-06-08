﻿using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_MonoStack_OptimizationSpeed
    {
        [FieldOffset(0)]
        public readonly REF_MONO_OBJECT _obj;


        /// <summary>
        /// 0x10 T[] _array
        /// </summary>
        [FieldOffset(0x10)]
        public readonly PMonoArray _array;


        /// <summary>
        /// 0x18 System.Object _syncRoot
        /// </summary>
        [FieldOffset(0x18)]
        public readonly nint _syncRoot;


        /// <summary>
        /// 0x20 System.Int32 _size
        /// </summary>
        [FieldOffset(0x20)]
        public readonly System.Int32 _size;


        /// <summary>
        /// 0x24 System.Int32 _version
        /// </summary>
        [FieldOffset(0x24)]
        public readonly System.Int32 _version;



    }

    readonly unsafe partial struct Ref_MonoStack_OptimizationSpeed : IRefMonoStack
    {
        public int Size => _size;

        public PMonoArray Array => _array;

    }
}

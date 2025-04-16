using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.Core
{
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct RefMonoClass
    {
        /* element class for arrays and enum basetype for enums */
        public readonly PMonoObject<RefMonoClass> element_class;

        /* used for subtype checks */
        public readonly PMonoObject<RefMonoClass> cast_class;

        /* for fast subtype checks */
        public readonly PMonoObject<PMonoObject<RefMonoClass>> supertypes;


        [MarshalAs(UnmanagedType.U2)]
        public readonly ushort idepth;

        /* array dimension */
        [MarshalAs(UnmanagedType.U1)]
        public readonly byte rank; // 0x0E

        /* One of the values from MonoTypeKind */
        [MarshalAs(UnmanagedType.U1)]
        public readonly byte class_kind;

        [MarshalAs(UnmanagedType.I4)]
        public readonly int instance_size; // 0x10

        [MarshalAs(UnmanagedType.U4)]
        public readonly uint bitfield1; // 0x14

        [MarshalAs(UnmanagedType.U1)]
        public readonly byte min_align; // 0x18

        [MarshalAs(UnmanagedType.U4)]
        public readonly uint bitfield2; // 0x1C

        [MarshalAs(UnmanagedType.U1)]
        public readonly byte exception_type;

        public readonly PMonoObject<RefMonoClass> parent; // 0x24
        public readonly PMonoObject<RefMonoClass> nested_in; // 0x28 // Should always be null

        //public IntPtr cattrs; // 0x2C

        //
        // Starting here (unity version from 2014+), fields will be offset by IntPtr.Size
        //

        [MarshalAs(UnmanagedType.SysInt)]
        public IntPtr nested_in_0x04; // 0x2C - 0x30

        [MarshalAs(UnmanagedType.SysInt)]
        public IntPtr nested_in_0x08; // 0x30 - 0x34

        [MarshalAs(UnmanagedType.SysInt)]
        public IntPtr nested_in_0x0C; // 0x34 - 0x38

        [MarshalAs(UnmanagedType.SysInt)]
        public IntPtr nested_in_0x10; // 0x38 - 0x3C



        public RefInlineArray array;



        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T_FieldValue GetMemberFieldValue<T_FieldValue>(nint @this, int fieldOffset) where T_FieldValue : unmanaged
        {
            ref var ref_Buffer = ref @this.AsRefStruct<byte>();
            ref var ref_Member = ref Unsafe.Add(ref ref_Buffer, fieldOffset);
            ref var ref_Value = ref Unsafe.As<byte, T_FieldValue>(ref ref_Member);
            return ref ref_Value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T_FieldValue GetMemberFieldValue<T_FieldValue>(scoped ref nint ref_field, int fieldOffset) where T_FieldValue : unmanaged
        {
            var fieldPointer = new nint(Unsafe.AsPointer(ref ref_field));
            return ref GetMemberFieldValue<T_FieldValue>(fieldPointer, fieldOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref PMonoUtf8Char GetClassName(int fieldOffset) => ref GetMemberFieldValue<PMonoUtf8Char>(ref this.nested_in_0x04, fieldOffset);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref PMonoUtf8Char GetNamespace(int fieldOffset) => ref GetMemberFieldValue<PMonoUtf8Char>(ref this.nested_in_0x08, fieldOffset);


    }
}

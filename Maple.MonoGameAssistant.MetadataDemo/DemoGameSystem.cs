using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.MetadataDemo
{

    [ClassParentMetadata<ClassMetadataCollector<DemoGameSystem.Ptr_DemoGameSystem>, DemoGameSystem.Ptr_DemoGameSystem>()]
    [ClassModelMetadata([], [], [], [])]
    public partial class DemoGameSystem

    {
        [StructLayout(LayoutKind.Sequential)]
        public readonly partial struct Ptr_DemoGameSystem(nint ptr) : IPtrMetadata /*: IPtrMetadata<Ptr_DemoGameSystem>*/
        {
            [MarshalAs(UnmanagedType.SysInt)]
            public readonly nint _ptr = ptr;
            public nint Ptr => _ptr;

            public static implicit operator Ptr_DemoGameSystem(nint ptr)
            {
                return new(ptr);
            }
            public static implicit operator nint(Ptr_DemoGameSystem ptr)
            {
                return ptr.Ptr;
            }
            public static implicit operator bool(Ptr_DemoGameSystem ptr)
            {
                return ptr.IsNotNull();
            }
        }

        partial struct Ptr_DemoGameSystem
        {
            [ClassPropertyMetadata([1, 1, 1], [11, 11, 11])]
            public partial Int32 Glod { get; }
            //public partial Int32 Glod => 1;


            [ClassPropertyMetadata([2, 2, 2])]
            public static partial long Config { get; set; }

            [ClassPropertyMetadata([3, 3, 3], default)]
            public partial Ptr_DemoGameSystem Exp { get; set; }

        }

        [StructLayout(LayoutKind.Sequential)]
        unsafe readonly struct X(nint ptr)
        {
            [MarshalAs(UnmanagedType.SysInt)]
            readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<int, out int, int> @delegate =
                (delegate* unmanaged[Cdecl, SuppressGCTransition]<int, out int, int>)ptr;
        }


        unsafe partial struct Ptr_DemoGameSystem
        {

            //readonly delegate* unmanaged[ Cdecl, SuppressGCTransition]<int, out int, int> @delegate = (delegate* unmanaged[Cdecl, SuppressGCTransition]<int, out int, int>)nint.Zero;
            //readonly delegate* managed<int, out int, int> @delegate = (delegate*  managed <int, out int, int>)nint.Zero;
            [ClassMethodMetadata([], default, CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
            public partial void GetGlod1(int a, ref readonly int b);

            [ClassMethodMetadata([], default, CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
            public partial int GetGlod2(int a, out int b);

            [ClassMethodMetadata([], default, CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
            public partial ref int GetGlod3(int a, in int b);

            [ClassMethodMetadata([], default, RuntimeMethodAsThis = true, CallConvs = [typeof(CallConvCdecl), typeof(CallConvSuppressGCTransition)])]
            public partial ref int GetGlod4(int a, ref int b);


            //[ClassMethodMetadata([1, 2, 3], [3, 2, 1])]
            //[ClassMethodParameterMetadata([0], 0)]
            //[ClassMethodParameterMetadata([1], 1)]
            //[ClassMethodParameterMetadata([3], 3)]
            //[ClassMethodParameterMetadata([2], 2)]
            //[ClassMethodParameterMetadata(default!, 4)]
            //public partial int SetGlod(int val);



        }



    }


    //[ClassParentMetadata<ClassMetadataCollector<DemoGameSystem.Ptr_DemoGameSystem>, DemoGameSystem.Ptr_DemoGameSystem>()]
    //[ClassModelMetadata([], [], [], [])]
    //public partial class ItemSystem
    //{

    //}

    //partial class DemoGameSystem : Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.Ptr_DemoGameSystem>
    //{
    //    static int s_Field_Glod;
    //    static int s_Field_Exp;
    //    static Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.MonoStaticFieldSource s_Field_Config;
    //    static FunctionPointerType_GetGlod1_6050 s_FunctionPointerType_GetGlod1_6050;
    //    static FunctionPointerType_GetGlod2_6854 s_FunctionPointerType_GetGlod2_6854;
    //    static FunctionPointerType_GetGlod3_7658 s_FunctionPointerType_GetGlod3_7658;
    //    static Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.MonoMethodDelegate<FunctionPointerType_GetGlod4_8462> s_FunctionPointerType_GetGlod4_8462;
    //    public DemoGameSystem(Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ContextMetadataCollector metadataCollector, ulong code = 2834UL) : base(metadataCollector, code)
    //    {
    //        Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_Field_Glod = this.GetMemberFieldOffset(3638UL);
    //        Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_Field_Exp = this.GetMemberFieldOffset(5246UL);
    //        Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_Field_Config = this.GetStaticFieldMetadata(4442UL);
    //        Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_FunctionPointerType_GetGlod1_6050 = this.GetMethodPointer(6050UL);
    //        Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_FunctionPointerType_GetGlod2_6854 = this.GetMethodPointer(6854UL);
    //        Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_FunctionPointerType_GetGlod3_7658 = this.GetMethodPointer(7658UL);
    //        Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_FunctionPointerType_GetGlod4_8462 = this.GetMethodDelegate<FunctionPointerType_GetGlod4_8462>(8462UL);
    //    }

    //    partial struct Ptr_DemoGameSystem
    //    {
    //        public partial int Glod
    //        {
    //            get
    //            {
    //                return Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.GetMemberFieldValue<int>(this, Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_Field_Glod);
    //            }
    //        }

    //        public partial Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.Ptr_DemoGameSystem Exp
    //        {
    //            get
    //            {
    //                return Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.GetMemberFieldValue<Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.Ptr_DemoGameSystem>(this, Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_Field_Exp);
    //            }

    //            set
    //            {
    //                Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.SetMemberFieldValue<Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.Ptr_DemoGameSystem>(this, Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_Field_Exp, in value);
    //            }
    //        }

    //        public static partial long Config
    //        {
    //            get
    //            {
    //                return Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.GetStaticFieldValue<long>(Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_Field_Config);
    //            }

    //            set
    //            {
    //                Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.SetStaticFieldValue<long>(Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_Field_Config, in value);
    //            }
    //        }
    //    }

    //    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    //    unsafe readonly struct FunctionPointerType_GetGlod1_6050(System.IntPtr pointer)
    //    {
    //        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
    //        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, int, ref readonly int, void> m_Pointer = (delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, int, ref readonly int, void>)pointer;
    //        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    //        public void Delegate(System.IntPtr @this, int a, ref readonly int b) => this.m_Pointer(@this, a, in b);
    //        public static implicit operator FunctionPointerType_GetGlod1_6050(System.IntPtr pointer) => new FunctionPointerType_GetGlod1_6050(pointer);
    //    }

    //    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    //    unsafe readonly struct FunctionPointerType_GetGlod2_6854(System.IntPtr pointer)
    //    {
    //        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
    //        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, int, out int, int> m_Pointer = (delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, int, out int, int>)pointer;
    //        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    //        public int Delegate(System.IntPtr @this, int a, out int b) => this.m_Pointer(@this, a, out b);
    //        public static implicit operator FunctionPointerType_GetGlod2_6854(System.IntPtr pointer) => new FunctionPointerType_GetGlod2_6854(pointer);
    //    }

    //    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    //    unsafe readonly struct FunctionPointerType_GetGlod3_7658(System.IntPtr pointer)
    //    {
    //        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
    //        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, int, in int, ref int> m_Pointer = (delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, int, in int, ref int>)pointer;
    //        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    //        public ref int Delegate(System.IntPtr @this, int a, in int b) => ref this.m_Pointer(@this, a, in b);
    //        public static implicit operator FunctionPointerType_GetGlod3_7658(System.IntPtr pointer) => new FunctionPointerType_GetGlod3_7658(pointer);
    //    }

    //    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    //    unsafe readonly struct FunctionPointerType_GetGlod4_8462(System.IntPtr pointer)
    //    {
    //        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
    //        readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, int, ref int, ref int> m_Pointer = (delegate* unmanaged[Cdecl, SuppressGCTransition]<System.IntPtr, int, ref int, ref int>)pointer;
    //        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    //        public ref int Delegate(System.IntPtr @this, int a, ref int b) => ref this.m_Pointer(@this, a, ref b);
    //        public static implicit operator FunctionPointerType_GetGlod4_8462(System.IntPtr pointer) => new FunctionPointerType_GetGlod4_8462(pointer);
    //    }

    //    partial struct Ptr_DemoGameSystem
    //    {
    //        public partial void GetGlod1(int a, ref readonly int b) => Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_FunctionPointerType_GetGlod1_6050.Delegate(this, a, in b);
    //        public partial int GetGlod2(int a, out int b) => Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_FunctionPointerType_GetGlod2_6854.Delegate(this, a, out b);
    //        public partial ref int GetGlod3(int a, in int b) => ref Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_FunctionPointerType_GetGlod3_7658.Delegate(this, a, in b);
    //        public partial ref int GetGlod4(int a, ref int b) => ref Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_FunctionPointerType_GetGlod4_8462.MethodPointer.Delegate(Maple.MonoGameAssistant.MetadataDemo.DemoGameSystem.s_FunctionPointerType_GetGlod4_8462.RuntimeMethod, a, ref b);
    //    }
    //}

}


using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.MetadataDemo
{

    [ClassParentMetadata<ClassMetadataCollector<DemoGameSystem.Ptr_DemoGameSystem>, DemoGameSystem.Ptr_DemoGameSystem>()]
    [ClassModelMetadata([1, 2, 3], [3, 2, 1], [4, 5, 6], [8, 8, 8])]
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

        //[StructLayout(LayoutKind.Sequential)]
        //unsafe readonly struct X(nint ptr)
        //{
        //    [MarshalAs(UnmanagedType.SysInt)]
        //    readonly delegate* unmanaged[Cdecl, SuppressGCTransition]<int, out int, int> @delegate =
        //        (delegate* unmanaged[Cdecl, SuppressGCTransition]<int, out int, int>)ptr;
        //}


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


            [ClassMethodMetadata([1, 2, 3], [3, 2, 1])]
            [ClassMethodParameterMetadata([0], 0)]
            [ClassMethodParameterMetadata([1], 1)]
            [ClassMethodParameterMetadata([3], 3)]
            [ClassMethodParameterMetadata([2], 2)]
            [ClassMethodParameterMetadata(default!, 4)]
            public partial int SetGlod(int val);



        }



    }




}


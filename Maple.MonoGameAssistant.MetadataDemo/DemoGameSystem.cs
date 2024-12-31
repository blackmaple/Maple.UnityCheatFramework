using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
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
            public static partial Int32 Config { get; set; }

            [ClassPropertyMetadata([3, 3, 3], default)]
            public partial Int32 Exp { get; set; }

        }

        //partial struct Ptr_DemoGameSystem
        //{
        //    public static partial Int32 Config => 1;

        //}

        partial struct Ptr_DemoGameSystem
        {
            [ClassMethodMetadata([], default)]
            public partial int GetGlod();

            [ClassMethodMetadata([1, 2, 3], [3, 2, 1])]
            [ClassMethodParameterMetadata([0], 0)]
            [ClassMethodParameterMetadata([1], 1)]
            [ClassMethodParameterMetadata([3], 3)]
            [ClassMethodParameterMetadata([2], 2)]
            [ClassMethodParameterMetadata(default!, 4)]
            public partial int SetGlod(int val);


            //[StaticFieldMetadataAttribute([], [])]
            //public static partial Ptr_DemoGameSystem T { get; }

            //public static partial Ptr_DemoGameSystem T => nint.Zero;

        }



    }


    [ClassParentMetadata<ClassMetadataCollector<DemoGameSystem.Ptr_DemoGameSystem>, DemoGameSystem.Ptr_DemoGameSystem>()]
    [ClassModelMetadata([], [], [], [])]
    public partial class ItemSystem
    {

    }
}


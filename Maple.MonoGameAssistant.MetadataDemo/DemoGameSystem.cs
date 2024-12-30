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
            [ClassPropertyMetadata([], [])]
            public partial Int32 Glod { set; get; }
        }

        //partial struct Ptr_DemoGameSystem
        //{
        //    [MethodMetadata([], [])]
        //    public partial int GetGlod();

        //    [MethodMetadata([], [])]
        //    [MethodParameterMetadata([], 0)]
        //    public partial int SetGlod(int val);


        //    [StaticFieldMetadataAttribute([], [])]
        //    public static partial Ptr_DemoGameSystem T { get; }

        //    public static partial Ptr_DemoGameSystem T => nint.Zero;

        //}



    }


    [ClassParentMetadata<ClassMetadataCollector<DemoGameSystem.Ptr_DemoGameSystem>, DemoGameSystem.Ptr_DemoGameSystem>()]
    [ClassModelMetadata([], [], [], [])]
    public partial class ItemSystem
    {

    }
}


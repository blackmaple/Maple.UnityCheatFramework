using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.Metadata;
using Maple.MonoGameAssistant.MetadataExtensions.Service;
using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using Maple.MonoGameAssistant.MetadataModel.MetadataAttribute;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.MetadataDemo
{
    [SettingsMetadata(123, RandomSalt = true)]
    public partial class DemoGameMetadataContext(ILogger logger, MetadataCollectorSearchService searchService, MonoRuntimeContext runtimeContext)
        : ContextMetadataCollector(logger, searchService, runtimeContext)
    {
    }


    [ClassMetadata([], [], [], [])]
    public partial class DemoGameSystem(ContextMetadataCollector metadataCollector, MonoClassMetadataCollection collection) :
        ClassMetadataCollector<DemoGameSystem.Ptr_DemoGameSystem>(metadataCollector, collection)
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
            [FieldMetadata([], [])]
            public partial Int32 Glod { set; get; }
        }

        partial struct Ptr_DemoGameSystem
        {
            [MethodMetadata([], [])]
            public partial int GetGlod();

            [MethodMetadata([], [])]
            [MethodParameterMetadata([], 0)]
            public partial int SetGlod(int val);


            [StaticFieldMetadataAttribute([], [])]
            public static partial Ptr_DemoGameSystem T { get; }

            public static partial Ptr_DemoGameSystem T => nint.Zero;

        }

        public class TestMetadata
        {

            public void Test()
            {

            }
        }


    }
}

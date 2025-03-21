using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.Model;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataObject
{
    public static class MetadataObjectExtensions
    {
        public static ConcurrentDictionary<PMonoClass, MonoClassMetadataCollection> MetadataObjectCache { get; } = [];

        public static bool TryGetClassMetadata(this MonoRuntimeContext @this, PMonoObject pMonoObject, [MaybeNullWhen(false)] out MonoClassMetadataCollection classMetadataCollection)
        {
            Unsafe.SkipInit(out classMetadataCollection);
            if (pMonoObject == nint.Zero)
            {
                return false;
            }
            var pMonoClass = @this.RuntiemProvider.GetMonoClass(pMonoObject);
            classMetadataCollection = @this.GetClassMetadata(pMonoClass);
            return true;
        }

        public static MonoClassMetadataCollection GetClassMetadata(this MonoRuntimeContext @this, PMonoObject pMonoObject)
        {
            return @this.GetClassMetadata(@this.RuntiemProvider.GetMonoClass(pMonoObject));
        }

        public static MonoClassMetadataCollection GetClassMetadata(this MonoRuntimeContext @this, PMonoClass pMonoClass)
        {
            return MetadataObjectCache.GetOrAdd(pMonoClass, klass => @this.GetMonoClassMetadataCollection(klass));
        }

        public static MonoClassMetadataCollection GetClassMetadata(this MonoRuntimeContext @this, MonoFieldInfoDTO fieldInfoDTO)
        {
            return MetadataObjectCache.GetOrAdd(fieldInfoDTO.FieldType.Pointer, klass => @this.GetMonoClassMetadataCollection(klass));
        }

        public static MonoClassMetadataCollection GetClassMetadata(this MonoRuntimeContext @this, MonoParameterTypeDTO parameterTypeDTO)
        {
            return MetadataObjectCache.GetOrAdd(parameterTypeDTO.Pointer, klass => @this.GetMonoClassMetadataCollection(klass));
        }

        public static MonoClassMetadataCollection GetClassMetadata(this MonoRuntimeContext @this, MonoReturnTypeDTO returnTypeDTO)
        {
            return MetadataObjectCache.GetOrAdd(returnTypeDTO.Pointer, klass => @this.GetMonoClassMetadataCollection(klass));
        }

    }




    public class System_Collections_Generic_List : AbstractClassMetadataCollector
    {
        static bool s_init;
        static readonly Lock s_lock = new();
        static readonly MonoDescriptionFieldDTO s_Desc__ITEMS = new()
        {
            IsStatic = false,
            Utf8Name = [95, 105, 116, 101, 109, 115]//"_items"u8.ToArray()
        };

        static int s_Field__ITEMS;


        static readonly MonoDescriptionFieldDTO s_Desc__SIZE = new()
        {
            IsStatic = false,
            Utf8Name = [95, 115, 105, 122, 101]//"_size"u8.ToArray()
        };
        static int s_Field__SIZE;


        protected virtual void InitMetadata()
        {
            lock (s_lock)
            {
                if (s_init == false)
                {
                    s_init = true;

                    if (this.ClassMetadata.TryGetFieldMetadata(s_Desc__ITEMS, out var itemMetdata))
                    {
                        s_Field__ITEMS = itemMetdata.Offset;
                    }
                    if (this.ClassMetadata.TryGetFieldMetadata(s_Desc__SIZE, out var sizeMetadata))
                    {
                        s_Field__SIZE = sizeMetadata.Offset;
                    }

                }
            }
        }

        public System_Collections_Generic_List(ContextMetadataCollector contextMetadata, MonoClassMetadataCollection classMetadataCollection) : base(contextMetadata, classMetadataCollection)
        {
            InitMetadata();
        }

        public System_Collections_Generic_List(ContextMetadataCollector contextMetadata, PMonoObject pMonoObject) : this(contextMetadata, contextMetadata.RuntimeContext.GetClassMetadata(pMonoObject))
        {

        }
        public System_Collections_Generic_List(ContextMetadataCollector contextMetadata, PMonoClass pMonoClass) : this(contextMetadata, contextMetadata.RuntimeContext.GetClassMetadata(pMonoClass))
        {

        }
        public System_Collections_Generic_List(ContextMetadataCollector contextMetadata, MonoFieldInfoDTO fieldInfoDTO) : this(contextMetadata, contextMetadata.RuntimeContext.GetClassMetadata(fieldInfoDTO))
        {

        }
        public System_Collections_Generic_List(ContextMetadataCollector contextMetadata, MonoParameterTypeDTO parameterTypeDTO) : this(contextMetadata, contextMetadata.RuntimeContext.GetClassMetadata(parameterTypeDTO))
        {

        }
        public System_Collections_Generic_List(ContextMetadataCollector contextMetadata, MonoReturnTypeDTO returnTypeDTO) : this(contextMetadata, contextMetadata.RuntimeContext.GetClassMetadata(returnTypeDTO))
        {

        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_System_Collections_Generic_List(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_System_Collections_Generic_List(System.IntPtr ptr) => new(ptr);
            public static implicit operator System.IntPtr(Ptr_System_Collections_Generic_List ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_System_Collections_Generic_List ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }


        partial struct Ptr_System_Collections_Generic_List
        {
            /// <summary>
            /// 0x10 T[] _items
            /// class ["mscorlib"."System.Collections.Generic"."T[]"]
            /// </summary>
            /// <returns>class T[]</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_items", "T[]")]
            public PMonoArray ITEMS => ClassMetadataCollector.GetMemberFieldValue<PMonoArray>(this, s_Field__ITEMS);


            /// <summary>
            /// 0x18 System.Int32 _size
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_size", "System.Int32")]
            public System.Int32 SIZE => ClassMetadataCollector.GetMemberFieldValue<int>(this, s_Field__SIZE);


            /// <summary>
            /// 0x1C System.Int32 _version
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_version", "System.Int32")]
           public partial System.Int32 _VERSION { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Object _syncRoot
            /// class ["mscorlib"."System"."Object"]
            /// </summary>
            /// <returns>class System.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_syncRoot", "System.Object")]
           public partial nint _SYNC_ROOT { get; set; } 
*/

        }


    }
}

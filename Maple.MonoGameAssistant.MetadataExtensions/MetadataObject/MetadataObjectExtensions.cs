using Maple.MonoGameAssistant.Core;
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




    public class System_Collections_Generic_List
    {

        public System_Collections_Generic_List()
        { 
        
        }

        public unsafe struct Ptr_System_Collections_Generic_List
        {
            /// <summary>
            /// 0x10 T[] _items
            /// class ["mscorlib"."System.Collections.Generic"."T[]"]
            /// </summary>
            /// <returns>class T[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_items", "T[]")]
           public partial nint _ITEMS { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 _size
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_size", "System.Int32")]
           public partial System.Int32 _SIZE { get; set; } 
*/

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

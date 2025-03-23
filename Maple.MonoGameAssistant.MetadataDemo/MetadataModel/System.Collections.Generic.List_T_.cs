using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;

namespace Maple.MonoGameAssistant.MetadataDemo
{
    /// <summary>
    /// class ["mscorlib"."System.Collections.Generic"."List`1"]
    /// [System.Object]
    /// [System.Collections.Generic.IList<T>]=>[System.Collections.Generic.ICollection<T>]=>[System.Collections.Generic.IEnumerable<T>]=>[System.Collections.IEnumerable]=>[System.Collections.IList]=>[System.Collections.ICollection]=>[System.Collections.Generic.IReadOnlyList<T>]=>[System.Collections.Generic.IReadOnlyCollection<T>]
    /// </summary>
    [MetadataExtensions.MetadataGenerator.GenericClassParentMetadataAttribute(
        typeof(GenericClassMetadataCollector<,>)
        , typeof(ListGeneric<>.Ptr_ListGeneric)
        )]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.GenericClassModelMetadataAttribute()]
    public partial class ListGeneric<TITEM>(MonoRuntimeContext runtimeContext, MonoClassMetadataCollection classMetadataCollection)
    //: GenericClassMetadataCollector<ListGeneric<TITEM>, ListGeneric<TITEM>.Ptr_ListGeneric>(runtimeContext, classMetadataCollection)
    //where TITEM : unmanaged
    {

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ListGeneric(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ListGeneric(System.IntPtr ptr) => new Ptr_ListGeneric(ptr);
            public static implicit operator System.IntPtr(Ptr_ListGeneric ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_ListGeneric ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["mscorlib"."System.Collections.Generic"."List`1"]
        /// </summary>
        partial struct Ptr_ListGeneric
        {
            /// <summary>
            /// 0x0 System.Int32 DefaultCapacity
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           public const System.Int32 DEFAULT_CAPACITY = 4; 
*/
            /// <summary>
            /// 0x0 T[] s_emptyArray
            /// class ["mscorlib"."System.Collections.Generic"."T[]"]
            /// </summary>
            /// <returns>class T[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("s_emptyArray", "T[]")]
           public static partial nint S_EMPTY_ARRAY { get; set; } 
*/

            /// <summary>
            /// 0x10 T[] _items
            /// class ["mscorlib"."System.Collections.Generic"."T[]"]
            /// </summary>
            /// <returns>class T[]</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_items", "T[]")]
            //public partial nint _ITEMS { get; set; }


            /// <summary>
            /// 0x18 System.Int32 _size
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_size", "System.Int32")]
            //public partial System.Int32 _SIZE { get; set; }


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

        /// <summary>
        /// class ["mscorlib"."System.Collections.Generic"."List`1"]
        /// </summary>
        partial struct Ptr_ListGeneric
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  System.Boolean IsCompatibleObject(System.Object value)
            /// </summary>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsCompatibleObject", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
           public static partial System.Boolean IS_COMPATIBLE_OBJECT(nint value); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 capacity)
            /// </summary>
            /// <param name = "capacity">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void CTOR(System.Int32 capacity); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IEnumerable<T> collection)
            /// </summary>
            /// <param name = "collection">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
           public partial void CTOR(nint collection); 
*/
            /// <summary>
            ///   System.Void Add(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Void</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Add", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            //public partial void ADD(nint item);

            /// <summary>
            ///   System.Void AddEnumerable(System.Collections.Generic.IEnumerable<T> enumerable)
            /// </summary>
            /// <param name = "enumerable">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddEnumerable", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
           public partial void ADD_ENUMERABLE(nint enumerable); 
*/
            /// <summary>
            ///   System.Void AddRange(System.Collections.Generic.IEnumerable<T> collection)
            /// </summary>
            /// <param name = "collection">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddRange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
           public partial void ADD_RANGE(nint collection); 
*/
            /// <summary>
            ///   System.Void AddWithResize(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddWithResize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           public partial void ADD_WITH_RESIZE(nint item); 
*/
            /// <summary>
            ///   System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly()
            /// </summary>
            /// <returns>class System.Collections.ObjectModel.ReadOnlyCollection<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AsReadOnly", "System.Collections.ObjectModel.ReadOnlyCollection<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint AS_READ_ONLY(); 
*/
            /// <summary>
            ///   System.Int32 BinarySearch(System.Int32 index, System.Int32 count, T item, System.Collections.Generic.IComparer<T> comparer)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "item">class T</param>
            /// <param name = "comparer">interface System.Collections.Generic.IComparer<T></param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BinarySearch", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IComparer<T>", 3)]
           public partial System.Int32 BINARY_SEARCH(System.Int32 index, System.Int32 count, nint item, nint comparer); 
*/
            /// <summary>
            ///   System.Int32 BinarySearch(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BinarySearch", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           public partial System.Int32 BINARY_SEARCH(nint item); 
*/
            /// <summary>
            ///   System.Int32 BinarySearch(T item, System.Collections.Generic.IComparer<T> comparer)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <param name = "comparer">interface System.Collections.Generic.IComparer<T></param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BinarySearch", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IComparer<T>", 1)]
           public partial System.Int32 BINARY_SEARCH(nint item, nint comparer); 
*/
            /// <summary>
            ///   System.Void Clear()
            /// </summary>
            /// <returns>struct System.Void</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clear", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            //public partial void CLEAR();

            /// <summary>
            ///   System.Boolean Contains(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           public partial System.Boolean CONTAINS(nint item); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TOutput> ConvertAll(System.Converter<T , TOutput> converter)
            /// </summary>
            /// <param name = "converter">class System.Converter<T , TOutput></param>
            /// <returns>class System.Collections.Generic.List<TOutput></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ConvertAll", "System.Collections.Generic.List<TOutput>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Converter<T,TOutput>", 0)]
           public partial nint CONVERT_ALL(nint converter); 
*/
            /// <summary>
            ///   System.Void CopyTo(T[] array)
            /// </summary>
            /// <param name = "array">class T[]</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T[]", 0)]
           public partial void COPY_TO(nint array); 
*/
            /// <summary>
            ///   System.Void CopyTo(System.Int32 index, T[] array, System.Int32 arrayIndex, System.Int32 count)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "array">class T[]</param>
            /// <param name = "arrayIndex">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T[]", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public partial void COPY_TO(System.Int32 index, nint array, System.Int32 arrayIndex, System.Int32 count); 
*/
            /// <summary>
            ///   System.Void CopyTo(T[] array, System.Int32 arrayIndex)
            /// </summary>
            /// <param name = "array">class T[]</param>
            /// <param name = "arrayIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void COPY_TO(nint array, System.Int32 arrayIndex); 
*/
            /// <summary>
            ///   System.Void EnsureCapacity(System.Int32 min)
            /// </summary>
            /// <param name = "min">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EnsureCapacity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void ENSURE_CAPACITY(System.Int32 min); 
*/
            /// <summary>
            ///   System.Boolean Exists(System.Predicate<T> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<T></param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Exists", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<T>", 0)]
           public partial System.Boolean EXISTS(nint match); 
*/
            /// <summary>
            ///   T Find(System.Predicate<T> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<T></param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Find", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<T>", 0)]
           public partial nint FIND(nint match); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<T> FindAll(System.Predicate<T> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<T></param>
            /// <returns>class System.Collections.Generic.List<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindAll", "System.Collections.Generic.List<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<T>", 0)]
           public partial nint FIND_ALL(nint match); 
*/
            /// <summary>
            ///   System.Int32 FindIndex(System.Predicate<T> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<T></param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<T>", 0)]
           public partial System.Int32 FIND_INDEX(nint match); 
*/
            /// <summary>
            ///   System.Int32 FindIndex(System.Int32 startIndex, System.Predicate<T> match)
            /// </summary>
            /// <param name = "startIndex">struct System.Int32</param>
            /// <param name = "match">class System.Predicate<T></param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<T>", 1)]
           public partial System.Int32 FIND_INDEX(System.Int32 startIndex, nint match); 
*/
            /// <summary>
            ///   System.Int32 FindIndex(System.Int32 startIndex, System.Int32 count, System.Predicate<T> match)
            /// </summary>
            /// <param name = "startIndex">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "match">class System.Predicate<T></param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<T>", 2)]
           public partial System.Int32 FIND_INDEX(System.Int32 startIndex, System.Int32 count, nint match); 
*/
            /// <summary>
            ///   T FindLast(System.Predicate<T> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<T></param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindLast", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<T>", 0)]
           public partial nint FIND_LAST(nint match); 
*/
            /// <summary>
            ///   System.Int32 FindLastIndex(System.Predicate<T> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<T></param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindLastIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<T>", 0)]
           public partial System.Int32 FIND_LAST_INDEX(nint match); 
*/
            /// <summary>
            ///   System.Int32 FindLastIndex(System.Int32 startIndex, System.Predicate<T> match)
            /// </summary>
            /// <param name = "startIndex">struct System.Int32</param>
            /// <param name = "match">class System.Predicate<T></param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindLastIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<T>", 1)]
           public partial System.Int32 FIND_LAST_INDEX(System.Int32 startIndex, nint match); 
*/
            /// <summary>
            ///   System.Int32 FindLastIndex(System.Int32 startIndex, System.Int32 count, System.Predicate<T> match)
            /// </summary>
            /// <param name = "startIndex">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "match">class System.Predicate<T></param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindLastIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<T>", 2)]
           public partial System.Int32 FIND_LAST_INDEX(System.Int32 startIndex, System.Int32 count, nint match); 
*/
            /// <summary>
            ///   System.Void ForEach(System.Action<T> action)
            /// </summary>
            /// <param name = "action">class System.Action<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ForEach", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<T>", 0)]
           public partial void FOR_EACH(nint action); 
*/
            /// <summary>
            ///   System.Int32 get_Capacity()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Capacity", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 GET_CAPACITY(); 
*/
            /// <summary>
            ///   System.Int32 get_Count()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Count", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 GET_COUNT(); 
*/
            /// <summary>
            ///   T get_Item(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Item", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial nint GET_ITEM(System.Int32 index); 
*/
            /// <summary>
            ///   System.Collections.Generic.List.Enumerator<T> GetEnumerator()
            /// </summary>
            /// <returns>struct System.Collections.Generic.List.Enumerator<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEnumerator", "System.Collections.Generic.List.Enumerator<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Collections.Generic.List.Enumerator<T> GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<T> GetRange(System.Int32 index, System.Int32 count)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRange", "System.Collections.Generic.List<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial nint GET_RANGE(System.Int32 index, System.Int32 count); 
*/
            /// <summary>
            ///   System.Int32 IndexOf(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           public partial System.Int32 INDEX_OF(nint item); 
*/
            /// <summary>
            ///   System.Int32 IndexOf(T item, System.Int32 index)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Int32 INDEX_OF(nint item, System.Int32 index); 
*/
            /// <summary>
            ///   System.Int32 IndexOf(T item, System.Int32 index, System.Int32 count)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial System.Int32 INDEX_OF(nint item, System.Int32 index, System.Int32 count); 
*/
            /// <summary>
            ///   System.Void Insert(System.Int32 index, T item)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Insert", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 1)]
           public partial void INSERT(System.Int32 index, nint item); 
*/
            /// <summary>
            ///   System.Void InsertRange(System.Int32 index, System.Collections.Generic.IEnumerable<T> collection)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "collection">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InsertRange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 1)]
           public partial void INSERT_RANGE(System.Int32 index, nint collection); 
*/
            /// <summary>
            ///   System.Int32 LastIndexOf(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LastIndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           public partial System.Int32 LAST_INDEX_OF(nint item); 
*/
            /// <summary>
            ///   System.Int32 LastIndexOf(T item, System.Int32 index)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LastIndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Int32 LAST_INDEX_OF(nint item, System.Int32 index); 
*/
            /// <summary>
            ///   System.Int32 LastIndexOf(T item, System.Int32 index, System.Int32 count)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LastIndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial System.Int32 LAST_INDEX_OF(nint item, System.Int32 index, System.Int32 count); 
*/
            /// <summary>
            ///   System.Boolean Remove(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Remove", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            //public partial System.Boolean REMOVE(nint item);

            /// <summary>
            ///   System.Int32 RemoveAll(System.Predicate<T> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<T></param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveAll", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<T>", 0)]
           public partial System.Int32 REMOVE_ALL(nint match); 
*/
            /// <summary>
            ///   System.Void RemoveAt(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveAt", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void REMOVE_AT(System.Int32 index); 
*/
            /// <summary>
            ///   System.Void RemoveRange(System.Int32 index, System.Int32 count)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveRange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void REMOVE_RANGE(System.Int32 index, System.Int32 count); 
*/
            /// <summary>
            ///   System.Void Reverse()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reverse", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void REVERSE(); 
*/
            /// <summary>
            ///   System.Void Reverse(System.Int32 index, System.Int32 count)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reverse", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void REVERSE(System.Int32 index, System.Int32 count); 
*/
            /// <summary>
            ///   System.Void set_Capacity(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Capacity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void SET_CAPACITY(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_Item(System.Int32 index, T value)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "value">class T</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Item", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 1)]
           public partial void SET_ITEM(System.Int32 index, nint value); 
*/
            /// <summary>
            ///   System.Void Sort()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Sort", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void SORT(); 
*/
            /// <summary>
            ///   System.Void Sort(System.Collections.Generic.IComparer<T> comparer)
            /// </summary>
            /// <param name = "comparer">interface System.Collections.Generic.IComparer<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Sort", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IComparer<T>", 0)]
           public partial void SORT(nint comparer); 
*/
            /// <summary>
            ///   System.Void Sort(System.Int32 index, System.Int32 count, System.Collections.Generic.IComparer<T> comparer)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "comparer">interface System.Collections.Generic.IComparer<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Sort", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IComparer<T>", 2)]
           public partial void SORT(System.Int32 index, System.Int32 count, nint comparer); 
*/
            /// <summary>
            ///   System.Void Sort(System.Comparison<T> comparison)
            /// </summary>
            /// <param name = "comparison">class System.Comparison<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Sort", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Comparison<T>", 0)]
           public partial void SORT(nint comparison); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.ICollection<T>.get_IsReadOnly", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean SYSTEM_COLLECTIONS_GENERIC_I_COLLECTION_TGET_IS_READ_ONLY(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerator<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.IEnumerable<T>.GetEnumerator", "System.Collections.Generic.IEnumerator<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint SYSTEM_COLLECTIONS_GENERIC_I_ENUMERABLE_T_GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 arrayIndex)
            /// </summary>
            /// <param name = "array">abstract class System.Array</param>
            /// <param name = "arrayIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.ICollection.CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Array", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void SYSTEM_COLLECTIONS_I_COLLECTION_COPY_TO(nint array, System.Int32 arrayIndex); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.ICollection.get_IsSynchronized()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.ICollection.get_IsSynchronized", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean SYSTEM_COLLECTIONS_I_COLLECTIONGET_IS_SYNCHRONIZED(); 
*/
            /// <summary>
            ///   System.Object System.Collections.ICollection.get_SyncRoot()
            /// </summary>
            /// <returns>class System.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.ICollection.get_SyncRoot", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint SYSTEM_COLLECTIONS_I_COLLECTIONGET_SYNC_ROOT(); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IEnumerable.GetEnumerator", "System.Collections.IEnumerator", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint SYSTEM_COLLECTIONS_I_ENUMERABLE_GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   System.Int32 System.Collections.IList.Add(System.Object item)
            /// </summary>
            /// <param name = "item">class System.Object</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.Add", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
           public partial System.Int32 SYSTEM_COLLECTIONS_I_LIST_ADD(nint item); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.IList.Contains(System.Object item)
            /// </summary>
            /// <param name = "item">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
           public partial System.Boolean SYSTEM_COLLECTIONS_I_LIST_CONTAINS(nint item); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.IList.get_IsFixedSize()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.get_IsFixedSize", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean SYSTEM_COLLECTIONS_I_LISTGET_IS_FIXED_SIZE(); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.IList.get_IsReadOnly()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.get_IsReadOnly", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean SYSTEM_COLLECTIONS_I_LISTGET_IS_READ_ONLY(); 
*/
            /// <summary>
            ///   System.Object System.Collections.IList.get_Item(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>class System.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.get_Item", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial nint SYSTEM_COLLECTIONS_I_LISTGET_ITEM(System.Int32 index); 
*/
            /// <summary>
            ///   System.Int32 System.Collections.IList.IndexOf(System.Object item)
            /// </summary>
            /// <param name = "item">class System.Object</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.IndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
           public partial System.Int32 SYSTEM_COLLECTIONS_I_LIST_INDEX_OF(nint item); 
*/
            /// <summary>
            ///   System.Void System.Collections.IList.Insert(System.Int32 index, System.Object item)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "item">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.Insert", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
           public partial void SYSTEM_COLLECTIONS_I_LIST_INSERT(System.Int32 index, nint item); 
*/
            /// <summary>
            ///   System.Void System.Collections.IList.Remove(System.Object item)
            /// </summary>
            /// <param name = "item">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.Remove", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
           public partial void SYSTEM_COLLECTIONS_I_LIST_REMOVE(nint item); 
*/
            /// <summary>
            ///   System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.set_Item", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
           public partial void SYSTEM_COLLECTIONS_I_LISTSET_ITEM(System.Int32 index, nint value); 
*/
            /// <summary>
            ///   T[] ToArray()
            /// </summary>
            /// <returns>class T[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToArray", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint TO_ARRAY(); 
*/
            /// <summary>
            ///   System.Void TrimExcess()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TrimExcess", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void TRIM_EXCESS(); 
*/
            /// <summary>
            ///   System.Boolean TrueForAll(System.Predicate<T> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<T></param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TrueForAll", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<T>", 0)]
           public partial System.Boolean TRUE_FOR_ALL(nint match); 
*/
        }
    }
}
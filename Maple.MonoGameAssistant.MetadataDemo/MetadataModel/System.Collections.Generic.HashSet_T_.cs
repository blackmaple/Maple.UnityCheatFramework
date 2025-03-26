using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;

namespace Maple.MonoGameAssistant.MetadataDemo
{
    /// <summary>
    /// class ["System.Core"."System.Collections.Generic"."HashSet`1"]
    /// [System.Object]
    /// [System.Collections.Generic.ICollection<T>]=>[System.Collections.Generic.IEnumerable<T>]=>[System.Collections.IEnumerable]=>[System.Collections.Generic.ISet<T>]=>[System.Collections.Generic.IReadOnlyCollection<T>]=>[System.Runtime.Serialization.ISerializable]=>[System.Runtime.Serialization.IDeserializationCallback]
    /// </summary>
    [MetadataExtensions.MetadataGenerator.GenericClassParentMetadataAttribute(
        typeof(GenericClassMetadataCollector<>)
        , typeof(HashSetGeneric<>.Ptr_HashSetGeneric)
        )]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.GenericClassModelMetadataAttribute()]
    public partial class HashSetGeneric<TITEM> where TITEM : unmanaged
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_HashSetGeneric(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_HashSetGeneric(System.IntPtr ptr) => new Ptr_HashSetGeneric(ptr);
            public static implicit operator System.IntPtr(Ptr_HashSetGeneric ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_HashSetGeneric ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["System.Core"."System.Collections.Generic"."HashSet`1"]
        /// </summary>
        partial struct Ptr_HashSetGeneric
        {
            /// <summary>
            /// 0x0 System.Int32 Lower31BitMask
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            public const System.Int32 LOWER31_BIT_MASK = 0; 
*/
            /// <summary>
            /// 0x0 System.Int32 StackAllocThreshold
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            public const System.Int32 STACK_ALLOC_THRESHOLD = 0; 
*/
            /// <summary>
            /// 0x0 System.Int32 ShrinkThreshold
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            public const System.Int32 SHRINK_THRESHOLD = 0; 
*/
            /// <summary>
            /// 0x0 System.String CapacityName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint CAPACITY_NAME = ; 
*/
            /// <summary>
            /// 0x0 System.String ElementsName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint ELEMENTS_NAME = ; 
*/
            /// <summary>
            /// 0x0 System.String ComparerName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint COMPARER_NAME = ; 
*/
            /// <summary>
            /// 0x0 System.String VersionName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint VERSION_NAME = ; 
*/
            /// <summary>
            /// 0x10 System.Int32[] _buckets
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_buckets", "System.Int32[]")]
            public partial nint _BUCKETS { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.HashSet.Slot<T>[] _slots
            /// class ["System.Core".""."Slot[]"]
            /// </summary>
            /// <returns>class System.Collections.Generic.HashSet.Slot<T>[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_slots", "System.Collections.Generic.HashSet.Slot<T>[]")]
            public partial nint _SLOTS { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.IEqualityComparer<T> _comparer
            /// interface ["mscorlib"."System.Collections.Generic"."IEqualityComparer`1"]
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEqualityComparer<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_comparer", "System.Collections.Generic.IEqualityComparer<T>")]
            public partial nint _COMPARER { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Runtime.Serialization.SerializationInfo _siInfo
            /// class ["mscorlib"."System.Runtime.Serialization"."SerializationInfo"]
            /// </summary>
            /// <returns>class System.Runtime.Serialization.SerializationInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_siInfo", "System.Runtime.Serialization.SerializationInfo")]
            public partial nint _SI_INFO { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 _count
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_count", "System.Int32")]
            public partial System.Int32 _COUNT { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Int32 _lastIndex
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_lastIndex", "System.Int32")]
            public partial System.Int32 _LAST_INDEX { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32 _freeList
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_freeList", "System.Int32")]
            public partial System.Int32 _FREE_LIST { get; set; } 
*/

            /// <summary>
            /// 0x3C System.Int32 _version
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_version", "System.Int32")]
            public partial System.Int32 _VERSION { get; set; } 
*/
        }

        /// <summary>
        /// class ["System.Core"."System.Collections.Generic"."HashSet`1"]
        /// </summary>
        partial struct Ptr_HashSetGeneric
        {
            /// <summary>
            /// static  System.Boolean AreEqualityComparersEqual(System.Collections.Generic.HashSet<T> set1, System.Collections.Generic.HashSet<T> set2)
            /// </summary>
            /// <param name = "set1">class System.Collections.Generic.HashSet<T></param>
            /// <param name = "set2">class System.Collections.Generic.HashSet<T></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AreEqualityComparersEqual", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.HashSet<T>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.HashSet<T>", 1)]
            public static partial System.Boolean ARE_EQUALITY_COMPARERS_EQUAL(nint set1, nint set2); 
*/
            /// <summary>
            /// static  System.Collections.Generic.IEqualityComparer<System.Collections.Generic.HashSet<T>> CreateSetComparer()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEqualityComparer<System.Collections.Generic.HashSet<T>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateSetComparer", "System.Collections.Generic.IEqualityComparer<System.Collections.Generic.HashSet<T>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint CREATE_SET_COMPARER(); 
*/
            /// <summary>
            /// static  System.Boolean HashSetEquals(System.Collections.Generic.HashSet<T> set1, System.Collections.Generic.HashSet<T> set2, System.Collections.Generic.IEqualityComparer<T> comparer)
            /// </summary>
            /// <param name = "set1">class System.Collections.Generic.HashSet<T></param>
            /// <param name = "set2">class System.Collections.Generic.HashSet<T></param>
            /// <param name = "comparer">interface System.Collections.Generic.IEqualityComparer<T></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HashSetEquals", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.HashSet<T>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.HashSet<T>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEqualityComparer<T>", 2)]
            public static partial System.Boolean HASH_SET_EQUALS(nint set1, nint set2, nint comparer); 
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
            ///   System.Void .ctor(System.Collections.Generic.IEqualityComparer<T> comparer)
            /// </summary>
            /// <param name = "comparer">interface System.Collections.Generic.IEqualityComparer<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEqualityComparer<T>", 0)]
            public partial void CTOR(nint comparer); 
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
            ///   System.Void .ctor(System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IEqualityComparer<T> comparer)
            /// </summary>
            /// <param name = "collection">interface System.Collections.Generic.IEnumerable<T></param>
            /// <param name = "comparer">interface System.Collections.Generic.IEqualityComparer<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEqualityComparer<T>", 1)]
            public partial void CTOR(nint collection, nint comparer); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "info">class System.Runtime.Serialization.SerializationInfo</param>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.SerializationInfo", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 1)]
            public partial void CTOR(nint info, System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 capacity, System.Collections.Generic.IEqualityComparer<T> comparer)
            /// </summary>
            /// <param name = "capacity">struct System.Int32</param>
            /// <param name = "comparer">interface System.Collections.Generic.IEqualityComparer<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEqualityComparer<T>", 1)]
            public partial void CTOR(System.Int32 capacity, nint comparer); 
*/
            /// <summary>
            ///   System.Boolean Add(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Add", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public partial System.Boolean ADD(nint item); 
*/
            /// <summary>
            ///   System.Boolean AddIfNotPresent(T value)
            /// </summary>
            /// <param name = "value">class T</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddIfNotPresent", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public partial System.Boolean ADD_IF_NOT_PRESENT(nint value); 
*/
            /// <summary>
            ///   System.Boolean AddOrGetLocation(T value, System.Int32& location)
            /// </summary>
            /// <param name = "value">class T</param>
            /// <param name = "location">struct System.Int32&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddOrGetLocation", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 1)]
            public partial System.Boolean ADD_OR_GET_LOCATION(nint value, System.Int32 &location); 
*/
            /// <summary>
            ///   System.Void AddValue(System.Int32 index, System.Int32 hashCode, T value)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "hashCode">struct System.Int32</param>
            /// <param name = "value">class T</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddValue", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 2)]
            public partial void ADD_VALUE(System.Int32 index, System.Int32 hashCode, nint value); 
*/
            /// <summary>
            ///   System.Collections.Generic.HashSet.ElementCount<T> CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable<T> other, System.Boolean returnIfUnfound)
            /// </summary>
            /// <param name = "other">interface System.Collections.Generic.IEnumerable<T></param>
            /// <param name = "returnIfUnfound">struct System.Boolean</param>
            /// <returns>struct System.Collections.Generic.HashSet.ElementCount<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckUniqueAndUnfoundElements", "System.Collections.Generic.HashSet.ElementCount<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Collections.Generic.HashSet.ElementCount<T> CHECK_UNIQUE_AND_UNFOUND_ELEMENTS(nint other, System.Boolean returnIfUnfound); 
*/
            /// <summary>
            ///   System.Void Clear()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clear", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR(); 
*/
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
            ///   System.Boolean ContainsAllElements(System.Collections.Generic.IEnumerable<T> other)
            /// </summary>
            /// <param name = "other">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ContainsAllElements", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            public partial System.Boolean CONTAINS_ALL_ELEMENTS(nint other); 
*/
            /// <summary>
            ///   System.Void CopyFrom(System.Collections.Generic.HashSet<T> source)
            /// </summary>
            /// <param name = "source">class System.Collections.Generic.HashSet<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyFrom", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.HashSet<T>", 0)]
            public partial void COPY_FROM(nint source); 
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
            ///   System.Void CopyTo(T[] array, System.Int32 arrayIndex, System.Int32 count)
            /// </summary>
            /// <param name = "array">class T[]</param>
            /// <param name = "arrayIndex">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T[]", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void COPY_TO(nint array, System.Int32 arrayIndex, System.Int32 count); 
*/
            /// <summary>
            ///   System.Int32 EnsureCapacity(System.Int32 capacity)
            /// </summary>
            /// <param name = "capacity">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EnsureCapacity", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 ENSURE_CAPACITY(System.Int32 capacity); 
*/
            /// <summary>
            ///   System.Void ExceptWith(System.Collections.Generic.IEnumerable<T> other)
            /// </summary>
            /// <param name = "other">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ExceptWith", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            public partial void EXCEPT_WITH(nint other); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEqualityComparer<T> get_Comparer()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEqualityComparer<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Comparer", "System.Collections.Generic.IEqualityComparer<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPARER(); 
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
            ///   System.Collections.Generic.HashSet.Enumerator<T> GetEnumerator()
            /// </summary>
            /// <returns>struct System.Collections.Generic.HashSet.Enumerator<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEnumerator", "System.Collections.Generic.HashSet.Enumerator<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Collections.Generic.HashSet.Enumerator<T> GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "info">class System.Runtime.Serialization.SerializationInfo</param>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetObjectData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.SerializationInfo", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 1)]
            public partial void GET_OBJECT_DATA(nint info, System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   System.Void IncreaseCapacity()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IncreaseCapacity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INCREASE_CAPACITY(); 
*/
            /// <summary>
            ///   System.Int32 Initialize(System.Int32 capacity)
            /// </summary>
            /// <param name = "capacity">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Initialize", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 INITIALIZE(System.Int32 capacity); 
*/
            /// <summary>
            ///   System.Int32 InternalGetHashCode(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InternalGetHashCode", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public partial System.Int32 INTERNAL_GET_HASH_CODE(nint item); 
*/
            /// <summary>
            ///   System.Int32 InternalIndexOf(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InternalIndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public partial System.Int32 INTERNAL_INDEX_OF(nint item); 
*/
            /// <summary>
            ///   System.Void IntersectWith(System.Collections.Generic.IEnumerable<T> other)
            /// </summary>
            /// <param name = "other">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IntersectWith", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            public partial void INTERSECT_WITH(nint other); 
*/
            /// <summary>
            ///   System.Void IntersectWithEnumerable(System.Collections.Generic.IEnumerable<T> other)
            /// </summary>
            /// <param name = "other">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IntersectWithEnumerable", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            public partial void INTERSECT_WITH_ENUMERABLE(nint other); 
*/
            /// <summary>
            ///   System.Void IntersectWithHashSetWithSameEC(System.Collections.Generic.HashSet<T> other)
            /// </summary>
            /// <param name = "other">class System.Collections.Generic.HashSet<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IntersectWithHashSetWithSameEC", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.HashSet<T>", 0)]
            public partial void INTERSECT_WITH_HASH_SET_WITH_SAME_EC(nint other); 
*/
            /// <summary>
            ///   System.Boolean IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other)
            /// </summary>
            /// <param name = "other">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsProperSubsetOf", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            public partial System.Boolean IS_PROPER_SUBSET_OF(nint other); 
*/
            /// <summary>
            ///   System.Boolean IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other)
            /// </summary>
            /// <param name = "other">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsProperSupersetOf", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            public partial System.Boolean IS_PROPER_SUPERSET_OF(nint other); 
*/
            /// <summary>
            ///   System.Boolean IsSubsetOf(System.Collections.Generic.IEnumerable<T> other)
            /// </summary>
            /// <param name = "other">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsSubsetOf", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            public partial System.Boolean IS_SUBSET_OF(nint other); 
*/
            /// <summary>
            ///   System.Boolean IsSubsetOfHashSetWithSameEC(System.Collections.Generic.HashSet<T> other)
            /// </summary>
            /// <param name = "other">class System.Collections.Generic.HashSet<T></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsSubsetOfHashSetWithSameEC", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.HashSet<T>", 0)]
            public partial System.Boolean IS_SUBSET_OF_HASH_SET_WITH_SAME_EC(nint other); 
*/
            /// <summary>
            ///   System.Boolean IsSupersetOf(System.Collections.Generic.IEnumerable<T> other)
            /// </summary>
            /// <param name = "other">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsSupersetOf", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            public partial System.Boolean IS_SUPERSET_OF(nint other); 
*/
            /// <summary>
            ///   System.Void OnDeserialization(System.Object sender)
            /// </summary>
            /// <param name = "sender">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDeserialization", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial void ON_DESERIALIZATION(nint sender); 
*/
            /// <summary>
            ///   System.Boolean Overlaps(System.Collections.Generic.IEnumerable<T> other)
            /// </summary>
            /// <param name = "other">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Overlaps", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            public partial System.Boolean OVERLAPS(nint other); 
*/
            /// <summary>
            ///   System.Boolean Remove(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Remove", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public partial System.Boolean REMOVE(nint item); 
*/
            /// <summary>
            ///   System.Int32 RemoveWhere(System.Predicate<T> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<T></param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveWhere", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<T>", 0)]
            public partial System.Int32 REMOVE_WHERE(nint match); 
*/
            /// <summary>
            ///   System.Void SetCapacity(System.Int32 newSize)
            /// </summary>
            /// <param name = "newSize">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetCapacity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_CAPACITY(System.Int32 newSize); 
*/
            /// <summary>
            ///   System.Boolean SetEquals(System.Collections.Generic.IEnumerable<T> other)
            /// </summary>
            /// <param name = "other">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetEquals", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            public partial System.Boolean SET_EQUALS(nint other); 
*/
            /// <summary>
            ///   System.Void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> other)
            /// </summary>
            /// <param name = "other">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SymmetricExceptWith", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            public partial void SYMMETRIC_EXCEPT_WITH(nint other); 
*/
            /// <summary>
            ///   System.Void SymmetricExceptWithEnumerable(System.Collections.Generic.IEnumerable<T> other)
            /// </summary>
            /// <param name = "other">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SymmetricExceptWithEnumerable", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            public partial void SYMMETRIC_EXCEPT_WITH_ENUMERABLE(nint other); 
*/
            /// <summary>
            ///   System.Void SymmetricExceptWithUniqueHashSet(System.Collections.Generic.HashSet<T> other)
            /// </summary>
            /// <param name = "other">class System.Collections.Generic.HashSet<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SymmetricExceptWithUniqueHashSet", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.HashSet<T>", 0)]
            public partial void SYMMETRIC_EXCEPT_WITH_UNIQUE_HASH_SET(nint other); 
*/
            /// <summary>
            ///   System.Void System.Collections.Generic.ICollection<T>.Add(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.ICollection<T>.Add", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public partial void SYSTEM_COLLECTIONS_GENERIC_I_COLLECTION_T_ADD(nint item); 
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
            ///   System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.IEnumerator</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IEnumerable.GetEnumerator", "System.Collections.IEnumerator", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SYSTEM_COLLECTIONS_I_ENUMERABLE_GET_ENUMERATOR(); 
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
            ///   System.Boolean TryGetValue(T equalValue, T& actualValue)
            /// </summary>
            /// <param name = "equalValue">class T</param>
            /// <param name = "actualValue">class T&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryGetValue", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 1)]
            public partial System.Boolean TRY_GET_VALUE(nint equalValue, nint actualValue); 
*/
            /// <summary>
            ///   System.Void UnionWith(System.Collections.Generic.IEnumerable<T> other)
            /// </summary>
            /// <param name = "other">interface System.Collections.Generic.IEnumerable<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnionWith", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<T>", 0)]
            public partial void UNION_WITH(nint other); 
*/
        }
    }
}
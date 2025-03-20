namespace Maple.MonoGameAssistant.MetadataDemo
{
    /// <summary>
    /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
    /// [System.Object]
    /// [System.Collections.Generic.IDictionary<TKey , TValue>]=>[System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey , TValue>>]=>[System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey , TValue>>]=>[System.Collections.IEnumerable]=>[System.Collections.IDictionary]=>[System.Collections.ICollection]=>[System.Collections.Generic.IReadOnlyDictionary<TKey , TValue>]=>[System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey , TValue>>]=>[System.Runtime.Serialization.ISerializable]=>[System.Runtime.Serialization.IDeserializationCallback]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_DictionaryGeneric>, Ptr_DictionaryGeneric>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("mscorlib", "System.Collections.Generic", "Dictionary`2", "System.Collections.Generic.Dictionary<TKey,TValue>")]
    public partial class DictionaryGeneric
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_DictionaryGeneric(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_DictionaryGeneric(System.IntPtr ptr) => new Ptr_DictionaryGeneric(ptr);
            public static implicit operator System.IntPtr(Ptr_DictionaryGeneric ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_DictionaryGeneric ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
        /// </summary>
        partial struct Ptr_DictionaryGeneric
        {
            /// <summary>
            /// 0x0 System.String VersionName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint VERSION_NAME = ; 
*/
            /// <summary>
            /// 0x0 System.String HashSizeName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint HASH_SIZE_NAME = ; 
*/
            /// <summary>
            /// 0x0 System.String KeyValuePairsName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint KEY_VALUE_PAIRS_NAME = ; 
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
            /// 0x10 System.Int32[] _buckets
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_buckets", "System.Int32[]")]
            public partial nint _BUCKETS { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.Dictionary.Entry<TKey , TValue>[] _entries
            /// class ["mscorlib".""."Entry[]"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary.Entry<TKey , TValue>[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_entries", "System.Collections.Generic.Dictionary.Entry<TKey,TValue>[]")]
            public partial nint _ENTRIES { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.IEqualityComparer<TKey> _comparer
            /// interface ["mscorlib"."System.Collections.Generic"."IEqualityComparer`1"]
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEqualityComparer<TKey></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_comparer", "System.Collections.Generic.IEqualityComparer<TKey>")]
            public partial nint _COMPARER { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.Dictionary.KeyCollection<TKey , TValue> _keys
            /// class ["mscorlib".""."KeyCollection"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary.KeyCollection<TKey , TValue></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_keys", "System.Collections.Generic.Dictionary.KeyCollection<TKey,TValue>")]
            public partial nint _KEYS { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.Dictionary.ValueCollection<TKey , TValue> _values
            /// class ["mscorlib".""."ValueCollection"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary.ValueCollection<TKey , TValue></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_values", "System.Collections.Generic.Dictionary.ValueCollection<TKey,TValue>")]
            public partial nint _VALUES { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Object _syncRoot
            /// class ["mscorlib"."System"."Object"]
            /// </summary>
            /// <returns>class System.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_syncRoot", "System.Object")]
            public partial nint _SYNC_ROOT { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 _count
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_count", "System.Int32")]
            public partial System.Int32 _COUNT { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Int32 _freeList
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_freeList", "System.Int32")]
            public partial System.Int32 _FREE_LIST { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 _freeCount
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_freeCount", "System.Int32")]
            public partial System.Int32 _FREE_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x4C System.Int32 _version
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_version", "System.Int32")]
            public partial System.Int32 _VERSION { get; set; } 
*/
        }

        /// <summary>
        /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
        /// </summary>
        partial struct Ptr_DictionaryGeneric
        {
            /// <summary>
            /// static  System.Boolean IsCompatibleKey(System.Object key)
            /// </summary>
            /// <param name = "key">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsCompatibleKey", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public static partial System.Boolean IS_COMPATIBLE_KEY(nint key); 
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
            ///   System.Void .ctor(System.Collections.Generic.IEqualityComparer<TKey> comparer)
            /// </summary>
            /// <param name = "comparer">interface System.Collections.Generic.IEqualityComparer<TKey></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEqualityComparer<TKey>", 0)]
            public partial void CTOR(nint comparer); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer)
            /// </summary>
            /// <param name = "capacity">struct System.Int32</param>
            /// <param name = "comparer">interface System.Collections.Generic.IEqualityComparer<TKey></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEqualityComparer<TKey>", 1)]
            public partial void CTOR(System.Int32 capacity, nint comparer); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IDictionary<TKey , TValue> dictionary)
            /// </summary>
            /// <param name = "dictionary">interface System.Collections.Generic.IDictionary<TKey , TValue></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IDictionary<TKey,TValue>", 0)]
            public partial void CTOR(nint dictionary); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IDictionary<TKey , TValue> dictionary, System.Collections.Generic.IEqualityComparer<TKey> comparer)
            /// </summary>
            /// <param name = "dictionary">interface System.Collections.Generic.IDictionary<TKey , TValue></param>
            /// <param name = "comparer">interface System.Collections.Generic.IEqualityComparer<TKey></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IDictionary<TKey,TValue>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEqualityComparer<TKey>", 1)]
            public partial void CTOR(nint dictionary, nint comparer); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey , TValue>> collection)
            /// </summary>
            /// <param name = "collection">interface System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey , TValue>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>", 0)]
            public partial void CTOR(nint collection); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey , TValue>> collection, System.Collections.Generic.IEqualityComparer<TKey> comparer)
            /// </summary>
            /// <param name = "collection">interface System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey , TValue>></param>
            /// <param name = "comparer">interface System.Collections.Generic.IEqualityComparer<TKey></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEqualityComparer<TKey>", 1)]
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
            ///   System.Void Add(TKey key, TValue value)
            /// </summary>
            /// <param name = "key">class TKey</param>
            /// <param name = "value">class TValue</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Add", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TKey", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TValue", 1)]
            public partial void ADD(nint key, nint value); 
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
            ///   System.Boolean ContainsKey(TKey key)
            /// </summary>
            /// <param name = "key">class TKey</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ContainsKey", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TKey", 0)]
            public partial System.Boolean CONTAINS_KEY(nint key); 
*/
            /// <summary>
            ///   System.Boolean ContainsValue(TValue value)
            /// </summary>
            /// <param name = "value">class TValue</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ContainsValue", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TValue", 0)]
            public partial System.Boolean CONTAINS_VALUE(nint value); 
*/
            /// <summary>
            ///   System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey , TValue>[] array, System.Int32 index)
            /// </summary>
            /// <param name = "array">class System.Collections.Generic.KeyValuePair<TKey , TValue>[]</param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.KeyValuePair<TKey,TValue>[]", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void COPY_TO(nint array, System.Int32 index); 
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
            ///   System.Int32 FindEntry(TKey key)
            /// </summary>
            /// <param name = "key">class TKey</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindEntry", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TKey", 0)]
            public partial System.Int32 FIND_ENTRY(nint key); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEqualityComparer<TKey> get_Comparer()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEqualityComparer<TKey></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Comparer", "System.Collections.Generic.IEqualityComparer<TKey>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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
            ///   TValue get_Item(TKey key)
            /// </summary>
            /// <param name = "key">class TKey</param>
            /// <returns>class TValue</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Item", "TValue", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TKey", 0)]
            public partial nint GET_ITEM(nint key); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary.KeyCollection<TKey , TValue> get_Keys()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary.KeyCollection<TKey , TValue></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Keys", "System.Collections.Generic.Dictionary.KeyCollection<TKey,TValue>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_KEYS(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary.ValueCollection<TKey , TValue> get_Values()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary.ValueCollection<TKey , TValue></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Values", "System.Collections.Generic.Dictionary.ValueCollection<TKey,TValue>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_VALUES(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary.Enumerator<TKey , TValue> GetEnumerator()
            /// </summary>
            /// <returns>struct System.Collections.Generic.Dictionary.Enumerator<TKey , TValue></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEnumerator", "System.Collections.Generic.Dictionary.Enumerator<TKey,TValue>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Collections.Generic.Dictionary.Enumerator<TKey, TValue> GET_ENUMERATOR(); 
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
            ///   System.Boolean Remove(TKey key)
            /// </summary>
            /// <param name = "key">class TKey</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Remove", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TKey", 0)]
            public partial System.Boolean REMOVE(nint key); 
*/
            /// <summary>
            ///   System.Boolean Remove(TKey key, TValue& value)
            /// </summary>
            /// <param name = "key">class TKey</param>
            /// <param name = "value">class TValue&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Remove", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TKey", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TValue&", 1)]
            public partial System.Boolean REMOVE(nint key, nint value); 
*/
            /// <summary>
            ///   System.Void Resize()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Resize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESIZE(); 
*/
            /// <summary>
            ///   System.Void Resize(System.Int32 newSize, System.Boolean forceNewHashCodes)
            /// </summary>
            /// <param name = "newSize">struct System.Int32</param>
            /// <param name = "forceNewHashCodes">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Resize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void RESIZE(System.Int32 newSize, System.Boolean forceNewHashCodes); 
*/
            /// <summary>
            ///   System.Void set_Item(TKey key, TValue value)
            /// </summary>
            /// <param name = "key">class TKey</param>
            /// <param name = "value">class TValue</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Item", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TKey", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TValue", 1)]
            public partial void SET_ITEM(nint key, nint value); 
*/
            /// <summary>
            ///   System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey , TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey , TValue> keyValuePair)
            /// </summary>
            /// <param name = "keyValuePair">struct System.Collections.Generic.KeyValuePair<TKey , TValue></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.KeyValuePair<TKey,TValue>", 0)]
            public partial void SYSTEM_COLLECTIONS_GENERIC_I_COLLECTION_SYSTEM_COLLECTIONS_GENERIC_KEY_VALUE_PAIR_T_KEY,T_VALUE_ADD(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey , TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey , TValue> keyValuePair)
            /// </summary>
            /// <param name = "keyValuePair">struct System.Collections.Generic.KeyValuePair<TKey , TValue></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.KeyValuePair<TKey,TValue>", 0)]
            public partial System.Boolean SYSTEM_COLLECTIONS_GENERIC_I_COLLECTION_SYSTEM_COLLECTIONS_GENERIC_KEY_VALUE_PAIR_T_KEY,T_VALUE_CONTAINS(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair); 
*/
            /// <summary>
            ///   System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey , TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey , TValue>[] array, System.Int32 index)
            /// </summary>
            /// <param name = "array">class System.Collections.Generic.KeyValuePair<TKey , TValue>[]</param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.KeyValuePair<TKey,TValue>[]", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SYSTEM_COLLECTIONS_GENERIC_I_COLLECTION_SYSTEM_COLLECTIONS_GENERIC_KEY_VALUE_PAIR_T_KEY,T_VALUE_COPY_TO(nint array, System.Int32 index); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey , TValue>>.get_IsReadOnly()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean SYSTEM_COLLECTIONS_GENERIC_I_COLLECTION_SYSTEM_COLLECTIONS_GENERIC_KEY_VALUE_PAIR_T_KEY,T_VALUEGET_IS_READ_ONLY(); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey , TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey , TValue> keyValuePair)
            /// </summary>
            /// <param name = "keyValuePair">struct System.Collections.Generic.KeyValuePair<TKey , TValue></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.KeyValuePair<TKey,TValue>", 0)]
            public partial System.Boolean SYSTEM_COLLECTIONS_GENERIC_I_COLLECTION_SYSTEM_COLLECTIONS_GENERIC_KEY_VALUE_PAIR_T_KEY,T_VALUE_REMOVE(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair); 
*/
            /// <summary>
            ///   System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey , TValue>.get_Keys()
            /// </summary>
            /// <returns>interface System.Collections.Generic.ICollection<TKey></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys", "System.Collections.Generic.ICollection<TKey>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SYSTEM_COLLECTIONS_GENERIC_I_DICTIONARY_T_KEY,T_VALUEGET_KEYS(); 
*/
            /// <summary>
            ///   System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey , TValue>.get_Values()
            /// </summary>
            /// <returns>interface System.Collections.Generic.ICollection<TValue></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.IDictionary<TKey,TValue>.get_Values", "System.Collections.Generic.ICollection<TValue>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SYSTEM_COLLECTIONS_GENERIC_I_DICTIONARY_T_KEY,T_VALUEGET_VALUES(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey , TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey , TValue>>.GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey , TValue>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator", "System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SYSTEM_COLLECTIONS_GENERIC_I_ENUMERABLE_SYSTEM_COLLECTIONS_GENERIC_KEY_VALUE_PAIR_T_KEY,T_VALUE_GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey , TValue>.get_Keys()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerable<TKey></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys", "System.Collections.Generic.IEnumerable<TKey>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SYSTEM_COLLECTIONS_GENERIC_I_READ_ONLY_DICTIONARY_T_KEY,T_VALUEGET_KEYS(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey , TValue>.get_Values()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerable<TValue></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values", "System.Collections.Generic.IEnumerable<TValue>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SYSTEM_COLLECTIONS_GENERIC_I_READ_ONLY_DICTIONARY_T_KEY,T_VALUEGET_VALUES(); 
*/
            /// <summary>
            ///   System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
            /// </summary>
            /// <param name = "array">abstract class System.Array</param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.ICollection.CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Array", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SYSTEM_COLLECTIONS_I_COLLECTION_COPY_TO(nint array, System.Int32 index); 
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
            ///   System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value)
            /// </summary>
            /// <param name = "key">class System.Object</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IDictionary.Add", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial void SYSTEM_COLLECTIONS_I_DICTIONARY_ADD(nint key, nint value); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.IDictionary.Contains(System.Object key)
            /// </summary>
            /// <param name = "key">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IDictionary.Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial System.Boolean SYSTEM_COLLECTIONS_I_DICTIONARY_CONTAINS(nint key); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.IDictionary.get_IsFixedSize()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IDictionary.get_IsFixedSize", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean SYSTEM_COLLECTIONS_I_DICTIONARYGET_IS_FIXED_SIZE(); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.IDictionary.get_IsReadOnly()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IDictionary.get_IsReadOnly", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean SYSTEM_COLLECTIONS_I_DICTIONARYGET_IS_READ_ONLY(); 
*/
            /// <summary>
            ///   System.Object System.Collections.IDictionary.get_Item(System.Object key)
            /// </summary>
            /// <param name = "key">class System.Object</param>
            /// <returns>class System.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IDictionary.get_Item", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial nint SYSTEM_COLLECTIONS_I_DICTIONARYGET_ITEM(nint key); 
*/
            /// <summary>
            ///   System.Collections.ICollection System.Collections.IDictionary.get_Keys()
            /// </summary>
            /// <returns>interface System.Collections.ICollection</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IDictionary.get_Keys", "System.Collections.ICollection", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SYSTEM_COLLECTIONS_I_DICTIONARYGET_KEYS(); 
*/
            /// <summary>
            ///   System.Collections.ICollection System.Collections.IDictionary.get_Values()
            /// </summary>
            /// <returns>interface System.Collections.ICollection</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IDictionary.get_Values", "System.Collections.ICollection", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SYSTEM_COLLECTIONS_I_DICTIONARYGET_VALUES(); 
*/
            /// <summary>
            ///   System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.IDictionaryEnumerator</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IDictionary.GetEnumerator", "System.Collections.IDictionaryEnumerator", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SYSTEM_COLLECTIONS_I_DICTIONARY_GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   System.Void System.Collections.IDictionary.Remove(System.Object key)
            /// </summary>
            /// <param name = "key">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IDictionary.Remove", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial void SYSTEM_COLLECTIONS_I_DICTIONARY_REMOVE(nint key); 
*/
            /// <summary>
            ///   System.Void System.Collections.IDictionary.set_Item(System.Object key, System.Object value)
            /// </summary>
            /// <param name = "key">class System.Object</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IDictionary.set_Item", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial void SYSTEM_COLLECTIONS_I_DICTIONARYSET_ITEM(nint key, nint value); 
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
            ///   System.Void TrimExcess(System.Int32 capacity)
            /// </summary>
            /// <param name = "capacity">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TrimExcess", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void TRIM_EXCESS(System.Int32 capacity); 
*/
            /// <summary>
            ///   System.Boolean TryAdd(TKey key, TValue value)
            /// </summary>
            /// <param name = "key">class TKey</param>
            /// <param name = "value">class TValue</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryAdd", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TKey", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TValue", 1)]
            public partial System.Boolean TRY_ADD(nint key, nint value); 
*/
            /// <summary>
            ///   System.Boolean TryGetValue(TKey key, TValue& value)
            /// </summary>
            /// <param name = "key">class TKey</param>
            /// <param name = "value">class TValue&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryGetValue", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TKey", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TValue&", 1)]
            public partial System.Boolean TRY_GET_VALUE(nint key, nint value); 
*/
            /// <summary>
            ///   System.Boolean TryInsert(TKey key, TValue value, System.Collections.Generic.InsertionBehavior behavior)
            /// </summary>
            /// <param name = "key">class TKey</param>
            /// <param name = "value">class TValue</param>
            /// <param name = "behavior">enum System.Collections.Generic.InsertionBehavior</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryInsert", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TKey", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TValue", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.InsertionBehavior", 2)]
            public partial System.Boolean TRY_INSERT(nint key, nint value, System.Collections.Generic.InsertionBehavior behavior); 
*/
        }
    }
}
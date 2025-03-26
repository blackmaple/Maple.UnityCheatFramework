using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataObject;

namespace Maple.MonoGameAssistant.MetadataDemo
{
    /// <summary>
    /// class ["mscorlib"."System.Collections.Generic"."Stack`1"]
    /// [System.Object]
    /// [System.Collections.Generic.IEnumerable<T>]=>[System.Collections.IEnumerable]=>[System.Collections.ICollection]=>[System.Collections.Generic.IReadOnlyCollection<T>]
    /// </summary>
    [MetadataExtensions.MetadataGenerator.GenericClassParentMetadataAttribute(
        typeof(GenericClassMetadataCollector<>)
        , typeof(StackGeneric<>.Ptr_StackGeneric)
        )]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.GenericClassModelMetadataAttribute()]
    public partial class StackGeneric<TITEM> where TITEM : unmanaged

    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_StackGeneric(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_StackGeneric(System.IntPtr ptr) => new Ptr_StackGeneric(ptr);
            public static implicit operator System.IntPtr(Ptr_StackGeneric ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_StackGeneric ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["mscorlib"."System.Collections.Generic"."Stack`1"]
        /// </summary>
        partial struct Ptr_StackGeneric
        {
            /// <summary>
            /// 0x0 System.Int32 DefaultCapacity
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           public const System.Int32 DEFAULT_CAPACITY = 0; 
*/
            /// <summary>
            /// 0x10 T[] _array
            /// class ["mscorlib"."System.Collections.Generic"."T[]"]
            /// </summary>
            /// <returns>class T[]</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_array", default)]
            public partial PMonoArray<TITEM> _ARRAY { get; set; }


            /// <summary>
            /// 0x18 System.Object _syncRoot
            /// class ["mscorlib"."System"."Object"]
            /// </summary>
            /// <returns>class System.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_syncRoot", "System.Object")]
           public partial nint _SYNC_ROOT { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 _size
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_size", "System.Int32")]
            public partial System.Int32 _SIZE { get; set; }


            /// <summary>
            /// 0x24 System.Int32 _version
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_version", "System.Int32")]
           public partial System.Int32 _VERSION { get; set; } 
*/
        }

        /// <summary>
        /// class ["mscorlib"."System.Collections.Generic"."Stack`1"]
        /// </summary>
        partial struct Ptr_StackGeneric
        {
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
            ///   System.Int32 get_Count()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Count", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_COUNT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Stack.Enumerator<T> GetEnumerator()
            /// </summary>
            /// <returns>struct System.Collections.Generic.Stack.Enumerator<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEnumerator", "System.Collections.Generic.Stack.Enumerator<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Collections.Generic.Stack.Enumerator<T> GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   T Peek()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Peek", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint PEEK(); 
*/
            /// <summary>
            ///   T Pop()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Pop", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint POP(); 
*/
            /// <summary>
            ///   System.Void Push(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Push", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public partial void PUSH(nint item); 
*/
            /// <summary>
            ///   System.Void PushWithResize(T item)
            /// </summary>
            /// <param name = "item">class T</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PushWithResize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public partial void PUSH_WITH_RESIZE(nint item); 
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
            ///   System.Void ThrowForEmptyStack()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ThrowForEmptyStack", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void THROW_FOR_EMPTY_STACK(); 
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
            ///   System.Boolean TryPeek(T& result)
            /// </summary>
            /// <param name = "result">class T&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryPeek", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 0)]
            public partial System.Boolean TRY_PEEK(nint result); 
*/
            /// <summary>
            ///   System.Boolean TryPop(T& result)
            /// </summary>
            /// <param name = "result">class T&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryPop", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 0)]
            public partial System.Boolean TRY_POP(nint result); 
*/
        }


        partial struct Ptr_StackGeneric : ISysPtrStack<TITEM>
        {
            public int Size => _SIZE;

            public PMonoArray<TITEM> Array => _ARRAY;

            public Ptr_MonoItem<TITEM>[] PtrStackToArray() => this.PtrStackAsRefArray<Ptr_StackGeneric, TITEM>();
            public IEnumerable<Ptr_MonoItem<TITEM>> PtrStackAsEnumerable() => this.PtrStackAsEnumerable<Ptr_StackGeneric, TITEM>();


        }
    }
}
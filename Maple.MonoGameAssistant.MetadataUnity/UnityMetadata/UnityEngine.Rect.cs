using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.MetadataUnity
{
    /// <summary>
    /// struct ["UnityEngine.CoreModule"."UnityEngine"."Rect"]
    /// [System.IEquatable<UnityEngine.Rect>]=>[System.IFormattable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Rect>, Ptr_Rect>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("UnityEngine.CoreModule", "UnityEngine", "Rect", "UnityEngine.Rect")]
    public partial class Rect
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Ref_Rect
        {
            /// <summary>
            /// 0x0 System.Single m_XMin
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            // [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            [MarshalAs(UnmanagedType.R4)]
            public System.Single m_XMin;
            /// <summary>
            /// 0x4 System.Single m_YMin
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            //   [System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
            [MarshalAs(UnmanagedType.R4)]
            public System.Single m_YMin;
            /// <summary>
            /// 0x8 System.Single m_Width
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            //    [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            [MarshalAs(UnmanagedType.R4)]
            public System.Single m_Width;
            /// <summary>
            /// 0xC System.Single m_Heightk
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            //     [System.Runtime.InteropServices.FieldOffsetAttribute(0xC)]
            [MarshalAs(UnmanagedType.R4)]
            public System.Single m_Height;
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Rect(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_Rect(System.IntPtr ptr) => new Ptr_Rect(ptr);
            public static implicit operator System.IntPtr(Ptr_Rect ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_Rect ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// struct ["UnityEngine.CoreModule"."UnityEngine"."Rect"]
        /// </summary>
        partial struct Ptr_Rect
        {
            /// <summary>
            /// 0x10 System.Single m_XMin
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_XMin", "System.Single")]
            public partial System.Single M_X_MIN { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Single m_YMin
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_YMin", "System.Single")]
            public partial System.Single M_Y_MIN { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Single m_Width
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Width", "System.Single")]
            public partial System.Single M_WIDTH { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Single m_Height
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Height", "System.Single")]
            public partial System.Single M_HEIGHT { get; set; } 
*/
        }

        /// <summary>
        /// struct ["UnityEngine.CoreModule"."UnityEngine"."Rect"]
        /// </summary>
        partial struct Ptr_Rect
        {
            /// <summary>
            /// static  UnityEngine.Rect get_zero()
            /// </summary>
            /// <returns>struct UnityEngine.Rect</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_zero", "UnityEngine.Rect", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Rect GET_ZERO(); 
*/
            /// <summary>
            /// static  UnityEngine.Rect MinMaxRect(System.Single xmin, System.Single ymin, System.Single xmax, System.Single ymax)
            /// </summary>
            /// <param name = "xmin">struct System.Single</param>
            /// <param name = "ymin">struct System.Single</param>
            /// <param name = "xmax">struct System.Single</param>
            /// <param name = "ymax">struct System.Single</param>
            /// <returns>struct UnityEngine.Rect</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MinMaxRect", "UnityEngine.Rect", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public static partial UnityEngine.Rect MIN_MAX_RECT(System.Single xmin, System.Single ymin, System.Single xmax, System.Single ymax); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 NormalizedToPoint(UnityEngine.Rect rectangle, UnityEngine.Vector2 normalizedRectCoordinates)
            /// </summary>
            /// <param name = "rectangle">struct UnityEngine.Rect</param>
            /// <param name = "normalizedRectCoordinates">struct UnityEngine.Vector2</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("NormalizedToPoint", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial UnityEngine.Vector2 NORMALIZED_TO_POINT(UnityEngine.Rect rectangle, UnityEngine.Vector2 normalizedRectCoordinates); 
*/
            /// <summary>
            /// static  System.Boolean op_Equality(UnityEngine.Rect lhs, UnityEngine.Rect rhs)
            /// </summary>
            /// <param name = "lhs">struct UnityEngine.Rect</param>
            /// <param name = "rhs">struct UnityEngine.Rect</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Equality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 1)]
            public static partial System.Boolean OP_EQUALITY(UnityEngine.Rect lhs, UnityEngine.Rect rhs); 
*/
            /// <summary>
            /// static  System.Boolean op_Inequality(UnityEngine.Rect lhs, UnityEngine.Rect rhs)
            /// </summary>
            /// <param name = "lhs">struct UnityEngine.Rect</param>
            /// <param name = "rhs">struct UnityEngine.Rect</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Inequality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 1)]
            public static partial System.Boolean OP_INEQUALITY(UnityEngine.Rect lhs, UnityEngine.Rect rhs); 
*/
            /// <summary>
            /// static  UnityEngine.Rect OrderMinMax(UnityEngine.Rect rect)
            /// </summary>
            /// <param name = "rect">struct UnityEngine.Rect</param>
            /// <returns>struct UnityEngine.Rect</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OrderMinMax", "UnityEngine.Rect", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
            public static partial UnityEngine.Rect ORDER_MIN_MAX(UnityEngine.Rect rect); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 PointToNormalized(UnityEngine.Rect rectangle, UnityEngine.Vector2 point)
            /// </summary>
            /// <param name = "rectangle">struct UnityEngine.Rect</param>
            /// <param name = "point">struct UnityEngine.Vector2</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PointToNormalized", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial UnityEngine.Vector2 POINT_TO_NORMALIZED(UnityEngine.Rect rectangle, UnityEngine.Vector2 point); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Single x, System.Single y, System.Single width, System.Single height)
            /// </summary>
            /// <param name = "x">struct System.Single</param>
            /// <param name = "y">struct System.Single</param>
            /// <param name = "width">struct System.Single</param>
            /// <param name = "height">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public partial void CTOR(System.Single x, System.Single y, System.Single width, System.Single height); 
*/
            /// <summary>
            ///   System.Void .ctor(UnityEngine.Vector2 position, UnityEngine.Vector2 size)
            /// </summary>
            /// <param name = "position">struct UnityEngine.Vector2</param>
            /// <param name = "size">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public partial void CTOR(UnityEngine.Vector2 position, UnityEngine.Vector2 size); 
*/
            /// <summary>
            ///   System.Void .ctor(UnityEngine.Rect source)
            /// </summary>
            /// <param name = "source">struct UnityEngine.Rect</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
            public partial void CTOR(UnityEngine.Rect source); 
*/
            /// <summary>
            ///   System.Boolean Contains(UnityEngine.Vector2 point)
            /// </summary>
            /// <param name = "point">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            public partial System.Boolean CONTAINS(UnityEngine.Vector2 point); 
*/
            /// <summary>
            ///   System.Boolean Contains(UnityEngine.Vector3 point)
            /// </summary>
            /// <param name = "point">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            public partial System.Boolean CONTAINS(UnityEngine.Vector3 point); 
*/
            /// <summary>
            ///   System.Boolean Contains(UnityEngine.Vector3 point, System.Boolean allowInverse)
            /// </summary>
            /// <param name = "point">struct UnityEngine.Vector3</param>
            /// <param name = "allowInverse">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Boolean CONTAINS(UnityEngine.Vector3 point, System.Boolean allowInverse); 
*/
            /// <summary>
            ///   System.Boolean Equals(System.Object other)
            /// </summary>
            /// <param name = "other">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Equals", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial System.Boolean EQUALS(nint other); 
*/
            /// <summary>
            ///   System.Boolean Equals(UnityEngine.Rect other)
            /// </summary>
            /// <param name = "other">struct UnityEngine.Rect</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Equals", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
            public partial System.Boolean EQUALS(UnityEngine.Rect other); 
*/
            /// <summary>
            ///   System.Single get_bottom()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_bottom", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_BOTTOM(); 
*/
            /// <summary>
            ///   UnityEngine.Vector2 get_center()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_center", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector2 GET_CENTER(); 
*/
            /// <summary>
            ///   System.Single get_height()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_height", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_HEIGHT(); 
*/
            /// <summary>
            ///   System.Single get_left()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_left", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_LEFT(); 
*/
            /// <summary>
            ///   UnityEngine.Vector2 get_max()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_max", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector2 GET_MAX(); 
*/
            /// <summary>
            ///   UnityEngine.Vector2 get_min()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_min", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector2 GET_MIN(); 
*/
            /// <summary>
            ///   UnityEngine.Vector2 get_position()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_position", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector2 GET_POSITION(); 
*/
            /// <summary>
            ///   System.Single get_right()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_right", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_RIGHT(); 
*/
            /// <summary>
            ///   UnityEngine.Vector2 get_size()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_size", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector2 GET_SIZE(); 
*/
            /// <summary>
            ///   System.Single get_top()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_top", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_TOP(); 
*/
            /// <summary>
            ///   System.Single get_width()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_width", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_WIDTH(); 
*/
            /// <summary>
            ///   System.Single get_x()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_x", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_X(); 
*/
            /// <summary>
            ///   System.Single get_xMax()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_xMax", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_X_MAX(); 
*/
            /// <summary>
            ///   System.Single get_xMin()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_xMin", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_X_MIN(); 
*/
            /// <summary>
            ///   System.Single get_y()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_y", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_Y(); 
*/
            /// <summary>
            ///   System.Single get_yMax()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_yMax", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_Y_MAX(); 
*/
            /// <summary>
            ///   System.Single get_yMin()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_yMin", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_Y_MIN(); 
*/
            /// <summary>
            ///   System.Int32 GetHashCode()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHashCode", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HASH_CODE(); 
*/
            /// <summary>
            ///   System.Boolean Overlaps(UnityEngine.Rect other)
            /// </summary>
            /// <param name = "other">struct UnityEngine.Rect</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Overlaps", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
            public partial System.Boolean OVERLAPS(UnityEngine.Rect other); 
*/
            /// <summary>
            ///   System.Boolean Overlaps(UnityEngine.Rect other, System.Boolean allowInverse)
            /// </summary>
            /// <param name = "other">struct UnityEngine.Rect</param>
            /// <param name = "allowInverse">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Overlaps", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Boolean OVERLAPS(UnityEngine.Rect other, System.Boolean allowInverse); 
*/
            /// <summary>
            ///   System.Void Set(System.Single x, System.Single y, System.Single width, System.Single height)
            /// </summary>
            /// <param name = "x">struct System.Single</param>
            /// <param name = "y">struct System.Single</param>
            /// <param name = "width">struct System.Single</param>
            /// <param name = "height">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Set", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public partial void SET(System.Single x, System.Single y, System.Single width, System.Single height); 
*/
            /// <summary>
            ///   System.Void set_center(UnityEngine.Vector2 value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_center", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            public partial void SET_CENTER(UnityEngine.Vector2 value); 
*/
            /// <summary>
            ///   System.Void set_height(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_height", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_HEIGHT(System.Single value); 
*/
            /// <summary>
            ///   System.Void set_max(UnityEngine.Vector2 value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_max", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            public partial void SET_MAX(UnityEngine.Vector2 value); 
*/
            /// <summary>
            ///   System.Void set_min(UnityEngine.Vector2 value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_min", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            public partial void SET_MIN(UnityEngine.Vector2 value); 
*/
            /// <summary>
            ///   System.Void set_position(UnityEngine.Vector2 value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_position", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            public partial void SET_POSITION(UnityEngine.Vector2 value); 
*/
            /// <summary>
            ///   System.Void set_size(UnityEngine.Vector2 value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_size", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            public partial void SET_SIZE(UnityEngine.Vector2 value); 
*/
            /// <summary>
            ///   System.Void set_width(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_width", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_WIDTH(System.Single value); 
*/
            /// <summary>
            ///   System.Void set_x(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_x", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_X(System.Single value); 
*/
            /// <summary>
            ///   System.Void set_xMax(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_xMax", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_X_MAX(System.Single value); 
*/
            /// <summary>
            ///   System.Void set_xMin(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_xMin", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_X_MIN(System.Single value); 
*/
            /// <summary>
            ///   System.Void set_y(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_y", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_Y(System.Single value); 
*/
            /// <summary>
            ///   System.Void set_yMax(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_yMax", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_Y_MAX(System.Single value); 
*/
            /// <summary>
            ///   System.Void set_yMin(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_yMin", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_Y_MIN(System.Single value); 
*/
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint TO_STRING(); 
*/
            /// <summary>
            ///   System.String ToString(System.String format)
            /// </summary>
            /// <param name = "format">class System.String</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint TO_STRING(nint format); 
*/
            /// <summary>
            ///   System.String ToString(System.String format, System.IFormatProvider formatProvider)
            /// </summary>
            /// <param name = "format">class System.String</param>
            /// <param name = "formatProvider">interface System.IFormatProvider</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IFormatProvider", 1)]
            public partial nint TO_STRING(nint format, nint formatProvider); 
*/
        }
    }
}
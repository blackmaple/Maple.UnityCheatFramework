namespace Maple.MonoGameAssistant.MetadataUnity
{
    /// <summary>
    /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
    /// [System.IEquatable<UnityEngine.Vector3>]=>[System.IFormattable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Vector3>, Ptr_Vector3>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("UnityEngine.CoreModule.dll", "UnityEngine", "Vector3", "UnityEngine.Vector3")]
    public partial class Vector3
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct Ref_Vector3
        {
            /// <summary>
            /// 0x0 System.Single x
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public System.Single x;
            /// <summary>
            /// 0x4 System.Single y
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
            public System.Single y;
            /// <summary>
            /// 0x8 System.Single z
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            public System.Single z;
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Vector3(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_Vector3(System.IntPtr ptr) => new Ptr_Vector3(ptr);
            public static implicit operator System.IntPtr(Ptr_Vector3 ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_Vector3 ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
        /// </summary>
        partial struct Ptr_Vector3
        {
            /// <summary>
            /// 0x0 System.Single kEpsilon
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            public const System.Single K_EPSILON = 1E-05; 
*/
            /// <summary>
            /// 0x0 System.Single kEpsilonNormalSqrt
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            public const System.Single K_EPSILON_NORMAL_SQRT = 1E-15; 
*/
            /// <summary>
            /// 0x0 UnityEngine.Vector3 zeroVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("zeroVector", "UnityEngine.Vector3")]
            public static partial UnityEngine.Vector3 ZERO_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0xC UnityEngine.Vector3 oneVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("oneVector", "UnityEngine.Vector3")]
            public static partial UnityEngine.Vector3 ONE_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x18 UnityEngine.Vector3 upVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("upVector", "UnityEngine.Vector3")]
            public static partial UnityEngine.Vector3 UP_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x24 UnityEngine.Vector3 downVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("downVector", "UnityEngine.Vector3")]
            public static partial UnityEngine.Vector3 DOWN_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x30 UnityEngine.Vector3 leftVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("leftVector", "UnityEngine.Vector3")]
            public static partial UnityEngine.Vector3 LEFT_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x3C UnityEngine.Vector3 rightVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("rightVector", "UnityEngine.Vector3")]
            public static partial UnityEngine.Vector3 RIGHT_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x48 UnityEngine.Vector3 forwardVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forwardVector", "UnityEngine.Vector3")]
            public static partial UnityEngine.Vector3 FORWARD_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x54 UnityEngine.Vector3 backVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("backVector", "UnityEngine.Vector3")]
            public static partial UnityEngine.Vector3 BACK_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x60 UnityEngine.Vector3 positiveInfinityVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("positiveInfinityVector", "UnityEngine.Vector3")]
            public static partial UnityEngine.Vector3 POSITIVE_INFINITY_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x6C UnityEngine.Vector3 negativeInfinityVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("negativeInfinityVector", "UnityEngine.Vector3")]
            public static partial UnityEngine.Vector3 NEGATIVE_INFINITY_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x10 System.Single x
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("x", "System.Single")]
            public partial System.Single X { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Single y
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("y", "System.Single")]
            public partial System.Single Y { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Single z
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("z", "System.Single")]
            public partial System.Single Z { get; set; } 
*/
        }

        /// <summary>
        /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
        /// </summary>
        partial struct Ptr_Vector3
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
            /// static  System.Single Angle(UnityEngine.Vector3 from, UnityEngine.Vector3 to)
            /// </summary>
            /// <param name = "from">struct UnityEngine.Vector3</param>
            /// <param name = "to">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Angle", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial System.Single ANGLE(UnityEngine.Vector3 from, UnityEngine.Vector3 to); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 ClampMagnitude(UnityEngine.Vector3 vector, System.Single maxLength)
            /// </summary>
            /// <param name = "vector">struct UnityEngine.Vector3</param>
            /// <param name = "maxLength">struct System.Single</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClampMagnitude", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial UnityEngine.Vector3 CLAMP_MAGNITUDE(UnityEngine.Vector3 vector, System.Single maxLength); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 Cross(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs)
            /// </summary>
            /// <param name = "lhs">struct UnityEngine.Vector3</param>
            /// <param name = "rhs">struct UnityEngine.Vector3</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cross", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial UnityEngine.Vector3 CROSS(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs); 
*/
            /// <summary>
            /// static  System.Single Distance(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector3</param>
            /// <param name = "b">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Distance", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial System.Single DISTANCE(UnityEngine.Vector3 a, UnityEngine.Vector3 b); 
*/
            /// <summary>
            /// static  System.Single Dot(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs)
            /// </summary>
            /// <param name = "lhs">struct UnityEngine.Vector3</param>
            /// <param name = "rhs">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Dot", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial System.Single DOT(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 get_back()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_back", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Vector3 GET_BACK(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 get_down()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_down", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Vector3 GET_DOWN(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 get_forward()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_forward", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Vector3 GET_FORWARD(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 get_left()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_left", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Vector3 GET_LEFT(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 get_one()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_one", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Vector3 GET_ONE(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 get_right()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_right", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Vector3 GET_RIGHT(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 get_up()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_up", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Vector3 GET_UP(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 get_zero()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_zero", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Vector3 GET_ZERO(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 Lerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector3</param>
            /// <param name = "b">struct UnityEngine.Vector3</param>
            /// <param name = "t">struct System.Single</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Lerp", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public static partial UnityEngine.Vector3 LERP(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector3</param>
            /// <param name = "b">struct UnityEngine.Vector3</param>
            /// <param name = "t">struct System.Single</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LerpUnclamped", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public static partial UnityEngine.Vector3 LERP_UNCLAMPED(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t); 
*/
            /// <summary>
            /// static  System.Single Magnitude(UnityEngine.Vector3 vector)
            /// </summary>
            /// <param name = "vector">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Magnitude", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            public static partial System.Single MAGNITUDE(UnityEngine.Vector3 vector); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 Max(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs)
            /// </summary>
            /// <param name = "lhs">struct UnityEngine.Vector3</param>
            /// <param name = "rhs">struct UnityEngine.Vector3</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Max", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial UnityEngine.Vector3 MAX(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 Min(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs)
            /// </summary>
            /// <param name = "lhs">struct UnityEngine.Vector3</param>
            /// <param name = "rhs">struct UnityEngine.Vector3</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Min", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial UnityEngine.Vector3 MIN(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 MoveTowards(UnityEngine.Vector3 current, UnityEngine.Vector3 target, System.Single maxDistanceDelta)
            /// </summary>
            /// <param name = "current">struct UnityEngine.Vector3</param>
            /// <param name = "target">struct UnityEngine.Vector3</param>
            /// <param name = "maxDistanceDelta">struct System.Single</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MoveTowards", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public static partial UnityEngine.Vector3 MOVE_TOWARDS(UnityEngine.Vector3 current, UnityEngine.Vector3 target, System.Single maxDistanceDelta); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 Normalize(UnityEngine.Vector3 value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Vector3</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Normalize", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            public static partial UnityEngine.Vector3 NORMALIZE(UnityEngine.Vector3 value); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 op_Addition(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector3</param>
            /// <param name = "b">struct UnityEngine.Vector3</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Addition", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial UnityEngine.Vector3 OP_ADDITION(UnityEngine.Vector3 a, UnityEngine.Vector3 b); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 op_Division(UnityEngine.Vector3 a, System.Single d)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector3</param>
            /// <param name = "d">struct System.Single</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Division", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial UnityEngine.Vector3 OP_DIVISION(UnityEngine.Vector3 a, System.Single d); 
*/
            /// <summary>
            /// static  System.Boolean op_Equality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs)
            /// </summary>
            /// <param name = "lhs">struct UnityEngine.Vector3</param>
            /// <param name = "rhs">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Equality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial System.Boolean OP_EQUALITY(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs); 
*/
            /// <summary>
            /// static  System.Boolean op_Inequality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs)
            /// </summary>
            /// <param name = "lhs">struct UnityEngine.Vector3</param>
            /// <param name = "rhs">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Inequality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial System.Boolean OP_INEQUALITY(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 op_Multiply(UnityEngine.Vector3 a, System.Single d)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector3</param>
            /// <param name = "d">struct System.Single</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Multiply", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial UnityEngine.Vector3 OP_MULTIPLY(UnityEngine.Vector3 a, System.Single d); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 op_Multiply(System.Single d, UnityEngine.Vector3 a)
            /// </summary>
            /// <param name = "d">struct System.Single</param>
            /// <param name = "a">struct UnityEngine.Vector3</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Multiply", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial UnityEngine.Vector3 OP_MULTIPLY(System.Single d, UnityEngine.Vector3 a); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 op_Subtraction(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector3</param>
            /// <param name = "b">struct UnityEngine.Vector3</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Subtraction", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial UnityEngine.Vector3 OP_SUBTRACTION(UnityEngine.Vector3 a, UnityEngine.Vector3 b); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 op_UnaryNegation(UnityEngine.Vector3 a)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector3</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_UnaryNegation", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            public static partial UnityEngine.Vector3 OP_UNARY_NEGATION(UnityEngine.Vector3 a); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 Project(UnityEngine.Vector3 vector, UnityEngine.Vector3 onNormal)
            /// </summary>
            /// <param name = "vector">struct UnityEngine.Vector3</param>
            /// <param name = "onNormal">struct UnityEngine.Vector3</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Project", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial UnityEngine.Vector3 PROJECT(UnityEngine.Vector3 vector, UnityEngine.Vector3 onNormal); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal)
            /// </summary>
            /// <param name = "vector">struct UnityEngine.Vector3</param>
            /// <param name = "planeNormal">struct UnityEngine.Vector3</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ProjectOnPlane", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial UnityEngine.Vector3 PROJECT_ON_PLANE(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 Reflect(UnityEngine.Vector3 inDirection, UnityEngine.Vector3 inNormal)
            /// </summary>
            /// <param name = "inDirection">struct UnityEngine.Vector3</param>
            /// <param name = "inNormal">struct UnityEngine.Vector3</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reflect", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial UnityEngine.Vector3 REFLECT(UnityEngine.Vector3 inDirection, UnityEngine.Vector3 inNormal); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 Scale(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector3</param>
            /// <param name = "b">struct UnityEngine.Vector3</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Scale", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public static partial UnityEngine.Vector3 SCALE(UnityEngine.Vector3 a, UnityEngine.Vector3 b); 
*/
            /// <summary>
            /// static  System.Single SignedAngle(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 axis)
            /// </summary>
            /// <param name = "from">struct UnityEngine.Vector3</param>
            /// <param name = "to">struct UnityEngine.Vector3</param>
            /// <param name = "axis">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SignedAngle", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            public static partial System.Single SIGNED_ANGLE(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 axis); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 Slerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector3</param>
            /// <param name = "b">struct UnityEngine.Vector3</param>
            /// <param name = "t">struct System.Single</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Slerp", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public static partial UnityEngine.Vector3 SLERP(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t); 
*/
            /// <summary>
            /// static  System.Void Slerp_Injected(UnityEngine.Vector3& a, UnityEngine.Vector3& b, System.Single t, UnityEngine.Vector3& ret)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector3&</param>
            /// <param name = "b">struct UnityEngine.Vector3&</param>
            /// <param name = "t">struct System.Single</param>
            /// <param name = "ret">struct UnityEngine.Vector3&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Slerp_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 3)]
            public static partial void SLERP_INJECTED(UnityEngine.Vector3 &a, UnityEngine.Vector3 &b, System.Single t, UnityEngine.Vector3 &ret); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3 current, UnityEngine.Vector3 target, UnityEngine.Vector3& currentVelocity, System.Single smoothTime, System.Single maxSpeed, System.Single deltaTime)
            /// </summary>
            /// <param name = "current">struct UnityEngine.Vector3</param>
            /// <param name = "target">struct UnityEngine.Vector3</param>
            /// <param name = "currentVelocity">struct UnityEngine.Vector3&</param>
            /// <param name = "smoothTime">struct System.Single</param>
            /// <param name = "maxSpeed">struct System.Single</param>
            /// <param name = "deltaTime">struct System.Single</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SmoothDamp", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 5)]
            public static partial UnityEngine.Vector3 SMOOTH_DAMP(UnityEngine.Vector3 current, UnityEngine.Vector3 target, UnityEngine.Vector3 &currentVelocity, System.Single smoothTime, System.Single maxSpeed, System.Single deltaTime); 
*/
            /// <summary>
            /// static  System.Single SqrMagnitude(UnityEngine.Vector3 vector)
            /// </summary>
            /// <param name = "vector">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SqrMagnitude", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            public static partial System.Single SQR_MAGNITUDE(UnityEngine.Vector3 vector); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Single x, System.Single y, System.Single z)
            /// </summary>
            /// <param name = "x">struct System.Single</param>
            /// <param name = "y">struct System.Single</param>
            /// <param name = "z">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void CTOR(System.Single x, System.Single y, System.Single z); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Single x, System.Single y)
            /// </summary>
            /// <param name = "x">struct System.Single</param>
            /// <param name = "y">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void CTOR(System.Single x, System.Single y); 
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
            ///   System.Boolean Equals(UnityEngine.Vector3 other)
            /// </summary>
            /// <param name = "other">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Equals", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            public partial System.Boolean EQUALS(UnityEngine.Vector3 other); 
*/
            /// <summary>
            ///   System.Single get_Item(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Item", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Single GET_ITEM(System.Int32 index); 
*/
            /// <summary>
            ///   System.Single get_magnitude()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_magnitude", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_MAGNITUDE(); 
*/
            /// <summary>
            ///   UnityEngine.Vector3 get_normalized()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_normalized", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector3 GET_NORMALIZED(); 
*/
            /// <summary>
            ///   System.Single get_sqrMagnitude()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_sqrMagnitude", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_SQR_MAGNITUDE(); 
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
            ///   System.Void Normalize()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Normalize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void NORMALIZE(); 
*/
            /// <summary>
            ///   System.Void Scale(UnityEngine.Vector3 scale)
            /// </summary>
            /// <param name = "scale">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Scale", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            public partial void SCALE(UnityEngine.Vector3 scale); 
*/
            /// <summary>
            ///   System.Void Set(System.Single newX, System.Single newY, System.Single newZ)
            /// </summary>
            /// <param name = "newX">struct System.Single</param>
            /// <param name = "newY">struct System.Single</param>
            /// <param name = "newZ">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Set", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void SET(System.Single newX, System.Single newY, System.Single newZ); 
*/
            /// <summary>
            ///   System.Void set_Item(System.Int32 index, System.Single value)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Item", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void SET_ITEM(System.Int32 index, System.Single value); 
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
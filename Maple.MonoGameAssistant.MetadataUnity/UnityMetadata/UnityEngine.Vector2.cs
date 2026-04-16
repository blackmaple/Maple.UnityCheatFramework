namespace Maple.MonoGameAssistant.MetadataUnity
{
    /// <summary>
    /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector2"]
    /// [System.IEquatable<UnityEngine.Vector2>]=>[System.IFormattable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Vector2>, Ptr_Vector2>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("UnityEngine.CoreModule.dll", "UnityEngine", "Vector2", "UnityEngine.Vector2")]
    public partial class Vector2
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct Ref_Vector2
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
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Vector2(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_Vector2(System.IntPtr ptr) => new Ptr_Vector2(ptr);
            public static implicit operator System.IntPtr(Ptr_Vector2 ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_Vector2 ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector2"]
        /// </summary>
        partial struct Ptr_Vector2
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
            /// 0x0 UnityEngine.Vector2 zeroVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector2"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("zeroVector", "UnityEngine.Vector2")]
            public static partial UnityEngine.Vector2 ZERO_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x8 UnityEngine.Vector2 oneVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector2"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("oneVector", "UnityEngine.Vector2")]
            public static partial UnityEngine.Vector2 ONE_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x10 UnityEngine.Vector2 upVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector2"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("upVector", "UnityEngine.Vector2")]
            public static partial UnityEngine.Vector2 UP_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x18 UnityEngine.Vector2 downVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector2"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("downVector", "UnityEngine.Vector2")]
            public static partial UnityEngine.Vector2 DOWN_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x20 UnityEngine.Vector2 leftVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector2"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("leftVector", "UnityEngine.Vector2")]
            public static partial UnityEngine.Vector2 LEFT_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x28 UnityEngine.Vector2 rightVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector2"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("rightVector", "UnityEngine.Vector2")]
            public static partial UnityEngine.Vector2 RIGHT_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x30 UnityEngine.Vector2 positiveInfinityVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector2"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("positiveInfinityVector", "UnityEngine.Vector2")]
            public static partial UnityEngine.Vector2 POSITIVE_INFINITY_VECTOR { get; set; } 
*/

            /// <summary>
            /// 0x38 UnityEngine.Vector2 negativeInfinityVector
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector2"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("negativeInfinityVector", "UnityEngine.Vector2")]
            public static partial UnityEngine.Vector2 NEGATIVE_INFINITY_VECTOR { get; set; } 
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
        }

        /// <summary>
        /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector2"]
        /// </summary>
        partial struct Ptr_Vector2
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
            /// static  System.Single Angle(UnityEngine.Vector2 from, UnityEngine.Vector2 to)
            /// </summary>
            /// <param name = "from">struct UnityEngine.Vector2</param>
            /// <param name = "to">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Angle", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial System.Single ANGLE(UnityEngine.Vector2 from, UnityEngine.Vector2 to); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 ClampMagnitude(UnityEngine.Vector2 vector, System.Single maxLength)
            /// </summary>
            /// <param name = "vector">struct UnityEngine.Vector2</param>
            /// <param name = "maxLength">struct System.Single</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClampMagnitude", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial UnityEngine.Vector2 CLAMP_MAGNITUDE(UnityEngine.Vector2 vector, System.Single maxLength); 
*/
            /// <summary>
            /// static  System.Single Distance(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector2</param>
            /// <param name = "b">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Distance", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial System.Single DISTANCE(UnityEngine.Vector2 a, UnityEngine.Vector2 b); 
*/
            /// <summary>
            /// static  System.Single Dot(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs)
            /// </summary>
            /// <param name = "lhs">struct UnityEngine.Vector2</param>
            /// <param name = "rhs">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Dot", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial System.Single DOT(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 get_down()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_down", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Vector2 GET_DOWN(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 get_left()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_left", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Vector2 GET_LEFT(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 get_one()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_one", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Vector2 GET_ONE(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 get_right()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_right", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Vector2 GET_RIGHT(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 get_up()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_up", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Vector2 GET_UP(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 get_zero()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_zero", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial UnityEngine.Vector2 GET_ZERO(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 Lerp(UnityEngine.Vector2 a, UnityEngine.Vector2 b, System.Single t)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector2</param>
            /// <param name = "b">struct UnityEngine.Vector2</param>
            /// <param name = "t">struct System.Single</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Lerp", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public static partial UnityEngine.Vector2 LERP(UnityEngine.Vector2 a, UnityEngine.Vector2 b, System.Single t); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 Max(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs)
            /// </summary>
            /// <param name = "lhs">struct UnityEngine.Vector2</param>
            /// <param name = "rhs">struct UnityEngine.Vector2</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Max", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial UnityEngine.Vector2 MAX(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 Min(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs)
            /// </summary>
            /// <param name = "lhs">struct UnityEngine.Vector2</param>
            /// <param name = "rhs">struct UnityEngine.Vector2</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Min", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial UnityEngine.Vector2 MIN(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 MoveTowards(UnityEngine.Vector2 current, UnityEngine.Vector2 target, System.Single maxDistanceDelta)
            /// </summary>
            /// <param name = "current">struct UnityEngine.Vector2</param>
            /// <param name = "target">struct UnityEngine.Vector2</param>
            /// <param name = "maxDistanceDelta">struct System.Single</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MoveTowards", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public static partial UnityEngine.Vector2 MOVE_TOWARDS(UnityEngine.Vector2 current, UnityEngine.Vector2 target, System.Single maxDistanceDelta); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 op_Addition(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector2</param>
            /// <param name = "b">struct UnityEngine.Vector2</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Addition", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial UnityEngine.Vector2 OP_ADDITION(UnityEngine.Vector2 a, UnityEngine.Vector2 b); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector2</param>
            /// <param name = "b">struct UnityEngine.Vector2</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Division", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial UnityEngine.Vector2 OP_DIVISION(UnityEngine.Vector2 a, UnityEngine.Vector2 b); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, System.Single d)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector2</param>
            /// <param name = "d">struct System.Single</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Division", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial UnityEngine.Vector2 OP_DIVISION(UnityEngine.Vector2 a, System.Single d); 
*/
            /// <summary>
            /// static  System.Boolean op_Equality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs)
            /// </summary>
            /// <param name = "lhs">struct UnityEngine.Vector2</param>
            /// <param name = "rhs">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Equality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial System.Boolean OP_EQUALITY(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 op_Implicit(UnityEngine.Vector3 v)
            /// </summary>
            /// <param name = "v">struct UnityEngine.Vector3</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Implicit", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            public static partial UnityEngine.Vector2 OP_IMPLICIT(UnityEngine.Vector3 v); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 op_Implicit(UnityEngine.Vector2 v)
            /// </summary>
            /// <param name = "v">struct UnityEngine.Vector2</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Implicit", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            public static partial UnityEngine.Vector3 OP_IMPLICIT(UnityEngine.Vector2 v); 
*/
            /// <summary>
            /// static  System.Boolean op_Inequality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs)
            /// </summary>
            /// <param name = "lhs">struct UnityEngine.Vector2</param>
            /// <param name = "rhs">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Inequality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial System.Boolean OP_INEQUALITY(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector2</param>
            /// <param name = "b">struct UnityEngine.Vector2</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Multiply", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial UnityEngine.Vector2 OP_MULTIPLY(UnityEngine.Vector2 a, UnityEngine.Vector2 b); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, System.Single d)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector2</param>
            /// <param name = "d">struct System.Single</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Multiply", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial UnityEngine.Vector2 OP_MULTIPLY(UnityEngine.Vector2 a, System.Single d); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 op_Multiply(System.Single d, UnityEngine.Vector2 a)
            /// </summary>
            /// <param name = "d">struct System.Single</param>
            /// <param name = "a">struct UnityEngine.Vector2</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Multiply", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial UnityEngine.Vector2 OP_MULTIPLY(System.Single d, UnityEngine.Vector2 a); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 op_Subtraction(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector2</param>
            /// <param name = "b">struct UnityEngine.Vector2</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Subtraction", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial UnityEngine.Vector2 OP_SUBTRACTION(UnityEngine.Vector2 a, UnityEngine.Vector2 b); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 op_UnaryNegation(UnityEngine.Vector2 a)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector2</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_UnaryNegation", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            public static partial UnityEngine.Vector2 OP_UNARY_NEGATION(UnityEngine.Vector2 a); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 Scale(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector2</param>
            /// <param name = "b">struct UnityEngine.Vector2</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Scale", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial UnityEngine.Vector2 SCALE(UnityEngine.Vector2 a, UnityEngine.Vector2 b); 
*/
            /// <summary>
            /// static  System.Single SignedAngle(UnityEngine.Vector2 from, UnityEngine.Vector2 to)
            /// </summary>
            /// <param name = "from">struct UnityEngine.Vector2</param>
            /// <param name = "to">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SignedAngle", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
            public static partial System.Single SIGNED_ANGLE(UnityEngine.Vector2 from, UnityEngine.Vector2 to); 
*/
            /// <summary>
            /// static  System.Single SqrMagnitude(UnityEngine.Vector2 a)
            /// </summary>
            /// <param name = "a">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SqrMagnitude", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            public static partial System.Single SQR_MAGNITUDE(UnityEngine.Vector2 a); 
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
            ///   System.Boolean Equals(UnityEngine.Vector2 other)
            /// </summary>
            /// <param name = "other">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Equals", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            public partial System.Boolean EQUALS(UnityEngine.Vector2 other); 
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
            ///   UnityEngine.Vector2 get_normalized()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_normalized", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector2 GET_NORMALIZED(); 
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
            ///   System.Void Scale(UnityEngine.Vector2 scale)
            /// </summary>
            /// <param name = "scale">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Scale", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            public partial void SCALE(UnityEngine.Vector2 scale); 
*/
            /// <summary>
            ///   System.Void Set(System.Single newX, System.Single newY)
            /// </summary>
            /// <param name = "newX">struct System.Single</param>
            /// <param name = "newY">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Set", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void SET(System.Single newX, System.Single newY); 
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
using Maple.MonoGameAssistant.Common;

namespace Maple.MonoGameAssistant.MetadataUnity
{
    /// <summary>
    /// class ["UnityEngine.CoreModule"."UnityEngine"."Sprite"]
    /// [UnityEngine.Object]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Sprite>, Ptr_Sprite>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("UnityEngine.CoreModule", "UnityEngine", "Sprite", "UnityEngine.Sprite")]
    public partial class Sprite
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Sprite(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_Sprite(System.IntPtr ptr) => new Ptr_Sprite(ptr);
            public static implicit operator System.IntPtr(Ptr_Sprite ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_Sprite ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule"."UnityEngine"."Sprite"]
        /// </summary>
        partial struct Ptr_Sprite
        {
            /// <summary>
            /// 0x0 System.String objectIsNullMessage
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint OBJECT_IS_NULL_MESSAGE = The Object you want to instantiate is null.; 
*/
            /// <summary>
            /// 0x0 System.String cloneDestroyedMessage
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint CLONE_DESTROYED_MESSAGE = Instantiate failed because the clone was destroyed during creati; 
*/
            /// <summary>
            /// 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OffsetOfInstanceIDInCPlusPlusObject", "System.Int32")]
            public static partial System.Int32 OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT { get; set; } 
*/

            /// <summary>
            /// 0x10 System.IntPtr m_CachedPtr
            /// struct ["mscorlib"."System"."IntPtr"]
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_CachedPtr", "System.IntPtr")]
            public partial System.IntPtr M_CACHED_PTR { get; set; } 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule"."UnityEngine"."Sprite"]
        /// </summary>
        partial struct Ptr_Sprite
        {
            /// <summary>
            /// static  UnityEngine.Sprite Create(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsToUnits, UnityEngine.Texture2D texture)
            /// </summary>
            /// <param name = "rect">struct UnityEngine.Rect</param>
            /// <param name = "pivot">struct UnityEngine.Vector2</param>
            /// <param name = "pixelsToUnits">struct System.Single</param>
            /// <param name = "texture">class UnityEngine.Texture2D</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Create", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 3)]
           public static partial nint CREATE(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsToUnits, nint texture); 
*/
            /// <summary>
            /// static  UnityEngine.Sprite Create(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsToUnits)
            /// </summary>
            /// <param name = "rect">struct UnityEngine.Rect</param>
            /// <param name = "pivot">struct UnityEngine.Vector2</param>
            /// <param name = "pixelsToUnits">struct System.Single</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Create", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
           public static partial nint CREATE(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsToUnits); 
*/
            /// <summary>
            /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, System.Boolean generateFallbackPhysicsShape)
            /// </summary>
            /// <param name = "texture">class UnityEngine.Texture2D</param>
            /// <param name = "rect">struct UnityEngine.Rect</param>
            /// <param name = "pivot">struct UnityEngine.Vector2</param>
            /// <param name = "pixelsPerUnit">struct System.Single</param>
            /// <param name = "extrude">struct System.UInt32</param>
            /// <param name = "meshType">enum UnityEngine.SpriteMeshType</param>
            /// <param name = "border">struct UnityEngine.Vector4</param>
            /// <param name = "generateFallbackPhysicsShape">struct System.Boolean</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Create", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SpriteMeshType", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector4", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           public static partial nint CREATE(nint texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, System.Boolean generateFallbackPhysicsShape); 
*/
            /// <summary>
            /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border)
            /// </summary>
            /// <param name = "texture">class UnityEngine.Texture2D</param>
            /// <param name = "rect">struct UnityEngine.Rect</param>
            /// <param name = "pivot">struct UnityEngine.Vector2</param>
            /// <param name = "pixelsPerUnit">struct System.Single</param>
            /// <param name = "extrude">struct System.UInt32</param>
            /// <param name = "meshType">enum UnityEngine.SpriteMeshType</param>
            /// <param name = "border">struct UnityEngine.Vector4</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Create", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SpriteMeshType", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector4", 6)]
           public static partial nint CREATE(nint texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border); 
*/
            /// <summary>
            /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType)
            /// </summary>
            /// <param name = "texture">class UnityEngine.Texture2D</param>
            /// <param name = "rect">struct UnityEngine.Rect</param>
            /// <param name = "pivot">struct UnityEngine.Vector2</param>
            /// <param name = "pixelsPerUnit">struct System.Single</param>
            /// <param name = "extrude">struct System.UInt32</param>
            /// <param name = "meshType">enum UnityEngine.SpriteMeshType</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Create", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SpriteMeshType", 5)]
           public static partial nint CREATE(nint texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType); 
*/
            /// <summary>
            /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude)
            /// </summary>
            /// <param name = "texture">class UnityEngine.Texture2D</param>
            /// <param name = "rect">struct UnityEngine.Rect</param>
            /// <param name = "pivot">struct UnityEngine.Vector2</param>
            /// <param name = "pixelsPerUnit">struct System.Single</param>
            /// <param name = "extrude">struct System.UInt32</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Create", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           public static partial nint CREATE(nint texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude); 
*/
            /// <summary>
            /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit)
            /// </summary>
            /// <param name = "texture">class UnityEngine.Texture2D</param>
            /// <param name = "rect">struct UnityEngine.Rect</param>
            /// <param name = "pivot">struct UnityEngine.Vector2</param>
            /// <param name = "pixelsPerUnit">struct System.Single</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Create", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
           public static partial nint CREATE(nint texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit); 
*/
            /// <summary>
            /// static  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot)
            /// </summary>
            /// <param name = "texture">class UnityEngine.Texture2D</param>
            /// <param name = "rect">struct UnityEngine.Rect</param>
            /// <param name = "pivot">struct UnityEngine.Vector2</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Create", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 2)]
           public static partial nint CREATE(nint texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot); 
*/
            /// <summary>
            /// static  UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, System.Boolean generateFallbackPhysicsShape)
            /// </summary>
            /// <param name = "texture">class UnityEngine.Texture2D</param>
            /// <param name = "rect">struct UnityEngine.Rect</param>
            /// <param name = "pivot">struct UnityEngine.Vector2</param>
            /// <param name = "pixelsPerUnit">struct System.Single</param>
            /// <param name = "extrude">struct System.UInt32</param>
            /// <param name = "meshType">enum UnityEngine.SpriteMeshType</param>
            /// <param name = "border">struct UnityEngine.Vector4</param>
            /// <param name = "generateFallbackPhysicsShape">struct System.Boolean</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateSprite", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SpriteMeshType", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector4", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           public static partial nint CREATE_SPRITE(nint texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, System.Boolean generateFallbackPhysicsShape); 
*/
            /// <summary>
            /// static  UnityEngine.Sprite CreateSprite_Injected(UnityEngine.Texture2D texture, UnityEngine.Rect& rect, UnityEngine.Vector2& pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4& border, System.Boolean generateFallbackPhysicsShape)
            /// </summary>
            /// <param name = "texture">class UnityEngine.Texture2D</param>
            /// <param name = "rect">struct UnityEngine.Rect&</param>
            /// <param name = "pivot">struct UnityEngine.Vector2&</param>
            /// <param name = "pixelsPerUnit">struct System.Single</param>
            /// <param name = "extrude">struct System.UInt32</param>
            /// <param name = "meshType">enum UnityEngine.SpriteMeshType</param>
            /// <param name = "border">struct UnityEngine.Vector4&</param>
            /// <param name = "generateFallbackPhysicsShape">struct System.Boolean</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateSprite_Injected", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2&", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SpriteMeshType", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector4&", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           public static partial nint CREATE_SPRITE_INJECTED(nint texture, UnityEngine.Rect &rect, UnityEngine.Vector2 &pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 &border, System.Boolean generateFallbackPhysicsShape); 
*/
            /// <summary>
            /// static  UnityEngine.Sprite CreateSpriteWithoutTextureScripting(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsToUnits, UnityEngine.Texture2D texture)
            /// </summary>
            /// <param name = "rect">struct UnityEngine.Rect</param>
            /// <param name = "pivot">struct UnityEngine.Vector2</param>
            /// <param name = "pixelsToUnits">struct System.Single</param>
            /// <param name = "texture">class UnityEngine.Texture2D</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateSpriteWithoutTextureScripting", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 3)]
           public static partial nint CREATE_SPRITE_WITHOUT_TEXTURE_SCRIPTING(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsToUnits, nint texture); 
*/
            /// <summary>
            /// static  UnityEngine.Sprite CreateSpriteWithoutTextureScripting_Injected(UnityEngine.Rect& rect, UnityEngine.Vector2& pivot, System.Single pixelsToUnits, UnityEngine.Texture2D texture)
            /// </summary>
            /// <param name = "rect">struct UnityEngine.Rect&</param>
            /// <param name = "pivot">struct UnityEngine.Vector2&</param>
            /// <param name = "pixelsToUnits">struct System.Single</param>
            /// <param name = "texture">class UnityEngine.Texture2D</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateSpriteWithoutTextureScripting_Injected", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 3)]
           public static partial nint CREATE_SPRITE_WITHOUT_TEXTURE_SCRIPTING_INJECTED(UnityEngine.Rect &rect, UnityEngine.Vector2 &pivot, System.Single pixelsToUnits, nint texture); 
*/
            /// <summary>
            /// static  System.Void GetPhysicsShapeImpl(UnityEngine.Sprite sprite, System.Int32 shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2> physicsShape)
            /// </summary>
            /// <param name = "sprite">class UnityEngine.Sprite</param>
            /// <param name = "shapeIdx">struct System.Int32</param>
            /// <param name = "physicsShape">class System.Collections.Generic.List<UnityEngine.Vector2></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPhysicsShapeImpl", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Sprite", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Vector2>", 2)]
           public static partial void GET_PHYSICS_SHAPE_IMPL(nint sprite, System.Int32 shapeIdx, nint physicsShape); 
*/
            /// <summary>
            /// static  System.Void OverridePhysicsShape(UnityEngine.Sprite sprite, UnityEngine.Vector2[] physicsShape, System.Int32 idx)
            /// </summary>
            /// <param name = "sprite">class UnityEngine.Sprite</param>
            /// <param name = "physicsShape">class UnityEngine.Vector2[]</param>
            /// <param name = "idx">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OverridePhysicsShape", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Sprite", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2[]", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public static partial void OVERRIDE_PHYSICS_SHAPE(nint sprite, nint physicsShape, System.Int32 idx); 
*/
            /// <summary>
            /// static  System.Void OverridePhysicsShapeCount(UnityEngine.Sprite sprite, System.Int32 physicsShapeCount)
            /// </summary>
            /// <param name = "sprite">class UnityEngine.Sprite</param>
            /// <param name = "physicsShapeCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OverridePhysicsShapeCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Sprite", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public static partial void OVERRIDE_PHYSICS_SHAPE_COUNT(nint sprite, System.Int32 physicsShapeCount); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial void CTOR(); 
*/
            /// <summary>
            ///   UnityEngine.Texture2D get_associatedAlphaSplitTexture()
            /// </summary>
            /// <returns>class UnityEngine.Texture2D</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_associatedAlphaSplitTexture", "UnityEngine.Texture2D", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial nint GET_ASSOCIATED_ALPHA_SPLIT_TEXTURE(); 
*/
            /// <summary>
            ///   UnityEngine.Vector4 get_border()
            /// </summary>
            /// <returns>struct UnityEngine.Vector4</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_border", "UnityEngine.Vector4", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Vector4 GET_BORDER(); 
*/
            /// <summary>
            ///   System.Void get_border_Injected(UnityEngine.Vector4& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.Vector4&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_border_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector4&", 0)]
           public partial void GET_BORDER_INJECTED(UnityEngine.Vector4 &ret); 
*/
            /// <summary>
            ///   UnityEngine.Bounds get_bounds()
            /// </summary>
            /// <returns>struct UnityEngine.Bounds</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_bounds", "UnityEngine.Bounds", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Bounds GET_BOUNDS(); 
*/
            /// <summary>
            ///   System.Void get_bounds_Injected(UnityEngine.Bounds& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.Bounds&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_bounds_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds&", 0)]
           public partial void GET_BOUNDS_INJECTED(UnityEngine.Bounds &ret); 
*/
            /// <summary>
            ///   System.Boolean get_packed()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_packed", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_PACKED(); 
*/
            /// <summary>
            ///   UnityEngine.SpritePackingMode get_packingMode()
            /// </summary>
            /// <returns>enum UnityEngine.SpritePackingMode</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_packingMode", "UnityEngine.SpritePackingMode", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.SpritePackingMode GET_PACKING_MODE(); 
*/
            /// <summary>
            ///   UnityEngine.SpritePackingRotation get_packingRotation()
            /// </summary>
            /// <returns>enum UnityEngine.SpritePackingRotation</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_packingRotation", "UnityEngine.SpritePackingRotation", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.SpritePackingRotation GET_PACKING_ROTATION(); 
*/
            /// <summary>
            ///   UnityEngine.Vector2 get_pivot()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_pivot", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Vector2 GET_PIVOT(); 
*/
            /// <summary>
            ///   System.Void get_pivot_Injected(UnityEngine.Vector2& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.Vector2&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_pivot_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2&", 0)]
           public partial void GET_PIVOT_INJECTED(UnityEngine.Vector2 &ret); 
*/
            /// <summary>
            ///   System.Single get_pixelsPerUnit()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_pixelsPerUnit", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Single GET_PIXELS_PER_UNIT(); 
*/
            /// <summary>
            ///   UnityEngine.Rect get_rect()
            /// </summary>
            /// <returns>struct UnityEngine.Rect</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_rect", "UnityEngine.Rect", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Rect GET_RECT(); 
*/
            /// <summary>
            ///   System.Void get_rect_Injected(UnityEngine.Rect& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.Rect&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_rect_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect&", 0)]
           public partial void GET_RECT_INJECTED(UnityEngine.Rect &ret); 
*/
            /// <summary>
            ///   System.Single get_spriteAtlasTextureScale()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_spriteAtlasTextureScale", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Single GET_SPRITE_ATLAS_TEXTURE_SCALE(); 
*/
            /// <summary>
            ///   UnityEngine.Texture2D get_texture()
            /// </summary>
            /// <returns>class UnityEngine.Texture2D</returns>
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_texture", "UnityEngine.Texture2D", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial Texture2D.Ptr_Texture2D GET_TEXTURE();

            /// <summary>
            ///   UnityEngine.Rect get_textureRect()
            /// </summary>
            /// <returns>struct UnityEngine.Rect</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_textureRect", "UnityEngine.Rect", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Rect GET_TEXTURE_RECT(); 
*/
            /// <summary>
            ///   UnityEngine.Vector2 get_textureRectOffset()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_textureRectOffset", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Vector2 GET_TEXTURE_RECT_OFFSET(); 
*/
            /// <summary>
            ///   System.UInt16[] get_triangles()
            /// </summary>
            /// <returns>class System.UInt16[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_triangles", "System.UInt16[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial nint GET_TRIANGLES(); 
*/
            /// <summary>
            ///   UnityEngine.Vector2[] get_uv()
            /// </summary>
            /// <returns>class UnityEngine.Vector2[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_uv", "UnityEngine.Vector2[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial nint GET_UV(); 
*/
            /// <summary>
            ///   UnityEngine.Vector2[] get_vertices()
            /// </summary>
            /// <returns>class UnityEngine.Vector2[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_vertices", "UnityEngine.Vector2[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial nint GET_VERTICES(); 
*/
            /// <summary>
            ///   UnityEngine.Vector4 GetInnerUVs()
            /// </summary>
            /// <returns>struct UnityEngine.Vector4</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetInnerUVs", "UnityEngine.Vector4", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Vector4 GET_INNER_U_VS(); 
*/
            /// <summary>
            ///   System.Void GetInnerUVs_Injected(UnityEngine.Vector4& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.Vector4&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetInnerUVs_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector4&", 0)]
           public partial void GET_INNER_U_VS_INJECTED(UnityEngine.Vector4 &ret); 
*/
            /// <summary>
            ///   UnityEngine.Vector4 GetOuterUVs()
            /// </summary>
            /// <returns>struct UnityEngine.Vector4</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOuterUVs", "UnityEngine.Vector4", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Vector4 GET_OUTER_U_VS(); 
*/
            /// <summary>
            ///   System.Void GetOuterUVs_Injected(UnityEngine.Vector4& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.Vector4&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOuterUVs_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector4&", 0)]
           public partial void GET_OUTER_U_VS_INJECTED(UnityEngine.Vector4 &ret); 
*/
            /// <summary>
            ///   System.Int32 GetPacked()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPacked", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_PACKED(); 
*/
            /// <summary>
            ///   System.Int32 GetPackingMode()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPackingMode", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_PACKING_MODE(); 
*/
            /// <summary>
            ///   System.Int32 GetPackingRotation()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPackingRotation", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_PACKING_ROTATION(); 
*/
            /// <summary>
            ///   UnityEngine.Vector4 GetPadding()
            /// </summary>
            /// <returns>struct UnityEngine.Vector4</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPadding", "UnityEngine.Vector4", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Vector4 GET_PADDING(); 
*/
            /// <summary>
            ///   System.Void GetPadding_Injected(UnityEngine.Vector4& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.Vector4&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPadding_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector4&", 0)]
           public partial void GET_PADDING_INJECTED(UnityEngine.Vector4 &ret); 
*/
            /// <summary>
            ///   System.Int32 GetPhysicsShape(System.Int32 shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2> physicsShape)
            /// </summary>
            /// <param name = "shapeIdx">struct System.Int32</param>
            /// <param name = "physicsShape">class System.Collections.Generic.List<UnityEngine.Vector2></param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPhysicsShape", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Vector2>", 1)]
           public partial System.Int32 GET_PHYSICS_SHAPE(System.Int32 shapeIdx, nint physicsShape); 
*/
            /// <summary>
            ///   System.Int32 GetPhysicsShapeCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPhysicsShapeCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_PHYSICS_SHAPE_COUNT(); 
*/
            /// <summary>
            ///   System.Int32 GetPhysicsShapePointCount(System.Int32 shapeIdx)
            /// </summary>
            /// <param name = "shapeIdx">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPhysicsShapePointCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial System.Int32 GET_PHYSICS_SHAPE_POINT_COUNT(System.Int32 shapeIdx); 
*/
            /// <summary>
            ///   UnityEngine.Texture2D GetSecondaryTexture(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>class UnityEngine.Texture2D</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSecondaryTexture", "UnityEngine.Texture2D", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial nint GET_SECONDARY_TEXTURE(System.Int32 index); 
*/
            /// <summary>
            ///   UnityEngine.Rect GetTextureRect()
            /// </summary>
            /// <returns>struct UnityEngine.Rect</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTextureRect", "UnityEngine.Rect", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Rect GET_TEXTURE_RECT(); 
*/
            /// <summary>
            ///   System.Void GetTextureRect_Injected(UnityEngine.Rect& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.Rect&</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTextureRect_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect&", 0)]
            public partial void GET_TEXTURE_RECT_INJECTED(MapleOut<Rect.Ref_Rect> rect);

            /// <summary>
            ///   UnityEngine.Vector2 GetTextureRectOffset()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTextureRectOffset", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Vector2 GET_TEXTURE_RECT_OFFSET(); 
*/
            /// <summary>
            ///   System.Void GetTextureRectOffset_Injected(UnityEngine.Vector2& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.Vector2&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTextureRectOffset_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2&", 0)]
           public partial void GET_TEXTURE_RECT_OFFSET_INJECTED(UnityEngine.Vector2 &ret); 
*/
            /// <summary>
            ///   System.Int32 Internal_GetPhysicsShapePointCount(System.Int32 shapeIdx)
            /// </summary>
            /// <param name = "shapeIdx">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_GetPhysicsShapePointCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial System.Int32 INTERNAL_GET_PHYSICS_SHAPE_POINT_COUNT(System.Int32 shapeIdx); 
*/
            /// <summary>
            ///   System.Void OverrideGeometry(UnityEngine.Vector2[] vertices, System.UInt16[] triangles)
            /// </summary>
            /// <param name = "vertices">class UnityEngine.Vector2[]</param>
            /// <param name = "triangles">class System.UInt16[]</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OverrideGeometry", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt16[]", 1)]
           public partial void OVERRIDE_GEOMETRY(nint vertices, nint triangles); 
*/
            /// <summary>
            ///   System.Void OverridePhysicsShape(System.Collections.Generic.IList<UnityEngine.Vector2 [ ]> physicsShapes)
            /// </summary>
            /// <param name = "physicsShapes">interface System.Collections.Generic.IList<UnityEngine.Vector2 [ ]></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OverridePhysicsShape", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IList<UnityEngine.Vector2[]>", 0)]
           public partial void OVERRIDE_PHYSICS_SHAPE(nint physicsShapes); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule"."UnityEngine"."Object"]
        /// </summary>
        partial struct Ptr_Sprite
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  System.Void CheckNullArgument(System.Object arg, System.String message)
            /// </summary>
            /// <param name = "arg">class System.Object</param>
            /// <param name = "message">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckNullArgument", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial void CHECK_NULL_ARGUMENT(nint arg, nint message); 
*/
            /// <summary>
            /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs)
            /// </summary>
            /// <param name = "lhs">class UnityEngine.Object</param>
            /// <param name = "rhs">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CompareBaseObjects", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 1)]
            public static partial System.Boolean COMPARE_BASE_OBJECTS(nint lhs, nint rhs); 
*/
            /// <summary>
            /// static  System.Boolean CurrentThreadIsMainThread()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CurrentThreadIsMainThread", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public static partial System.Boolean CURRENT_THREAD_IS_MAIN_THREAD(); 
*/
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Destroy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial void DESTROY(nint obj, System.Single t); 
*/
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Destroy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DESTROY(nint obj); 
*/
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "allowDestroyingAssets">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyImmediate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial void DESTROY_IMMEDIATE(nint obj, System.Boolean allowDestroyingAssets); 
*/
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyImmediate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DESTROY_IMMEDIATE(nint obj); 
*/
            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyObject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial void DESTROY_OBJECT(nint obj, System.Single t); 
*/
            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyObject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DESTROY_OBJECT(nint obj); 
*/
            /// <summary>
            /// static  System.Boolean DoesObjectWithInstanceIDExist(System.Int32 instanceID)
            /// </summary>
            /// <param name = "instanceID">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DoesObjectWithInstanceIDExist", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Boolean DOES_OBJECT_WITH_INSTANCE_ID_EXIST(System.Int32 instanceID); 
*/
            /// <summary>
            /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
            /// </summary>
            /// <param name = "target">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DontDestroyOnLoad", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DONT_DESTROY_ON_LOAD(nint target); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name = "instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectFromInstanceID", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint FIND_OBJECT_FROM_INSTANCE_ID(System.Int32 instanceID); 
*/
            /// <summary>
            /// static  T FindObjectOfType()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectOfType", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public static partial nint FIND_OBJECT_OF_TYPE(); 
*/
            /// <summary>
            /// static  T FindObjectOfType(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectOfType", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public static partial nint FIND_OBJECT_OF_TYPE(System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectOfType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_OBJECT_OF_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectOfType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial nint FIND_OBJECT_OF_TYPE(nint type, System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_OBJECTS_OF_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial nint FIND_OBJECTS_OF_TYPE(nint type, System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  T[] FindObjectsOfType()
            /// </summary>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfType", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public static partial nint FIND_OBJECTS_OF_TYPE(); 
*/
            /// <summary>
            /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfType", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public static partial nint FIND_OBJECTS_OF_TYPE(System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfTypeAll", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_OBJECTS_OF_TYPE_ALL(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfTypeIncludingAssets", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_OBJECTS_OF_TYPE_INCLUDING_ASSETS(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindSceneObjectsOfType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindSceneObjectsOfType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_SCENE_OBJECTS_OF_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object ForceLoadFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name = "instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ForceLoadFromInstanceID", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint FORCE_LOAD_FROM_INSTANCE_ID(System.Int32 instanceID); 
*/
            /// <summary>
            /// static  System.String GetName(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint GET_NAME(nint obj); 
*/
            /// <summary>
            /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOffsetOfInstanceIDInCPlusPlusObject", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public static partial System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT(); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 3)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint INSTANTIATE(nint original); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            public static partial nint INSTANTIATE(nint original, nint parent); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "instantiateInWorldSpace">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint INSTANTIATE(nint original, nint parent, System.Boolean instantiateInWorldSpace); 
*/
            /// <summary>
            /// static  T Instantiate(T original)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public static partial nint INSTANTIATE(nint original); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 3)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            public static partial nint INSTANTIATE(nint original, nint parent); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "worldPositionStays">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint INSTANTIATE(nint original, nint parent, System.Boolean worldPositionStays); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CloneSingle", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint INTERNAL_CLONE_SINGLE(nint data); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "worldPositionStays">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CloneSingleWithParent", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint INTERNAL_CLONE_SINGLE_WITH_PARENT(nint data, nint parent, System.Boolean worldPositionStays); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <param name = "rot">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingle", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE(nint data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "pos">struct UnityEngine.Vector3&</param>
            /// <param name = "rot">struct UnityEngine.Quaternion&</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingle_Injected", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion&", 2)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE_INJECTED(nint data, UnityEngine.Vector3 &pos, UnityEngine.Quaternion &rot); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <param name = "rot">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingleWithParent", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 3)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT(nint data, nint parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "pos">struct UnityEngine.Vector3&</param>
            /// <param name = "rot">struct UnityEngine.Quaternion&</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingleWithParent_Injected", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion&", 3)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT_INJECTED(nint data, nint parent, UnityEngine.Vector3 &pos, UnityEngine.Quaternion &rot); 
*/
            /// <summary>
            /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
            /// </summary>
            /// <param name = "o">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsNativeObjectAlive", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial System.Boolean IS_NATIVE_OBJECT_ALIVE(nint o); 
*/
            /// <summary>
            /// static  System.Boolean IsPersistent(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsPersistent", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial System.Boolean IS_PERSISTENT(nint obj); 
*/
            /// <summary>
            /// static  System.Boolean op_Equality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name = "x">class UnityEngine.Object</param>
            /// <param name = "y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Equality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 1)]
            public static partial System.Boolean OP_EQUALITY(nint x, nint y); 
*/
            /// <summary>
            /// static  System.Boolean op_Implicit(UnityEngine.Object exists)
            /// </summary>
            /// <param name = "exists">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Implicit", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial System.Boolean OP_IMPLICIT(nint exists); 
*/
            /// <summary>
            /// static  System.Boolean op_Inequality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name = "x">class UnityEngine.Object</param>
            /// <param name = "y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Inequality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 1)]
            public static partial System.Boolean OP_INEQUALITY(nint x, nint y); 
*/
            /// <summary>
            /// static  System.Void SetName(UnityEngine.Object obj, System.String name)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetName", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial void SET_NAME(nint obj, nint name); 
*/
            /// <summary>
            /// static  System.String ToString(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint TO_STRING(nint obj); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void EnsureRunningOnMainThread()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EnsureRunningOnMainThread", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial void ENSURE_RUNNING_ON_MAIN_THREAD(); 
*/
            /// <summary>
            ///   System.Boolean Equals(System.Object other)
            /// </summary>
            /// <param name = "other">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Equals", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial System.Boolean EQUALS(nint other); 
*/
            /// <summary>
            ///   UnityEngine.HideFlags get_hideFlags()
            /// </summary>
            /// <returns>enum UnityEngine.HideFlags</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_hideFlags", "UnityEngine.HideFlags", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial UnityEngine.HideFlags GET_HIDE_FLAGS(); 
*/
            /// <summary>
            ///   System.String get_name()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_name", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial nint GET_NAME(); 
*/
            /// <summary>
            ///   System.IntPtr GetCachedPtr()
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCachedPtr", "System.IntPtr", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial System.IntPtr GET_CACHED_PTR(); 
*/
            /// <summary>
            ///   System.Int32 GetHashCode()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHashCode", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial System.Int32 GET_HASH_CODE(); 
*/
            /// <summary>
            ///   System.Int32 GetInstanceID()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetInstanceID", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial System.Int32 GET_INSTANCE_ID(); 
*/
            /// <summary>
            ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.HideFlags</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_hideFlags", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.HideFlags", 0)]
            public partial void SET_HIDE_FLAGS(UnityEngine.HideFlags value); 
*/
            /// <summary>
            ///   System.Void set_name(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_name", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_NAME(nint value); 
*/
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial nint TO_STRING(); 
*/
        }
    }
}
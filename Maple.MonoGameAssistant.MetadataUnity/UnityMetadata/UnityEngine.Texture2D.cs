using Maple.MonoGameAssistant.Common;

namespace Maple.MonoGameAssistant.MetadataUnity
{
    /// <summary>
    /// class ["UnityEngine.CoreModule"."UnityEngine"."Texture2D"]
    /// [UnityEngine.Texture]=>[UnityEngine.Object]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Texture2D>, Ptr_Texture2D>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("UnityEngine.CoreModule", "UnityEngine", "Texture2D", "UnityEngine.Texture2D")]
    public partial class Texture2D
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Texture2D(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_Texture2D(System.IntPtr ptr) => new Ptr_Texture2D(ptr);
            public static implicit operator System.IntPtr(Ptr_Texture2D ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_Texture2D ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule"."UnityEngine"."Texture2D"]
        /// </summary>
        partial struct Ptr_Texture2D
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
            /// 0x0 System.Int32 GenerateAllMips
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("GenerateAllMips", "System.Int32")]
            public static partial System.Int32 GENERATE_ALL_MIPS { get; set; } 
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
        /// class ["UnityEngine.CoreModule"."UnityEngine"."Texture2D"]
        /// </summary>
        partial struct Ptr_Texture2D
        {
            /// <summary>
            /// static  UnityEngine.Texture2D CreateExternalTexture(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean mipChain, System.Boolean linear, System.IntPtr nativeTex)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.TextureFormat</param>
            /// <param name = "mipChain">struct System.Boolean</param>
            /// <param name = "linear">struct System.Boolean</param>
            /// <param name = "nativeTex">struct System.IntPtr</param>
            /// <returns>class UnityEngine.Texture2D</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateExternalTexture", "UnityEngine.Texture2D", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.TextureFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 5)]
           public static partial nint CREATE_EXTERNAL_TEXTURE(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean mipChain, System.Boolean linear, System.IntPtr nativeTex); 
*/
            /// <summary>
            /// static  System.Boolean GenerateAtlas(UnityEngine.Vector2[] sizes, System.Int32 padding, System.Int32 atlasSize, System.Collections.Generic.List<UnityEngine.Rect> results)
            /// </summary>
            /// <param name = "sizes">class UnityEngine.Vector2[]</param>
            /// <param name = "padding">struct System.Int32</param>
            /// <param name = "atlasSize">struct System.Int32</param>
            /// <param name = "results">class System.Collections.Generic.List<UnityEngine.Rect></param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateAtlas", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Rect>", 3)]
           public static partial System.Boolean GENERATE_ATLAS(nint sizes, System.Int32 padding, System.Int32 atlasSize, nint results); 
*/
            /// <summary>
            /// static  System.Void GenerateAtlasImpl(UnityEngine.Vector2[] sizes, System.Int32 padding, System.Int32 atlasSize, UnityEngine.Rect[] rect)
            /// </summary>
            /// <param name = "sizes">class UnityEngine.Vector2[]</param>
            /// <param name = "padding">struct System.Int32</param>
            /// <param name = "atlasSize">struct System.Int32</param>
            /// <param name = "rect">class UnityEngine.Rect[]</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateAtlasImpl", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect[]", 3)]
           public static partial void GENERATE_ATLAS_IMPL(nint sizes, System.Int32 padding, System.Int32 atlasSize, nint rect); 
*/
            /// <summary>
            /// static  UnityEngine.Texture2D get_blackTexture()
            /// </summary>
            /// <returns>class UnityEngine.Texture2D</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_blackTexture", "UnityEngine.Texture2D", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial nint GET_BLACK_TEXTURE(); 
*/
            /// <summary>
            /// static  UnityEngine.Texture2D get_grayTexture()
            /// </summary>
            /// <returns>class UnityEngine.Texture2D</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_grayTexture", "UnityEngine.Texture2D", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial nint GET_GRAY_TEXTURE(); 
*/
            /// <summary>
            /// static  UnityEngine.Texture2D get_linearGrayTexture()
            /// </summary>
            /// <returns>class UnityEngine.Texture2D</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_linearGrayTexture", "UnityEngine.Texture2D", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial nint GET_LINEAR_GRAY_TEXTURE(); 
*/
            /// <summary>
            /// static  UnityEngine.Texture2D get_normalTexture()
            /// </summary>
            /// <returns>class UnityEngine.Texture2D</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_normalTexture", "UnityEngine.Texture2D", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial nint GET_NORMAL_TEXTURE(); 
*/
            /// <summary>
            /// static  UnityEngine.Texture2D get_redTexture()
            /// </summary>
            /// <returns>class UnityEngine.Texture2D</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_redTexture", "UnityEngine.Texture2D", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial nint GET_RED_TEXTURE(); 
*/
            /// <summary>
            /// static  UnityEngine.Texture2D get_whiteTexture()
            /// </summary>
            /// <returns>class UnityEngine.Texture2D</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_whiteTexture", "UnityEngine.Texture2D", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial nint GET_WHITE_TEXTURE(); 
*/
            /// <summary>
            /// static  System.Void Internal_Create(UnityEngine.Texture2D mono, System.Int32 w, System.Int32 h, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex)
            /// </summary>
            /// <param name = "mono">class UnityEngine.Texture2D</param>
            /// <param name = "w">struct System.Int32</param>
            /// <param name = "h">struct System.Int32</param>
            /// <param name = "mipCount">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "flags">enum UnityEngine.Experimental.Rendering.TextureCreationFlags</param>
            /// <param name = "nativeTex">struct System.IntPtr</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_Create", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.TextureCreationFlags", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 6)]
           public static partial void INTERNAL_CREATE(nint mono, System.Int32 w, System.Int32 h, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex); 
*/
            /// <summary>
            /// static  System.Boolean Internal_CreateImpl(UnityEngine.Texture2D mono, System.Int32 w, System.Int32 h, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex)
            /// </summary>
            /// <param name = "mono">class UnityEngine.Texture2D</param>
            /// <param name = "w">struct System.Int32</param>
            /// <param name = "h">struct System.Int32</param>
            /// <param name = "mipCount">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "flags">enum UnityEngine.Experimental.Rendering.TextureCreationFlags</param>
            /// <param name = "nativeTex">struct System.IntPtr</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CreateImpl", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.TextureCreationFlags", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 6)]
           public static partial System.Boolean INTERNAL_CREATE_IMPL(nint mono, System.Int32 w, System.Int32 h, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.Int32 mipCount, System.IntPtr nativeTex)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "flags">enum UnityEngine.Experimental.Rendering.TextureCreationFlags</param>
            /// <param name = "mipCount">struct System.Int32</param>
            /// <param name = "nativeTex">struct System.IntPtr</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.TextureCreationFlags", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 5)]
           public partial void CTOR(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.Int32 mipCount, System.IntPtr nativeTex); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.DefaultFormat</param>
            /// <param name = "flags">enum UnityEngine.Experimental.Rendering.TextureCreationFlags</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.DefaultFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.TextureCreationFlags", 3)]
           public partial void CTOR(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "flags">enum UnityEngine.Experimental.Rendering.TextureCreationFlags</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.TextureCreationFlags", 3)]
           public partial void CTOR(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "mipCount">struct System.Int32</param>
            /// <param name = "flags">enum UnityEngine.Experimental.Rendering.TextureCreationFlags</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.TextureCreationFlags", 4)]
           public partial void CTOR(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.Boolean linear, System.IntPtr nativeTex)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "textureFormat">enum UnityEngine.TextureFormat</param>
            /// <param name = "mipCount">struct System.Int32</param>
            /// <param name = "linear">struct System.Boolean</param>
            /// <param name = "nativeTex">struct System.IntPtr</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.TextureFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 5)]
           public partial void CTOR(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.Boolean linear, System.IntPtr nativeTex); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.Boolean linear)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "textureFormat">enum UnityEngine.TextureFormat</param>
            /// <param name = "mipCount">struct System.Int32</param>
            /// <param name = "linear">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.TextureFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
           public partial void CTOR(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.Boolean linear); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain, System.Boolean linear)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "textureFormat">enum UnityEngine.TextureFormat</param>
            /// <param name = "mipChain">struct System.Boolean</param>
            /// <param name = "linear">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.TextureFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
           public partial void CTOR(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain, System.Boolean linear); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "textureFormat">enum UnityEngine.TextureFormat</param>
            /// <param name = "mipChain">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.TextureFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
           public partial void CTOR(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void CTOR(System.Int32 width, System.Int32 height);

            /// <summary>
            ///   System.Void Apply(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable)
            /// </summary>
            /// <param name = "updateMipmaps">struct System.Boolean</param>
            /// <param name = "makeNoLongerReadable">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Apply", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial void APPLY(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable); 
*/
            /// <summary>
            ///   System.Void Apply(System.Boolean updateMipmaps)
            /// </summary>
            /// <param name = "updateMipmaps">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Apply", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void APPLY(System.Boolean updateMipmaps); 
*/
            /// <summary>
            ///   System.Void Apply()
            /// </summary>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Apply", "System.Void", VoidArgument = true, CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial void APPLY();

            /// <summary>
            ///   System.Void ApplyImpl(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable)
            /// </summary>
            /// <param name = "updateMipmaps">struct System.Boolean</param>
            /// <param name = "makeNoLongerReadable">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ApplyImpl", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial void APPLY_IMPL(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable); 
*/
            /// <summary>
            ///   System.Void ClearMinimumMipmapLevel()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearMinimumMipmapLevel", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial void CLEAR_MINIMUM_MIPMAP_LEVEL(); 
*/
            /// <summary>
            ///   System.Void ClearRequestedMipmapLevel()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearRequestedMipmapLevel", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial void CLEAR_REQUESTED_MIPMAP_LEVEL(); 
*/
            /// <summary>
            ///   System.Void Compress(System.Boolean highQuality)
            /// </summary>
            /// <param name = "highQuality">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Compress", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void COMPRESS(System.Boolean highQuality); 
*/
            /// <summary>
            ///   System.Int32 get_calculatedMipmapLevel()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_calculatedMipmapLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_CALCULATED_MIPMAP_LEVEL(); 
*/
            /// <summary>
            ///   System.Int32 get_desiredMipmapLevel()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_desiredMipmapLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_DESIRED_MIPMAP_LEVEL(); 
*/
            /// <summary>
            ///   UnityEngine.TextureFormat get_format()
            /// </summary>
            /// <returns>enum UnityEngine.TextureFormat</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_format", "UnityEngine.TextureFormat", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.TextureFormat GET_FORMAT(); 
*/
            /// <summary>
            ///   System.Boolean get_isPreProcessed()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isPreProcessed", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_IS_PRE_PROCESSED(); 
*/
            /// <summary>
            ///   System.Boolean get_isReadable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isReadable", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_IS_READABLE(); 
*/
            /// <summary>
            ///   System.Boolean get_loadAllMips()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_loadAllMips", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_LOAD_ALL_MIPS(); 
*/
            /// <summary>
            ///   System.Int32 get_loadedMipmapLevel()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_loadedMipmapLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_LOADED_MIPMAP_LEVEL(); 
*/
            /// <summary>
            ///   System.Int32 get_loadingMipmapLevel()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_loadingMipmapLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_LOADING_MIPMAP_LEVEL(); 
*/
            /// <summary>
            ///   System.Int32 get_minimumMipmapLevel()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_minimumMipmapLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_MINIMUM_MIPMAP_LEVEL(); 
*/
            /// <summary>
            ///   System.Int32 get_requestedMipmapLevel()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_requestedMipmapLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_REQUESTED_MIPMAP_LEVEL(); 
*/
            /// <summary>
            ///   System.Boolean get_streamingMipmaps()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_streamingMipmaps", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_STREAMING_MIPMAPS(); 
*/
            /// <summary>
            ///   System.Int32 get_streamingMipmapsPriority()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_streamingMipmapsPriority", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_STREAMING_MIPMAPS_PRIORITY(); 
*/
            /// <summary>
            ///   System.Boolean get_vtOnly()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_vtOnly", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_VT_ONLY(); 
*/
            /// <summary>
            ///   UnityEngine.Color GetPixel(System.Int32 x, System.Int32 y)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <returns>struct UnityEngine.Color</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixel", "UnityEngine.Color", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial UnityEngine.Color GET_PIXEL(System.Int32 x, System.Int32 y); 
*/
            /// <summary>
            ///   UnityEngine.Color GetPixel(System.Int32 x, System.Int32 y, System.Int32 mipLevel)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <returns>struct UnityEngine.Color</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixel", "UnityEngine.Color", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial UnityEngine.Color GET_PIXEL(System.Int32 x, System.Int32 y, System.Int32 mipLevel); 
*/
            /// <summary>
            ///   UnityEngine.Color GetPixelBilinear(System.Single u, System.Single v)
            /// </summary>
            /// <param name = "u">struct System.Single</param>
            /// <param name = "v">struct System.Single</param>
            /// <returns>struct UnityEngine.Color</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixelBilinear", "UnityEngine.Color", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
           public partial UnityEngine.Color GET_PIXEL_BILINEAR(System.Single u, System.Single v); 
*/
            /// <summary>
            ///   UnityEngine.Color GetPixelBilinear(System.Single u, System.Single v, System.Int32 mipLevel)
            /// </summary>
            /// <param name = "u">struct System.Single</param>
            /// <param name = "v">struct System.Single</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <returns>struct UnityEngine.Color</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixelBilinear", "UnityEngine.Color", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial UnityEngine.Color GET_PIXEL_BILINEAR(System.Single u, System.Single v, System.Int32 mipLevel); 
*/
            /// <summary>
            ///   UnityEngine.Color GetPixelBilinearImpl(System.Int32 image, System.Int32 mip, System.Single u, System.Single v)
            /// </summary>
            /// <param name = "image">struct System.Int32</param>
            /// <param name = "mip">struct System.Int32</param>
            /// <param name = "u">struct System.Single</param>
            /// <param name = "v">struct System.Single</param>
            /// <returns>struct UnityEngine.Color</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixelBilinearImpl", "UnityEngine.Color", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
           public partial UnityEngine.Color GET_PIXEL_BILINEAR_IMPL(System.Int32 image, System.Int32 mip, System.Single u, System.Single v); 
*/
            /// <summary>
            ///   System.Void GetPixelBilinearImpl_Injected(System.Int32 image, System.Int32 mip, System.Single u, System.Single v, UnityEngine.Color& ret)
            /// </summary>
            /// <param name = "image">struct System.Int32</param>
            /// <param name = "mip">struct System.Int32</param>
            /// <param name = "u">struct System.Single</param>
            /// <param name = "v">struct System.Single</param>
            /// <param name = "ret">struct UnityEngine.Color&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixelBilinearImpl_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color&", 4)]
           public partial void GET_PIXEL_BILINEAR_IMPL_INJECTED(System.Int32 image, System.Int32 mip, System.Single u, System.Single v, UnityEngine.Color &ret); 
*/
            /// <summary>
            ///   Unity.Collections.NativeArray<T> GetPixelData(System.Int32 mipLevel)
            /// </summary>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <returns>struct Unity.Collections.NativeArray<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixelData", "Unity.Collections.NativeArray<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial Unity.Collections.NativeArray<T> GET_PIXEL_DATA(System.Int32 mipLevel); 
*/
            /// <summary>
            ///   UnityEngine.Color GetPixelImpl(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y)
            /// </summary>
            /// <param name = "image">struct System.Int32</param>
            /// <param name = "mip">struct System.Int32</param>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <returns>struct UnityEngine.Color</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixelImpl", "UnityEngine.Color", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public partial UnityEngine.Color GET_PIXEL_IMPL(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y); 
*/
            /// <summary>
            ///   System.Void GetPixelImpl_Injected(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color& ret)
            /// </summary>
            /// <param name = "image">struct System.Int32</param>
            /// <param name = "mip">struct System.Int32</param>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "ret">struct UnityEngine.Color&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixelImpl_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color&", 4)]
           public partial void GET_PIXEL_IMPL_INJECTED(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color &ret); 
*/
            /// <summary>
            ///   UnityEngine.Color[] GetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, System.Int32 miplevel)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "blockWidth">struct System.Int32</param>
            /// <param name = "blockHeight">struct System.Int32</param>
            /// <param name = "miplevel">struct System.Int32</param>
            /// <returns>class UnityEngine.Color[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixels", "UnityEngine.Color[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public partial nint GET_PIXELS(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, System.Int32 miplevel); 
*/
            /// <summary>
            ///   UnityEngine.Color[] GetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "blockWidth">struct System.Int32</param>
            /// <param name = "blockHeight">struct System.Int32</param>
            /// <returns>class UnityEngine.Color[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixels", "UnityEngine.Color[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public partial nint GET_PIXELS(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight); 
*/
            /// <summary>
            ///   UnityEngine.Color[] GetPixels(System.Int32 miplevel)
            /// </summary>
            /// <param name = "miplevel">struct System.Int32</param>
            /// <returns>class UnityEngine.Color[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixels", "UnityEngine.Color[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial nint GET_PIXELS(System.Int32 miplevel); 
*/
            /// <summary>
            ///   UnityEngine.Color[] GetPixels()
            /// </summary>
            /// <returns>class UnityEngine.Color[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixels", "UnityEngine.Color[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial nint GET_PIXELS(); 
*/
            /// <summary>
            ///   UnityEngine.Color32[] GetPixels32(System.Int32 miplevel)
            /// </summary>
            /// <param name = "miplevel">struct System.Int32</param>
            /// <returns>class UnityEngine.Color32[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixels32", "UnityEngine.Color32[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial nint GET_PIXELS32(System.Int32 miplevel); 
*/
            /// <summary>
            ///   UnityEngine.Color32[] GetPixels32()
            /// </summary>
            /// <returns>class UnityEngine.Color32[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixels32", "UnityEngine.Color32[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial nint GET_PIXELS32(); 
*/
            /// <summary>
            ///   System.Int64 GetRawImageDataSize()
            /// </summary>
            /// <returns>struct System.Int64</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRawImageDataSize", "System.Int64", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int64 GET_RAW_IMAGE_DATA_SIZE(); 
*/
            /// <summary>
            ///   System.Byte[] GetRawTextureData()
            /// </summary>
            /// <returns>class System.Byte[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRawTextureData", "System.Byte[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial nint GET_RAW_TEXTURE_DATA(); 
*/
            /// <summary>
            ///   Unity.Collections.NativeArray<T> GetRawTextureData()
            /// </summary>
            /// <returns>struct Unity.Collections.NativeArray<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRawTextureData", "Unity.Collections.NativeArray<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial Unity.Collections.NativeArray<T> GET_RAW_TEXTURE_DATA(); 
*/
            /// <summary>
            ///   System.IntPtr GetWritableImageData(System.Int32 frame)
            /// </summary>
            /// <param name = "frame">struct System.Int32</param>
            /// <returns>struct System.IntPtr</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWritableImageData", "System.IntPtr", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial System.IntPtr GET_WRITABLE_IMAGE_DATA(System.Int32 frame); 
*/
            /// <summary>
            ///   System.Boolean IsRequestedMipmapLevelLoaded()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsRequestedMipmapLevelLoaded", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean IS_REQUESTED_MIPMAP_LEVEL_LOADED(); 
*/
            /// <summary>
            ///   System.Void LoadRawTextureData(System.IntPtr data, System.Int32 size)
            /// </summary>
            /// <param name = "data">struct System.IntPtr</param>
            /// <param name = "size">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadRawTextureData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void LOAD_RAW_TEXTURE_DATA(System.IntPtr data, System.Int32 size); 
*/
            /// <summary>
            ///   System.Void LoadRawTextureData(System.Byte[] data)
            /// </summary>
            /// <param name = "data">class System.Byte[]</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadRawTextureData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Byte[]", 0)]
           public partial void LOAD_RAW_TEXTURE_DATA(nint data); 
*/
            /// <summary>
            ///   System.Void LoadRawTextureData(Unity.Collections.NativeArray<T> data)
            /// </summary>
            /// <param name = "data">struct Unity.Collections.NativeArray<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadRawTextureData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Unity.Collections.NativeArray<T>", 0)]
           public partial void LOAD_RAW_TEXTURE_DATA(Unity.Collections.NativeArray<T> data); 
*/
            /// <summary>
            ///   System.Boolean LoadRawTextureDataImpl(System.IntPtr data, System.Int32 size)
            /// </summary>
            /// <param name = "data">struct System.IntPtr</param>
            /// <param name = "size">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadRawTextureDataImpl", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Boolean LOAD_RAW_TEXTURE_DATA_IMPL(System.IntPtr data, System.Int32 size); 
*/
            /// <summary>
            ///   System.Boolean LoadRawTextureDataImplArray(System.Byte[] data)
            /// </summary>
            /// <param name = "data">class System.Byte[]</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadRawTextureDataImplArray", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Byte[]", 0)]
           public partial System.Boolean LOAD_RAW_TEXTURE_DATA_IMPL_ARRAY(nint data); 
*/
            /// <summary>
            ///   UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, System.Int32 padding, System.Int32 maximumAtlasSize, System.Boolean makeNoLongerReadable)
            /// </summary>
            /// <param name = "textures">class UnityEngine.Texture2D[]</param>
            /// <param name = "padding">struct System.Int32</param>
            /// <param name = "maximumAtlasSize">struct System.Int32</param>
            /// <param name = "makeNoLongerReadable">struct System.Boolean</param>
            /// <returns>class UnityEngine.Rect[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PackTextures", "UnityEngine.Rect[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
           public partial nint PACK_TEXTURES(nint textures, System.Int32 padding, System.Int32 maximumAtlasSize, System.Boolean makeNoLongerReadable); 
*/
            /// <summary>
            ///   UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, System.Int32 padding, System.Int32 maximumAtlasSize)
            /// </summary>
            /// <param name = "textures">class UnityEngine.Texture2D[]</param>
            /// <param name = "padding">struct System.Int32</param>
            /// <param name = "maximumAtlasSize">struct System.Int32</param>
            /// <returns>class UnityEngine.Rect[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PackTextures", "UnityEngine.Rect[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial nint PACK_TEXTURES(nint textures, System.Int32 padding, System.Int32 maximumAtlasSize); 
*/
            /// <summary>
            ///   UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, System.Int32 padding)
            /// </summary>
            /// <param name = "textures">class UnityEngine.Texture2D[]</param>
            /// <param name = "padding">struct System.Int32</param>
            /// <returns>class UnityEngine.Rect[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PackTextures", "UnityEngine.Rect[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial nint PACK_TEXTURES(nint textures, System.Int32 padding); 
*/
            /// <summary>
            ///   System.Void ReadPixels(UnityEngine.Rect source, System.Int32 destX, System.Int32 destY, System.Boolean recalculateMipMaps)
            /// </summary>
            /// <param name = "source">struct UnityEngine.Rect</param>
            /// <param name = "destX">struct System.Int32</param>
            /// <param name = "destY">struct System.Int32</param>
            /// <param name = "recalculateMipMaps">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReadPixels", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
           public partial void READ_PIXELS(UnityEngine.Rect source, System.Int32 destX, System.Int32 destY, System.Boolean recalculateMipMaps); 
*/
            /// <summary>
            ///   System.Void ReadPixels(UnityEngine.Rect source, System.Int32 destX, System.Int32 destY)
            /// </summary>
            /// <param name = "source">struct UnityEngine.Rect</param>
            /// <param name = "destX">struct System.Int32</param>
            /// <param name = "destY">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReadPixels", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial void READ_PIXELS(UnityEngine.Rect source, System.Int32 destX, System.Int32 destY); 
*/
            /// <summary>
            ///   System.Void ReadPixelsImpl(UnityEngine.Rect source, System.Int32 destX, System.Int32 destY, System.Boolean recalculateMipMaps)
            /// </summary>
            /// <param name = "source">struct UnityEngine.Rect</param>
            /// <param name = "destX">struct System.Int32</param>
            /// <param name = "destY">struct System.Int32</param>
            /// <param name = "recalculateMipMaps">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReadPixelsImpl", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
           public partial void READ_PIXELS_IMPL(UnityEngine.Rect source, System.Int32 destX, System.Int32 destY, System.Boolean recalculateMipMaps); 
*/
            /// <summary>
            ///   System.Void ReadPixelsImpl_Injected(UnityEngine.Rect& source, System.Int32 destX, System.Int32 destY, System.Boolean recalculateMipMaps)
            /// </summary>
            /// <param name = "source">struct UnityEngine.Rect&</param>
            /// <param name = "destX">struct System.Int32</param>
            /// <param name = "destY">struct System.Int32</param>
            /// <param name = "recalculateMipMaps">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReadPixelsImpl_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect&", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial void READ_PIXELS_IMPL_INJECTED(MapleRef<Rect.Ref_Rect> source, System.Int32 destX, System.Int32 destY, System.Boolean recalculateMipMaps);

            /// <summary>
            ///   System.Boolean Reinitialize(System.Int32 width, System.Int32 height)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reinitialize", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Boolean REINITIALIZE(System.Int32 width, System.Int32 height); 
*/
            /// <summary>
            ///   System.Boolean Reinitialize(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean hasMipMap)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.TextureFormat</param>
            /// <param name = "hasMipMap">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reinitialize", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.TextureFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
           public partial System.Boolean REINITIALIZE(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean hasMipMap); 
*/
            /// <summary>
            ///   System.Boolean Reinitialize(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean hasMipMap)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "hasMipMap">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reinitialize", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
           public partial System.Boolean REINITIALIZE(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean hasMipMap); 
*/
            /// <summary>
            ///   System.Boolean ReinitializeImpl(System.Int32 width, System.Int32 height)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReinitializeImpl", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Boolean REINITIALIZE_IMPL(System.Int32 width, System.Int32 height); 
*/
            /// <summary>
            ///   System.Boolean ReinitializeWithFormatImpl(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean hasMipMap)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "hasMipMap">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReinitializeWithFormatImpl", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
           public partial System.Boolean REINITIALIZE_WITH_FORMAT_IMPL(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean hasMipMap); 
*/
            /// <summary>
            ///   System.Boolean Resize(System.Int32 width, System.Int32 height)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Resize", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Boolean RESIZE(System.Int32 width, System.Int32 height); 
*/
            /// <summary>
            ///   System.Boolean Resize(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean hasMipMap)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.TextureFormat</param>
            /// <param name = "hasMipMap">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Resize", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.TextureFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
           public partial System.Boolean RESIZE(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean hasMipMap); 
*/
            /// <summary>
            ///   System.Boolean Resize(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean hasMipMap)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "hasMipMap">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Resize", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
           public partial System.Boolean RESIZE(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean hasMipMap); 
*/
            /// <summary>
            ///   System.Void set_loadAllMips(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_loadAllMips", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void SET_LOAD_ALL_MIPS(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_minimumMipmapLevel(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_minimumMipmapLevel", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void SET_MINIMUM_MIPMAP_LEVEL(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_requestedMipmapLevel(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_requestedMipmapLevel", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void SET_REQUESTED_MIPMAP_LEVEL(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void SetAllPixels32(UnityEngine.Color32[] colors, System.Int32 miplevel)
            /// </summary>
            /// <param name = "colors">class UnityEngine.Color32[]</param>
            /// <param name = "miplevel">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAllPixels32", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color32[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void SET_ALL_PIXELS32(nint colors, System.Int32 miplevel); 
*/
            /// <summary>
            ///   System.Void SetBlockOfPixels32(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color32[] colors, System.Int32 miplevel)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "blockWidth">struct System.Int32</param>
            /// <param name = "blockHeight">struct System.Int32</param>
            /// <param name = "colors">class UnityEngine.Color32[]</param>
            /// <param name = "miplevel">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetBlockOfPixels32", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color32[]", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public partial void SET_BLOCK_OF_PIXELS32(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, nint colors, System.Int32 miplevel); 
*/
            /// <summary>
            ///   System.Void SetPixel(System.Int32 x, System.Int32 y, UnityEngine.Color color)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "color">struct UnityEngine.Color</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixel", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color", 2)]
           public partial void SET_PIXEL(System.Int32 x, System.Int32 y, UnityEngine.Color color); 
*/
            /// <summary>
            ///   System.Void SetPixel(System.Int32 x, System.Int32 y, UnityEngine.Color color, System.Int32 mipLevel)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "color">struct UnityEngine.Color</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixel", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public partial void SET_PIXEL(System.Int32 x, System.Int32 y, UnityEngine.Color color, System.Int32 mipLevel); 
*/
            /// <summary>
            ///   System.Void SetPixelData(T[] data, System.Int32 mipLevel, System.Int32 sourceDataStartIndex)
            /// </summary>
            /// <param name = "data">class T[]</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <param name = "sourceDataStartIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixelData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial void SET_PIXEL_DATA(nint data, System.Int32 mipLevel, System.Int32 sourceDataStartIndex); 
*/
            /// <summary>
            ///   System.Void SetPixelData(Unity.Collections.NativeArray<T> data, System.Int32 mipLevel, System.Int32 sourceDataStartIndex)
            /// </summary>
            /// <param name = "data">struct Unity.Collections.NativeArray<T></param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <param name = "sourceDataStartIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixelData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Unity.Collections.NativeArray<T>", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial void SET_PIXEL_DATA(Unity.Collections.NativeArray<T> data, System.Int32 mipLevel, System.Int32 sourceDataStartIndex); 
*/
            /// <summary>
            ///   System.Boolean SetPixelDataImpl(System.IntPtr data, System.Int32 mipLevel, System.Int32 elementSize, System.Int32 dataArraySize, System.Int32 sourceDataStartIndex)
            /// </summary>
            /// <param name = "data">struct System.IntPtr</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <param name = "elementSize">struct System.Int32</param>
            /// <param name = "dataArraySize">struct System.Int32</param>
            /// <param name = "sourceDataStartIndex">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixelDataImpl", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public partial System.Boolean SET_PIXEL_DATA_IMPL(System.IntPtr data, System.Int32 mipLevel, System.Int32 elementSize, System.Int32 dataArraySize, System.Int32 sourceDataStartIndex); 
*/
            /// <summary>
            ///   System.Boolean SetPixelDataImplArray(System.Array data, System.Int32 mipLevel, System.Int32 elementSize, System.Int32 dataArraySize, System.Int32 sourceDataStartIndex)
            /// </summary>
            /// <param name = "data">abstract class System.Array</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <param name = "elementSize">struct System.Int32</param>
            /// <param name = "dataArraySize">struct System.Int32</param>
            /// <param name = "sourceDataStartIndex">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixelDataImplArray", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Array", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public partial System.Boolean SET_PIXEL_DATA_IMPL_ARRAY(nint data, System.Int32 mipLevel, System.Int32 elementSize, System.Int32 dataArraySize, System.Int32 sourceDataStartIndex); 
*/
            /// <summary>
            ///   System.Void SetPixelImpl(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color color)
            /// </summary>
            /// <param name = "image">struct System.Int32</param>
            /// <param name = "mip">struct System.Int32</param>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "color">struct UnityEngine.Color</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixelImpl", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color", 4)]
           public partial void SET_PIXEL_IMPL(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color color); 
*/
            /// <summary>
            ///   System.Void SetPixelImpl_Injected(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color& color)
            /// </summary>
            /// <param name = "image">struct System.Int32</param>
            /// <param name = "mip">struct System.Int32</param>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "color">struct UnityEngine.Color&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixelImpl_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color&", 4)]
           public partial void SET_PIXEL_IMPL_INJECTED(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color &color); 
*/
            /// <summary>
            ///   System.Void SetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color[] colors, System.Int32 miplevel)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "blockWidth">struct System.Int32</param>
            /// <param name = "blockHeight">struct System.Int32</param>
            /// <param name = "colors">class UnityEngine.Color[]</param>
            /// <param name = "miplevel">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixels", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color[]", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public partial void SET_PIXELS(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, nint colors, System.Int32 miplevel); 
*/
            /// <summary>
            ///   System.Void SetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color[] colors)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "blockWidth">struct System.Int32</param>
            /// <param name = "blockHeight">struct System.Int32</param>
            /// <param name = "colors">class UnityEngine.Color[]</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixels", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color[]", 4)]
           public partial void SET_PIXELS(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, nint colors); 
*/
            /// <summary>
            ///   System.Void SetPixels(UnityEngine.Color[] colors, System.Int32 miplevel)
            /// </summary>
            /// <param name = "colors">class UnityEngine.Color[]</param>
            /// <param name = "miplevel">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixels", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void SET_PIXELS(nint colors, System.Int32 miplevel); 
*/
            /// <summary>
            ///   System.Void SetPixels(UnityEngine.Color[] colors)
            /// </summary>
            /// <param name = "colors">class UnityEngine.Color[]</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixels", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color[]", 0)]
           public partial void SET_PIXELS(nint colors); 
*/
            /// <summary>
            ///   System.Void SetPixels32(UnityEngine.Color32[] colors, System.Int32 miplevel)
            /// </summary>
            /// <param name = "colors">class UnityEngine.Color32[]</param>
            /// <param name = "miplevel">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixels32", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color32[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial void SET_PIXELS32(nint colors, System.Int32 miplevel); 
*/
            /// <summary>
            ///   System.Void SetPixels32(UnityEngine.Color32[] colors)
            /// </summary>
            /// <param name = "colors">class UnityEngine.Color32[]</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixels32", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color32[]", 0)]
           public partial void SET_PIXELS32(nint colors); 
*/
            /// <summary>
            ///   System.Void SetPixels32(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color32[] colors, System.Int32 miplevel)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "blockWidth">struct System.Int32</param>
            /// <param name = "blockHeight">struct System.Int32</param>
            /// <param name = "colors">class UnityEngine.Color32[]</param>
            /// <param name = "miplevel">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixels32", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color32[]", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public partial void SET_PIXELS32(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, nint colors, System.Int32 miplevel); 
*/
            /// <summary>
            ///   System.Void SetPixels32(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color32[] colors)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "blockWidth">struct System.Int32</param>
            /// <param name = "blockHeight">struct System.Int32</param>
            /// <param name = "colors">class UnityEngine.Color32[]</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixels32", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color32[]", 4)]
           public partial void SET_PIXELS32(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, nint colors); 
*/
            /// <summary>
            ///   System.Void SetPixelsImpl(System.Int32 x, System.Int32 y, System.Int32 w, System.Int32 h, UnityEngine.Color[] pixel, System.Int32 miplevel, System.Int32 frame)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "y">struct System.Int32</param>
            /// <param name = "w">struct System.Int32</param>
            /// <param name = "h">struct System.Int32</param>
            /// <param name = "pixel">class UnityEngine.Color[]</param>
            /// <param name = "miplevel">struct System.Int32</param>
            /// <param name = "frame">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPixelsImpl", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color[]", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           public partial void SET_PIXELS_IMPL(System.Int32 x, System.Int32 y, System.Int32 w, System.Int32 h, nint pixel, System.Int32 miplevel, System.Int32 frame); 
*/
            /// <summary>
            ///   System.Void UpdateExternalTexture(System.IntPtr nativeTex)
            /// </summary>
            /// <param name = "nativeTex">struct System.IntPtr</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateExternalTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 0)]
           public partial void UPDATE_EXTERNAL_TEXTURE(System.IntPtr nativeTex); 
*/
            /// <summary>
            ///   System.Boolean ValidateFormat(UnityEngine.TextureFormat format, System.Int32 width, System.Int32 height)
            /// </summary>
            /// <param name = "format">enum UnityEngine.TextureFormat</param>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ValidateFormat", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.TextureFormat", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial System.Boolean VALIDATE_FORMAT(UnityEngine.TextureFormat format, System.Int32 width, System.Int32 height); 
*/
            /// <summary>
            ///   System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 width, System.Int32 height)
            /// </summary>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ValidateFormat", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial System.Boolean VALIDATE_FORMAT(UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 width, System.Int32 height); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule"."UnityEngine"."Texture"]
        /// </summary>
        partial struct Ptr_Texture2D
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
            /// static  System.Boolean get_allowThreadedTextureCreation()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_allowThreadedTextureCreation", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.Boolean GET_ALLOW_THREADED_TEXTURE_CREATION(); 
*/
            /// <summary>
            /// static  UnityEngine.AnisotropicFiltering get_anisotropicFiltering()
            /// </summary>
            /// <returns>enum UnityEngine.AnisotropicFiltering</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_anisotropicFiltering", "UnityEngine.AnisotropicFiltering", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial UnityEngine.AnisotropicFiltering GET_ANISOTROPIC_FILTERING(); 
*/
            /// <summary>
            /// static  System.UInt64 get_currentTextureMemory()
            /// </summary>
            /// <returns>struct System.UInt64</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_currentTextureMemory", "System.UInt64", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.UInt64 GET_CURRENT_TEXTURE_MEMORY(); 
*/
            /// <summary>
            /// static  System.UInt64 get_desiredTextureMemory()
            /// </summary>
            /// <returns>struct System.UInt64</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_desiredTextureMemory", "System.UInt64", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.UInt64 GET_DESIRED_TEXTURE_MEMORY(); 
*/
            /// <summary>
            /// static  System.Int32 get_masterTextureLimit()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_masterTextureLimit", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.Int32 GET_MASTER_TEXTURE_LIMIT(); 
*/
            /// <summary>
            /// static  System.UInt64 get_nonStreamingTextureCount()
            /// </summary>
            /// <returns>struct System.UInt64</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_nonStreamingTextureCount", "System.UInt64", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.UInt64 GET_NON_STREAMING_TEXTURE_COUNT(); 
*/
            /// <summary>
            /// static  System.UInt64 get_nonStreamingTextureMemory()
            /// </summary>
            /// <returns>struct System.UInt64</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_nonStreamingTextureMemory", "System.UInt64", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.UInt64 GET_NON_STREAMING_TEXTURE_MEMORY(); 
*/
            /// <summary>
            /// static  System.UInt64 get_streamingMipmapUploadCount()
            /// </summary>
            /// <returns>struct System.UInt64</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_streamingMipmapUploadCount", "System.UInt64", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.UInt64 GET_STREAMING_MIPMAP_UPLOAD_COUNT(); 
*/
            /// <summary>
            /// static  System.UInt64 get_streamingRendererCount()
            /// </summary>
            /// <returns>struct System.UInt64</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_streamingRendererCount", "System.UInt64", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.UInt64 GET_STREAMING_RENDERER_COUNT(); 
*/
            /// <summary>
            /// static  System.UInt64 get_streamingTextureCount()
            /// </summary>
            /// <returns>struct System.UInt64</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_streamingTextureCount", "System.UInt64", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.UInt64 GET_STREAMING_TEXTURE_COUNT(); 
*/
            /// <summary>
            /// static  System.Boolean get_streamingTextureDiscardUnusedMips()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_streamingTextureDiscardUnusedMips", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.Boolean GET_STREAMING_TEXTURE_DISCARD_UNUSED_MIPS(); 
*/
            /// <summary>
            /// static  System.Boolean get_streamingTextureForceLoadAll()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_streamingTextureForceLoadAll", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.Boolean GET_STREAMING_TEXTURE_FORCE_LOAD_ALL(); 
*/
            /// <summary>
            /// static  System.UInt64 get_streamingTextureLoadingCount()
            /// </summary>
            /// <returns>struct System.UInt64</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_streamingTextureLoadingCount", "System.UInt64", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.UInt64 GET_STREAMING_TEXTURE_LOADING_COUNT(); 
*/
            /// <summary>
            /// static  System.UInt64 get_streamingTexturePendingLoadCount()
            /// </summary>
            /// <returns>struct System.UInt64</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_streamingTexturePendingLoadCount", "System.UInt64", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.UInt64 GET_STREAMING_TEXTURE_PENDING_LOAD_COUNT(); 
*/
            /// <summary>
            /// static  System.UInt64 get_targetTextureMemory()
            /// </summary>
            /// <returns>struct System.UInt64</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_targetTextureMemory", "System.UInt64", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.UInt64 GET_TARGET_TEXTURE_MEMORY(); 
*/
            /// <summary>
            /// static  System.UInt64 get_totalTextureMemory()
            /// </summary>
            /// <returns>struct System.UInt64</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_totalTextureMemory", "System.UInt64", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.UInt64 GET_TOTAL_TEXTURE_MEMORY(); 
*/
            /// <summary>
            /// static  System.Void set_allowThreadedTextureCreation(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_allowThreadedTextureCreation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public static partial void SET_ALLOW_THREADED_TEXTURE_CREATION(System.Boolean value); 
*/
            /// <summary>
            /// static  System.Void set_anisotropicFiltering(UnityEngine.AnisotropicFiltering value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.AnisotropicFiltering</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_anisotropicFiltering", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.AnisotropicFiltering", 0)]
           public static partial void SET_ANISOTROPIC_FILTERING(UnityEngine.AnisotropicFiltering value); 
*/
            /// <summary>
            /// static  System.Void set_masterTextureLimit(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_masterTextureLimit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public static partial void SET_MASTER_TEXTURE_LIMIT(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_streamingTextureDiscardUnusedMips(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_streamingTextureDiscardUnusedMips", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public static partial void SET_STREAMING_TEXTURE_DISCARD_UNUSED_MIPS(System.Boolean value); 
*/
            /// <summary>
            /// static  System.Void set_streamingTextureForceLoadAll(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_streamingTextureForceLoadAll", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public static partial void SET_STREAMING_TEXTURE_FORCE_LOAD_ALL(System.Boolean value); 
*/
            /// <summary>
            /// static  System.Void SetGlobalAnisotropicFilteringLimits(System.Int32 forcedMin, System.Int32 globalMax)
            /// </summary>
            /// <param name = "forcedMin">struct System.Int32</param>
            /// <param name = "globalMax">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetGlobalAnisotropicFilteringLimits", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public static partial void SET_GLOBAL_ANISOTROPIC_FILTERING_LIMITS(System.Int32 forcedMin, System.Int32 globalMax); 
*/
            /// <summary>
            /// static  System.Void SetStreamingTextureMaterialDebugProperties()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetStreamingTextureMaterialDebugProperties", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial void SET_STREAMING_TEXTURE_MATERIAL_DEBUG_PROPERTIES(); 
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
            ///   UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture t)
            /// </summary>
            /// <param name = "t">class UnityEngine.Texture</param>
            /// <returns>class UnityEngine.UnityException</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateNonReadableException", "UnityEngine.UnityException", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           public partial nint CREATE_NON_READABLE_EXCEPTION(nint t); 
*/
            /// <summary>
            ///   UnityEngine.ColorSpace get_activeTextureColorSpace()
            /// </summary>
            /// <returns>enum UnityEngine.ColorSpace</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_activeTextureColorSpace", "UnityEngine.ColorSpace", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.ColorSpace GET_ACTIVE_TEXTURE_COLOR_SPACE(); 
*/
            /// <summary>
            ///   System.Int32 get_anisoLevel()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_anisoLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_ANISO_LEVEL(); 
*/
            /// <summary>
            ///   UnityEngine.Rendering.TextureDimension get_dimension()
            /// </summary>
            /// <returns>enum UnityEngine.Rendering.TextureDimension</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dimension", "UnityEngine.Rendering.TextureDimension", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Rendering.TextureDimension GET_DIMENSION(); 
*/
            /// <summary>
            ///   UnityEngine.FilterMode get_filterMode()
            /// </summary>
            /// <returns>enum UnityEngine.FilterMode</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_filterMode", "UnityEngine.FilterMode", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.FilterMode GET_FILTER_MODE(); 
*/
            /// <summary>
            ///   UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat()
            /// </summary>
            /// <returns>enum UnityEngine.Experimental.Rendering.GraphicsFormat</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_graphicsFormat", "UnityEngine.Experimental.Rendering.GraphicsFormat", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Experimental.Rendering.GraphicsFormat GET_GRAPHICS_FORMAT(); 
*/
            /// <summary>
            ///   System.Int32 get_height()
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_height", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial System.Int32 GET_HEIGHT();

            /// <summary>
            ///   System.Boolean get_isReadable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isReadable", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_IS_READABLE(); 
*/
            /// <summary>
            ///   System.Single get_mipMapBias()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_mipMapBias", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Single GET_MIP_MAP_BIAS(); 
*/
            /// <summary>
            ///   System.Int32 get_mipmapCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_mipmapCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_MIPMAP_COUNT(); 
*/
            /// <summary>
            ///   UnityEngine.Vector2 get_texelSize()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_texelSize", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Vector2 GET_TEXEL_SIZE(); 
*/
            /// <summary>
            ///   System.Void get_texelSize_Injected(UnityEngine.Vector2& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.Vector2&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_texelSize_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2&", 0)]
           public partial void GET_TEXEL_SIZE_INJECTED(UnityEngine.Vector2 &ret); 
*/
            /// <summary>
            ///   System.UInt32 get_updateCount()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_updateCount", "System.UInt32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.UInt32 GET_UPDATE_COUNT(); 
*/
            /// <summary>
            ///   System.Int32 get_width()
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_width", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial System.Int32 GET_WIDTH();

            /// <summary>
            ///   UnityEngine.TextureWrapMode get_wrapMode()
            /// </summary>
            /// <returns>enum UnityEngine.TextureWrapMode</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_wrapMode", "UnityEngine.TextureWrapMode", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.TextureWrapMode GET_WRAP_MODE(); 
*/
            /// <summary>
            ///   UnityEngine.TextureWrapMode get_wrapModeU()
            /// </summary>
            /// <returns>enum UnityEngine.TextureWrapMode</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_wrapModeU", "UnityEngine.TextureWrapMode", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.TextureWrapMode GET_WRAP_MODE_U(); 
*/
            /// <summary>
            ///   UnityEngine.TextureWrapMode get_wrapModeV()
            /// </summary>
            /// <returns>enum UnityEngine.TextureWrapMode</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_wrapModeV", "UnityEngine.TextureWrapMode", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.TextureWrapMode GET_WRAP_MODE_V(); 
*/
            /// <summary>
            ///   UnityEngine.TextureWrapMode get_wrapModeW()
            /// </summary>
            /// <returns>enum UnityEngine.TextureWrapMode</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_wrapModeW", "UnityEngine.TextureWrapMode", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.TextureWrapMode GET_WRAP_MODE_W(); 
*/
            /// <summary>
            ///   System.Int32 GetDataHeight()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDataHeight", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_DATA_HEIGHT(); 
*/
            /// <summary>
            ///   System.Int32 GetDataWidth()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDataWidth", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_DATA_WIDTH(); 
*/
            /// <summary>
            ///   UnityEngine.Rendering.TextureDimension GetDimension()
            /// </summary>
            /// <returns>enum UnityEngine.Rendering.TextureDimension</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDimension", "UnityEngine.Rendering.TextureDimension", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Rendering.TextureDimension GET_DIMENSION(); 
*/
            /// <summary>
            ///   System.Int32 GetNativeTextureID()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNativeTextureID", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_NATIVE_TEXTURE_ID(); 
*/
            /// <summary>
            ///   System.IntPtr GetNativeTexturePtr()
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNativeTexturePtr", "System.IntPtr", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.IntPtr GET_NATIVE_TEXTURE_PTR(); 
*/
            /// <summary>
            ///   System.Int32 GetPixelDataOffset(System.Int32 mipLevel, System.Int32 element)
            /// </summary>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <param name = "element">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixelDataOffset", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Int32 GET_PIXEL_DATA_OFFSET(System.Int32 mipLevel, System.Int32 element); 
*/
            /// <summary>
            ///   System.Int32 GetPixelDataSize(System.Int32 mipLevel, System.Int32 element)
            /// </summary>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <param name = "element">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPixelDataSize", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Int32 GET_PIXEL_DATA_SIZE(System.Int32 mipLevel, System.Int32 element); 
*/
            /// <summary>
            ///   System.Void IncrementUpdateCount()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IncrementUpdateCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial void INCREMENT_UPDATE_COUNT(); 
*/
            /// <summary>
            ///   System.Int32 Internal_GetActiveTextureColorSpace()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_GetActiveTextureColorSpace", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 INTERNAL_GET_ACTIVE_TEXTURE_COLOR_SPACE(); 
*/
            /// <summary>
            ///   System.Void set_anisoLevel(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_anisoLevel", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void SET_ANISO_LEVEL(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_dimension(UnityEngine.Rendering.TextureDimension value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.Rendering.TextureDimension</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_dimension", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.TextureDimension", 0)]
           public partial void SET_DIMENSION(UnityEngine.Rendering.TextureDimension value); 
*/
            /// <summary>
            ///   System.Void set_filterMode(UnityEngine.FilterMode value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.FilterMode</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_filterMode", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FilterMode", 0)]
           public partial void SET_FILTER_MODE(UnityEngine.FilterMode value); 
*/
            /// <summary>
            ///   System.Void set_height(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_height", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void SET_HEIGHT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_mipMapBias(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_mipMapBias", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
           public partial void SET_MIP_MAP_BIAS(System.Single value); 
*/
            /// <summary>
            ///   System.Void set_width(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_width", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void SET_WIDTH(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_wrapMode(UnityEngine.TextureWrapMode value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.TextureWrapMode</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_wrapMode", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.TextureWrapMode", 0)]
           public partial void SET_WRAP_MODE(UnityEngine.TextureWrapMode value); 
*/
            /// <summary>
            ///   System.Void set_wrapModeU(UnityEngine.TextureWrapMode value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.TextureWrapMode</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_wrapModeU", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.TextureWrapMode", 0)]
           public partial void SET_WRAP_MODE_U(UnityEngine.TextureWrapMode value); 
*/
            /// <summary>
            ///   System.Void set_wrapModeV(UnityEngine.TextureWrapMode value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.TextureWrapMode</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_wrapModeV", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.TextureWrapMode", 0)]
           public partial void SET_WRAP_MODE_V(UnityEngine.TextureWrapMode value); 
*/
            /// <summary>
            ///   System.Void set_wrapModeW(UnityEngine.TextureWrapMode value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.TextureWrapMode</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_wrapModeW", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.TextureWrapMode", 0)]
           public partial void SET_WRAP_MODE_W(UnityEngine.TextureWrapMode value); 
*/
            /// <summary>
            ///   System.Boolean ValidateFormat(UnityEngine.RenderTextureFormat format)
            /// </summary>
            /// <param name = "format">enum UnityEngine.RenderTextureFormat</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ValidateFormat", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureFormat", 0)]
           public partial System.Boolean VALIDATE_FORMAT(UnityEngine.RenderTextureFormat format); 
*/
            /// <summary>
            ///   System.Boolean ValidateFormat(UnityEngine.TextureFormat format)
            /// </summary>
            /// <param name = "format">enum UnityEngine.TextureFormat</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ValidateFormat", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.TextureFormat", 0)]
           public partial System.Boolean VALIDATE_FORMAT(UnityEngine.TextureFormat format); 
*/
            /// <summary>
            ///   System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
            /// </summary>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "usage">enum UnityEngine.Experimental.Rendering.FormatUsage</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ValidateFormat", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.FormatUsage", 1)]
           public partial System.Boolean VALIDATE_FORMAT(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule"."UnityEngine"."Object"]
        /// </summary>
        partial struct Ptr_Texture2D
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
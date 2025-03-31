namespace Maple.MonoGameAssistant.MetadataUnity
{
    /// <summary>
    /// class ["UnityEngine.CoreModule"."UnityEngine"."RenderTexture"]
    /// [UnityEngine.Texture]=>[UnityEngine.Object]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_RenderTexture>, Ptr_RenderTexture>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("UnityEngine.CoreModule", "UnityEngine", "RenderTexture", "UnityEngine.RenderTexture")]
    public partial class RenderTexture
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_RenderTexture(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_RenderTexture(System.IntPtr ptr) => new Ptr_RenderTexture(ptr);
            public static implicit operator System.IntPtr(Ptr_RenderTexture ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_RenderTexture ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule"."UnityEngine"."RenderTexture"]
        /// </summary>
        partial struct Ptr_RenderTexture
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
        /// class ["UnityEngine.CoreModule"."UnityEngine"."RenderTexture"]
        /// </summary>
        partial struct Ptr_RenderTexture
        {
            /// <summary>
            /// static  UnityEngine.RenderTexture get_active()
            /// </summary>
            /// <returns>class UnityEngine.RenderTexture</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_active", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public static partial RenderTexture.Ptr_RenderTexture GET_ACTIVE();

            /// <summary>
            /// static  System.Boolean get_enabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_enabled", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.Boolean GET_ENABLED(); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetActive()
            /// </summary>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetActive", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial nint GET_ACTIVE(); 
*/
            /// <summary>
            /// static  UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.RenderTextureFormat renderTextureFormat, UnityEngine.RenderTextureReadWrite readWrite)
            /// </summary>
            /// <param name = "renderTextureFormat">enum UnityEngine.RenderTextureFormat</param>
            /// <param name = "readWrite">enum UnityEngine.RenderTextureReadWrite</param>
            /// <returns>enum UnityEngine.Experimental.Rendering.GraphicsFormat</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCompatibleFormat", "UnityEngine.Experimental.Rendering.GraphicsFormat", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureFormat", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureReadWrite", 1)]
           public static partial UnityEngine.Experimental.Rendering.GraphicsFormat GET_COMPATIBLE_FORMAT(UnityEngine.RenderTextureFormat renderTextureFormat, UnityEngine.RenderTextureReadWrite readWrite); 
*/
            /// <summary>
            /// static  UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(System.Int32 depthBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat)
            /// </summary>
            /// <param name = "depthBits">struct System.Int32</param>
            /// <param name = "colorFormat">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <returns>enum UnityEngine.Experimental.Rendering.GraphicsFormat</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDepthStencilFormatLegacy", "UnityEngine.Experimental.Rendering.GraphicsFormat", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 1)]
           public static partial UnityEngine.Experimental.Rendering.GraphicsFormat GET_DEPTH_STENCIL_FORMAT_LEGACY(System.Int32 depthBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc)
            /// </summary>
            /// <param name = "desc">struct UnityEngine.RenderTextureDescriptor</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureDescriptor", 0)]
           public static partial nint GET_TEMPORARY(UnityEngine.RenderTextureDescriptor desc); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, System.Boolean useDynamicScale)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depthBuffer">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "antiAliasing">struct System.Int32</param>
            /// <param name = "memorylessMode">enum UnityEngine.RenderTextureMemoryless</param>
            /// <param name = "vrUsage">enum UnityEngine.VRTextureUsage</param>
            /// <param name = "useDynamicScale">struct System.Boolean</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureMemoryless", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.VRTextureUsage", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           public static partial nint GET_TEMPORARY(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, System.Boolean useDynamicScale); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depthBuffer">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "antiAliasing">struct System.Int32</param>
            /// <param name = "memorylessMode">enum UnityEngine.RenderTextureMemoryless</param>
            /// <param name = "vrUsage">enum UnityEngine.VRTextureUsage</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureMemoryless", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.VRTextureUsage", 6)]
           public static partial nint GET_TEMPORARY(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depthBuffer">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "antiAliasing">struct System.Int32</param>
            /// <param name = "memorylessMode">enum UnityEngine.RenderTextureMemoryless</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureMemoryless", 5)]
           public static partial nint GET_TEMPORARY(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 antiAliasing)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depthBuffer">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "antiAliasing">struct System.Int32</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial nint GET_TEMPORARY(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 antiAliasing); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depthBuffer">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 3)]
           public static partial nint GET_TEMPORARY(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, System.Boolean useDynamicScale)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depthBuffer">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.RenderTextureFormat</param>
            /// <param name = "readWrite">enum UnityEngine.RenderTextureReadWrite</param>
            /// <param name = "antiAliasing">struct System.Int32</param>
            /// <param name = "memorylessMode">enum UnityEngine.RenderTextureMemoryless</param>
            /// <param name = "vrUsage">enum UnityEngine.VRTextureUsage</param>
            /// <param name = "useDynamicScale">struct System.Boolean</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureFormat", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureReadWrite", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureMemoryless", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.VRTextureUsage", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           public static partial nint GET_TEMPORARY(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, System.Boolean useDynamicScale); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depthBuffer">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.RenderTextureFormat</param>
            /// <param name = "readWrite">enum UnityEngine.RenderTextureReadWrite</param>
            /// <param name = "antiAliasing">struct System.Int32</param>
            /// <param name = "memorylessMode">enum UnityEngine.RenderTextureMemoryless</param>
            /// <param name = "vrUsage">enum UnityEngine.VRTextureUsage</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureFormat", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureReadWrite", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureMemoryless", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.VRTextureUsage", 7)]
           public static partial nint GET_TEMPORARY(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depthBuffer">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.RenderTextureFormat</param>
            /// <param name = "readWrite">enum UnityEngine.RenderTextureReadWrite</param>
            /// <param name = "antiAliasing">struct System.Int32</param>
            /// <param name = "memorylessMode">enum UnityEngine.RenderTextureMemoryless</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureFormat", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureReadWrite", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureMemoryless", 6)]
           public static partial nint GET_TEMPORARY(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depthBuffer">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.RenderTextureFormat</param>
            /// <param name = "readWrite">enum UnityEngine.RenderTextureReadWrite</param>
            /// <param name = "antiAliasing">struct System.Int32</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureFormat", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureReadWrite", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial nint GET_TEMPORARY(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depthBuffer">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.RenderTextureFormat</param>
            /// <param name = "readWrite">enum UnityEngine.RenderTextureReadWrite</param>
            /// <returns>class UnityEngine.RenderTexture</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureFormat", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureReadWrite", 4)]
            public static partial RenderTexture.Ptr_RenderTexture GET_TEMPORARY(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite);

            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depthBuffer">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.RenderTextureFormat</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureFormat", 3)]
           public static partial nint GET_TEMPORARY(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depthBuffer">struct System.Int32</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public static partial nint GET_TEMPORARY(System.Int32 width, System.Int32 height, System.Int32 depthBuffer); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public static partial nint GET_TEMPORARY(System.Int32 width, System.Int32 height); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary_Internal(UnityEngine.RenderTextureDescriptor desc)
            /// </summary>
            /// <param name = "desc">struct UnityEngine.RenderTextureDescriptor</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary_Internal", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureDescriptor", 0)]
           public static partial nint GET_TEMPORARY_INTERNAL(UnityEngine.RenderTextureDescriptor desc); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporary_Internal_Injected(UnityEngine.RenderTextureDescriptor& desc)
            /// </summary>
            /// <param name = "desc">struct UnityEngine.RenderTextureDescriptor&</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporary_Internal_Injected", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureDescriptor&", 0)]
           public static partial nint GET_TEMPORARY_INTERNAL_INJECTED(UnityEngine.RenderTextureDescriptor &desc); 
*/
            /// <summary>
            /// static  UnityEngine.RenderTexture GetTemporaryImpl(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, System.Boolean useDynamicScale)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depthBuffer">struct System.Int32</param>
            /// <param name = "colorFormat">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "antiAliasing">struct System.Int32</param>
            /// <param name = "memorylessMode">enum UnityEngine.RenderTextureMemoryless</param>
            /// <param name = "vrUsage">enum UnityEngine.VRTextureUsage</param>
            /// <param name = "useDynamicScale">struct System.Boolean</param>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTemporaryImpl", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureMemoryless", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.VRTextureUsage", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           public static partial nint GET_TEMPORARY_IMPL(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, System.Boolean useDynamicScale); 
*/
            /// <summary>
            /// static  System.Void Internal_Create(UnityEngine.RenderTexture rt)
            /// </summary>
            /// <param name = "rt">class UnityEngine.RenderTexture</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_Create", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 0)]
           public static partial void INTERNAL_CREATE(nint rt); 
*/
            /// <summary>
            /// static  System.Void ReleaseTemporary(UnityEngine.RenderTexture temp)
            /// </summary>
            /// <param name = "temp">class UnityEngine.RenderTexture</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReleaseTemporary", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 0)]
            public static partial void RELEASE_TEMPORARY(RenderTexture.Ptr_RenderTexture temp);

            /// <summary>
            /// static  System.Void set_active(UnityEngine.RenderTexture value)
            /// </summary>
            /// <param name = "value">class UnityEngine.RenderTexture</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_active", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 0)]
            public static partial void SET_ACTIVE(RenderTexture.Ptr_RenderTexture value);

            /// <summary>
            /// static  System.Void set_enabled(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_enabled", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public static partial void SET_ENABLED(System.Boolean value); 
*/
            /// <summary>
            /// static  System.Void SetActive(UnityEngine.RenderTexture rt)
            /// </summary>
            /// <param name = "rt">class UnityEngine.RenderTexture</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetActive", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 0)]
           public static partial void SET_ACTIVE(nint rt); 
*/
            /// <summary>
            /// static  System.Boolean SupportsStencil(UnityEngine.RenderTexture rt)
            /// </summary>
            /// <param name = "rt">class UnityEngine.RenderTexture</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SupportsStencil", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 0)]
           public static partial System.Boolean SUPPORTS_STENCIL(nint rt); 
*/
            /// <summary>
            /// static  System.Void ValidateRenderTextureDesc(UnityEngine.RenderTextureDescriptor desc)
            /// </summary>
            /// <param name = "desc">struct UnityEngine.RenderTextureDescriptor</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ValidateRenderTextureDesc", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureDescriptor", 0)]
           public static partial void VALIDATE_RENDER_TEXTURE_DESC(UnityEngine.RenderTextureDescriptor desc); 
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
            ///   System.Void .ctor(UnityEngine.RenderTextureDescriptor desc)
            /// </summary>
            /// <param name = "desc">struct UnityEngine.RenderTextureDescriptor</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureDescriptor", 0)]
           public partial void CTOR(UnityEngine.RenderTextureDescriptor desc); 
*/
            /// <summary>
            ///   System.Void .ctor(UnityEngine.RenderTexture textureToCopy)
            /// </summary>
            /// <param name = "textureToCopy">class UnityEngine.RenderTexture</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 0)]
           public partial void CTOR(nint textureToCopy); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.DefaultFormat format)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depth">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.DefaultFormat</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.DefaultFormat", 3)]
           public partial void CTOR(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.DefaultFormat format); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depth">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 3)]
           public partial void CTOR(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 mipCount)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depth">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "mipCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public partial void CTOR(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 mipCount); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, System.Int32 mipCount)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "colorFormat">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "depthStencilFormat">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "mipCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public partial void CTOR(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, System.Int32 mipCount); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "colorFormat">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "depthStencilFormat">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 3)]
           public partial void CTOR(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depth">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.RenderTextureFormat</param>
            /// <param name = "readWrite">enum UnityEngine.RenderTextureReadWrite</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureFormat", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureReadWrite", 4)]
           public partial void CTOR(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depth">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.RenderTextureFormat</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureFormat", 3)]
           public partial void CTOR(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depth">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial void CTOR(System.Int32 width, System.Int32 height, System.Int32 depth); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, System.Int32 mipCount)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depth">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.RenderTextureFormat</param>
            /// <param name = "mipCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureFormat", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public partial void CTOR(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, System.Int32 mipCount); 
*/
            /// <summary>
            ///   System.Void ConvertToEquirect(UnityEngine.RenderTexture equirect, UnityEngine.Camera.MonoOrStereoscopicEye eye)
            /// </summary>
            /// <param name = "equirect">class UnityEngine.RenderTexture</param>
            /// <param name = "eye">enum UnityEngine.Camera.MonoOrStereoscopicEye</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ConvertToEquirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera.MonoOrStereoscopicEye", 1)]
           public partial void CONVERT_TO_EQUIRECT(nint equirect, UnityEngine.Camera.MonoOrStereoscopicEye eye); 
*/
            /// <summary>
            ///   System.Boolean Create()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Create", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean CREATE(); 
*/
            /// <summary>
            ///   System.Void DiscardContents(System.Boolean discardColor, System.Boolean discardDepth)
            /// </summary>
            /// <param name = "discardColor">struct System.Boolean</param>
            /// <param name = "discardDepth">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DiscardContents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial void DISCARD_CONTENTS(System.Boolean discardColor, System.Boolean discardDepth); 
*/
            /// <summary>
            ///   System.Void DiscardContents()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DiscardContents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial void DISCARD_CONTENTS(); 
*/
            /// <summary>
            ///   System.Void GenerateMips()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateMips", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial void GENERATE_MIPS(); 
*/
            /// <summary>
            ///   System.Int32 get_antiAliasing()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_antiAliasing", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_ANTI_ALIASING(); 
*/
            /// <summary>
            ///   System.Boolean get_autoGenerateMips()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_autoGenerateMips", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_AUTO_GENERATE_MIPS(); 
*/
            /// <summary>
            ///   System.Boolean get_bindTextureMS()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_bindTextureMS", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_BIND_TEXTURE_MS(); 
*/
            /// <summary>
            ///   UnityEngine.RenderBuffer get_colorBuffer()
            /// </summary>
            /// <returns>struct UnityEngine.RenderBuffer</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_colorBuffer", "UnityEngine.RenderBuffer", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.RenderBuffer GET_COLOR_BUFFER(); 
*/
            /// <summary>
            ///   System.Int32 get_depth()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_depth", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_DEPTH(); 
*/
            /// <summary>
            ///   UnityEngine.RenderBuffer get_depthBuffer()
            /// </summary>
            /// <returns>struct UnityEngine.RenderBuffer</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_depthBuffer", "UnityEngine.RenderBuffer", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.RenderBuffer GET_DEPTH_BUFFER(); 
*/
            /// <summary>
            ///   UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat()
            /// </summary>
            /// <returns>enum UnityEngine.Experimental.Rendering.GraphicsFormat</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_depthStencilFormat", "UnityEngine.Experimental.Rendering.GraphicsFormat", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Experimental.Rendering.GraphicsFormat GET_DEPTH_STENCIL_FORMAT(); 
*/
            /// <summary>
            ///   UnityEngine.RenderTextureDescriptor get_descriptor()
            /// </summary>
            /// <returns>struct UnityEngine.RenderTextureDescriptor</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_descriptor", "UnityEngine.RenderTextureDescriptor", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.RenderTextureDescriptor GET_DESCRIPTOR(); 
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
            ///   System.Boolean get_enableRandomWrite()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_enableRandomWrite", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_ENABLE_RANDOM_WRITE(); 
*/
            /// <summary>
            ///   UnityEngine.RenderTextureFormat get_format()
            /// </summary>
            /// <returns>enum UnityEngine.RenderTextureFormat</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_format", "UnityEngine.RenderTextureFormat", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.RenderTextureFormat GET_FORMAT(); 
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
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_height", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_HEIGHT(); 
*/
            /// <summary>
            ///   System.Boolean get_isCubemap()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isCubemap", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_IS_CUBEMAP(); 
*/
            /// <summary>
            ///   System.Boolean get_isPowerOfTwo()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isPowerOfTwo", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_IS_POWER_OF_TWO(); 
*/
            /// <summary>
            ///   System.Boolean get_isVolume()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isVolume", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_IS_VOLUME(); 
*/
            /// <summary>
            ///   UnityEngine.RenderTextureMemoryless get_memorylessMode()
            /// </summary>
            /// <returns>enum UnityEngine.RenderTextureMemoryless</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_memorylessMode", "UnityEngine.RenderTextureMemoryless", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.RenderTextureMemoryless GET_MEMORYLESS_MODE(); 
*/
            /// <summary>
            ///   System.Boolean get_sRGB()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_sRGB", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_S_RGB(); 
*/
            /// <summary>
            ///   UnityEngine.Experimental.Rendering.GraphicsFormat get_stencilFormat()
            /// </summary>
            /// <returns>enum UnityEngine.Experimental.Rendering.GraphicsFormat</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_stencilFormat", "UnityEngine.Experimental.Rendering.GraphicsFormat", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Experimental.Rendering.GraphicsFormat GET_STENCIL_FORMAT(); 
*/
            /// <summary>
            ///   System.Boolean get_useDynamicScale()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_useDynamicScale", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_USE_DYNAMIC_SCALE(); 
*/
            /// <summary>
            ///   System.Boolean get_useMipMap()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_useMipMap", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_USE_MIP_MAP(); 
*/
            /// <summary>
            ///   System.Int32 get_volumeDepth()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_volumeDepth", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_VOLUME_DEPTH(); 
*/
            /// <summary>
            ///   UnityEngine.VRTextureUsage get_vrUsage()
            /// </summary>
            /// <returns>enum UnityEngine.VRTextureUsage</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_vrUsage", "UnityEngine.VRTextureUsage", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.VRTextureUsage GET_VR_USAGE(); 
*/
            /// <summary>
            ///   System.Int32 get_width()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_width", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Int32 GET_WIDTH(); 
*/
            /// <summary>
            ///   UnityEngine.RenderBuffer GetColorBuffer()
            /// </summary>
            /// <returns>struct UnityEngine.RenderBuffer</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetColorBuffer", "UnityEngine.RenderBuffer", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.RenderBuffer GET_COLOR_BUFFER(); 
*/
            /// <summary>
            ///   System.Void GetColorBuffer_Injected(UnityEngine.RenderBuffer& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.RenderBuffer&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetColorBuffer_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer&", 0)]
           public partial void GET_COLOR_BUFFER_INJECTED(UnityEngine.RenderBuffer &ret); 
*/
            /// <summary>
            ///   UnityEngine.RenderBuffer GetDepthBuffer()
            /// </summary>
            /// <returns>struct UnityEngine.RenderBuffer</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDepthBuffer", "UnityEngine.RenderBuffer", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.RenderBuffer GET_DEPTH_BUFFER(); 
*/
            /// <summary>
            ///   System.Void GetDepthBuffer_Injected(UnityEngine.RenderBuffer& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.RenderBuffer&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDepthBuffer_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer&", 0)]
           public partial void GET_DEPTH_BUFFER_INJECTED(UnityEngine.RenderBuffer &ret); 
*/
            /// <summary>
            ///   UnityEngine.RenderTextureDescriptor GetDescriptor()
            /// </summary>
            /// <returns>struct UnityEngine.RenderTextureDescriptor</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDescriptor", "UnityEngine.RenderTextureDescriptor", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.RenderTextureDescriptor GET_DESCRIPTOR(); 
*/
            /// <summary>
            ///   System.Void GetDescriptor_Injected(UnityEngine.RenderTextureDescriptor& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.RenderTextureDescriptor&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDescriptor_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureDescriptor&", 0)]
           public partial void GET_DESCRIPTOR_INJECTED(UnityEngine.RenderTextureDescriptor &ret); 
*/
            /// <summary>
            ///   System.Boolean GetIsPowerOfTwo()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetIsPowerOfTwo", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean GET_IS_POWER_OF_TWO(); 
*/
            /// <summary>
            ///   System.IntPtr GetNativeDepthBufferPtr()
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNativeDepthBufferPtr", "System.IntPtr", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.IntPtr GET_NATIVE_DEPTH_BUFFER_PTR(); 
*/
            /// <summary>
            ///   UnityEngine.Vector2 GetTexelOffset()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTexelOffset", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial UnityEngine.Vector2 GET_TEXEL_OFFSET(); 
*/
            /// <summary>
            ///   System.Void Initialize(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 mipCount)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "depth">struct System.Int32</param>
            /// <param name = "format">enum UnityEngine.RenderTextureFormat</param>
            /// <param name = "readWrite">enum UnityEngine.RenderTextureReadWrite</param>
            /// <param name = "mipCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Initialize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureFormat", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureReadWrite", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public partial void INITIALIZE(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 mipCount); 
*/
            /// <summary>
            ///   System.Boolean IsCreated()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsCreated", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial System.Boolean IS_CREATED(); 
*/
            /// <summary>
            ///   System.Void MarkRestoreExpected()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MarkRestoreExpected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial void MARK_RESTORE_EXPECTED(); 
*/
            /// <summary>
            ///   System.Void Release()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Release", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial void RELEASE(); 
*/
            /// <summary>
            ///   System.Void ResolveAA()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResolveAA", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial void RESOLVE_AA(); 
*/
            /// <summary>
            ///   System.Void ResolveAATo(UnityEngine.RenderTexture rt)
            /// </summary>
            /// <param name = "rt">class UnityEngine.RenderTexture</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResolveAATo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 0)]
           public partial void RESOLVE_AA_TO(nint rt); 
*/
            /// <summary>
            ///   System.Void ResolveAntiAliasedSurface()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResolveAntiAliasedSurface", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial void RESOLVE_ANTI_ALIASED_SURFACE(); 
*/
            /// <summary>
            ///   System.Void ResolveAntiAliasedSurface(UnityEngine.RenderTexture target)
            /// </summary>
            /// <param name = "target">class UnityEngine.RenderTexture</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResolveAntiAliasedSurface", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 0)]
           public partial void RESOLVE_ANTI_ALIASED_SURFACE(nint target); 
*/
            /// <summary>
            ///   System.Void set_antiAliasing(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_antiAliasing", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void SET_ANTI_ALIASING(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_autoGenerateMips(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_autoGenerateMips", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void SET_AUTO_GENERATE_MIPS(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_bindTextureMS(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_bindTextureMS", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void SET_BIND_TEXTURE_MS(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_depth(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_depth", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void SET_DEPTH(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_depthStencilFormat", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 0)]
           public partial void SET_DEPTH_STENCIL_FORMAT(UnityEngine.Experimental.Rendering.GraphicsFormat value); 
*/
            /// <summary>
            ///   System.Void set_descriptor(UnityEngine.RenderTextureDescriptor value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.RenderTextureDescriptor</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_descriptor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureDescriptor", 0)]
           public partial void SET_DESCRIPTOR(UnityEngine.RenderTextureDescriptor value); 
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
            ///   System.Void set_enableRandomWrite(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_enableRandomWrite", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void SET_ENABLE_RANDOM_WRITE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_format(UnityEngine.RenderTextureFormat value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.RenderTextureFormat</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_format", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureFormat", 0)]
           public partial void SET_FORMAT(UnityEngine.RenderTextureFormat value); 
*/
            /// <summary>
            ///   System.Void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_graphicsFormat", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 0)]
           public partial void SET_GRAPHICS_FORMAT(UnityEngine.Experimental.Rendering.GraphicsFormat value); 
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
            ///   System.Void set_isCubemap(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_isCubemap", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void SET_IS_CUBEMAP(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_isPowerOfTwo(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_isPowerOfTwo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void SET_IS_POWER_OF_TWO(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_isVolume(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_isVolume", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void SET_IS_VOLUME(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_memorylessMode(UnityEngine.RenderTextureMemoryless value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.RenderTextureMemoryless</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_memorylessMode", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureMemoryless", 0)]
           public partial void SET_MEMORYLESS_MODE(UnityEngine.RenderTextureMemoryless value); 
*/
            /// <summary>
            ///   System.Void set_stencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_stencilFormat", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 0)]
           public partial void SET_STENCIL_FORMAT(UnityEngine.Experimental.Rendering.GraphicsFormat value); 
*/
            /// <summary>
            ///   System.Void set_useDynamicScale(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_useDynamicScale", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void SET_USE_DYNAMIC_SCALE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_useMipMap(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_useMipMap", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void SET_USE_MIP_MAP(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_volumeDepth(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_volumeDepth", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void SET_VOLUME_DEPTH(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_vrUsage(UnityEngine.VRTextureUsage value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.VRTextureUsage</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_vrUsage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.VRTextureUsage", 0)]
           public partial void SET_VR_USAGE(UnityEngine.VRTextureUsage value); 
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
            ///   System.Void SetGlobalShaderProperty(System.String propertyName)
            /// </summary>
            /// <param name = "propertyName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetGlobalShaderProperty", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial void SET_GLOBAL_SHADER_PROPERTY(nint propertyName); 
*/
            /// <summary>
            ///   System.Void SetMipMapCount(System.Int32 count)
            /// </summary>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetMipMapCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void SET_MIP_MAP_COUNT(System.Int32 count); 
*/
            /// <summary>
            ///   System.Void SetRenderTextureDescriptor(UnityEngine.RenderTextureDescriptor desc)
            /// </summary>
            /// <param name = "desc">struct UnityEngine.RenderTextureDescriptor</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTextureDescriptor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureDescriptor", 0)]
           public partial void SET_RENDER_TEXTURE_DESCRIPTOR(UnityEngine.RenderTextureDescriptor desc); 
*/
            /// <summary>
            ///   System.Void SetRenderTextureDescriptor_Injected(UnityEngine.RenderTextureDescriptor& desc)
            /// </summary>
            /// <param name = "desc">struct UnityEngine.RenderTextureDescriptor&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTextureDescriptor_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTextureDescriptor&", 0)]
           public partial void SET_RENDER_TEXTURE_DESCRIPTOR_INJECTED(UnityEngine.RenderTextureDescriptor &desc); 
*/
            /// <summary>
            ///   System.Void SetShadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode samplingMode)
            /// </summary>
            /// <param name = "samplingMode">enum UnityEngine.Rendering.ShadowSamplingMode</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetShadowSamplingMode", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowSamplingMode", 0)]
           public partial void SET_SHADOW_SAMPLING_MODE(UnityEngine.Rendering.ShadowSamplingMode samplingMode); 
*/
            /// <summary>
            ///   System.Void SetSRGBReadWrite(System.Boolean srgb)
            /// </summary>
            /// <param name = "srgb">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSRGBReadWrite", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void SET_SRGB_READ_WRITE(System.Boolean srgb); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule"."UnityEngine"."Texture"]
        /// </summary>
        partial struct Ptr_RenderTexture
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
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_height", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial System.Int32 GET_HEIGHT(); 
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
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_width", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial System.Int32 GET_WIDTH(); 
*/
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
        partial struct Ptr_RenderTexture
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
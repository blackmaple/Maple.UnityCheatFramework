namespace Maple.MonoGameAssistant.MetadataUnity
{
    /// <summary>
    /// class ["UnityEngine.CoreModule"."UnityEngine"."Graphics"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Graphics>, Ptr_Graphics>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("UnityEngine.CoreModule", "UnityEngine", "Graphics", "UnityEngine.Graphics")]
    public partial class Graphics
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Graphics(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_Graphics(System.IntPtr ptr) => new Ptr_Graphics(ptr);
            public static implicit operator System.IntPtr(Ptr_Graphics ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_Graphics ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule"."UnityEngine"."Graphics"]
        /// </summary>
        partial struct Ptr_Graphics
        {
            /// <summary>
            /// 0x0 System.Int32 kMaxDrawMeshInstanceCount
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("kMaxDrawMeshInstanceCount", "System.Int32")]
            public static partial System.Int32 K_MAX_DRAW_MESH_INSTANCE_COUNT { get; set; } 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule"."UnityEngine"."Graphics"]
        /// </summary>
        partial struct Ptr_Graphics
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
            /// static  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           public static partial void BLIT(nint source, nint dest); 
*/
            /// <summary>
            /// static  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "sourceDepthSlice">struct System.Int32</param>
            /// <param name = "destDepthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void BLIT(nint source, nint dest, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice); 
*/
            /// <summary>
            /// static  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "scale">struct UnityEngine.Vector2</param>
            /// <param name = "offset">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 3)]
           public static partial void BLIT(nint source, nint dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset); 
*/
            /// <summary>
            /// static  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "scale">struct UnityEngine.Vector2</param>
            /// <param name = "offset">struct UnityEngine.Vector2</param>
            /// <param name = "sourceDepthSlice">struct System.Int32</param>
            /// <param name = "destDepthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void BLIT(nint source, nint dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice); 
*/
            /// <summary>
            /// static  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 pass)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "pass">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void BLIT(nint source, nint dest, nint mat, System.Int32 pass); 
*/
            /// <summary>
            /// static  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 pass, System.Int32 destDepthSlice)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "pass">struct System.Int32</param>
            /// <param name = "destDepthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void BLIT(nint source, nint dest, nint mat, System.Int32 pass, System.Int32 destDepthSlice); 
*/
            /// <summary>
            /// static  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           public static partial void BLIT(nint source, nint dest, nint mat); 
*/
            /// <summary>
            /// static  System.Void Blit(UnityEngine.Texture source, UnityEngine.Material mat, System.Int32 pass)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "pass">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public static partial void BLIT(nint source, nint mat, System.Int32 pass); 
*/
            /// <summary>
            /// static  System.Void Blit(UnityEngine.Texture source, UnityEngine.Material mat, System.Int32 pass, System.Int32 destDepthSlice)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "pass">struct System.Int32</param>
            /// <param name = "destDepthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void BLIT(nint source, nint mat, System.Int32 pass, System.Int32 destDepthSlice); 
*/
            /// <summary>
            /// static  System.Void Blit(UnityEngine.Texture source, UnityEngine.Material mat)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 1)]
           public static partial void BLIT(nint source, nint mat); 
*/
            /// <summary>
            /// static  System.Void Blit2(UnityEngine.Texture source, UnityEngine.RenderTexture dest)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit2", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
            public static partial void BLIT2(nint source, nint dest);

            /// <summary>
            /// static  System.Void Blit3(UnityEngine.Texture source, UnityEngine.RenderTexture dest, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "sourceDepthSlice">struct System.Int32</param>
            /// <param name = "destDepthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void BLIT3(nint source, nint dest, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice); 
*/
            /// <summary>
            /// static  System.Void Blit4(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "scale">struct UnityEngine.Vector2</param>
            /// <param name = "offset">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit4", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 3)]
           public static partial void BLIT4(nint source, nint dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset); 
*/
            /// <summary>
            /// static  System.Void Blit4_Injected(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2& scale, UnityEngine.Vector2& offset)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "scale">struct UnityEngine.Vector2&</param>
            /// <param name = "offset">struct UnityEngine.Vector2&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit4_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2&", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2&", 3)]
           public static partial void BLIT4_INJECTED(nint source, nint dest, UnityEngine.Vector2 &scale, UnityEngine.Vector2 &offset); 
*/
            /// <summary>
            /// static  System.Void Blit5(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "scale">struct UnityEngine.Vector2</param>
            /// <param name = "offset">struct UnityEngine.Vector2</param>
            /// <param name = "sourceDepthSlice">struct System.Int32</param>
            /// <param name = "destDepthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit5", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void BLIT5(nint source, nint dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice); 
*/
            /// <summary>
            /// static  System.Void Blit5_Injected(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2& scale, UnityEngine.Vector2& offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "scale">struct UnityEngine.Vector2&</param>
            /// <param name = "offset">struct UnityEngine.Vector2&</param>
            /// <param name = "sourceDepthSlice">struct System.Int32</param>
            /// <param name = "destDepthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Blit5_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2&", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2&", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void BLIT5_INJECTED(nint source, nint dest, UnityEngine.Vector2 &scale, UnityEngine.Vector2 &offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice); 
*/
            /// <summary>
            /// static  System.Void BlitMultiTap(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, UnityEngine.Vector2[] offsets)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "offsets">class UnityEngine.Vector2[]</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BlitMultiTap", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2[]", 3)]
           public static partial void BLIT_MULTI_TAP(nint source, nint dest, nint mat, nint offsets); 
*/
            /// <summary>
            /// static  System.Void BlitMultiTap(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 destDepthSlice, UnityEngine.Vector2[] offsets)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "destDepthSlice">struct System.Int32</param>
            /// <param name = "offsets">class UnityEngine.Vector2[]</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BlitMultiTap", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2[]", 4)]
           public static partial void BLIT_MULTI_TAP(nint source, nint dest, nint mat, System.Int32 destDepthSlice, nint offsets); 
*/
            /// <summary>
            /// static  System.Void CheckLoadActionValid(UnityEngine.Rendering.RenderBufferLoadAction load, System.String bufferType)
            /// </summary>
            /// <param name = "load">enum UnityEngine.Rendering.RenderBufferLoadAction</param>
            /// <param name = "bufferType">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckLoadActionValid", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.RenderBufferLoadAction", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           public static partial void CHECK_LOAD_ACTION_VALID(UnityEngine.Rendering.RenderBufferLoadAction load, nint bufferType); 
*/
            /// <summary>
            /// static  System.Void CheckStoreActionValid(UnityEngine.Rendering.RenderBufferStoreAction store, System.String bufferType)
            /// </summary>
            /// <param name = "store">enum UnityEngine.Rendering.RenderBufferStoreAction</param>
            /// <param name = "bufferType">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckStoreActionValid", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.RenderBufferStoreAction", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           public static partial void CHECK_STORE_ACTION_VALID(UnityEngine.Rendering.RenderBufferStoreAction store, nint bufferType); 
*/
            /// <summary>
            /// static  System.Void ClearRandomWriteTargets()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearRandomWriteTargets", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial void CLEAR_RANDOM_WRITE_TARGETS(); 
*/
            /// <summary>
            /// static  System.Boolean ConvertTexture(UnityEngine.Texture src, UnityEngine.Texture dst)
            /// </summary>
            /// <param name = "src">class UnityEngine.Texture</param>
            /// <param name = "dst">class UnityEngine.Texture</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ConvertTexture", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           public static partial System.Boolean CONVERT_TEXTURE(nint src, nint dst); 
*/
            /// <summary>
            /// static  System.Boolean ConvertTexture(UnityEngine.Texture src, System.Int32 srcElement, UnityEngine.Texture dst, System.Int32 dstElement)
            /// </summary>
            /// <param name = "src">class UnityEngine.Texture</param>
            /// <param name = "srcElement">struct System.Int32</param>
            /// <param name = "dst">class UnityEngine.Texture</param>
            /// <param name = "dstElement">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ConvertTexture", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial System.Boolean CONVERT_TEXTURE(nint src, System.Int32 srcElement, nint dst, System.Int32 dstElement); 
*/
            /// <summary>
            /// static  System.Boolean ConvertTexture_Full(UnityEngine.Texture src, UnityEngine.Texture dst)
            /// </summary>
            /// <param name = "src">class UnityEngine.Texture</param>
            /// <param name = "dst">class UnityEngine.Texture</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ConvertTexture_Full", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           public static partial System.Boolean CONVERT_TEXTURE_FULL(nint src, nint dst); 
*/
            /// <summary>
            /// static  System.Boolean ConvertTexture_Slice(UnityEngine.Texture src, System.Int32 srcElement, UnityEngine.Texture dst, System.Int32 dstElement)
            /// </summary>
            /// <param name = "src">class UnityEngine.Texture</param>
            /// <param name = "srcElement">struct System.Int32</param>
            /// <param name = "dst">class UnityEngine.Texture</param>
            /// <param name = "dstElement">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ConvertTexture_Slice", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial System.Boolean CONVERT_TEXTURE_SLICE(nint src, System.Int32 srcElement, nint dst, System.Int32 dstElement); 
*/
            /// <summary>
            /// static  System.Void CopyBuffer(UnityEngine.GraphicsBuffer source, UnityEngine.GraphicsBuffer dest)
            /// </summary>
            /// <param name = "source">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "dest">class UnityEngine.GraphicsBuffer</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyBuffer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 1)]
           public static partial void COPY_BUFFER(nint source, nint dest); 
*/
            /// <summary>
            /// static  System.Void CopyBufferImpl(UnityEngine.GraphicsBuffer source, UnityEngine.GraphicsBuffer dest)
            /// </summary>
            /// <param name = "source">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "dest">class UnityEngine.GraphicsBuffer</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyBufferImpl", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 1)]
           public static partial void COPY_BUFFER_IMPL(nint source, nint dest); 
*/
            /// <summary>
            /// static  System.Void CopyTexture(UnityEngine.Texture src, UnityEngine.Texture dst)
            /// </summary>
            /// <param name = "src">class UnityEngine.Texture</param>
            /// <param name = "dst">class UnityEngine.Texture</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           public static partial void COPY_TEXTURE(nint src, nint dst); 
*/
            /// <summary>
            /// static  System.Void CopyTexture(UnityEngine.Texture src, System.Int32 srcElement, UnityEngine.Texture dst, System.Int32 dstElement)
            /// </summary>
            /// <param name = "src">class UnityEngine.Texture</param>
            /// <param name = "srcElement">struct System.Int32</param>
            /// <param name = "dst">class UnityEngine.Texture</param>
            /// <param name = "dstElement">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void COPY_TEXTURE(nint src, System.Int32 srcElement, nint dst, System.Int32 dstElement); 
*/
            /// <summary>
            /// static  System.Void CopyTexture(UnityEngine.Texture src, System.Int32 srcElement, System.Int32 srcMip, UnityEngine.Texture dst, System.Int32 dstElement, System.Int32 dstMip)
            /// </summary>
            /// <param name = "src">class UnityEngine.Texture</param>
            /// <param name = "srcElement">struct System.Int32</param>
            /// <param name = "srcMip">struct System.Int32</param>
            /// <param name = "dst">class UnityEngine.Texture</param>
            /// <param name = "dstElement">struct System.Int32</param>
            /// <param name = "dstMip">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void COPY_TEXTURE(nint src, System.Int32 srcElement, System.Int32 srcMip, nint dst, System.Int32 dstElement, System.Int32 dstMip); 
*/
            /// <summary>
            /// static  System.Void CopyTexture(UnityEngine.Texture src, System.Int32 srcElement, System.Int32 srcMip, System.Int32 srcX, System.Int32 srcY, System.Int32 srcWidth, System.Int32 srcHeight, UnityEngine.Texture dst, System.Int32 dstElement, System.Int32 dstMip, System.Int32 dstX, System.Int32 dstY)
            /// </summary>
            /// <param name = "src">class UnityEngine.Texture</param>
            /// <param name = "srcElement">struct System.Int32</param>
            /// <param name = "srcMip">struct System.Int32</param>
            /// <param name = "srcX">struct System.Int32</param>
            /// <param name = "srcY">struct System.Int32</param>
            /// <param name = "srcWidth">struct System.Int32</param>
            /// <param name = "srcHeight">struct System.Int32</param>
            /// <param name = "dst">class UnityEngine.Texture</param>
            /// <param name = "dstElement">struct System.Int32</param>
            /// <param name = "dstMip">struct System.Int32</param>
            /// <param name = "dstX">struct System.Int32</param>
            /// <param name = "dstY">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 11)]
           public static partial void COPY_TEXTURE(nint src, System.Int32 srcElement, System.Int32 srcMip, System.Int32 srcX, System.Int32 srcY, System.Int32 srcWidth, System.Int32 srcHeight, nint dst, System.Int32 dstElement, System.Int32 dstMip, System.Int32 dstX, System.Int32 dstY); 
*/
            /// <summary>
            /// static  System.Void CopyTexture_Full(UnityEngine.Texture src, UnityEngine.Texture dst)
            /// </summary>
            /// <param name = "src">class UnityEngine.Texture</param>
            /// <param name = "dst">class UnityEngine.Texture</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTexture_Full", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           public static partial void COPY_TEXTURE_FULL(nint src, nint dst); 
*/
            /// <summary>
            /// static  System.Void CopyTexture_Region(UnityEngine.Texture src, System.Int32 srcElement, System.Int32 srcMip, System.Int32 srcX, System.Int32 srcY, System.Int32 srcWidth, System.Int32 srcHeight, UnityEngine.Texture dst, System.Int32 dstElement, System.Int32 dstMip, System.Int32 dstX, System.Int32 dstY)
            /// </summary>
            /// <param name = "src">class UnityEngine.Texture</param>
            /// <param name = "srcElement">struct System.Int32</param>
            /// <param name = "srcMip">struct System.Int32</param>
            /// <param name = "srcX">struct System.Int32</param>
            /// <param name = "srcY">struct System.Int32</param>
            /// <param name = "srcWidth">struct System.Int32</param>
            /// <param name = "srcHeight">struct System.Int32</param>
            /// <param name = "dst">class UnityEngine.Texture</param>
            /// <param name = "dstElement">struct System.Int32</param>
            /// <param name = "dstMip">struct System.Int32</param>
            /// <param name = "dstX">struct System.Int32</param>
            /// <param name = "dstY">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTexture_Region", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 11)]
           public static partial void COPY_TEXTURE_REGION(nint src, System.Int32 srcElement, System.Int32 srcMip, System.Int32 srcX, System.Int32 srcY, System.Int32 srcWidth, System.Int32 srcHeight, nint dst, System.Int32 dstElement, System.Int32 dstMip, System.Int32 dstX, System.Int32 dstY); 
*/
            /// <summary>
            /// static  System.Void CopyTexture_Slice(UnityEngine.Texture src, System.Int32 srcElement, System.Int32 srcMip, UnityEngine.Texture dst, System.Int32 dstElement, System.Int32 dstMip)
            /// </summary>
            /// <param name = "src">class UnityEngine.Texture</param>
            /// <param name = "srcElement">struct System.Int32</param>
            /// <param name = "srcMip">struct System.Int32</param>
            /// <param name = "dst">class UnityEngine.Texture</param>
            /// <param name = "dstElement">struct System.Int32</param>
            /// <param name = "dstMip">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTexture_Slice", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void COPY_TEXTURE_SLICE(nint src, System.Int32 srcElement, System.Int32 srcMip, nint dst, System.Int32 dstElement, System.Int32 dstMip); 
*/
            /// <summary>
            /// static  System.Void CopyTexture_Slice_AllMips(UnityEngine.Texture src, System.Int32 srcElement, UnityEngine.Texture dst, System.Int32 dstElement)
            /// </summary>
            /// <param name = "src">class UnityEngine.Texture</param>
            /// <param name = "srcElement">struct System.Int32</param>
            /// <param name = "dst">class UnityEngine.Texture</param>
            /// <param name = "dstElement">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTexture_Slice_AllMips", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void COPY_TEXTURE_SLICE_ALL_MIPS(nint src, System.Int32 srcElement, nint dst, System.Int32 dstElement); 
*/
            /// <summary>
            /// static  UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence(UnityEngine.Rendering.SynchronisationStage stage)
            /// </summary>
            /// <param name = "stage">enum UnityEngine.Rendering.SynchronisationStage</param>
            /// <returns>struct UnityEngine.Rendering.GraphicsFence</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateAsyncGraphicsFence", "UnityEngine.Rendering.GraphicsFence", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.SynchronisationStage", 0)]
           public static partial UnityEngine.Rendering.GraphicsFence CREATE_ASYNC_GRAPHICS_FENCE(UnityEngine.Rendering.SynchronisationStage stage); 
*/
            /// <summary>
            /// static  UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence()
            /// </summary>
            /// <returns>struct UnityEngine.Rendering.GraphicsFence</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateAsyncGraphicsFence", "UnityEngine.Rendering.GraphicsFence", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial UnityEngine.Rendering.GraphicsFence CREATE_ASYNC_GRAPHICS_FENCE(); 
*/
            /// <summary>
            /// static  System.IntPtr CreateGPUFenceImpl(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage)
            /// </summary>
            /// <param name = "fenceType">enum UnityEngine.Rendering.GraphicsFenceType</param>
            /// <param name = "stage">enum UnityEngine.Rendering.SynchronisationStageFlags</param>
            /// <returns>struct System.IntPtr</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateGPUFenceImpl", "System.IntPtr", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.GraphicsFenceType", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.SynchronisationStageFlags", 1)]
           public static partial System.IntPtr CREATE_GPU_FENCE_IMPL(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage); 
*/
            /// <summary>
            /// static  UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage)
            /// </summary>
            /// <param name = "fenceType">enum UnityEngine.Rendering.GraphicsFenceType</param>
            /// <param name = "stage">enum UnityEngine.Rendering.SynchronisationStageFlags</param>
            /// <returns>struct UnityEngine.Rendering.GraphicsFence</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateGraphicsFence", "UnityEngine.Rendering.GraphicsFence", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.GraphicsFenceType", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.SynchronisationStageFlags", 1)]
           public static partial UnityEngine.Rendering.GraphicsFence CREATE_GRAPHICS_FENCE(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows, System.Boolean receiveShadows, System.Boolean useLightProbes)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">struct System.Boolean</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "useLightProbes">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 10)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, System.Boolean castShadows, System.Boolean receiveShadows, System.Boolean useLightProbes); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, System.Boolean useLightProbes)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "probeAnchor">class UnityEngine.Transform</param>
            /// <param name = "useLightProbes">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 11)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, nint probeAnchor, System.Boolean useLightProbes); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows, System.Boolean receiveShadows, System.Boolean useLightProbes)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">struct System.Boolean</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "useLightProbes">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Matrix4x4 matrix, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, System.Boolean castShadows, System.Boolean receiveShadows, System.Boolean useLightProbes); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "probeAnchor">class UnityEngine.Transform</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 11)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Matrix4x4 matrix, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, nint probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint material, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint material, System.Int32 layer, nint camera); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, System.Boolean castShadows); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows, System.Boolean receiveShadows)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">struct System.Boolean</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, System.Boolean castShadows, System.Boolean receiveShadows); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 8)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "probeAnchor">class UnityEngine.Transform</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 10)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, nint probeAnchor); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Matrix4x4 matrix, nint material, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 4)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Matrix4x4 matrix, nint material, System.Int32 layer, nint camera); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Matrix4x4 matrix, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Matrix4x4 matrix, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Matrix4x4 matrix, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, System.Boolean castShadows); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows, System.Boolean receiveShadows)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">struct System.Boolean</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Matrix4x4 matrix, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, System.Boolean castShadows, System.Boolean receiveShadows); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Matrix4x4 matrix, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Matrix4x4 matrix, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "probeAnchor">class UnityEngine.Transform</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 9)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Matrix4x4 matrix, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, nint probeAnchor); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, System.Boolean useLightProbes)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "probeAnchor">class UnityEngine.Transform</param>
            /// <param name = "useLightProbes">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 10)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Matrix4x4 matrix, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, nint probeAnchor, System.Boolean useLightProbes); 
*/
            /// <summary>
            /// static  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "probeAnchor">class UnityEngine.Transform</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 10)]
           public static partial void DRAW_MESH(nint mesh, UnityEngine.Matrix4x4 matrix, nint material, System.Int32 layer, nint camera, System.Int32 submeshIndex, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, nint probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class UnityEngine.Matrix4x4[]</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4[]", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 11)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, System.Int32 count, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class System.Collections.Generic.List<UnityEngine.Matrix4x4></param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Matrix4x4>", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 10)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class UnityEngine.Matrix4x4[]</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4[]", 3)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class UnityEngine.Matrix4x4[]</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4[]", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, System.Int32 count); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class UnityEngine.Matrix4x4[]</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4[]", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 5)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, System.Int32 count, nint properties); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class UnityEngine.Matrix4x4[]</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4[]", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 6)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, System.Int32 count, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class UnityEngine.Matrix4x4[]</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4[]", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, System.Int32 count, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class UnityEngine.Matrix4x4[]</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4[]", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, System.Int32 count, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class UnityEngine.Matrix4x4[]</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4[]", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 9)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, System.Int32 count, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class UnityEngine.Matrix4x4[]</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4[]", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 10)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, System.Int32 count, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class System.Collections.Generic.List<UnityEngine.Matrix4x4></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Matrix4x4>", 3)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class System.Collections.Generic.List<UnityEngine.Matrix4x4></param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Matrix4x4>", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 4)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, nint properties); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class System.Collections.Generic.List<UnityEngine.Matrix4x4></param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Matrix4x4>", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 5)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class System.Collections.Generic.List<UnityEngine.Matrix4x4></param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Matrix4x4>", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 6)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class System.Collections.Generic.List<UnityEngine.Matrix4x4></param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Matrix4x4>", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 7)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class System.Collections.Generic.List<UnityEngine.Matrix4x4></param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Matrix4x4>", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 8)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class System.Collections.Generic.List<UnityEngine.Matrix4x4></param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Matrix4x4>", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 9)]
           public static partial void DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "bufferWithArgs">class UnityEngine.ComputeBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstancedIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 11)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 12)]
           public static partial void DRAW_MESH_INSTANCED_INDIRECT(nint mesh, System.Int32 submeshIndex, nint material, UnityEngine.Bounds bounds, nint bufferWithArgs, System.Int32 argsOffset, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "bufferWithArgs">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstancedIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 11)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 12)]
           public static partial void DRAW_MESH_INSTANCED_INDIRECT(nint mesh, System.Int32 submeshIndex, nint material, UnityEngine.Bounds bounds, nint bufferWithArgs, System.Int32 argsOffset, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "bufferWithArgs">class UnityEngine.ComputeBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstancedIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 11)]
           public static partial void DRAW_MESH_INSTANCED_INDIRECT(nint mesh, System.Int32 submeshIndex, nint material, UnityEngine.Bounds bounds, nint bufferWithArgs, System.Int32 argsOffset, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "bufferWithArgs">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstancedIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 11)]
           public static partial void DRAW_MESH_INSTANCED_INDIRECT(nint mesh, System.Int32 submeshIndex, nint material, UnityEngine.Bounds bounds, nint bufferWithArgs, System.Int32 argsOffset, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage); 
*/
            /// <summary>
            /// static  System.Void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshInstancedProcedural", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 11)]
           public static partial void DRAW_MESH_INSTANCED_PROCEDURAL(nint mesh, System.Int32 submeshIndex, nint material, UnityEngine.Bounds bounds, System.Int32 count, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void DrawMeshNow(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 materialIndex)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "materialIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void DRAW_MESH_NOW(nint mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 materialIndex); 
*/
            /// <summary>
            /// static  System.Void DrawMeshNow(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, System.Int32 materialIndex)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "materialIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public static partial void DRAW_MESH_NOW(nint mesh, UnityEngine.Matrix4x4 matrix, System.Int32 materialIndex); 
*/
            /// <summary>
            /// static  System.Void DrawMeshNow(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
           public static partial void DRAW_MESH_NOW(nint mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  System.Void DrawMeshNow(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawMeshNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 1)]
           public static partial void DRAW_MESH_NOW(nint mesh, UnityEngine.Matrix4x4 matrix); 
*/
            /// <summary>
            /// static  System.Void DrawProcedural(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "vertexCount">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawProcedural", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           public static partial void DRAW_PROCEDURAL(nint material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void DrawProcedural(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "indexCount">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawProcedural", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 10)]
           public static partial void DRAW_PROCEDURAL(nint material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, nint indexBuffer, System.Int32 indexCount, System.Int32 instanceCount, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "bufferWithArgs">class UnityEngine.ComputeBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawProceduralIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           public static partial void DRAW_PROCEDURAL_INDIRECT(nint material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, nint bufferWithArgs, System.Int32 argsOffset, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "bufferWithArgs">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawProceduralIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           public static partial void DRAW_PROCEDURAL_INDIRECT(nint material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, nint bufferWithArgs, System.Int32 argsOffset, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "bufferWithArgs">class UnityEngine.ComputeBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawProceduralIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 10)]
           public static partial void DRAW_PROCEDURAL_INDIRECT(nint material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, nint indexBuffer, nint bufferWithArgs, System.Int32 argsOffset, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "bufferWithArgs">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawProceduralIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 10)]
           public static partial void DRAW_PROCEDURAL_INDIRECT(nint material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, nint indexBuffer, nint bufferWithArgs, System.Int32 argsOffset, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset)
            /// </summary>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "bufferWithArgs">class UnityEngine.ComputeBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawProceduralIndirectNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public static partial void DRAW_PROCEDURAL_INDIRECT_NOW(UnityEngine.MeshTopology topology, nint bufferWithArgs, System.Int32 argsOffset); 
*/
            /// <summary>
            /// static  System.Void DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset)
            /// </summary>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "bufferWithArgs">class UnityEngine.ComputeBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawProceduralIndirectNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void DRAW_PROCEDURAL_INDIRECT_NOW(UnityEngine.MeshTopology topology, nint indexBuffer, nint bufferWithArgs, System.Int32 argsOffset); 
*/
            /// <summary>
            /// static  System.Void DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset)
            /// </summary>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "bufferWithArgs">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawProceduralIndirectNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public static partial void DRAW_PROCEDURAL_INDIRECT_NOW(UnityEngine.MeshTopology topology, nint bufferWithArgs, System.Int32 argsOffset); 
*/
            /// <summary>
            /// static  System.Void DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset)
            /// </summary>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "bufferWithArgs">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawProceduralIndirectNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void DRAW_PROCEDURAL_INDIRECT_NOW(UnityEngine.MeshTopology topology, nint indexBuffer, nint bufferWithArgs, System.Int32 argsOffset); 
*/
            /// <summary>
            /// static  System.Void DrawProceduralNow(UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount)
            /// </summary>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "vertexCount">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawProceduralNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public static partial void DRAW_PROCEDURAL_NOW(UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void DrawProceduralNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount)
            /// </summary>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "indexCount">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawProceduralNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void DRAW_PROCEDURAL_NOW(UnityEngine.MeshTopology topology, nint indexBuffer, System.Int32 indexCount, System.Int32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color, UnityEngine.Material mat, System.Int32 pass)
            /// </summary>
            /// <param name = "screenRect">struct UnityEngine.Rect</param>
            /// <param name = "texture">class UnityEngine.Texture</param>
            /// <param name = "sourceRect">struct UnityEngine.Rect</param>
            /// <param name = "leftBorder">struct System.Int32</param>
            /// <param name = "rightBorder">struct System.Int32</param>
            /// <param name = "topBorder">struct System.Int32</param>
            /// <param name = "bottomBorder">struct System.Int32</param>
            /// <param name = "color">struct UnityEngine.Color</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "pass">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           public static partial void DRAW_TEXTURE(UnityEngine.Rect screenRect, nint texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color, nint mat, System.Int32 pass); 
*/
            /// <summary>
            /// static  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Material mat, System.Int32 pass)
            /// </summary>
            /// <param name = "screenRect">struct UnityEngine.Rect</param>
            /// <param name = "texture">class UnityEngine.Texture</param>
            /// <param name = "sourceRect">struct UnityEngine.Rect</param>
            /// <param name = "leftBorder">struct System.Int32</param>
            /// <param name = "rightBorder">struct System.Int32</param>
            /// <param name = "topBorder">struct System.Int32</param>
            /// <param name = "bottomBorder">struct System.Int32</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "pass">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
           public static partial void DRAW_TEXTURE(UnityEngine.Rect screenRect, nint texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, nint mat, System.Int32 pass); 
*/
            /// <summary>
            /// static  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Material mat, System.Int32 pass)
            /// </summary>
            /// <param name = "screenRect">struct UnityEngine.Rect</param>
            /// <param name = "texture">class UnityEngine.Texture</param>
            /// <param name = "leftBorder">struct System.Int32</param>
            /// <param name = "rightBorder">struct System.Int32</param>
            /// <param name = "topBorder">struct System.Int32</param>
            /// <param name = "bottomBorder">struct System.Int32</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "pass">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 7)]
           public static partial void DRAW_TEXTURE(UnityEngine.Rect screenRect, nint texture, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, nint mat, System.Int32 pass); 
*/
            /// <summary>
            /// static  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Material mat, System.Int32 pass)
            /// </summary>
            /// <param name = "screenRect">struct UnityEngine.Rect</param>
            /// <param name = "texture">class UnityEngine.Texture</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "pass">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void DRAW_TEXTURE(UnityEngine.Rect screenRect, nint texture, nint mat, System.Int32 pass); 
*/
            /// <summary>
            /// static  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color, UnityEngine.Material mat)
            /// </summary>
            /// <param name = "screenRect">struct UnityEngine.Rect</param>
            /// <param name = "texture">class UnityEngine.Texture</param>
            /// <param name = "sourceRect">struct UnityEngine.Rect</param>
            /// <param name = "leftBorder">struct System.Int32</param>
            /// <param name = "rightBorder">struct System.Int32</param>
            /// <param name = "topBorder">struct System.Int32</param>
            /// <param name = "bottomBorder">struct System.Int32</param>
            /// <param name = "color">struct UnityEngine.Color</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 8)]
           public static partial void DRAW_TEXTURE(UnityEngine.Rect screenRect, nint texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color, nint mat); 
*/
            /// <summary>
            /// static  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color)
            /// </summary>
            /// <param name = "screenRect">struct UnityEngine.Rect</param>
            /// <param name = "texture">class UnityEngine.Texture</param>
            /// <param name = "sourceRect">struct UnityEngine.Rect</param>
            /// <param name = "leftBorder">struct System.Int32</param>
            /// <param name = "rightBorder">struct System.Int32</param>
            /// <param name = "topBorder">struct System.Int32</param>
            /// <param name = "bottomBorder">struct System.Int32</param>
            /// <param name = "color">struct UnityEngine.Color</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color", 7)]
           public static partial void DRAW_TEXTURE(UnityEngine.Rect screenRect, nint texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color); 
*/
            /// <summary>
            /// static  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Material mat)
            /// </summary>
            /// <param name = "screenRect">struct UnityEngine.Rect</param>
            /// <param name = "texture">class UnityEngine.Texture</param>
            /// <param name = "sourceRect">struct UnityEngine.Rect</param>
            /// <param name = "leftBorder">struct System.Int32</param>
            /// <param name = "rightBorder">struct System.Int32</param>
            /// <param name = "topBorder">struct System.Int32</param>
            /// <param name = "bottomBorder">struct System.Int32</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 7)]
           public static partial void DRAW_TEXTURE(UnityEngine.Rect screenRect, nint texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, nint mat); 
*/
            /// <summary>
            /// static  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder)
            /// </summary>
            /// <param name = "screenRect">struct UnityEngine.Rect</param>
            /// <param name = "texture">class UnityEngine.Texture</param>
            /// <param name = "sourceRect">struct UnityEngine.Rect</param>
            /// <param name = "leftBorder">struct System.Int32</param>
            /// <param name = "rightBorder">struct System.Int32</param>
            /// <param name = "topBorder">struct System.Int32</param>
            /// <param name = "bottomBorder">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           public static partial void DRAW_TEXTURE(UnityEngine.Rect screenRect, nint texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder); 
*/
            /// <summary>
            /// static  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Material mat)
            /// </summary>
            /// <param name = "screenRect">struct UnityEngine.Rect</param>
            /// <param name = "texture">class UnityEngine.Texture</param>
            /// <param name = "leftBorder">struct System.Int32</param>
            /// <param name = "rightBorder">struct System.Int32</param>
            /// <param name = "topBorder">struct System.Int32</param>
            /// <param name = "bottomBorder">struct System.Int32</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 6)]
           public static partial void DRAW_TEXTURE(UnityEngine.Rect screenRect, nint texture, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, nint mat); 
*/
            /// <summary>
            /// static  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder)
            /// </summary>
            /// <param name = "screenRect">struct UnityEngine.Rect</param>
            /// <param name = "texture">class UnityEngine.Texture</param>
            /// <param name = "leftBorder">struct System.Int32</param>
            /// <param name = "rightBorder">struct System.Int32</param>
            /// <param name = "topBorder">struct System.Int32</param>
            /// <param name = "bottomBorder">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void DRAW_TEXTURE(UnityEngine.Rect screenRect, nint texture, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder); 
*/
            /// <summary>
            /// static  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Material mat)
            /// </summary>
            /// <param name = "screenRect">struct UnityEngine.Rect</param>
            /// <param name = "texture">class UnityEngine.Texture</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           public static partial void DRAW_TEXTURE(UnityEngine.Rect screenRect, nint texture, nint mat); 
*/
            /// <summary>
            /// static  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture)
            /// </summary>
            /// <param name = "screenRect">struct UnityEngine.Rect</param>
            /// <param name = "texture">class UnityEngine.Texture</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           public static partial void DRAW_TEXTURE(UnityEngine.Rect screenRect, nint texture); 
*/
            /// <summary>
            /// static  System.Void DrawTextureImpl(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color, UnityEngine.Material mat, System.Int32 pass)
            /// </summary>
            /// <param name = "screenRect">struct UnityEngine.Rect</param>
            /// <param name = "texture">class UnityEngine.Texture</param>
            /// <param name = "sourceRect">struct UnityEngine.Rect</param>
            /// <param name = "leftBorder">struct System.Int32</param>
            /// <param name = "rightBorder">struct System.Int32</param>
            /// <param name = "topBorder">struct System.Int32</param>
            /// <param name = "bottomBorder">struct System.Int32</param>
            /// <param name = "color">struct UnityEngine.Color</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "pass">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawTextureImpl", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rect", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           public static partial void DRAW_TEXTURE_IMPL(UnityEngine.Rect screenRect, nint texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color, nint mat, System.Int32 pass); 
*/
            /// <summary>
            /// static  System.Void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer buffer)
            /// </summary>
            /// <param name = "buffer">class UnityEngine.Rendering.CommandBuffer</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ExecuteCommandBuffer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.CommandBuffer", 0)]
           public static partial void EXECUTE_COMMAND_BUFFER(nint buffer); 
*/
            /// <summary>
            /// static  System.Void ExecuteCommandBufferAsync(UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
            /// </summary>
            /// <param name = "buffer">class UnityEngine.Rendering.CommandBuffer</param>
            /// <param name = "queueType">enum UnityEngine.Rendering.ComputeQueueType</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ExecuteCommandBufferAsync", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.CommandBuffer", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ComputeQueueType", 1)]
           public static partial void EXECUTE_COMMAND_BUFFER_ASYNC(nint buffer, UnityEngine.Rendering.ComputeQueueType queueType); 
*/
            /// <summary>
            /// static  UnityEngine.RenderBuffer get_activeColorBuffer()
            /// </summary>
            /// <returns>struct UnityEngine.RenderBuffer</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_activeColorBuffer", "UnityEngine.RenderBuffer", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial UnityEngine.RenderBuffer GET_ACTIVE_COLOR_BUFFER(); 
*/
            /// <summary>
            /// static  UnityEngine.ColorGamut get_activeColorGamut()
            /// </summary>
            /// <returns>enum UnityEngine.ColorGamut</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_activeColorGamut", "UnityEngine.ColorGamut", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial UnityEngine.ColorGamut GET_ACTIVE_COLOR_GAMUT(); 
*/
            /// <summary>
            /// static  UnityEngine.RenderBuffer get_activeDepthBuffer()
            /// </summary>
            /// <returns>struct UnityEngine.RenderBuffer</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_activeDepthBuffer", "UnityEngine.RenderBuffer", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial UnityEngine.RenderBuffer GET_ACTIVE_DEPTH_BUFFER(); 
*/
            /// <summary>
            /// static  UnityEngine.Rendering.GraphicsTier get_activeTier()
            /// </summary>
            /// <returns>enum UnityEngine.Rendering.GraphicsTier</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_activeTier", "UnityEngine.Rendering.GraphicsTier", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial UnityEngine.Rendering.GraphicsTier GET_ACTIVE_TIER(); 
*/
            /// <summary>
            /// static  UnityEngine.Rendering.OpenGLESVersion get_minOpenGLESVersion()
            /// </summary>
            /// <returns>enum UnityEngine.Rendering.OpenGLESVersion</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_minOpenGLESVersion", "UnityEngine.Rendering.OpenGLESVersion", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial UnityEngine.Rendering.OpenGLESVersion GET_MIN_OPEN_GLES_VERSION(); 
*/
            /// <summary>
            /// static  System.Boolean get_preserveFramebufferAlpha()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_preserveFramebufferAlpha", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.Boolean GET_PRESERVE_FRAMEBUFFER_ALPHA(); 
*/
            /// <summary>
            /// static  UnityEngine.RenderBuffer GetActiveColorBuffer()
            /// </summary>
            /// <returns>struct UnityEngine.RenderBuffer</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetActiveColorBuffer", "UnityEngine.RenderBuffer", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial UnityEngine.RenderBuffer GET_ACTIVE_COLOR_BUFFER(); 
*/
            /// <summary>
            /// static  System.Void GetActiveColorBuffer_Injected(UnityEngine.RenderBuffer& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.RenderBuffer&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetActiveColorBuffer_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer&", 0)]
           public static partial void GET_ACTIVE_COLOR_BUFFER_INJECTED(UnityEngine.RenderBuffer &ret); 
*/
            /// <summary>
            /// static  UnityEngine.ColorGamut GetActiveColorGamut()
            /// </summary>
            /// <returns>enum UnityEngine.ColorGamut</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetActiveColorGamut", "UnityEngine.ColorGamut", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial UnityEngine.ColorGamut GET_ACTIVE_COLOR_GAMUT(); 
*/
            /// <summary>
            /// static  UnityEngine.RenderBuffer GetActiveDepthBuffer()
            /// </summary>
            /// <returns>struct UnityEngine.RenderBuffer</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetActiveDepthBuffer", "UnityEngine.RenderBuffer", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial UnityEngine.RenderBuffer GET_ACTIVE_DEPTH_BUFFER(); 
*/
            /// <summary>
            /// static  System.Void GetActiveDepthBuffer_Injected(UnityEngine.RenderBuffer& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.RenderBuffer&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetActiveDepthBuffer_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer&", 0)]
           public static partial void GET_ACTIVE_DEPTH_BUFFER_INJECTED(UnityEngine.RenderBuffer &ret); 
*/
            /// <summary>
            /// static  UnityEngine.Rendering.OpenGLESVersion GetMinOpenGLESVersion()
            /// </summary>
            /// <returns>enum UnityEngine.Rendering.OpenGLESVersion</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMinOpenGLESVersion", "UnityEngine.Rendering.OpenGLESVersion", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial UnityEngine.Rendering.OpenGLESVersion GET_MIN_OPEN_GLES_VERSION(); 
*/
            /// <summary>
            /// static  System.Boolean GetPreserveFramebufferAlpha()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPreserveFramebufferAlpha", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.Boolean GET_PRESERVE_FRAMEBUFFER_ALPHA(); 
*/
            /// <summary>
            /// static  System.Void Internal_BlitMaterial5(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 pass, System.Boolean setRT)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "pass">struct System.Int32</param>
            /// <param name = "setRT">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_BlitMaterial5", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
           public static partial void INTERNAL_BLIT_MATERIAL5(nint source, nint dest, nint mat, System.Int32 pass, System.Boolean setRT); 
*/
            /// <summary>
            /// static  System.Void Internal_BlitMaterial6(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 pass, System.Boolean setRT, System.Int32 destDepthSlice)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "pass">struct System.Int32</param>
            /// <param name = "setRT">struct System.Boolean</param>
            /// <param name = "destDepthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_BlitMaterial6", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void INTERNAL_BLIT_MATERIAL6(nint source, nint dest, nint mat, System.Int32 pass, System.Boolean setRT, System.Int32 destDepthSlice); 
*/
            /// <summary>
            /// static  System.Void Internal_BlitMultiTap4(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, UnityEngine.Vector2[] offsets)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "offsets">class UnityEngine.Vector2[]</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_BlitMultiTap4", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2[]", 3)]
           public static partial void INTERNAL_BLIT_MULTI_TAP4(nint source, nint dest, nint mat, nint offsets); 
*/
            /// <summary>
            /// static  System.Void Internal_BlitMultiTap5(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, UnityEngine.Vector2[] offsets, System.Int32 destDepthSlice)
            /// </summary>
            /// <param name = "source">class UnityEngine.Texture</param>
            /// <param name = "dest">class UnityEngine.RenderTexture</param>
            /// <param name = "mat">class UnityEngine.Material</param>
            /// <param name = "offsets">class UnityEngine.Vector2[]</param>
            /// <param name = "destDepthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_BlitMultiTap5", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2[]", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void INTERNAL_BLIT_MULTI_TAP5(nint source, nint dest, nint mat, nint offsets, System.Int32 destDepthSlice); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawMesh(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "probeAnchor">class UnityEngine.Transform</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 11)]
           public static partial void INTERNAL_DRAW_MESH(nint mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4 matrix, nint material, System.Int32 layer, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, nint probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawMesh_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4& matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4&</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "probeAnchor">class UnityEngine.Transform</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawMesh_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4&", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 11)]
           public static partial void INTERNAL_DRAW_MESH_INJECTED(nint mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4 &matrix, nint material, System.Int32 layer, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, nint probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "matrices">class UnityEngine.Matrix4x4[]</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4[]", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 11)]
           public static partial void INTERNAL_DRAW_MESH_INSTANCED(nint mesh, System.Int32 submeshIndex, nint material, nint matrices, System.Int32 count, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "bufferWithArgs">class UnityEngine.ComputeBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawMeshInstancedIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 11)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 12)]
           public static partial void INTERNAL_DRAW_MESH_INSTANCED_INDIRECT(nint mesh, System.Int32 submeshIndex, nint material, UnityEngine.Bounds bounds, nint bufferWithArgs, System.Int32 argsOffset, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawMeshInstancedIndirect_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds&</param>
            /// <param name = "bufferWithArgs">class UnityEngine.ComputeBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawMeshInstancedIndirect_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds&", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 11)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 12)]
           public static partial void INTERNAL_DRAW_MESH_INSTANCED_INDIRECT_INJECTED(nint mesh, System.Int32 submeshIndex, nint material, UnityEngine.Bounds &bounds, nint bufferWithArgs, System.Int32 argsOffset, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawMeshInstancedIndirectGraphicsBuffer(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "bufferWithArgs">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawMeshInstancedIndirectGraphicsBuffer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 11)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 12)]
           public static partial void INTERNAL_DRAW_MESH_INSTANCED_INDIRECT_GRAPHICS_BUFFER(nint mesh, System.Int32 submeshIndex, nint material, UnityEngine.Bounds bounds, nint bufferWithArgs, System.Int32 argsOffset, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds&</param>
            /// <param name = "bufferWithArgs">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds&", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 11)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 12)]
           public static partial void INTERNAL_DRAW_MESH_INSTANCED_INDIRECT_GRAPHICS_BUFFER_INJECTED(nint mesh, System.Int32 submeshIndex, nint material, UnityEngine.Bounds &bounds, nint bufferWithArgs, System.Int32 argsOffset, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawMeshInstancedProcedural", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 11)]
           public static partial void INTERNAL_DRAW_MESH_INSTANCED_PROCEDURAL(nint mesh, System.Int32 submeshIndex, nint material, UnityEngine.Bounds bounds, System.Int32 count, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawMeshInstancedProcedural_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds& bounds, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds&</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "lightProbeUsage">enum UnityEngine.Rendering.LightProbeUsage</param>
            /// <param name = "lightProbeProxyVolume">class UnityEngine.LightProbeProxyVolume</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawMeshInstancedProcedural_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds&", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.LightProbeUsage", 10)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.LightProbeProxyVolume", 11)]
           public static partial void INTERNAL_DRAW_MESH_INSTANCED_PROCEDURAL_INJECTED(nint mesh, System.Int32 submeshIndex, nint material, UnityEngine.Bounds &bounds, System.Int32 count, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawMeshNow1(UnityEngine.Mesh mesh, System.Int32 subsetIndex, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "subsetIndex">struct System.Int32</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawMeshNow1", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 3)]
           public static partial void INTERNAL_DRAW_MESH_NOW1(nint mesh, System.Int32 subsetIndex, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawMeshNow1_Injected(UnityEngine.Mesh mesh, System.Int32 subsetIndex, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "subsetIndex">struct System.Int32</param>
            /// <param name = "position">struct UnityEngine.Vector3&</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawMeshNow1_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion&", 3)]
           public static partial void INTERNAL_DRAW_MESH_NOW1_INJECTED(nint mesh, System.Int32 subsetIndex, UnityEngine.Vector3 &position, UnityEngine.Quaternion &rotation); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawMeshNow2(UnityEngine.Mesh mesh, System.Int32 subsetIndex, UnityEngine.Matrix4x4 matrix)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "subsetIndex">struct System.Int32</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawMeshNow2", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 2)]
           public static partial void INTERNAL_DRAW_MESH_NOW2(nint mesh, System.Int32 subsetIndex, UnityEngine.Matrix4x4 matrix); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawMeshNow2_Injected(UnityEngine.Mesh mesh, System.Int32 subsetIndex, UnityEngine.Matrix4x4& matrix)
            /// </summary>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "subsetIndex">struct System.Int32</param>
            /// <param name = "matrix">struct UnityEngine.Matrix4x4&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawMeshNow2_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4&", 2)]
           public static partial void INTERNAL_DRAW_MESH_NOW2_INJECTED(nint mesh, System.Int32 subsetIndex, UnityEngine.Matrix4x4 &matrix); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProcedural(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "vertexCount">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProcedural", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           public static partial void INTERNAL_DRAW_PROCEDURAL(nint material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProcedural_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds&</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "vertexCount">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProcedural_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INJECTED(nint material, UnityEngine.Bounds &bounds, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndexed(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "indexCount">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndexed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 10)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDEXED(nint material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, nint indexBuffer, System.Int32 indexCount, System.Int32 instanceCount, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndexed_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds&</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "indexCount">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndexed_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 10)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDEXED_INJECTED(nint material, UnityEngine.Bounds &bounds, UnityEngine.MeshTopology topology, nint indexBuffer, System.Int32 indexCount, System.Int32 instanceCount, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndexedIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "bufferWithArgs">class UnityEngine.ComputeBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndexedIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 10)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDEXED_INDIRECT(nint material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, nint indexBuffer, nint bufferWithArgs, System.Int32 argsOffset, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndexedIndirect_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds&</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "bufferWithArgs">class UnityEngine.ComputeBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndexedIndirect_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 10)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDEXED_INDIRECT_INJECTED(nint material, UnityEngine.Bounds &bounds, UnityEngine.MeshTopology topology, nint indexBuffer, nint bufferWithArgs, System.Int32 argsOffset, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "bufferWithArgs">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndexedIndirectGraphicsBuffer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 10)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDEXED_INDIRECT_GRAPHICS_BUFFER(nint material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, nint indexBuffer, nint bufferWithArgs, System.Int32 argsOffset, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds&</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "bufferWithArgs">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 9)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 10)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDEXED_INDIRECT_GRAPHICS_BUFFER_INJECTED(nint material, UnityEngine.Bounds &bounds, UnityEngine.MeshTopology topology, nint indexBuffer, nint bufferWithArgs, System.Int32 argsOffset, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndexedIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset)
            /// </summary>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "bufferWithArgs">class UnityEngine.ComputeBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndexedIndirectNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDEXED_INDIRECT_NOW(UnityEngine.MeshTopology topology, nint indexBuffer, nint bufferWithArgs, System.Int32 argsOffset); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset)
            /// </summary>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "bufferWithArgs">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDEXED_INDIRECT_NOW_GRAPHICS_BUFFER(UnityEngine.MeshTopology topology, nint indexBuffer, nint bufferWithArgs, System.Int32 argsOffset); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndexedNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount)
            /// </summary>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "indexCount">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndexedNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDEXED_NOW(UnityEngine.MeshTopology topology, nint indexBuffer, System.Int32 indexCount, System.Int32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "bufferWithArgs">class UnityEngine.ComputeBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDIRECT(nint material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, nint bufferWithArgs, System.Int32 argsOffset, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndirect_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds&</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "bufferWithArgs">class UnityEngine.ComputeBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndirect_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDIRECT_INJECTED(nint material, UnityEngine.Bounds &bounds, UnityEngine.MeshTopology topology, nint bufferWithArgs, System.Int32 argsOffset, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndirectGraphicsBuffer(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "bufferWithArgs">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndirectGraphicsBuffer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDIRECT_GRAPHICS_BUFFER(nint material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, nint bufferWithArgs, System.Int32 argsOffset, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
            /// </summary>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "bounds">struct UnityEngine.Bounds&</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "bufferWithArgs">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <param name = "camera">class UnityEngine.Camera</param>
            /// <param name = "properties">class UnityEngine.MaterialPropertyBlock</param>
            /// <param name = "castShadows">enum UnityEngine.Rendering.ShadowCastingMode</param>
            /// <param name = "receiveShadows">struct System.Boolean</param>
            /// <param name = "layer">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndirectGraphicsBuffer_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Bounds&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MaterialPropertyBlock", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ShadowCastingMode", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 8)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 9)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDIRECT_GRAPHICS_BUFFER_INJECTED(nint material, UnityEngine.Bounds &bounds, UnityEngine.MeshTopology topology, nint bufferWithArgs, System.Int32 argsOffset, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset)
            /// </summary>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "bufferWithArgs">class UnityEngine.ComputeBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndirectNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDIRECT_NOW(UnityEngine.MeshTopology topology, nint bufferWithArgs, System.Int32 argsOffset); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralIndirectNowGraphicsBuffer(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset)
            /// </summary>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "bufferWithArgs">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "argsOffset">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralIndirectNowGraphicsBuffer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_INDIRECT_NOW_GRAPHICS_BUFFER(UnityEngine.MeshTopology topology, nint bufferWithArgs, System.Int32 argsOffset); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawProceduralNow(UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount)
            /// </summary>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "vertexCount">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawProceduralNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public static partial void INTERNAL_DRAW_PROCEDURAL_NOW(UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void Internal_DrawTexture(UnityEngine.Internal_DrawTextureArguments& args)
            /// </summary>
            /// <param name = "args">struct UnityEngine.Internal_DrawTextureArguments&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_DrawTexture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Internal_DrawTextureArguments&", 0)]
           public static partial void INTERNAL_DRAW_TEXTURE(UnityEngine.Internal_DrawTextureArguments &args); 
*/
            /// <summary>
            /// static  System.Int32 Internal_GetMaxDrawMeshInstanceCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_GetMaxDrawMeshInstanceCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.Int32 INTERNAL_GET_MAX_DRAW_MESH_INSTANCE_COUNT(); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderMesh(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4 objectToWorld, UnityEngine.Matrix4x4* prevObjectToWorld)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams</param>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "objectToWorld">struct UnityEngine.Matrix4x4</param>
            /// <param name = "prevObjectToWorld">class UnityEngine.Matrix4x4*</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4*", 4)]
           public static partial void INTERNAL_RENDER_MESH(UnityEngine.RenderParams rparams, nint mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4 objectToWorld, nint prevObjectToWorld); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderMesh_Injected(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4& objectToWorld, UnityEngine.Matrix4x4* prevObjectToWorld)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "objectToWorld">struct UnityEngine.Matrix4x4&</param>
            /// <param name = "prevObjectToWorld">class UnityEngine.Matrix4x4*</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderMesh_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4&", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4*", 4)]
           public static partial void INTERNAL_RENDER_MESH_INJECTED(UnityEngine.RenderParams &rparams, nint mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4 &objectToWorld, nint prevObjectToWorld); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderMeshIndirect(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams</param>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "commandBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "commandCount">struct System.Int32</param>
            /// <param name = "startCommand">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderMeshIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void INTERNAL_RENDER_MESH_INDIRECT(UnityEngine.RenderParams rparams, nint mesh, nint commandBuffer, System.Int32 commandCount, System.Int32 startCommand); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderMeshIndirect_Injected(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "commandBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "commandCount">struct System.Int32</param>
            /// <param name = "startCommand">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderMeshIndirect_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void INTERNAL_RENDER_MESH_INDIRECT_INJECTED(UnityEngine.RenderParams &rparams, nint mesh, nint commandBuffer, System.Int32 commandCount, System.Int32 startCommand); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderMeshInstanced(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.IntPtr instanceData, UnityEngine.RenderInstancedDataLayout layout, System.UInt32 instanceCount)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams</param>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "instanceData">struct System.IntPtr</param>
            /// <param name = "layout">struct UnityEngine.RenderInstancedDataLayout</param>
            /// <param name = "instanceCount">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderInstancedDataLayout", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 5)]
           public static partial void INTERNAL_RENDER_MESH_INSTANCED(UnityEngine.RenderParams rparams, nint mesh, System.Int32 submeshIndex, System.IntPtr instanceData, UnityEngine.RenderInstancedDataLayout layout, System.UInt32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderMeshInstanced_Injected(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.IntPtr instanceData, UnityEngine.RenderInstancedDataLayout& layout, System.UInt32 instanceCount)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "instanceData">struct System.IntPtr</param>
            /// <param name = "layout">struct UnityEngine.RenderInstancedDataLayout&</param>
            /// <param name = "instanceCount">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderMeshInstanced_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderInstancedDataLayout&", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 5)]
           public static partial void INTERNAL_RENDER_MESH_INSTANCED_INJECTED(UnityEngine.RenderParams &rparams, nint mesh, System.Int32 submeshIndex, System.IntPtr instanceData, UnityEngine.RenderInstancedDataLayout &layout, System.UInt32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderMeshPrimitives(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.Int32 instanceCount)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams</param>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderMeshPrimitives", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void INTERNAL_RENDER_MESH_PRIMITIVES(UnityEngine.RenderParams rparams, nint mesh, System.Int32 submeshIndex, System.Int32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderMeshPrimitives_Injected(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.Int32 instanceCount)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderMeshPrimitives_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void INTERNAL_RENDER_MESH_PRIMITIVES_INJECTED(UnityEngine.RenderParams &rparams, nint mesh, System.Int32 submeshIndex, System.Int32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderPrimitives(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "vertexCount">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderPrimitives", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void INTERNAL_RENDER_PRIMITIVES(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderPrimitives_Injected(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "vertexCount">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderPrimitives_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void INTERNAL_RENDER_PRIMITIVES_INJECTED(UnityEngine.RenderParams &rparams, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderPrimitivesIndexed(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 startIndex, System.Int32 instanceCount)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "indexCount">struct System.Int32</param>
            /// <param name = "startIndex">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderPrimitivesIndexed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void INTERNAL_RENDER_PRIMITIVES_INDEXED(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, nint indexBuffer, System.Int32 indexCount, System.Int32 startIndex, System.Int32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderPrimitivesIndexed_Injected(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 startIndex, System.Int32 instanceCount)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "indexCount">struct System.Int32</param>
            /// <param name = "startIndex">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderPrimitivesIndexed_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void INTERNAL_RENDER_PRIMITIVES_INDEXED_INJECTED(UnityEngine.RenderParams &rparams, UnityEngine.MeshTopology topology, nint indexBuffer, System.Int32 indexCount, System.Int32 startIndex, System.Int32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderPrimitivesIndexedIndirect(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "commandBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "commandCount">struct System.Int32</param>
            /// <param name = "startCommand">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderPrimitivesIndexedIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void INTERNAL_RENDER_PRIMITIVES_INDEXED_INDIRECT(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, nint indexBuffer, nint commandBuffer, System.Int32 commandCount, System.Int32 startCommand); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderPrimitivesIndexedIndirect_Injected(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "commandBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "commandCount">struct System.Int32</param>
            /// <param name = "startCommand">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderPrimitivesIndexedIndirect_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void INTERNAL_RENDER_PRIMITIVES_INDEXED_INDIRECT_INJECTED(UnityEngine.RenderParams &rparams, UnityEngine.MeshTopology topology, nint indexBuffer, nint commandBuffer, System.Int32 commandCount, System.Int32 startCommand); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderPrimitivesIndirect(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "commandBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "commandCount">struct System.Int32</param>
            /// <param name = "startCommand">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderPrimitivesIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void INTERNAL_RENDER_PRIMITIVES_INDIRECT(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, nint commandBuffer, System.Int32 commandCount, System.Int32 startCommand); 
*/
            /// <summary>
            /// static  System.Void Internal_RenderPrimitivesIndirect_Injected(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "commandBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "commandCount">struct System.Int32</param>
            /// <param name = "startCommand">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_RenderPrimitivesIndirect_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void INTERNAL_RENDER_PRIMITIVES_INDIRECT_INJECTED(UnityEngine.RenderParams &rparams, UnityEngine.MeshTopology topology, nint commandBuffer, System.Int32 commandCount, System.Int32 startCommand); 
*/
            /// <summary>
            /// static  System.Void Internal_SetMRTFullSetup(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice, UnityEngine.Rendering.RenderBufferLoadAction[] colorLA, UnityEngine.Rendering.RenderBufferStoreAction[] colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA)
            /// </summary>
            /// <param name = "color">class UnityEngine.RenderBuffer[]</param>
            /// <param name = "depth">struct UnityEngine.RenderBuffer</param>
            /// <param name = "mip">struct System.Int32</param>
            /// <param name = "face">enum UnityEngine.CubemapFace</param>
            /// <param name = "depthSlice">struct System.Int32</param>
            /// <param name = "colorLA">class UnityEngine.Rendering.RenderBufferLoadAction[]</param>
            /// <param name = "colorSA">class UnityEngine.Rendering.RenderBufferStoreAction[]</param>
            /// <param name = "depthLA">enum UnityEngine.Rendering.RenderBufferLoadAction</param>
            /// <param name = "depthSA">enum UnityEngine.Rendering.RenderBufferStoreAction</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_SetMRTFullSetup", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.CubemapFace", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.RenderBufferLoadAction[]", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.RenderBufferStoreAction[]", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.RenderBufferLoadAction", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.RenderBufferStoreAction", 8)]
           public static partial void INTERNAL_SET_MRT_FULL_SETUP(nint color, UnityEngine.RenderBuffer depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice, nint colorLA, nint colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA); 
*/
            /// <summary>
            /// static  System.Void Internal_SetMRTFullSetup_Injected(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer& depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice, UnityEngine.Rendering.RenderBufferLoadAction[] colorLA, UnityEngine.Rendering.RenderBufferStoreAction[] colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA)
            /// </summary>
            /// <param name = "color">class UnityEngine.RenderBuffer[]</param>
            /// <param name = "depth">struct UnityEngine.RenderBuffer&</param>
            /// <param name = "mip">struct System.Int32</param>
            /// <param name = "face">enum UnityEngine.CubemapFace</param>
            /// <param name = "depthSlice">struct System.Int32</param>
            /// <param name = "colorLA">class UnityEngine.Rendering.RenderBufferLoadAction[]</param>
            /// <param name = "colorSA">class UnityEngine.Rendering.RenderBufferStoreAction[]</param>
            /// <param name = "depthLA">enum UnityEngine.Rendering.RenderBufferLoadAction</param>
            /// <param name = "depthSA">enum UnityEngine.Rendering.RenderBufferStoreAction</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_SetMRTFullSetup_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.CubemapFace", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.RenderBufferLoadAction[]", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.RenderBufferStoreAction[]", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.RenderBufferLoadAction", 7)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.RenderBufferStoreAction", 8)]
           public static partial void INTERNAL_SET_MRT_FULL_SETUP_INJECTED(nint color, UnityEngine.RenderBuffer &depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice, nint colorLA, nint colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA); 
*/
            /// <summary>
            /// static  System.Void Internal_SetMRTSimple(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice)
            /// </summary>
            /// <param name = "color">class UnityEngine.RenderBuffer[]</param>
            /// <param name = "depth">struct UnityEngine.RenderBuffer</param>
            /// <param name = "mip">struct System.Int32</param>
            /// <param name = "face">enum UnityEngine.CubemapFace</param>
            /// <param name = "depthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_SetMRTSimple", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.CubemapFace", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void INTERNAL_SET_MRT_SIMPLE(nint color, UnityEngine.RenderBuffer depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice); 
*/
            /// <summary>
            /// static  System.Void Internal_SetMRTSimple_Injected(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer& depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice)
            /// </summary>
            /// <param name = "color">class UnityEngine.RenderBuffer[]</param>
            /// <param name = "depth">struct UnityEngine.RenderBuffer&</param>
            /// <param name = "mip">struct System.Int32</param>
            /// <param name = "face">enum UnityEngine.CubemapFace</param>
            /// <param name = "depthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_SetMRTSimple_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.CubemapFace", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void INTERNAL_SET_MRT_SIMPLE_INJECTED(nint color, UnityEngine.RenderBuffer &depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice); 
*/
            /// <summary>
            /// static  System.Void Internal_SetNullRT()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_SetNullRT", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial void INTERNAL_SET_NULL_RT(); 
*/
            /// <summary>
            /// static  System.Void Internal_SetRandomWriteTargetBuffer(System.Int32 index, UnityEngine.ComputeBuffer uav, System.Boolean preserveCounterValue)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "uav">class UnityEngine.ComputeBuffer</param>
            /// <param name = "preserveCounterValue">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_SetRandomWriteTargetBuffer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
           public static partial void INTERNAL_SET_RANDOM_WRITE_TARGET_BUFFER(System.Int32 index, nint uav, System.Boolean preserveCounterValue); 
*/
            /// <summary>
            /// static  System.Void Internal_SetRandomWriteTargetGraphicsBuffer(System.Int32 index, UnityEngine.GraphicsBuffer uav, System.Boolean preserveCounterValue)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "uav">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "preserveCounterValue">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_SetRandomWriteTargetGraphicsBuffer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
           public static partial void INTERNAL_SET_RANDOM_WRITE_TARGET_GRAPHICS_BUFFER(System.Int32 index, nint uav, System.Boolean preserveCounterValue); 
*/
            /// <summary>
            /// static  System.Void Internal_SetRandomWriteTargetRT(System.Int32 index, UnityEngine.RenderTexture uav)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "uav">class UnityEngine.RenderTexture</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_SetRandomWriteTargetRT", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           public static partial void INTERNAL_SET_RANDOM_WRITE_TARGET_RT(System.Int32 index, nint uav); 
*/
            /// <summary>
            /// static  System.Void Internal_SetRTSimple(UnityEngine.RenderBuffer color, UnityEngine.RenderBuffer depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice)
            /// </summary>
            /// <param name = "color">struct UnityEngine.RenderBuffer</param>
            /// <param name = "depth">struct UnityEngine.RenderBuffer</param>
            /// <param name = "mip">struct System.Int32</param>
            /// <param name = "face">enum UnityEngine.CubemapFace</param>
            /// <param name = "depthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_SetRTSimple", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.CubemapFace", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void INTERNAL_SET_RT_SIMPLE(UnityEngine.RenderBuffer color, UnityEngine.RenderBuffer depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice); 
*/
            /// <summary>
            /// static  System.Void Internal_SetRTSimple_Injected(UnityEngine.RenderBuffer& color, UnityEngine.RenderBuffer& depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice)
            /// </summary>
            /// <param name = "color">struct UnityEngine.RenderBuffer&</param>
            /// <param name = "depth">struct UnityEngine.RenderBuffer&</param>
            /// <param name = "mip">struct System.Int32</param>
            /// <param name = "face">enum UnityEngine.CubemapFace</param>
            /// <param name = "depthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_SetRTSimple_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.CubemapFace", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void INTERNAL_SET_RT_SIMPLE_INJECTED(UnityEngine.RenderBuffer &color, UnityEngine.RenderBuffer &depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice); 
*/
            /// <summary>
            /// static  System.Void RenderMesh(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4 objectToWorld, System.Nullable<UnityEngine.Matrix4x4> prevObjectToWorld)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "objectToWorld">struct UnityEngine.Matrix4x4</param>
            /// <param name = "prevObjectToWorld">struct System.Nullable<UnityEngine.Matrix4x4></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RenderMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Nullable<UnityEngine.Matrix4x4>", 4)]
           public static partial void RENDER_MESH(UnityEngine.RenderParams &rparams, nint mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4 objectToWorld, System.Nullable<UnityEngine.Matrix4x4> prevObjectToWorld); 
*/
            /// <summary>
            /// static  System.Void RenderMeshIndirect(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "commandBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "commandCount">struct System.Int32</param>
            /// <param name = "startCommand">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RenderMeshIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void RENDER_MESH_INDIRECT(UnityEngine.RenderParams &rparams, nint mesh, nint commandBuffer, System.Int32 commandCount, System.Int32 startCommand); 
*/
            /// <summary>
            /// static  System.Void RenderMeshInstanced(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, T[] instanceData, System.Int32 instanceCount, System.Int32 startInstance)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "instanceData">class T[]</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <param name = "startInstance">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RenderMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T[]", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void RENDER_MESH_INSTANCED(UnityEngine.RenderParams &rparams, nint mesh, System.Int32 submeshIndex, nint instanceData, System.Int32 instanceCount, System.Int32 startInstance); 
*/
            /// <summary>
            /// static  System.Void RenderMeshInstanced(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.Collections.Generic.List<T> instanceData, System.Int32 instanceCount, System.Int32 startInstance)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "instanceData">class System.Collections.Generic.List<T></param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <param name = "startInstance">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RenderMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<T>", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void RENDER_MESH_INSTANCED(UnityEngine.RenderParams &rparams, nint mesh, System.Int32 submeshIndex, nint instanceData, System.Int32 instanceCount, System.Int32 startInstance); 
*/
            /// <summary>
            /// static  System.Void RenderMeshInstanced(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, Unity.Collections.NativeArray<T> instanceData, System.Int32 instanceCount, System.Int32 startInstance)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams</param>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "instanceData">struct Unity.Collections.NativeArray<T></param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <param name = "startInstance">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RenderMeshInstanced", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Unity.Collections.NativeArray<T>", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void RENDER_MESH_INSTANCED(UnityEngine.RenderParams rparams, nint mesh, System.Int32 submeshIndex, Unity.Collections.NativeArray<T> instanceData, System.Int32 instanceCount, System.Int32 startInstance); 
*/
            /// <summary>
            /// static  System.Void RenderMeshPrimitives(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.Int32 instanceCount)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "mesh">class UnityEngine.Mesh</param>
            /// <param name = "submeshIndex">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RenderMeshPrimitives", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Mesh", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void RENDER_MESH_PRIMITIVES(UnityEngine.RenderParams &rparams, nint mesh, System.Int32 submeshIndex, System.Int32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void RenderPrimitives(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "vertexCount">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RenderPrimitives", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void RENDER_PRIMITIVES(UnityEngine.RenderParams &rparams, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void RenderPrimitivesIndexed(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 startIndex, System.Int32 instanceCount)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "indexCount">struct System.Int32</param>
            /// <param name = "startIndex">struct System.Int32</param>
            /// <param name = "instanceCount">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RenderPrimitivesIndexed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void RENDER_PRIMITIVES_INDEXED(UnityEngine.RenderParams &rparams, UnityEngine.MeshTopology topology, nint indexBuffer, System.Int32 indexCount, System.Int32 startIndex, System.Int32 instanceCount); 
*/
            /// <summary>
            /// static  System.Void RenderPrimitivesIndexedIndirect(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "indexBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "commandBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "commandCount">struct System.Int32</param>
            /// <param name = "startCommand">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RenderPrimitivesIndexedIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial void RENDER_PRIMITIVES_INDEXED_INDIRECT(UnityEngine.RenderParams &rparams, UnityEngine.MeshTopology topology, nint indexBuffer, nint commandBuffer, System.Int32 commandCount, System.Int32 startCommand); 
*/
            /// <summary>
            /// static  System.Void RenderPrimitivesIndirect(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
            /// </summary>
            /// <param name = "rparams">struct UnityEngine.RenderParams&</param>
            /// <param name = "topology">enum UnityEngine.MeshTopology</param>
            /// <param name = "commandBuffer">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "commandCount">struct System.Int32</param>
            /// <param name = "startCommand">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RenderPrimitivesIndirect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderParams&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MeshTopology", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void RENDER_PRIMITIVES_INDIRECT(UnityEngine.RenderParams &rparams, UnityEngine.MeshTopology topology, nint commandBuffer, System.Int32 commandCount, System.Int32 startCommand); 
*/
            /// <summary>
            /// static  System.Void set_activeTier(UnityEngine.Rendering.GraphicsTier value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.Rendering.GraphicsTier</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_activeTier", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.GraphicsTier", 0)]
           public static partial void SET_ACTIVE_TIER(UnityEngine.Rendering.GraphicsTier value); 
*/
            /// <summary>
            /// static  System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.RenderTexture uav)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "uav">class UnityEngine.RenderTexture</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRandomWriteTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 1)]
           public static partial void SET_RANDOM_WRITE_TARGET(System.Int32 index, nint uav); 
*/
            /// <summary>
            /// static  System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.ComputeBuffer uav, System.Boolean preserveCounterValue)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "uav">class UnityEngine.ComputeBuffer</param>
            /// <param name = "preserveCounterValue">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRandomWriteTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
           public static partial void SET_RANDOM_WRITE_TARGET(System.Int32 index, nint uav, System.Boolean preserveCounterValue); 
*/
            /// <summary>
            /// static  System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.GraphicsBuffer uav, System.Boolean preserveCounterValue)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "uav">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "preserveCounterValue">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRandomWriteTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
           public static partial void SET_RANDOM_WRITE_TARGET(System.Int32 index, nint uav, System.Boolean preserveCounterValue); 
*/
            /// <summary>
            /// static  System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.ComputeBuffer uav)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "uav">class UnityEngine.ComputeBuffer</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRandomWriteTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ComputeBuffer", 1)]
           public static partial void SET_RANDOM_WRITE_TARGET(System.Int32 index, nint uav); 
*/
            /// <summary>
            /// static  System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.GraphicsBuffer uav)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "uav">class UnityEngine.GraphicsBuffer</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRandomWriteTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 1)]
           public static partial void SET_RANDOM_WRITE_TARGET(System.Int32 index, nint uav); 
*/
            /// <summary>
            /// static  System.Void SetRenderTarget(UnityEngine.RenderTexture rt, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice)
            /// </summary>
            /// <param name = "rt">class UnityEngine.RenderTexture</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <param name = "face">enum UnityEngine.CubemapFace</param>
            /// <param name = "depthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.CubemapFace", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void SET_RENDER_TARGET(nint rt, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice); 
*/
            /// <summary>
            /// static  System.Void SetRenderTarget(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice)
            /// </summary>
            /// <param name = "colorBuffer">struct UnityEngine.RenderBuffer</param>
            /// <param name = "depthBuffer">struct UnityEngine.RenderBuffer</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <param name = "face">enum UnityEngine.CubemapFace</param>
            /// <param name = "depthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.CubemapFace", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void SET_RENDER_TARGET(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice); 
*/
            /// <summary>
            /// static  System.Void SetRenderTarget(UnityEngine.RenderBuffer[] colorBuffers, UnityEngine.RenderBuffer depthBuffer)
            /// </summary>
            /// <param name = "colorBuffers">class UnityEngine.RenderBuffer[]</param>
            /// <param name = "depthBuffer">struct UnityEngine.RenderBuffer</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 1)]
           public static partial void SET_RENDER_TARGET(nint colorBuffers, UnityEngine.RenderBuffer depthBuffer); 
*/
            /// <summary>
            /// static  System.Void SetRenderTarget(UnityEngine.RenderTargetSetup setup)
            /// </summary>
            /// <param name = "setup">struct UnityEngine.RenderTargetSetup</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTargetSetup", 0)]
           public static partial void SET_RENDER_TARGET(UnityEngine.RenderTargetSetup setup); 
*/
            /// <summary>
            /// static  System.Void SetRenderTarget(UnityEngine.RenderTexture rt)
            /// </summary>
            /// <param name = "rt">class UnityEngine.RenderTexture</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 0)]
           public static partial void SET_RENDER_TARGET(nint rt); 
*/
            /// <summary>
            /// static  System.Void SetRenderTarget(UnityEngine.RenderTexture rt, System.Int32 mipLevel)
            /// </summary>
            /// <param name = "rt">class UnityEngine.RenderTexture</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public static partial void SET_RENDER_TARGET(nint rt, System.Int32 mipLevel); 
*/
            /// <summary>
            /// static  System.Void SetRenderTarget(UnityEngine.RenderTexture rt, System.Int32 mipLevel, UnityEngine.CubemapFace face)
            /// </summary>
            /// <param name = "rt">class UnityEngine.RenderTexture</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <param name = "face">enum UnityEngine.CubemapFace</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.CubemapFace", 2)]
           public static partial void SET_RENDER_TARGET(nint rt, System.Int32 mipLevel, UnityEngine.CubemapFace face); 
*/
            /// <summary>
            /// static  System.Void SetRenderTarget(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer)
            /// </summary>
            /// <param name = "colorBuffer">struct UnityEngine.RenderBuffer</param>
            /// <param name = "depthBuffer">struct UnityEngine.RenderBuffer</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 1)]
           public static partial void SET_RENDER_TARGET(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer); 
*/
            /// <summary>
            /// static  System.Void SetRenderTarget(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel)
            /// </summary>
            /// <param name = "colorBuffer">struct UnityEngine.RenderBuffer</param>
            /// <param name = "depthBuffer">struct UnityEngine.RenderBuffer</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public static partial void SET_RENDER_TARGET(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel); 
*/
            /// <summary>
            /// static  System.Void SetRenderTarget(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face)
            /// </summary>
            /// <param name = "colorBuffer">struct UnityEngine.RenderBuffer</param>
            /// <param name = "depthBuffer">struct UnityEngine.RenderBuffer</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <param name = "face">enum UnityEngine.CubemapFace</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTarget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.CubemapFace", 3)]
           public static partial void SET_RENDER_TARGET(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face); 
*/
            /// <summary>
            /// static  System.Void SetRenderTargetImpl(UnityEngine.RenderTargetSetup setup)
            /// </summary>
            /// <param name = "setup">struct UnityEngine.RenderTargetSetup</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTargetImpl", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTargetSetup", 0)]
           public static partial void SET_RENDER_TARGET_IMPL(UnityEngine.RenderTargetSetup setup); 
*/
            /// <summary>
            /// static  System.Void SetRenderTargetImpl(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice)
            /// </summary>
            /// <param name = "colorBuffer">struct UnityEngine.RenderBuffer</param>
            /// <param name = "depthBuffer">struct UnityEngine.RenderBuffer</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <param name = "face">enum UnityEngine.CubemapFace</param>
            /// <param name = "depthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTargetImpl", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.CubemapFace", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void SET_RENDER_TARGET_IMPL(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice); 
*/
            /// <summary>
            /// static  System.Void SetRenderTargetImpl(UnityEngine.RenderTexture rt, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice)
            /// </summary>
            /// <param name = "rt">class UnityEngine.RenderTexture</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <param name = "face">enum UnityEngine.CubemapFace</param>
            /// <param name = "depthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTargetImpl", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderTexture", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.CubemapFace", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public static partial void SET_RENDER_TARGET_IMPL(nint rt, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice); 
*/
            /// <summary>
            /// static  System.Void SetRenderTargetImpl(UnityEngine.RenderBuffer[] colorBuffers, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice)
            /// </summary>
            /// <param name = "colorBuffers">class UnityEngine.RenderBuffer[]</param>
            /// <param name = "depthBuffer">struct UnityEngine.RenderBuffer</param>
            /// <param name = "mipLevel">struct System.Int32</param>
            /// <param name = "face">enum UnityEngine.CubemapFace</param>
            /// <param name = "depthSlice">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRenderTargetImpl", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer[]", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RenderBuffer", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.CubemapFace", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           public static partial void SET_RENDER_TARGET_IMPL(nint colorBuffers, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice); 
*/
            /// <summary>
            /// static  System.Void ValidateCopyBuffer(UnityEngine.GraphicsBuffer source, UnityEngine.GraphicsBuffer dest)
            /// </summary>
            /// <param name = "source">class UnityEngine.GraphicsBuffer</param>
            /// <param name = "dest">class UnityEngine.GraphicsBuffer</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ValidateCopyBuffer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GraphicsBuffer", 1)]
           public static partial void VALIDATE_COPY_BUFFER(nint source, nint dest); 
*/
            /// <summary>
            /// static  System.Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence)
            /// </summary>
            /// <param name = "fence">struct UnityEngine.Rendering.GraphicsFence</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("WaitOnAsyncGraphicsFence", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.GraphicsFence", 0)]
           public static partial void WAIT_ON_ASYNC_GRAPHICS_FENCE(UnityEngine.Rendering.GraphicsFence fence); 
*/
            /// <summary>
            /// static  System.Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStage stage)
            /// </summary>
            /// <param name = "fence">struct UnityEngine.Rendering.GraphicsFence</param>
            /// <param name = "stage">enum UnityEngine.Rendering.SynchronisationStage</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("WaitOnAsyncGraphicsFence", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.GraphicsFence", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.SynchronisationStage", 1)]
           public static partial void WAIT_ON_ASYNC_GRAPHICS_FENCE(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStage stage); 
*/
            /// <summary>
            /// static  System.Void WaitOnGPUFenceImpl(System.IntPtr fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage)
            /// </summary>
            /// <param name = "fencePtr">struct System.IntPtr</param>
            /// <param name = "stage">enum UnityEngine.Rendering.SynchronisationStageFlags</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("WaitOnGPUFenceImpl", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.SynchronisationStageFlags", 1)]
           public static partial void WAIT_ON_GPU_FENCE_IMPL(System.IntPtr fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public partial void CTOR(); 
*/
        }
    }
}
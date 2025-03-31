using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.MetadataUnity
{
    /// <summary>
    /// static class ["UnityEngine.ImageConversionModule"."UnityEngine"."ImageConversion"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ImageConversion>, Ptr_ImageConversion>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("UnityEngine.ImageConversionModule", "UnityEngine", "ImageConversion", "UnityEngine.ImageConversion")]
    public partial class ImageConversion
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ImageConversion(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ImageConversion(System.IntPtr ptr) => new Ptr_ImageConversion(ptr);
            public static implicit operator System.IntPtr(Ptr_ImageConversion ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_ImageConversion ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// static class ["UnityEngine.ImageConversionModule"."UnityEngine"."ImageConversion"]
        /// </summary>
        partial struct Ptr_ImageConversion
        {
        }

        /// <summary>
        /// static class ["UnityEngine.ImageConversionModule"."UnityEngine"."ImageConversion"]
        /// </summary>
        partial struct Ptr_ImageConversion
        {
            /// <summary>
            /// static  System.Byte[] EncodeArrayToEXR(System.Array array, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes, UnityEngine.Texture2D.EXRFlags flags)
            /// </summary>
            /// <param name = "array">abstract class System.Array</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "width">struct System.UInt32</param>
            /// <param name = "height">struct System.UInt32</param>
            /// <param name = "rowBytes">struct System.UInt32</param>
            /// <param name = "flags">enum UnityEngine.Texture2D.EXRFlags</param>
            /// <returns>class System.Byte[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EncodeArrayToEXR", "System.Byte[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Array", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D.EXRFlags", 5)]
           public static partial nint ENCODE_ARRAY_TO_EXR(nint array, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes, UnityEngine.Texture2D.EXRFlags flags); 
*/
            /// <summary>
            /// static  System.Byte[] EncodeArrayToJPG(System.Array array, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes, System.Int32 quality)
            /// </summary>
            /// <param name = "array">abstract class System.Array</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "width">struct System.UInt32</param>
            /// <param name = "height">struct System.UInt32</param>
            /// <param name = "rowBytes">struct System.UInt32</param>
            /// <param name = "quality">struct System.Int32</param>
            /// <returns>class System.Byte[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EncodeArrayToJPG", "System.Byte[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Array", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial nint ENCODE_ARRAY_TO_JPG(nint array, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes, System.Int32 quality); 
*/
            /// <summary>
            /// static  System.Byte[] EncodeArrayToPNG(System.Array array, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes)
            /// </summary>
            /// <param name = "array">abstract class System.Array</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "width">struct System.UInt32</param>
            /// <param name = "height">struct System.UInt32</param>
            /// <param name = "rowBytes">struct System.UInt32</param>
            /// <returns>class System.Byte[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EncodeArrayToPNG", "System.Byte[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Array", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           public static partial nint ENCODE_ARRAY_TO_PNG(nint array, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes); 
*/
            /// <summary>
            /// static  System.Byte[] EncodeArrayToTGA(System.Array array, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes)
            /// </summary>
            /// <param name = "array">abstract class System.Array</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "width">struct System.UInt32</param>
            /// <param name = "height">struct System.UInt32</param>
            /// <param name = "rowBytes">struct System.UInt32</param>
            /// <returns>class System.Byte[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EncodeArrayToTGA", "System.Byte[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Array", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           public static partial nint ENCODE_ARRAY_TO_TGA(nint array, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes); 
*/
            /// <summary>
            /// static  Unity.Collections.NativeArray<System.Byte> EncodeNativeArrayToEXR(Unity.Collections.NativeArray<T> input, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes, UnityEngine.Texture2D.EXRFlags flags)
            /// </summary>
            /// <param name = "input">struct Unity.Collections.NativeArray<T></param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "width">struct System.UInt32</param>
            /// <param name = "height">struct System.UInt32</param>
            /// <param name = "rowBytes">struct System.UInt32</param>
            /// <param name = "flags">enum UnityEngine.Texture2D.EXRFlags</param>
            /// <returns>struct Unity.Collections.NativeArray<System.Byte></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EncodeNativeArrayToEXR", "Unity.Collections.NativeArray<System.Byte>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Unity.Collections.NativeArray<T>", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D.EXRFlags", 5)]
           public static partial Unity.Collections.NativeArray<System.Byte> ENCODE_NATIVE_ARRAY_TO_EXR(Unity.Collections.NativeArray<T> input, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes, UnityEngine.Texture2D.EXRFlags flags); 
*/
            /// <summary>
            /// static  Unity.Collections.NativeArray<System.Byte> EncodeNativeArrayToJPG(Unity.Collections.NativeArray<T> input, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes, System.Int32 quality)
            /// </summary>
            /// <param name = "input">struct Unity.Collections.NativeArray<T></param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "width">struct System.UInt32</param>
            /// <param name = "height">struct System.UInt32</param>
            /// <param name = "rowBytes">struct System.UInt32</param>
            /// <param name = "quality">struct System.Int32</param>
            /// <returns>struct Unity.Collections.NativeArray<System.Byte></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EncodeNativeArrayToJPG", "Unity.Collections.NativeArray<System.Byte>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Unity.Collections.NativeArray<T>", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
           public static partial Unity.Collections.NativeArray<System.Byte> ENCODE_NATIVE_ARRAY_TO_JPG(Unity.Collections.NativeArray<T> input, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes, System.Int32 quality); 
*/
            /// <summary>
            /// static  Unity.Collections.NativeArray<System.Byte> EncodeNativeArrayToPNG(Unity.Collections.NativeArray<T> input, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes)
            /// </summary>
            /// <param name = "input">struct Unity.Collections.NativeArray<T></param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "width">struct System.UInt32</param>
            /// <param name = "height">struct System.UInt32</param>
            /// <param name = "rowBytes">struct System.UInt32</param>
            /// <returns>struct Unity.Collections.NativeArray<System.Byte></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EncodeNativeArrayToPNG", "Unity.Collections.NativeArray<System.Byte>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Unity.Collections.NativeArray<T>", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           public static partial Unity.Collections.NativeArray<System.Byte> ENCODE_NATIVE_ARRAY_TO_PNG(Unity.Collections.NativeArray<T> input, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes); 
*/
            /// <summary>
            /// static  Unity.Collections.NativeArray<System.Byte> EncodeNativeArrayToTGA(Unity.Collections.NativeArray<T> input, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes)
            /// </summary>
            /// <param name = "input">struct Unity.Collections.NativeArray<T></param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "width">struct System.UInt32</param>
            /// <param name = "height">struct System.UInt32</param>
            /// <param name = "rowBytes">struct System.UInt32</param>
            /// <returns>struct Unity.Collections.NativeArray<System.Byte></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EncodeNativeArrayToTGA", "Unity.Collections.NativeArray<System.Byte>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Unity.Collections.NativeArray<T>", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           public static partial Unity.Collections.NativeArray<System.Byte> ENCODE_NATIVE_ARRAY_TO_TGA(Unity.Collections.NativeArray<T> input, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes); 
*/
            /// <summary>
            /// static  System.Byte[] EncodeToEXR(UnityEngine.Texture2D tex, UnityEngine.Texture2D.EXRFlags flags)
            /// </summary>
            /// <param name = "tex">class UnityEngine.Texture2D</param>
            /// <param name = "flags">enum UnityEngine.Texture2D.EXRFlags</param>
            /// <returns>class System.Byte[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EncodeToEXR", "System.Byte[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D.EXRFlags", 1)]
           public static partial nint ENCODE_TO_EXR(nint tex, UnityEngine.Texture2D.EXRFlags flags); 
*/
            /// <summary>
            /// static  System.Byte[] EncodeToEXR(UnityEngine.Texture2D tex)
            /// </summary>
            /// <param name = "tex">class UnityEngine.Texture2D</param>
            /// <returns>class System.Byte[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EncodeToEXR", "System.Byte[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           public static partial nint ENCODE_TO_EXR(nint tex); 
*/
            /// <summary>
            /// static  System.Byte[] EncodeToJPG(UnityEngine.Texture2D tex, System.Int32 quality)
            /// </summary>
            /// <param name = "tex">class UnityEngine.Texture2D</param>
            /// <param name = "quality">struct System.Int32</param>
            /// <returns>class System.Byte[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EncodeToJPG", "System.Byte[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public static partial nint ENCODE_TO_JPG(nint tex, System.Int32 quality); 
*/
            /// <summary>
            /// static  System.Byte[] EncodeToJPG(UnityEngine.Texture2D tex)
            /// </summary>
            /// <param name = "tex">class UnityEngine.Texture2D</param>
            /// <returns>class System.Byte[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EncodeToJPG", "System.Byte[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           public static partial nint ENCODE_TO_JPG(nint tex); 
*/
            /// <summary>
            /// static  System.Byte[] EncodeToPNG(UnityEngine.Texture2D tex)
            /// </summary>
            /// <param name = "tex">class UnityEngine.Texture2D</param>
            /// <returns>class System.Byte[]</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EncodeToPNG", "System.Byte[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
            public static partial PMonoArray<byte> ENCODE_TO_PNG(Texture2D.Ptr_Texture2D tex);

            /// <summary>
            /// static  System.Byte[] EncodeToTGA(UnityEngine.Texture2D tex)
            /// </summary>
            /// <param name = "tex">class UnityEngine.Texture2D</param>
            /// <returns>class System.Byte[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EncodeToTGA", "System.Byte[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           public static partial nint ENCODE_TO_TGA(nint tex); 
*/
            /// <summary>
            /// static  System.Boolean get_EnableLegacyPngGammaRuntimeLoadBehavior()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EnableLegacyPngGammaRuntimeLoadBehavior", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.Boolean GET_ENABLE_LEGACY_PNG_GAMMA_RUNTIME_LOAD_BEHAVIOR(); 
*/
            /// <summary>
            /// static  System.Boolean GetEnableLegacyPngGammaRuntimeLoadBehavior()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEnableLegacyPngGammaRuntimeLoadBehavior", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           public static partial System.Boolean GET_ENABLE_LEGACY_PNG_GAMMA_RUNTIME_LOAD_BEHAVIOR(); 
*/
            /// <summary>
            /// static  System.Boolean LoadImage(UnityEngine.Texture2D tex, System.Byte[] data, System.Boolean markNonReadable)
            /// </summary>
            /// <param name = "tex">class UnityEngine.Texture2D</param>
            /// <param name = "data">class System.Byte[]</param>
            /// <param name = "markNonReadable">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadImage", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Byte[]", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
           public static partial System.Boolean LOAD_IMAGE(nint tex, nint data, System.Boolean markNonReadable); 
*/
            /// <summary>
            /// static  System.Boolean LoadImage(UnityEngine.Texture2D tex, System.Byte[] data)
            /// </summary>
            /// <param name = "tex">class UnityEngine.Texture2D</param>
            /// <param name = "data">class System.Byte[]</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadImage", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Byte[]", 1)]
           public static partial System.Boolean LOAD_IMAGE(nint tex, nint data); 
*/
            /// <summary>
            /// static  System.Void set_EnableLegacyPngGammaRuntimeLoadBehavior(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_EnableLegacyPngGammaRuntimeLoadBehavior", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public static partial void SET_ENABLE_LEGACY_PNG_GAMMA_RUNTIME_LOAD_BEHAVIOR(System.Boolean value); 
*/
            /// <summary>
            /// static  System.Void SetEnableLegacyPngGammaRuntimeLoadBehavior(System.Boolean enable)
            /// </summary>
            /// <param name = "enable">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetEnableLegacyPngGammaRuntimeLoadBehavior", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public static partial void SET_ENABLE_LEGACY_PNG_GAMMA_RUNTIME_LOAD_BEHAVIOR(System.Boolean enable); 
*/
            /// <summary>
            /// static  System.Void* UnsafeEncodeNativeArrayToEXR(System.Void* array, System.Int32& sizeInBytes, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes, UnityEngine.Texture2D.EXRFlags flags)
            /// </summary>
            /// <param name = "array">class System.Void*</param>
            /// <param name = "sizeInBytes">struct System.Int32&</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "width">struct System.UInt32</param>
            /// <param name = "height">struct System.UInt32</param>
            /// <param name = "rowBytes">struct System.UInt32</param>
            /// <param name = "flags">enum UnityEngine.Texture2D.EXRFlags</param>
            /// <returns>class System.Void*</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnsafeEncodeNativeArrayToEXR", "System.Void*", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Void*", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D.EXRFlags", 6)]
           public static partial nint UNSAFE_ENCODE_NATIVE_ARRAY_TO_EXR(nint array, System.Int32 &sizeInBytes, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes, UnityEngine.Texture2D.EXRFlags flags); 
*/
            /// <summary>
            /// static  System.Void* UnsafeEncodeNativeArrayToJPG(System.Void* array, System.Int32& sizeInBytes, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes, System.Int32 quality)
            /// </summary>
            /// <param name = "array">class System.Void*</param>
            /// <param name = "sizeInBytes">struct System.Int32&</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "width">struct System.UInt32</param>
            /// <param name = "height">struct System.UInt32</param>
            /// <param name = "rowBytes">struct System.UInt32</param>
            /// <param name = "quality">struct System.Int32</param>
            /// <returns>class System.Void*</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnsafeEncodeNativeArrayToJPG", "System.Void*", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Void*", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
           public static partial nint UNSAFE_ENCODE_NATIVE_ARRAY_TO_JPG(nint array, System.Int32 &sizeInBytes, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes, System.Int32 quality); 
*/
            /// <summary>
            /// static  System.Void* UnsafeEncodeNativeArrayToPNG(System.Void* array, System.Int32& sizeInBytes, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes)
            /// </summary>
            /// <param name = "array">class System.Void*</param>
            /// <param name = "sizeInBytes">struct System.Int32&</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "width">struct System.UInt32</param>
            /// <param name = "height">struct System.UInt32</param>
            /// <param name = "rowBytes">struct System.UInt32</param>
            /// <returns>class System.Void*</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnsafeEncodeNativeArrayToPNG", "System.Void*", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Void*", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 5)]
           public static partial nint UNSAFE_ENCODE_NATIVE_ARRAY_TO_PNG(nint array, System.Int32 &sizeInBytes, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes); 
*/
            /// <summary>
            /// static  System.Void* UnsafeEncodeNativeArrayToTGA(System.Void* array, System.Int32& sizeInBytes, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes)
            /// </summary>
            /// <param name = "array">class System.Void*</param>
            /// <param name = "sizeInBytes">struct System.Int32&</param>
            /// <param name = "format">enum UnityEngine.Experimental.Rendering.GraphicsFormat</param>
            /// <param name = "width">struct System.UInt32</param>
            /// <param name = "height">struct System.UInt32</param>
            /// <param name = "rowBytes">struct System.UInt32</param>
            /// <returns>class System.Void*</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnsafeEncodeNativeArrayToTGA", "System.Void*", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Void*", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Experimental.Rendering.GraphicsFormat", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 5)]
           public static partial nint UNSAFE_ENCODE_NATIVE_ARRAY_TO_TGA(nint array, System.Int32 &sizeInBytes, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.UInt32 width, System.UInt32 height, System.UInt32 rowBytes); 
*/
        }
    }
}
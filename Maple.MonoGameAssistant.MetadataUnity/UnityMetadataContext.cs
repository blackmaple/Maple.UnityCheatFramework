using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataService;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.MetadataUnity
{
    [ContextParentMetadata<ContextMetadataCollector>(true)]
    [ContextMemberMetadata<Graphics>]
    [ContextMemberMetadata<ImageConversion>]
    [ContextMemberMetadata<RenderTexture>]
    [ContextMemberMetadata<Sprite>]
    [ContextMemberMetadata<Texture2D>]
    public partial class UnityMetadataContext : IUnityPlayerNativeMethods
    {

        private static void CopyToTexture2D_TYPE1(Texture2D.Ptr_Texture2D pSrc, Texture2D.Ptr_Texture2D pDest)
        {
            var w = pSrc.GET_WIDTH();
            var h = pSrc.GET_HEIGHT();

            var pRenderTexture = RenderTexture.Ptr_RenderTexture.GET_TEMPORARY(w, h, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
            Graphics.Ptr_Graphics.BLIT2(pSrc, pRenderTexture);

            var previous = RenderTexture.Ptr_RenderTexture.GET_ACTIVE();
            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(pRenderTexture);

            pDest.CTOR(w, h);
            var rect = new Rect.Ref_Rect() { m_XMin = 0, m_YMin = 0, m_Height = h, m_Width = w };
            pDest.READ_PIXELS_IMPL_INJECTED(MapleRef<Rect.Ref_Rect>.FromRef(ref rect), 0, 0, true);
            pDest.APPLY();

            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(previous);
            RenderTexture.Ptr_RenderTexture.RELEASE_TEMPORARY(pRenderTexture);

        }

        private static void CopyToTexture2D_TYPE2(Texture2D.Ptr_Texture2D pSrc, Texture2D.Ptr_Texture2D pDest, in Rect.Ref_Rect ref_Rect)
        {
            var texture2D_width = pSrc.GET_WIDTH();
            var texture2D_height = pSrc.GET_HEIGHT();
 
            var pRenderTexture = RenderTexture.Ptr_RenderTexture.GET_TEMPORARY(texture2D_width, texture2D_height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
            Graphics.Ptr_Graphics.BLIT2(pSrc, pRenderTexture);
 
            var previous = RenderTexture.Ptr_RenderTexture.GET_ACTIVE();
            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(pRenderTexture);
 
            var w = (int)ref_Rect.m_Width;
            var h = (int)ref_Rect.m_Height;
            float textureY = texture2D_height - (ref_Rect.m_YMin + ref_Rect.m_Height);
            pDest.CTOR(w, h);
 
            var rect = new Rect.Ref_Rect() { m_XMin = ref_Rect.m_XMin, m_YMin = textureY, m_Width = ref_Rect.m_Width, m_Height = ref_Rect.m_Height };
            pDest.READ_PIXELS_IMPL_INJECTED(MapleRef<Rect.Ref_Rect>.FromRef(ref rect), 0, 0, true);
            pDest.APPLY();
 
            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(previous);
            RenderTexture.Ptr_RenderTexture.RELEASE_TEMPORARY(pRenderTexture);
 
        }

        private static void CopyToTexture2D_TYPE3(Texture2D.Ptr_Texture2D pSrc, Texture2D.Ptr_Texture2D pDest, in Rect.Ref_Rect ref_Rect)
        {
            var texture2D_width = pSrc.GET_WIDTH();
            var texture2D_height = pSrc.GET_HEIGHT();

            var pRenderTexture = RenderTexture.Ptr_RenderTexture.GET_TEMPORARY(texture2D_width, texture2D_height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
            Graphics.Ptr_Graphics.BLIT2(pSrc, pRenderTexture);

            var previous = RenderTexture.Ptr_RenderTexture.GET_ACTIVE();
            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(pRenderTexture);

            var w = (int)ref_Rect.m_Width;
            var h = (int)ref_Rect.m_Height;

            pDest.CTOR(w, h);
            pDest.READ_PIXELS_IMPL_INJECTED(MapleRef<Rect.Ref_Rect>.FromRef(ref Unsafe.AsRef(in ref_Rect)), 0, 0, true);
            pDest.APPLY();

            RenderTexture.Ptr_RenderTexture.SET_ACTIVE(previous);
            RenderTexture.Ptr_RenderTexture.RELEASE_TEMPORARY(pRenderTexture);

        }


        public PMonoArray<byte> ReadSprite2Png(nint ptr_Sprite, IUnityPlayerNativeMethods.ReadSpriteType type = IUnityPlayerNativeMethods.ReadSpriteType.TYPE2)
        {
            Sprite.Ptr_Sprite pSprite = ptr_Sprite;
            if (false == pSprite.IsNotNull())
            {
                return default;
            }
            var pSrcTexture2D = pSprite.GET_TEXTURE();
         
            if (false == pSrcTexture2D.IsNotNull())
            {
                return default;
            }
            var pDestTexture2D = this.Texture2D.New();
         
            switch (type)
            {
                case IUnityPlayerNativeMethods.ReadSpriteType.TYPE2:
                    {
                       
                        pSprite.GET_TEXTURE_RECT_INJECTED(MapleOut<Rect.Ref_Rect>.FromOut(out var ref_Rect));
                       
                        CopyToTexture2D_TYPE2(pSrcTexture2D, pDestTexture2D, ref_Rect);
                       
                        break;
                    }
                case IUnityPlayerNativeMethods.ReadSpriteType.TYPE3:
                    {
                        pSprite.GET_TEXTURE_RECT_INJECTED(MapleOut<Rect.Ref_Rect>.FromOut(out var ref_Rect));
                        CopyToTexture2D_TYPE3(pSrcTexture2D, pDestTexture2D, ref_Rect);
                        break;
                    }
                case IUnityPlayerNativeMethods.ReadSpriteType.TYPE1:
                default:
                    {
                        CopyToTexture2D_TYPE1(pSrcTexture2D, pDestTexture2D);
                        break;
                    }
            }

            return ImageConversion.Ptr_ImageConversion.ENCODE_TO_PNG(pDestTexture2D);
        }

        public static UnityMetadataContext? CreateUnityMetadataContext(MonoRuntimeContext runtimeContext, ILogger logger)
        {
            var searchService = new MetadataCollectorSearchService();
            searchService.UpdateMetadata(new MonoDescriptionCollectionDTO()
            {
                Classes = MonoJsonClassDTO,
                Methods = MonoJsonMethodDTO,
                Fields = MonoJsonFieldDTO,
            });
            return runtimeContext.RuntimeType switch
            {
                EnumMonoRuntimeType.MONO => new UnityMetadataContext_MONO(logger, searchService, runtimeContext),
                EnumMonoRuntimeType.IL2CPP => new UnityMetadataContext_IL2CPP(logger, searchService, runtimeContext),
                _ => default
            };
        }

    }

    public sealed partial class UnityMetadataContext_MONO(ILogger logger, MetadataCollectorSearchService searchService, MonoRuntimeContext runtimeContext) : UnityMetadataContext(logger, searchService, runtimeContext)
    {
        public static Dictionary<ulong, int> MethodOffsetCache { get; } = [];
        public static nint UnityPlayerBaseAddress { get; } = GetModuleBaseAddress("UnityPlayer.dll");
        public sealed override MonoClassMetadataCollection GetClassMetadataCollection(ulong code)
        {
            if (SearchService.TrySearchClass(code, out var descriptionClassDTO))
            {
                if (TryGetImageMetadata(descriptionClassDTO, out var imageNameDTO))
                {
                    if (TryGetClassMetadata(imageNameDTO, descriptionClassDTO, out var classMetadataCollection))
                    {
                        return classMetadataCollection;
                    }
                }
            }
            return default!;
        }

        public sealed override MonoMethodDelegate GetMethodDelegate(ulong code, MonoClassMetadataCollection classMetadataCollection)
        {
            if (MethodOffsetCache.TryGetValue(code, out var offset))
            {
                return new MonoMethodDelegate(nint.Zero, offset + UnityPlayerBaseAddress);
            }
            return base.GetMethodDelegate(code, classMetadataCollection);

        }

        static nint GetModuleBaseAddress(string moduleName)
        {
            //if (NativeLibrary.TryLoad(moduleName, out var address))
            //{
            //    return address;
            //}
            using var process = Process.GetCurrentProcess();
            foreach (ProcessModule module in process.Modules)
            {
                if (module.ModuleName.Contains(moduleName, StringComparison.OrdinalIgnoreCase))
                {
                    return module.BaseAddress;
                }
            }
            return default;
        }
    }

    public sealed partial class UnityMetadataContext_IL2CPP(ILogger logger, MetadataCollectorSearchService searchService, MonoRuntimeContext runtimeContext) : UnityMetadataContext(logger, searchService, runtimeContext)
    {
        /// <summary>
        /// UnityEngine.Sprite.get_texture - 40 53                 - push rbx
        /// </summary>
        public const string UnityEngine_Sprite_get_texture
            = "UnityEngine.Sprite::get_texture()";

        /// <summary>
        /// UnityEngine.Texture.GetDataHeight - 40 53                 - push rbx
        /// </summary>
        public const string UnityEngine_Texture_GetDataHeight
            = "UnityEngine.Texture::GetDataHeight()";

        /// <summary>
        /// UnityEngine.Texture.GetDataWidth - 40 53                 - push rbx
        /// </summary>
        public const string UnityEngine_Texture_GetDataWidth
            = "UnityEngine.Texture::GetDataWidth()";

        /// <summary>
        /// UnityEngine.ImageConversion.EncodeToPNG - 40 53                 - push rbx
        /// </summary>
        public const string UnityEngine_ImageConversion_EncodeToPNG
            = "UnityEngine.ImageConversion::EncodeToPNG(UnityEngine.Texture2D)";

        /// <summary>
        /// UnityEngine.Graphics.Blit2 - 48 89 5C 24 08        - mov [rsp+08],rbx
        /// </summary>
        public const string UnityEngine_Graphics_Blit2
            = "UnityEngine.Graphics::Blit2(UnityEngine.Texture,UnityEngine.RenderTexture)";

        /// <summary>
        /// UnityEngine.Sprite.get_rect_Injected - 48 89 5C 24 08        - mov [rsp+08],rbx
        /// </summary>
        public const string UnityEngine_Sprite_get_rect_Injected
            = "UnityEngine.Sprite::get_rect_Injected(UnityEngine.Rect&)";

        /// <summary>
        /// UnityEngine.Sprite.get_textureRect - 48 89 5C 24 08        - mov [rsp+08],rbx
        /// </summary>
        public const string UnityEngine_Sprite_GetTextureRect_Injected
            = "UnityEngine.Sprite::GetTextureRect_Injected(UnityEngine.Rect&)";

        public const string UnityEngine_RenderTexture_GetTemporary_Internal_Injected
            = "UnityEngine.RenderTexture::GetTemporary_Internal_Injected(UnityEngine.RenderTextureDescriptor&)";

        /// <summary>
        /// UnityEngine.RenderTexture.get_active - 48 83 EC 28           - sub rsp,28 { 40 }
        /// </summary>
        public const string UnityEngine_RenderTexture_GetActive = "UnityEngine.RenderTexture::GetActive()";

        /// <summary>
        /// UnityEngine.RenderTexture.SetActive - 40 53                 - push rbx
        /// </summary>
        public const string UnityEngine_RenderTexture_SetActive = "UnityEngine.RenderTexture::SetActive(UnityEngine.RenderTexture)";


        /// <summary>
        /// UnityEngine.RenderTexture.ReleaseTemporary - 40 53                 - push rbx
        /// </summary>
        public const string UnityEngine_RenderTexture_ReleaseTemporary = "UnityEngine.RenderTexture::ReleaseTemporary(UnityEngine.RenderTexture)";

        /// <summary>
        /// 
        /// UnityEngine.Texture2D.ReadPixelsImpl_Injected - 48 89 5C 24 08        - mov [rsp+08],rbx
        /// </summary>
        public const string UnityEngine_Texture2D_ReadPixelsImpl_Injected = "UnityEngine.Texture2D::ReadPixelsImpl_Injected(UnityEngine.Rect&,System.Int32,System.Int32,System.Boolean)";

        public static Dictionary<ulong, string> MethodSignatureCache { get; } = new Dictionary<ulong, string>
        {
            [Maple.MonoGameAssistant.MetadataUnity.Sprite.Code_FunctionPointerType_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F]
                = UnityEngine_Sprite_GetTextureRect_Injected,

            [Maple.MonoGameAssistant.MetadataUnity.Texture2D.Code_FunctionPointerType_READ_PIXELS_IMPL_INJECTED_3D6557C7BC276B18]
                = UnityEngine_Texture2D_ReadPixelsImpl_Injected,

            [Maple.MonoGameAssistant.MetadataUnity.Graphics.Code_FunctionPointerType_BLIT2_E9370053514A1DE4]
                = UnityEngine_Graphics_Blit2,

            [Maple.MonoGameAssistant.MetadataUnity.ImageConversion.Code_FunctionPointerType_ENCODE_TO_PNG_B997C8D2C1188DD2]
                = UnityEngine_ImageConversion_EncodeToPNG,
        };

        public sealed override MonoClassMetadataCollection GetClassMetadataCollection(ulong code)
        {
            if (SearchService.TrySearchClass(code, out var descriptionClassDTO))
            {
                if (TryGetImageMetadata(descriptionClassDTO, out var imageNameDTO))
                {
                    if (TryGetClassMetadata(imageNameDTO, descriptionClassDTO, out var classMetadataCollection))
                    {
                        return classMetadataCollection;
                    }
                }
            }
            return default!;
        }


        public sealed override MonoMethodDelegate GetMethodDelegate(ulong code, MonoClassMetadataCollection classMetadataCollection)
        {
            if (MethodSignatureCache.TryGetValue(code, out var signature))
            {
                return new(nint.Zero, this.RuntimeContext.GetInternalCall(signature));
            }
            return base.GetMethodDelegate(code, classMetadataCollection);
        }
    }

    //partial class Sprite
    //{
    //    public static nint Get1() => Unsafe.As<FunctionPointerType_GET_TEXTURE_9E369564B1447B9B, nint>(ref s_FunctionPointerType_GET_TEXTURE_9E369564B1447B9B);
    //    public static nint Get2() => Unsafe.As<FunctionPointerType_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F, nint>(ref s_FunctionPointerType_GET_TEXTURE_RECT_INJECTED_991A7878D43EDC7F);

    //}
}

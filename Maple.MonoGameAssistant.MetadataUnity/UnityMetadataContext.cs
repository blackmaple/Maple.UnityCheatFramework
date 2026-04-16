using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataService;
using Maple.MonoGameAssistant.MetadataUnity.UnityMetadata;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataUnity
{
    [ContextParentMetadata<ContextMetadataCollector>(true)]
    [ContextMemberMetadata<Graphics>]
    [ContextMemberMetadata<ImageConversion>]
    [ContextMemberMetadata<RenderTexture>]
    [ContextMemberMetadata<Sprite>]
    [ContextMemberMetadata<Texture2D>]
    [ContextMemberMetadata<Input>]

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

        public void SetImeCompositionMode()
        {
            Input.Ptr_Input.SET_IME_COMPOSITION_MODE(IMECompositionMode.On);
        }

        public bool TryGetTextureInfo(nint ptr_Sprite, out nint native_ptr, out float u0, out float v0, out float u1, out float v1)
        {
            Unsafe.SkipInit(out native_ptr);
            Unsafe.SkipInit(out u0);
            Unsafe.SkipInit(out v0);
            Unsafe.SkipInit(out u1);
            Unsafe.SkipInit(out v1);
            if (ptr_Sprite == nint.Zero)
            {
                return false;
            }
            Sprite.Ptr_Sprite pSprite = new(ptr_Sprite);
            var pTexture2D = pSprite.GET_TEXTURE();
            if (pTexture2D.IsNull())
            {
                return false;
            }
            native_ptr = pTexture2D.GET_NATIVE_TEXTURE_PTR();
            if (native_ptr == nint.Zero)
            {
                return false;
            }
            pSprite.GET_TEXTURE_RECT_INJECTED(MapleOut<Rect.Ref_Rect>.FromOut(out var ref_Rect));
            var w = pTexture2D.GET_WIDTH();
            var h = pTexture2D.GET_HEIGHT();
            u0 = ref_Rect.m_XMin / w;
            v0 = ref_Rect.m_YMin / h;
            u1 = (ref_Rect.m_XMin + ref_Rect.m_Width) / w;
            v1 = (ref_Rect.m_YMin + ref_Rect.m_Height) / h;
            return true;
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



        public MethodAddressCallbackDelegate? MethodAddressCallback { set; get; }
    }

    public delegate bool MethodAddressCallbackDelegate(ulong code, out nint address);

    public sealed partial class UnityMetadataContext_MONO : UnityMetadataContext
    {
        public static Dictionary<ulong, nint> MethodOffsetCache { get; } = [];
        public static nint UnityPlayerBaseAddress { get; } = GetModuleBaseAddress("UnityPlayer.dll");
        private static bool DefaultMethodAddressCallback(ulong code, out nint address)
        {
            Unsafe.SkipInit(out address);
            if (MethodOffsetCache.TryGetValue(code, out var offset))
            {
                address = UnityPlayerBaseAddress + offset;
                return true;
            }
            return false;
        }

        public UnityMetadataContext_MONO(ILogger logger, MetadataCollectorSearchService searchService, MonoRuntimeContext runtimeContext)
        : base(logger, searchService, runtimeContext)
        {
            this.MethodAddressCallback = DefaultMethodAddressCallback;
        }

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
            if (MethodAddressCallback?.Invoke(code, out var address) == true)
            {
                return new MonoMethodDelegate(nint.Zero, address);
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

    public sealed partial class UnityMetadataContext_IL2CPP : UnityMetadataContext
    {
        #region sign

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

        /// <summary>
        /// UnityEngine.Texture::GetNativeTexturePtr()
        /// </summary>
        public const string UnityEngine_Texture_GetNativeTexturePtr = "UnityEngine.Texture::GetNativeTexturePtr()";


        /// <summary>
        /// UnityEngine.Input::set_imeCompositionMode(UnityEngine.IMECompositionMode)
        /// </summary>
        public const string UnityEngine_Input_set_imeCompositionMode = "UnityEngine.Input::set_imeCompositionMode(UnityEngine.IMECompositionMode)";

        /// <summary>
        /// UnityEngine.Input::GetAxis(System.String)
        /// </summary>
        public const string UnityEngine_Input_GetAxis = "UnityEngine.Input::GetAxis(System.String)";
        /// <summary>
        /// UnityEngine.Input::GetAxisRaw(System.String)
        /// </summary>
        public const string UnityEngine_Input_GetAxisRaw = "UnityEngine.Input::GetAxisRaw(System.String)";

        /// <summary>
        /// UnityEngine.Input::GetKeyInt(UnityEngine.KeyCode)
        /// </summary>
        public const string UnityEngine_Input_GetKeyInt = "UnityEngine.Input::GetKeyInt(UnityEngine.KeyCode)";
        /// <summary>
        /// UnityEngine.Input::GetKeyDownInt(UnityEngine.KeyCode)
        /// </summary>
        public const string UnityEngine_Input_GetKeyDownInt = "UnityEngine.Input::GetKeyDownInt(UnityEngine.KeyCode)";
        /// <summary>
        /// UnityEngine.Input::GetKeyUpInt(UnityEngine.KeyCode)
        /// </summary>
        public const string UnityEngine_Input_GetKeyUpInt = "UnityEngine.Input::GetKeyUpInt(UnityEngine.KeyCode)";

        /// <summary>
        /// UnityEngine.Input::GetKeyDownString(System.String)
        /// </summary>
        public const string UnityEngine_Input_GetKeyDownString = "UnityEngine.Input::GetKeyDownString(System.String)";
        /// <summary>
        /// UnityEngine.Input::GetKeyString(System.String)
        /// </summary>
        public const string UnityEngine_Input_GetKeyString = "UnityEngine.Input::GetKeyString(System.String)";
        /// <summary>
        /// UnityEngine.Input::GetKeyUpString(System.String)
        /// </summary>
        public const string UnityEngine_Input_GetKeyUpString = "UnityEngine.Input::GetKeyUpString(System.String)";

        /// <summary>
        /// UnityEngine.Input::GetMouseButton(System.Int32)
        /// </summary>
        public const string UnityEngine_Input_GetMouseButton = "UnityEngine.Input::GetMouseButton(System.Int32)";
        /// <summary>
        /// UnityEngine.Input::GetMouseButtonDown(System.Int32)
        /// </summary>
        public const string UnityEngine_Input_GetMouseButtonDown = "UnityEngine.Input::GetMouseButtonDown(System.Int32)";
        /// <summary>
        /// UnityEngine.Input::GetMouseButtonUp(System.Int32)
        /// </summary>
        public const string UnityEngine_Input_GetMouseButtonUp = "UnityEngine.Input::GetMouseButtonUp(System.Int32)";

        /// <summary>
        /// UnityEngine.Input::GetTouch_Injected(System.Int32,UnityEngine.Touch&)
        /// </summary>
        public const string UnityEngine_Input_GetTouch_Injected = "UnityEngine.Input::GetTouch_Injected(System.Int32,UnityEngine.Touch&)";

        /// <summary>
        /// UnityEngine.Input::get_mousePosition_Injected(UnityEngine.Vector3&)
        /// </summary>
        public const string UnityEngine_Input_get_mousePosition_Injected = "UnityEngine.Input::get_mousePosition_Injected(UnityEngine.Vector3&)";

        /// <summary>
        /// UnityEngine.Input::get_mouseScrollDelta_Injected(UnityEngine.Vector2&)
        /// </summary>
        public const string UnityEngine_Input_get_mouseScrollDelta_Injected = "UnityEngine.Input::get_mouseScrollDelta_Injected(UnityEngine.Vector2&)";




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

            [Maple.MonoGameAssistant.MetadataUnity.Texture2D.Code_FunctionPointerType_GET_NATIVE_TEXTURE_PTR_81841FE86C2B23E0]
                = UnityEngine_Texture_GetNativeTexturePtr,

            [Input.Code_FunctionPointerType_SET_IME_COMPOSITION_MODE_6F1C9D826DB1C736]
                = UnityEngine_Input_set_imeCompositionMode,

            //[Input.Code_FunctionPointerType_GET_MOUSE_POSITION_INJECTED_A036AE9527B171A8]
            //    = UnityEngine_Input_get_mousePosition_Injected,

            //[Input.Code_FunctionPointerType_GET_MOUSE_SCROLL_DELTA_INJECTED_3FE14DD45FBD4C4F]
            //    = UnityEngine_Input_get_mouseScrollDelta_Injected,

            [Input.Code_FunctionPointerType_GET_AXIS_4AACA73548ECDA60]
                = UnityEngine_Input_GetAxis,
            [Input.Code_FunctionPointerType_GET_AXIS_RAW_C1F891B243D66D1]
                = UnityEngine_Input_GetAxisRaw,

            [Input.Code_FunctionPointerType_GET_KEY_INT_364226C2278E06B9]
                = UnityEngine_Input_GetKeyInt,
            [Input.Code_FunctionPointerType_GET_KEY_DOWN_INT_49C8675AD85C932A]
                = UnityEngine_Input_GetKeyDownInt,
            [Input.Code_FunctionPointerType_GET_KEY_UP_INT_2E27C050DF037639]
                = UnityEngine_Input_GetKeyUpInt,

            [Input.Code_FunctionPointerType_GET_KEY_STRING_F5AA5E669534DDF0]
                = UnityEngine_Input_GetKeyString,
            [Input.Code_FunctionPointerType_GET_KEY_DOWN_STRING_868655107A827883]
                = UnityEngine_Input_GetKeyDownString,
            [Input.Code_FunctionPointerType_GET_KEY_UP_STRING_45B9708814684170]
                = UnityEngine_Input_GetKeyUpString,

            [Input.Code_FunctionPointerType_GET_MOUSE_BUTTON_25FCDA1BB1401B53]
                = UnityEngine_Input_GetMouseButton,
            [Input.Code_FunctionPointerType_GET_MOUSE_BUTTON_DOWN_BE6A4B41F70F23EE]
                = UnityEngine_Input_GetMouseButtonDown,
            [Input.Code_FunctionPointerType_GET_MOUSE_BUTTON_UP_8EE9A0C534915B11]
                = UnityEngine_Input_GetMouseButtonUp,

            [Input.Code_FunctionPointerType_GET_MOUSE_POSITION_INJECTED_A036AE9527B171A8]
                = UnityEngine_Input_get_mousePosition_Injected,

            [Input.Code_FunctionPointerType_GET_MOUSE_SCROLL_DELTA_INJECTED_3FE14DD45FBD4C4F]
                = UnityEngine_Input_get_mouseScrollDelta_Injected,

        };
        #endregion

        private bool DefaultMethodAddressCallback(ulong code, out nint address)
        {
            Unsafe.SkipInit(out address);
            if (MethodSignatureCache.TryGetValue(code, out var signature))
            {
                address = this.RuntimeContext.GetInternalCall(signature);
                if (address != nint.Zero)
                {
                    return true;
                }
            }
            return false;
        }

        public UnityMetadataContext_IL2CPP(ILogger logger, MetadataCollectorSearchService searchService, MonoRuntimeContext runtimeContext) : base(logger, searchService, runtimeContext)
        {
            this.MethodAddressCallback = DefaultMethodAddressCallback;
        }

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

            if (MethodAddressCallback?.Invoke(code, out var address) == true)
            {
                return new MonoMethodDelegate(nint.Zero, address);
            }
            return base.GetMethodDelegate(code, classMetadataCollection);
        }
    }


}

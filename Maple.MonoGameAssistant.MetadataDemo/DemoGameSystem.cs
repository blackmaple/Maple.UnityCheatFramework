using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.MetadataDemo
{


    /// <summary>
    /// class ["Assembly-CSharp.dll"."Tstd2.Manager"."GameManager"]
    /// [Tstd2.Framework.SingleInstance<Tstd2.Manager.GameManager>]=>[UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    [ClassParentMetadataAttribute<ClassMetadataCollector<Ptr_GameManager>, Ptr_GameManager>()]
    //[ClassModelMetadataAttribute(
    //    [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 
    //    [84, 115, 116, 100, 50, 46, 77, 97, 110, 97, 103, 101, 114], 
    //    [71, 97, 109, 101, 77, 97, 110, 97, 103, 101, 114], 
    //    [84, 115, 116, 100, 50, 46, 77, 97, 110, 97, 103, 101, 114, 46, 71, 97, 109, 101, 77, 97, 110, 97, 103, 101, 114])]

    [ClassModelMetadataAttribute("Assembly-CSharp.dll", "Tstd2.Manager", "GameManager", default)]
    public partial class GameManager
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_GameManager(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_GameManager(System.IntPtr ptr) => new Ptr_GameManager(ptr);
            public static implicit operator System.IntPtr(Ptr_GameManager ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_GameManager ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Tstd2.Manager"."GameManager"]
        /// </summary>
        public unsafe readonly partial struct Ptr_GameManager
        {
            /// <summary>
            /// 0x0 System.String objectIsNullMessage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           public const nint OBJECT_IS_NULL_MESSAGE = The Object you want to instantiate is null.; 
*/
            /// <summary>
            /// 0x0 System.String cloneDestroyedMessage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           public const nint CLONE_DESTROYED_MESSAGE = Instantiate failed because the clone was destroyed during creati; 
*/
            /// <summary>
            /// 0x0 Tstd2.Framework.EditorConfigData editorConfig
            /// class ["Assembly-CSharp.dll"."Tstd2.Framework"."EditorConfigData"]
            /// </summary>
            /// <returns>class Tstd2.Framework.EditorConfigData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 69, 100, 105, 116, 111, 114, 67, 111, 110, 102, 105, 103, 68, 97, 116, 97])]
           public partial static nint editorConfig { get; set; } 
*/

            /// <summary>
            /// 0x0 Tstd2.Manager.GameManager Instance
            /// class ["Assembly-CSharp.dll"."Tstd2.Manager"."GameManager"]
            /// </summary>
            /// <returns>class Tstd2.Manager.GameManager</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [84, 115, 116, 100, 50, 46, 77, 97, 110, 97, 103, 101, 114, 46, 71, 97, 109, 101, 77, 97, 110, 97, 103, 101, 114])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Instance", "Tstd2.Manager.GameManager")]
            public static partial nint Instance { get; }


            /// <summary>
            /// 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50])]
           public partial static System.Int32 OffsetOfInstanceIDInCPlusPlusObject { get; set; } 
*/

            /// <summary>
            /// 0x8 System.Boolean skipDialog
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110])]
           public partial static System.Boolean skipDialog { get; set; } 
*/

            /// <summary>
            /// 0xC System.Int32 MaxLocalSaveCount
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50])]
           public partial static System.Int32 MaxLocalSaveCount { get; set; } 
*/

            /// <summary>
            /// 0x10 System.IntPtr m_CachedPtr
            /// struct ["mscorlib.dll"."System"."IntPtr"]
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 80, 116, 114])]
           public partial System.IntPtr m_CachedPtr { get; set; } 
*/

            /// <summary>
            /// 0x18 Tstd2.GamePlay.CameraControl cameraControl
            /// class ["Assembly-CSharp.dll"."Tstd2.GamePlay"."CameraControl"]
            /// </summary>
            /// <returns>class Tstd2.GamePlay.CameraControl</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [84, 115, 116, 100, 50, 46, 71, 97, 109, 101, 80, 108, 97, 121, 46, 67, 97, 109, 101, 114, 97, 67, 111, 110, 116, 114, 111, 108])]
           public partial nint cameraControl { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Double playTime
            /// struct ["mscorlib.dll"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 68, 111, 117, 98, 108, 101])]
           public partial System.Double playTime { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Double playTimeRecordTime
            /// struct ["mscorlib.dll"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 68, 111, 117, 98, 108, 101])]
           public partial System.Double playTimeRecordTime { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Text.StringBuilder _stepToastText
            /// class ["mscorlib.dll"."System.Text"."StringBuilder"]
            /// </summary>
            /// <returns>class System.Text.StringBuilder</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 84, 101, 120, 116, 46, 83, 116, 114, 105, 110, 103, 66, 117, 105, 108, 100, 101, 114])]
           public partial nint _stepToastText { get; set; } 
*/

            /// <summary>
            /// 0x38 Tstd2.Battle.BattleInfo _currentBattleInfo
            /// class ["Assembly-CSharp.dll"."Tstd2.Battle"."BattleInfo"]
            /// </summary>
            /// <returns>class Tstd2.Battle.BattleInfo</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [84, 115, 116, 100, 50, 46, 66, 97, 116, 116, 108, 101, 46, 66, 97, 116, 116, 108, 101, 73, 110, 102, 111])]
           public partial nint _currentBattleInfo { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Boolean smokeMarker
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110])]
           public partial System.Boolean smokeMarker { get; set; } 
*/

            /// <summary>
            /// 0x48 System.String configName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103])]
           public partial nint configName { get; set; } 
*/

            /// <summary>
            /// 0x50 Tstd2.Settings.GameConfig <InitConfig>k__BackingField
            /// class ["Assembly-CSharp.dll"."Tstd2.Settings"."GameConfig"]
            /// </summary>
            /// <returns>class Tstd2.Settings.GameConfig</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [84, 115, 116, 100, 50, 46, 83, 101, 116, 116, 105, 110, 103, 115, 46, 71, 97, 109, 101, 67, 111, 110, 102, 105, 103])]
           public partial nint InitConfig { get; set; } 
*/

            /// <summary>
            /// 0x58 Tstd2.Settings.ChapterData <Chapter>k__BackingField
            /// class ["Assembly-CSharp.dll"."Tstd2.Settings"."ChapterData"]
            /// </summary>
            /// <returns>class Tstd2.Settings.ChapterData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [84, 115, 116, 100, 50, 46, 83, 101, 116, 116, 105, 110, 103, 115, 46, 67, 104, 97, 112, 116, 101, 114, 68, 97, 116, 97])]
           public partial nint Chapter { get; set; } 
*/

            /// <summary>
            /// 0x60 Tstd2.Lua.QuestEvent <CurrentEvent>k__BackingField
            /// class ["Assembly-CSharp.dll"."Tstd2.Lua"."QuestEvent"]
            /// </summary>
            /// <returns>class Tstd2.Lua.QuestEvent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [84, 115, 116, 100, 50, 46, 76, 117, 97, 46, 81, 117, 101, 115, 116, 69, 118, 101, 110, 116])]
           public partial nint CurrentEvent { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Collections.Generic.Dictionary<System.String , System.Object> saveMap
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Object></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 68, 105, 99, 116, 105, 111, 110, 97, 114, 121, 60, 83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 44, 83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116, 62])]
           public partial nint saveMap { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Double netTime
            /// struct ["mscorlib.dll"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 68, 111, 117, 98, 108, 101])]
           public partial System.Double netTime { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Double netTimeRecordTime
            /// struct ["mscorlib.dll"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 68, 111, 117, 98, 108, 101])]
           public partial System.Double netTimeRecordTime { get; set; } 
*/

            /// <summary>
            /// 0x80 Tstd2.Framework.LocalConfigData localConfigData
            /// class ["Assembly-CSharp.dll"."Tstd2.Framework"."LocalConfigData"]
            /// </summary>
            /// <returns>class Tstd2.Framework.LocalConfigData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 76, 111, 99, 97, 108, 67, 111, 110, 102, 105, 103, 68, 97, 116, 97])]
           public partial nint localConfigData { get; set; } 
*/

            /// <summary>
            /// 0x88 Tstd2.Framework.NetConfigData netConfigData
            /// class ["Assembly-CSharp.dll"."Tstd2.Framework"."NetConfigData"]
            /// </summary>
            /// <returns>class Tstd2.Framework.NetConfigData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 78, 101, 116, 67, 111, 110, 102, 105, 103, 68, 97, 116, 97])]
           public partial nint netConfigData { get; set; } 
*/

            /// <summary>
            /// 0x90 Tstd2.Framework.WXLoginData userData
            /// class ["Assembly-CSharp.dll"."Tstd2.Framework"."WXLoginData"]
            /// </summary>
            /// <returns>class Tstd2.Framework.WXLoginData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 87, 88, 76, 111, 103, 105, 110, 68, 97, 116, 97])]
           public partial nint userData { get; set; } 
*/

            /// <summary>
            /// 0x98 Tstd2.Framework.ConfigData configData
            /// class ["Assembly-CSharp.dll"."Tstd2.Framework"."ConfigData"]
            /// </summary>
            /// <returns>class Tstd2.Framework.ConfigData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 67, 111, 110, 102, 105, 103, 68, 97, 116, 97])]
           public partial nint configData { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Boolean updateingTime
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110])]
           public partial System.Boolean updateingTime { get; set; } 
*/

            /// <summary>
            /// 0xA1 System.Boolean <IsUseUIAnimation>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110])]
           public partial System.Boolean IsUseUIAnimation { get; set; } 
*/

            /// <summary>
            /// 0xA2 System.Boolean <IsAdviserBattle>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110])]
           public partial System.Boolean IsAdviserBattle { get; set; } 
*/

            /// <summary>
            /// 0xA3 System.Boolean <IsUseSmokeSkill>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110])]
           public partial System.Boolean IsUseSmokeSkill { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.String key
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103])]
           public partial nint key { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Int32 <cloudSaveCount>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50])]
           public partial System.Int32 cloudSaveCount { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Collections.Generic.List<Tstd2.Framework.SaveData> _saveSummaryInfos
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Tstd2.Framework.SaveData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute(default, [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 76, 105, 115, 116, 60, 84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 83, 97, 118, 101, 68, 97, 116, 97, 62])]
           public partial nint _saveSummaryInfos { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Tstd2.Manager"."GameManager"]
        /// </summary>
        public unsafe readonly partial struct Ptr_GameManager
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([46, 99, 99, 116, 111, 114], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void _CCTOR();

            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void _CTOR();

            /// <summary>
            ///   System.Void <CalculateMoveStep>b__97_0()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([60, 67, 97, 108, 99, 117, 108, 97, 116, 101, 77, 111, 118, 101, 83, 116, 101, 112, 62, 98, 95, 95, 57, 55, 95, 48], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void <CALCULATE_MOVE_STEP>B__97_0(); 
*/
            /// <summary>
            ///   System.Boolean <SendAD>b__201_0(Tstd2.Framework.NetConfigResult _res)
            /// </summary>
            /// <param name = "_res">class Tstd2.Framework.NetConfigResult</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([60, 83, 101, 110, 100, 65, 68, 62, 98, 95, 95, 50, 48, 49, 95, 48], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 78, 101, 116, 67, 111, 110, 102, 105, 103, 82, 101, 115, 117, 108, 116], 0)]
           public partial System.Boolean <SEND_AD>B__201_0(nint _res); 
*/
            /// <summary>
            ///   System.Boolean <SendClear>b__199_0(Tstd2.Framework.NetConfigResult _res)
            /// </summary>
            /// <param name = "_res">class Tstd2.Framework.NetConfigResult</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([60, 83, 101, 110, 100, 67, 108, 101, 97, 114, 62, 98, 95, 95, 49, 57, 57, 95, 48], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 78, 101, 116, 67, 111, 110, 102, 105, 103, 82, 101, 115, 117, 108, 116], 0)]
           public partial System.Boolean <SEND_CLEAR>B__199_0(nint _res); 
*/
            /// <summary>
            ///   System.Boolean <SendFree>b__200_0(Tstd2.Framework.NetConfigResult _res)
            /// </summary>
            /// <param name = "_res">class Tstd2.Framework.NetConfigResult</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([60, 83, 101, 110, 100, 70, 114, 101, 101, 62, 98, 95, 95, 50, 48, 48, 95, 48], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 78, 101, 116, 67, 111, 110, 102, 105, 103, 82, 101, 115, 117, 108, 116], 0)]
           public partial System.Boolean <SEND_FREE>B__200_0(nint _res); 
*/
            /// <summary>
            ///   System.Void AddAlternateCharacters(System.String[] ids)
            /// </summary>
            /// <param name = "ids">class System.String[]</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddAlternateCharacters", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 91, 93], 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String[]", 1)]
            public partial void ADD_ALTERNATE_CHARACTERS(nint ids);

            /// <summary>
            ///   System.Void AddCharacters(System.String[] ids, System.Boolean autoEquip)
            /// </summary>
            /// <param name = "ids">class System.String[]</param>
            /// <param name = "autoEquip">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([65, 100, 100, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 91, 93], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 1)]
           public partial void ADD_CHARACTERS(nint ids, System.Boolean autoEquip); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<Tstd2.Inventory.ItemSlot> AddItems(Tstd2.Framework.ItemSlotSaveData[] items)
            /// </summary>
            /// <param name = "items">class Tstd2.Framework.ItemSlotSaveData[]</param>
            /// <returns>class System.Collections.Generic.List<Tstd2.Inventory.ItemSlot></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([65, 100, 100, 73, 116, 101, 109, 115], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 76, 105, 115, 116, 60, 84, 115, 116, 100, 50, 46, 73, 110, 118, 101, 110, 116, 111, 114, 121, 46, 73, 116, 101, 109, 83, 108, 111, 116, 62], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 73, 116, 101, 109, 83, 108, 111, 116, 83, 97, 118, 101, 68, 97, 116, 97, 91, 93], 0)]
           public partial nint ADD_ITEMS(nint items); 
*/
            /// <summary>
            ///   System.Void AddNPCCharacters(System.String[] ids)
            /// </summary>
            /// <param name = "ids">class System.String[]</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([65, 100, 100, 78, 80, 67, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 91, 93], 0)]
           public partial void ADD_NPC_CHARACTERS(nint ids); 
*/
            /// <summary>
            ///   System.Void AddVIPGenerals()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([65, 100, 100, 86, 73, 80, 71, 101, 110, 101, 114, 97, 108, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void ADD_VIP_GENERALS(); 
*/
            /// <summary>
            ///   System.Int32 AliveTeamCharactersCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([65, 108, 105, 118, 101, 84, 101, 97, 109, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115, 67, 111, 117, 110, 116], [83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 ALIVE_TEAM_CHARACTERS_COUNT(); 
*/
            /// <summary>
            ///   System.Boolean AliveTeamCharactersHasRole(System.String roleId)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([65, 108, 105, 118, 101, 84, 101, 97, 109, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115, 72, 97, 115, 82, 111, 108, 101], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial System.Boolean ALIVE_TEAM_CHARACTERS_HAS_ROLE(nint roleId); 
*/
            /// <summary>
            ///   System.Void AlternateInScene(System.Action finishCallback)
            /// </summary>
            /// <param name = "finishCallback">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([65, 108, 116, 101, 114, 110, 97, 116, 101, 73, 110, 83, 99, 101, 110, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110], 0)]
           public partial void ALTERNATE_IN_SCENE(nint finishCallback); 
*/
            /// <summary>
            ///   System.Void ApplicationInit()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([65, 112, 112, 108, 105, 99, 97, 116, 105, 111, 110, 73, 110, 105, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void APPLICATION_INIT(); 
*/
            /// <summary>
            ///   System.Void AutoEquip(Tstd2.Characters.Character character)
            /// </summary>
            /// <param name = "character">class Tstd2.Characters.Character</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([65, 117, 116, 111, 69, 113, 117, 105, 112], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115, 46, 67, 104, 97, 114, 97, 99, 116, 101, 114], 0)]
           public partial void AUTO_EQUIP(nint character); 
*/
            /// <summary>
            ///   System.Void BackToTile()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([66, 97, 99, 107, 84, 111, 84, 105, 108, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void BACK_TO_TILE(); 
*/
            /// <summary>
            ///   System.UInt32 CRC32Custom(System.String input)
            /// </summary>
            /// <param name = "input">class System.String</param>
            /// <returns>struct System.UInt32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([67, 82, 67, 51, 50, 67, 117, 115, 116, 111, 109], [83, 121, 115, 116, 101, 109, 46, 85, 73, 110, 116, 51, 50], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial System.UInt32 CRC32_CUSTOM(nint input); 
*/
            /// <summary>
            ///   System.Void CalculateMoveStep(System.Int32 step)
            /// </summary>
            /// <param name = "step">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([67, 97, 108, 99, 117, 108, 97, 116, 101, 77, 111, 118, 101, 83, 116, 101, 112], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           public partial void CALCULATE_MOVE_STEP(System.Int32 step); 
*/
            /// <summary>
            ///   System.Void ChangeEquipment(Tstd2.Characters.Character character, Tstd2.Inventory.Equipment equipment)
            /// </summary>
            /// <param name = "character">class Tstd2.Characters.Character</param>
            /// <param name = "equipment">class Tstd2.Inventory.Equipment</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([67, 104, 97, 110, 103, 101, 69, 113, 117, 105, 112, 109, 101, 110, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115, 46, 67, 104, 97, 114, 97, 99, 116, 101, 114], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 73, 110, 118, 101, 110, 116, 111, 114, 121, 46, 69, 113, 117, 105, 112, 109, 101, 110, 116], 1)]
           public partial void CHANGE_EQUIPMENT(nint character, nint equipment); 
*/
            /// <summary>
            ///   System.Void ChangeScene(Tstd2.SceneManagement.TransitionPoint.TransitionType type, System.String sceneName, System.String tag, System.Boolean playAudio)
            /// </summary>
            /// <param name = "type">enum Tstd2.SceneManagement.TransitionPoint.TransitionType</param>
            /// <param name = "sceneName">class System.String</param>
            /// <param name = "tag">class System.String</param>
            /// <param name = "playAudio">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([67, 104, 97, 110, 103, 101, 83, 99, 101, 110, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 83, 99, 101, 110, 101, 77, 97, 110, 97, 103, 101, 109, 101, 110, 116, 46, 84, 114, 97, 110, 115, 105, 116, 105, 111, 110, 80, 111, 105, 110, 116, 46, 84, 114, 97, 110, 115, 105, 116, 105, 111, 110, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 3)]
           public partial void CHANGE_SCENE(Tstd2.SceneManagement.TransitionPoint.TransitionType type, nint sceneName, nint tag, System.Boolean playAudio); 
*/
            /// <summary>
            ///   System.Void CheckFinishLuaCallBack(System.Action callback)
            /// </summary>
            /// <param name = "callback">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([67, 104, 101, 99, 107, 70, 105, 110, 105, 115, 104, 76, 117, 97, 67, 97, 108, 108, 66, 97, 99, 107], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110], 0)]
           public partial void CHECK_FINISH_LUA_CALL_BACK(nint callback); 
*/
            /// <summary>
            ///   System.String DialogueName(System.String roleName)
            /// </summary>
            /// <param name = "roleName">class System.String</param>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([68, 105, 97, 108, 111, 103, 117, 101, 78, 97, 109, 101], [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial nint DIALOGUE_NAME(nint roleName); 
*/
            /// <summary>
            ///   UnityEngine.Sprite DialoguePicture(System.String picName)
            /// </summary>
            /// <param name = "picName">class System.String</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([68, 105, 97, 108, 111, 103, 117, 101, 80, 105, 99, 116, 117, 114, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 83, 112, 114, 105, 116, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial nint DIALOGUE_PICTURE(nint picName); 
*/
            /// <summary>
            ///   UnityEngine.Sprite DialogueProfile(System.String roleName)
            /// </summary>
            /// <param name = "roleName">class System.String</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([68, 105, 97, 108, 111, 103, 117, 101, 80, 114, 111, 102, 105, 108, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 83, 112, 114, 105, 116, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial nint DIALOGUE_PROFILE(nint roleName); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator DownloadFile(System.String objName, System.Action<System.Byte [ ]> finish, System.Action<System.Int32> failed)
            /// </summary>
            /// <param name = "objName">class System.String</param>
            /// <param name = "finish">class System.Action<System.Byte [ ]></param>
            /// <param name = "failed">class System.Action<System.Int32></param>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([68, 111, 119, 110, 108, 111, 97, 100, 70, 105, 108, 101], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110, 60, 83, 121, 115, 116, 101, 109, 46, 66, 121, 116, 101, 91, 93, 62], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110, 60, 83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50, 62], 2)]
           public partial nint DOWNLOAD_FILE(nint objName, nint finish, nint failed); 
*/
            /// <summary>
            ///   System.Void DownloadNetConfigData()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([68, 111, 119, 110, 108, 111, 97, 100, 78, 101, 116, 67, 111, 110, 102, 105, 103, 68, 97, 116, 97], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void DOWNLOAD_NET_CONFIG_DATA(); 
*/
            /// <summary>
            /// static  System.String EventKey(System.String eventId)
            /// </summary>
            /// <param name = "eventId">class System.String</param>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([69, 118, 101, 110, 116, 75, 101, 121], [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial static nint EVENT_KEY(nint eventId); 
*/
            /// <summary>
            ///   System.Void FinishCurrentEvent()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 105, 115, 104, 67, 117, 114, 114, 101, 110, 116, 69, 118, 101, 110, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void FINISH_CURRENT_EVENT(); 
*/
            /// <summary>
            ///   System.Void FinishEvents(System.String[] ids)
            /// </summary>
            /// <param name = "ids">class System.String[]</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 105, 115, 104, 69, 118, 101, 110, 116, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 91, 93], 0)]
           public partial void FINISH_EVENTS(nint ids); 
*/
            /// <summary>
            ///   System.Void GameLoad(System.Int32 index, Tstd2.Framework.SaveData saveData)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "saveData">class Tstd2.Framework.SaveData</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 97, 109, 101, 76, 111, 97, 100], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 83, 97, 118, 101, 68, 97, 116, 97], 1)]
           public partial void GAME_LOAD(System.Int32 index, nint saveData); 
*/
            /// <summary>
            ///   System.Void GameStart()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 97, 109, 101, 83, 116, 97, 114, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void GAME_START(); 
*/
            /// <summary>
            ///   System.Int32 GenerateBattleEnemyCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 110, 101, 114, 97, 116, 101, 66, 97, 116, 116, 108, 101, 69, 110, 101, 109, 121, 67, 111, 117, 110, 116], [83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 GENERATE_BATTLE_ENEMY_COUNT(); 
*/
            /// <summary>
            ///   Tstd2.Battle.StartAttackType GenerateBattleStartAttackType(System.Int32 ambushedRate, System.Int32 sneakRate)
            /// </summary>
            /// <param name = "ambushedRate">struct System.Int32</param>
            /// <param name = "sneakRate">struct System.Int32</param>
            /// <returns>enum Tstd2.Battle.StartAttackType</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 110, 101, 114, 97, 116, 101, 66, 97, 116, 116, 108, 101, 83, 116, 97, 114, 116, 65, 116, 116, 97, 99, 107, 84, 121, 112, 101], [84, 115, 116, 100, 50, 46, 66, 97, 116, 116, 108, 101, 46, 83, 116, 97, 114, 116, 65, 116, 116, 97, 99, 107, 84, 121, 112, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 1)]
           public partial Tstd2.Battle.StartAttackType GENERATE_BATTLE_START_ATTACK_TYPE(System.Int32 ambushedRate, System.Int32 sneakRate); 
*/
            /// <summary>
            ///   System.ValueTuple<Tstd2.Framework.TerrainType , Tstd2.Framework.Property> GenerateBattleTerrain(UnityEngine.Vector2 pos)
            /// </summary>
            /// <param name = "pos">struct UnityEngine.Vector2</param>
            /// <returns>struct System.ValueTuple<Tstd2.Framework.TerrainType , Tstd2.Framework.Property></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 110, 101, 114, 97, 116, 101, 66, 97, 116, 116, 108, 101, 84, 101, 114, 114, 97, 105, 110], [83, 121, 115, 116, 101, 109, 46, 86, 97, 108, 117, 101, 84, 117, 112, 108, 101, 60, 84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 84, 101, 114, 114, 97, 105, 110, 84, 121, 112, 101, 44, 84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 80, 114, 111, 112, 101, 114, 116, 121, 62], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 86, 101, 99, 116, 111, 114, 50], 0)]
           public partial System.ValueTuple<Tstd2.Framework.TerrainType, Tstd2.Framework.Property> GENERATE_BATTLE_TERRAIN(UnityEngine.Vector2 pos); 
*/
            /// <summary>
            ///   System.Void GenerateCommonBattle(UnityEngine.Vector2 pos)
            /// </summary>
            /// <param name = "pos">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 110, 101, 114, 97, 116, 101, 67, 111, 109, 109, 111, 110, 66, 97, 116, 116, 108, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 86, 101, 99, 116, 111, 114, 50], 0)]
           public partial void GENERATE_COMMON_BATTLE(UnityEngine.Vector2 pos); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.String> GenerateGenerals(System.Int32 battleNum)
            /// </summary>
            /// <param name = "battleNum">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 110, 101, 114, 97, 116, 101, 71, 101, 110, 101, 114, 97, 108, 115], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 76, 105, 115, 116, 60, 83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 62], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           public partial nint GENERATE_GENERALS(System.Int32 battleNum); 
*/
            /// <summary>
            ///   System.Void GenerateQuestBattle(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 110, 101, 114, 97, 116, 101, 81, 117, 101, 115, 116, 66, 97, 116, 116, 108, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           public partial void GENERATE_QUEST_BATTLE(System.Int32 index); 
*/
            /// <summary>
            ///   System.Boolean GetAdviserBattle(System.Boolean defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 65, 100, 118, 105, 115, 101, 114, 66, 97, 116, 116, 108, 101], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial System.Boolean GET_ADVISER_BATTLE(System.Boolean defaultValue); 
*/
            /// <summary>
            ///   System.Void GetAllSaveData(System.Action refresh)
            /// </summary>
            /// <param name = "refresh">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 65, 108, 108, 83, 97, 118, 101, 68, 97, 116, 97], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110], 0)]
           public partial void GET_ALL_SAVE_DATA(nint refresh); 
*/
            /// <summary>
            ///   System.Single GetBGMVolume(System.Single defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Single</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 66, 71, 77, 86, 111, 108, 117, 109, 101], [83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           public partial System.Single GET_BGM_VOLUME(System.Single defaultValue); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator GetCongfigJson()
            /// </summary>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 110, 103, 102, 105, 103, 74, 115, 111, 110], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_CONGFIG_JSON(); 
*/
            /// <summary>
            ///   System.String GetCurrentTimeString()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 117, 114, 114, 101, 110, 116, 84, 105, 109, 101, 83, 116, 114, 105, 110, 103], [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_CURRENT_TIME_STRING(); 
*/
            /// <summary>
            ///   Tstd2.Settings.Difficulty GetDifficulty()
            /// </summary>
            /// <returns>class Tstd2.Settings.Difficulty</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 68, 105, 102, 102, 105, 99, 117, 108, 116, 121], [84, 115, 116, 100, 50, 46, 83, 101, 116, 116, 105, 110, 103, 115, 46, 68, 105, 102, 102, 105, 99, 117, 108, 116, 121], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_DIFFICULTY(); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator GetItemsTextFinishedCallback(System.Collections.Generic.List<Tstd2.Inventory.ItemSlot> itemSlots)
            /// </summary>
            /// <param name = "itemSlots">class System.Collections.Generic.List<Tstd2.Inventory.ItemSlot></param>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 73, 116, 101, 109, 115, 84, 101, 120, 116, 70, 105, 110, 105, 115, 104, 101, 100, 67, 97, 108, 108, 98, 97, 99, 107], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 76, 105, 115, 116, 60, 84, 115, 116, 100, 50, 46, 73, 110, 118, 101, 110, 116, 111, 114, 121, 46, 73, 116, 101, 109, 83, 108, 111, 116, 62], 0)]
           public partial nint GET_ITEMS_TEXT_FINISHED_CALLBACK(nint itemSlots); 
*/
            /// <summary>
            ///   System.Single GetKeyAlpha(System.Single defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Single</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 75, 101, 121, 65, 108, 112, 104, 97], [83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           public partial System.Single GET_KEY_ALPHA(System.Single defaultValue); 
*/
            /// <summary>
            ///   NPC GetNPC(System.Int32 childIndex)
            /// </summary>
            /// <param name = "childIndex">struct System.Int32</param>
            /// <returns>class NPC</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 78, 80, 67], [78, 80, 67], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           public partial nint GET_NPC(System.Int32 childIndex); 
*/
            /// <summary>
            ///   System.Void GetNetConfigData(Tstd2.Framework.NetConfigResult _res)
            /// </summary>
            /// <param name = "_res">class Tstd2.Framework.NetConfigResult</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 78, 101, 116, 67, 111, 110, 102, 105, 103, 68, 97, 116, 97], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 78, 101, 116, 67, 111, 110, 102, 105, 103, 82, 101, 115, 117, 108, 116], 0)]
           public partial void GET_NET_CONFIG_DATA(nint _res); 
*/
            /// <summary>
            ///   System.Void GetOpenID()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 79, 112, 101, 110, 73, 68], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void GET_OPEN_ID(); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator GetOpenIDSC(System.String code)
            /// </summary>
            /// <param name = "code">class System.String</param>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 79, 112, 101, 110, 73, 68, 83, 67], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial nint GET_OPEN_IDSC(nint code); 
*/
            /// <summary>
            ///   System.String GetPlatform()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 80, 108, 97, 116, 102, 111, 114, 109], [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_PLATFORM(); 
*/
            /// <summary>
            ///   System.Double GetPlayedTime()
            /// </summary>
            /// <returns>struct System.Double</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 80, 108, 97, 121, 101, 100, 84, 105, 109, 101], [83, 121, 115, 116, 101, 109, 46, 68, 111, 117, 98, 108, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Double GET_PLAYED_TIME(); 
*/
            /// <summary>
            ///   System.Single GetSEVolume(System.Single defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Single</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 83, 69, 86, 111, 108, 117, 109, 101], [83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           public partial System.Single GET_SE_VOLUME(System.Single defaultValue); 
*/
            /// <summary>
            ///   System.Object GetSave(System.String varName)
            /// </summary>
            /// <param name = "varName">class System.String</param>
            /// <returns>class System.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 83, 97, 118, 101], [83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial nint GET_SAVE(nint varName); 
*/
            /// <summary>
            ///   System.Int32 GetSaveInt(System.String varName, System.Int32 defaultValue)
            /// </summary>
            /// <param name = "varName">class System.String</param>
            /// <param name = "defaultValue">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 83, 97, 118, 101, 73, 110, 116], [83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 1)]
           public partial System.Int32 GET_SAVE_INT(nint varName, System.Int32 defaultValue); 
*/
            /// <summary>
            ///   System.DateTime GetTime(System.Double unixTick)
            /// </summary>
            /// <param name = "unixTick">struct System.Double</param>
            /// <returns>struct System.DateTime</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 84, 105, 109, 101], [83, 121, 115, 116, 101, 109, 46, 68, 97, 116, 101, 84, 105, 109, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 68, 111, 117, 98, 108, 101], 0)]
           public partial System.DateTime GET_TIME(System.Double unixTick); 
*/
            /// <summary>
            ///   System.Single GetTimeScale(System.Single defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Single</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 84, 105, 109, 101, 83, 99, 97, 108, 101], [83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           public partial System.Single GET_TIME_SCALE(System.Single defaultValue); 
*/
            /// <summary>
            ///   System.Boolean GetUIAnimation(System.Boolean defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 85, 73, 65, 110, 105, 109, 97, 116, 105, 111, 110], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial System.Boolean GET_UI_ANIMATION(System.Boolean defaultValue); 
*/
            /// <summary>
            ///   System.Single GetUIMatch(System.Single defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Single</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 85, 73, 77, 97, 116, 99, 104], [83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           public partial System.Single GET_UI_MATCH(System.Single defaultValue); 
*/
            /// <summary>
            ///   System.Double GetUnixTick(System.DateTime date)
            /// </summary>
            /// <param name = "date">struct System.DateTime</param>
            /// <returns>struct System.Double</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 85, 110, 105, 120, 84, 105, 99, 107], [83, 121, 115, 116, 101, 109, 46, 68, 111, 117, 98, 108, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 68, 97, 116, 101, 84, 105, 109, 101], 0)]
           public partial System.Double GET_UNIX_TICK(System.DateTime date); 
*/
            /// <summary>
            ///   System.Double GetUntrustyNetTime()
            /// </summary>
            /// <returns>struct System.Double</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 85, 110, 116, 114, 117, 115, 116, 121, 78, 101, 116, 84, 105, 109, 101], [83, 121, 115, 116, 101, 109, 46, 68, 111, 117, 98, 108, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Double GET_UNTRUSTY_NET_TIME(); 
*/
            /// <summary>
            ///   System.Boolean GetUseSmokeSkill(System.Boolean defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 85, 115, 101, 83, 109, 111, 107, 101, 83, 107, 105, 108, 108], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial System.Boolean GET_USE_SMOKE_SKILL(System.Boolean defaultValue); 
*/
            /// <summary>
            ///   System.Boolean HasCharacter(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([72, 97, 115, 67, 104, 97, 114, 97, 99, 116, 101, 114], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial System.Boolean HAS_CHARACTER(nint id); 
*/
            /// <summary>
            ///   System.Boolean HasFinishEvent(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([72, 97, 115, 70, 105, 110, 105, 115, 104, 69, 118, 101, 110, 116], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial System.Boolean HAS_FINISH_EVENT(nint id); 
*/
            /// <summary>
            ///   System.Boolean HasItem(System.String itemId, System.Int32 count)
            /// </summary>
            /// <param name = "itemId">class System.String</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([72, 97, 115, 73, 116, 101, 109], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 1)]
           public partial System.Boolean HAS_ITEM(nint itemId, System.Int32 count); 
*/
            /// <summary>
            ///   System.Boolean HasMoney(System.Int32 money)
            /// </summary>
            /// <param name = "money">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([72, 97, 115, 77, 111, 110, 101, 121], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           public partial System.Boolean HAS_MONEY(System.Int32 money); 
*/
            /// <summary>
            ///   System.Boolean HasOpenChest(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([72, 97, 115, 79, 112, 101, 110, 67, 104, 101, 115, 116], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial System.Boolean HAS_OPEN_CHEST(nint id); 
*/
            /// <summary>
            ///   System.Boolean HasSave(System.String varName)
            /// </summary>
            /// <param name = "varName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([72, 97, 115, 83, 97, 118, 101], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial System.Boolean HAS_SAVE(nint varName); 
*/
            /// <summary>
            ///   System.Void Init()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 105, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void INIT(); 
*/
            /// <summary>
            ///   System.Void InitActionBinding()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 105, 116, 65, 99, 116, 105, 111, 110, 66, 105, 110, 100, 105, 110, 103], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void INIT_ACTION_BINDING(); 
*/
            /// <summary>
            ///   System.Void InitAdviserBattle(System.Boolean defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 105, 116, 65, 100, 118, 105, 115, 101, 114, 66, 97, 116, 116, 108, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial void INIT_ADVISER_BATTLE(System.Boolean defaultValue); 
*/
            /// <summary>
            ///   System.Void InitBGMVolume(System.Single defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 105, 116, 66, 71, 77, 86, 111, 108, 117, 109, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           public partial void INIT_BGM_VOLUME(System.Single defaultValue); 
*/
            /// <summary>
            ///   System.Void InitGameConfig()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 105, 116, 71, 97, 109, 101, 67, 111, 110, 102, 105, 103], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void INIT_GAME_CONFIG(); 
*/
            /// <summary>
            ///   System.Void InitSEVolume(System.Single defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 105, 116, 83, 69, 86, 111, 108, 117, 109, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           public partial void INIT_SE_VOLUME(System.Single defaultValue); 
*/
            /// <summary>
            ///   System.Void InitTimeScale(System.Single defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 105, 116, 84, 105, 109, 101, 83, 99, 97, 108, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           public partial void INIT_TIME_SCALE(System.Single defaultValue); 
*/
            /// <summary>
            ///   System.Void InitUIAnimation(System.Boolean defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 105, 116, 85, 73, 65, 110, 105, 109, 97, 116, 105, 111, 110], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial void INIT_UI_ANIMATION(System.Boolean defaultValue); 
*/
            /// <summary>
            ///   System.Void InitUIMatch(System.Single defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 105, 116, 85, 73, 77, 97, 116, 99, 104], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           public partial void INIT_UI_MATCH(System.Single defaultValue); 
*/
            /// <summary>
            ///   System.Void InitUseSmokeSkill(System.Boolean defaultValue)
            /// </summary>
            /// <param name = "defaultValue">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 105, 116, 85, 115, 101, 83, 109, 111, 107, 101, 83, 107, 105, 108, 108], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial void INIT_USE_SMOKE_SKILL(System.Boolean defaultValue); 
*/
            /// <summary>
            ///   System.Boolean IsSpecialSkill(Tstd2.Skills.Skill skill)
            /// </summary>
            /// <param name = "skill">class Tstd2.Skills.Skill</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 115, 83, 112, 101, 99, 105, 97, 108, 83, 107, 105, 108, 108], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 83, 107, 105, 108, 108, 115, 46, 83, 107, 105, 108, 108], 0)]
           public partial System.Boolean IS_SPECIAL_SKILL(nint skill); 
*/
            /// <summary>
            ///   System.Void LoadConfig()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([76, 111, 97, 100, 67, 111, 110, 102, 105, 103], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void LOAD_CONFIG(); 
*/
            /// <summary>
            ///   Tstd2.Framework.SaveData LoadFile(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>class Tstd2.Framework.SaveData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([76, 111, 97, 100, 70, 105, 108, 101], [84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 83, 97, 118, 101, 68, 97, 116, 97], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           public partial nint LOAD_FILE(System.Int32 index); 
*/
            /// <summary>
            ///   T LoadFile(System.Byte[] array)
            /// </summary>
            /// <param name = "array">class System.Byte[]</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([76, 111, 97, 100, 70, 105, 108, 101], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 121, 116, 101, 91, 93], 0)]
           public partial nint LOAD_FILE(nint array); 
*/
            /// <summary>
            ///   T LoadFile(System.String _filename)
            /// </summary>
            /// <param name = "_filename">class System.String</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([76, 111, 97, 100, 70, 105, 108, 101], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial nint LOAD_FILE(nint _filename); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator LoadResource()
            /// </summary>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([76, 111, 97, 100, 82, 101, 115, 111, 117, 114, 99, 101], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint LOAD_RESOURCE(); 
*/
            /// <summary>
            ///   System.Collections.IEnumerable LvUpMessage(System.Int32 currentLv, System.Int32 targetLv)
            /// </summary>
            /// <param name = "currentLv">struct System.Int32</param>
            /// <param name = "targetLv">struct System.Int32</param>
            /// <returns>interface System.Collections.IEnumerable</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([76, 118, 85, 112, 77, 101, 115, 115, 97, 103, 101], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 98, 108, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 1)]
           public partial nint LV_UP_MESSAGE(System.Int32 currentLv, System.Int32 targetLv); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.String> ParametersInScene()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 73, 110, 83, 99, 101, 110, 101], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 76, 105, 115, 116, 60, 83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 62], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint PARAMETERS_IN_SCENE(); 
*/
            /// <summary>
            ///   System.Void PlayCurrentSceneBGM()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([80, 108, 97, 121, 67, 117, 114, 114, 101, 110, 116, 83, 99, 101, 110, 101, 66, 71, 77], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void PLAY_CURRENT_SCENE_BGM(); 
*/
            /// <summary>
            ///   System.Void Poison()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([80, 111, 105, 115, 111, 110], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void POISON(); 
*/
            /// <summary>
            ///   System.Void RefreshCurrentSceneEvents()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([82, 101, 102, 114, 101, 115, 104, 67, 117, 114, 114, 101, 110, 116, 83, 99, 101, 110, 101, 69, 118, 101, 110, 116, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void REFRESH_CURRENT_SCENE_EVENTS(); 
*/
            /// <summary>
            ///   System.Void RemoveCharacters(System.String[] ids, System.Boolean autoUnload)
            /// </summary>
            /// <param name = "ids">class System.String[]</param>
            /// <param name = "autoUnload">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([82, 101, 109, 111, 118, 101, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 91, 93], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 1)]
           public partial void REMOVE_CHARACTERS(nint ids, System.Boolean autoUnload); 
*/
            /// <summary>
            ///   System.Void ResetActionBinding()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([82, 101, 115, 101, 116, 65, 99, 116, 105, 111, 110, 66, 105, 110, 100, 105, 110, 103], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void RESET_ACTION_BINDING(); 
*/
            /// <summary>
            ///   System.Void Rest(System.Boolean resurrect)
            /// </summary>
            /// <param name = "resurrect">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([82, 101, 115, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial void REST(System.Boolean resurrect); 
*/
            /// <summary>
            ///   System.Void SaveActionBinding(System.String json)
            /// </summary>
            /// <param name = "json">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 97, 118, 101, 65, 99, 116, 105, 111, 110, 66, 105, 110, 100, 105, 110, 103], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial void SAVE_ACTION_BINDING(nint json); 
*/
            /// <summary>
            ///   System.Void SaveConfig()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 97, 118, 101, 67, 111, 110, 102, 105, 103], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void SAVE_CONFIG(); 
*/
            /// <summary>
            ///   System.Void SaveConfigToCloud(System.Action<Tstd2.Framework.NetConfigData> finish, System.Action failed)
            /// </summary>
            /// <param name = "finish">class System.Action<Tstd2.Framework.NetConfigData></param>
            /// <param name = "failed">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 97, 118, 101, 67, 111, 110, 102, 105, 103, 84, 111, 67, 108, 111, 117, 100], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110, 60, 84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 78, 101, 116, 67, 111, 110, 102, 105, 103, 68, 97, 116, 97, 62], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110], 1)]
           public partial void SAVE_CONFIG_TO_CLOUD(nint finish, nint failed); 
*/
            /// <summary>
            ///   System.Void SaveFile(T data, System.String _filename)
            /// </summary>
            /// <param name = "data">class T</param>
            /// <param name = "_filename">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 97, 118, 101, 70, 105, 108, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 1)]
           public partial void SAVE_FILE(nint data, nint _filename); 
*/
            /// <summary>
            ///   System.Void SaveToCloud(System.Int32 saveIndex, System.Action<Tstd2.Framework.SaveData> finish)
            /// </summary>
            /// <param name = "saveIndex">struct System.Int32</param>
            /// <param name = "finish">class System.Action<Tstd2.Framework.SaveData></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 97, 118, 101, 84, 111, 67, 108, 111, 117, 100], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110, 60, 84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 83, 97, 118, 101, 68, 97, 116, 97, 62], 1)]
           public partial void SAVE_TO_CLOUD(System.Int32 saveIndex, nint finish); 
*/
            /// <summary>
            ///   Tstd2.Framework.SaveData SaveToFile(System.Int32 fileIndex)
            /// </summary>
            /// <param name = "fileIndex">struct System.Int32</param>
            /// <returns>class Tstd2.Framework.SaveData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 97, 118, 101, 84, 111, 70, 105, 108, 101], [84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 83, 97, 118, 101, 68, 97, 116, 97], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           public partial nint SAVE_TO_FILE(System.Int32 fileIndex); 
*/
            /// <summary>
            ///   System.ValueTuple<System.Int64 , System.Int64 , System.Int64> SecondsToTime(System.Double time)
            /// </summary>
            /// <param name = "time">struct System.Double</param>
            /// <returns>struct System.ValueTuple<System.Int64 , System.Int64 , System.Int64></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 99, 111, 110, 100, 115, 84, 111, 84, 105, 109, 101], [83, 121, 115, 116, 101, 109, 46, 86, 97, 108, 117, 101, 84, 117, 112, 108, 101, 60, 83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 54, 52, 44, 83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 54, 52, 44, 83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 54, 52, 62], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 68, 111, 117, 98, 108, 101], 0)]
           public partial System.ValueTuple<System.Int64, System.Int64, System.Int64> SECONDS_TO_TIME(System.Double time); 
*/
            /// <summary>
            ///   System.Void SendAD(System.Action<Tstd2.Framework.NetConfigResult> finish, System.Action<System.String> failed)
            /// </summary>
            /// <param name = "finish">class System.Action<Tstd2.Framework.NetConfigResult></param>
            /// <param name = "failed">class System.Action<System.String></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 110, 100, 65, 68], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110, 60, 84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 78, 101, 116, 67, 111, 110, 102, 105, 103, 82, 101, 115, 117, 108, 116, 62], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110, 60, 83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 62], 1)]
           public partial void SEND_AD(nint finish, nint failed); 
*/
            /// <summary>
            ///   System.Void SendClear(System.Int32 _type, System.Action<Tstd2.Framework.NetConfigResult> finish, System.Action<System.String> failed)
            /// </summary>
            /// <param name = "_type">struct System.Int32</param>
            /// <param name = "finish">class System.Action<Tstd2.Framework.NetConfigResult></param>
            /// <param name = "failed">class System.Action<System.String></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 110, 100, 67, 108, 101, 97, 114], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110, 60, 84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 78, 101, 116, 67, 111, 110, 102, 105, 103, 82, 101, 115, 117, 108, 116, 62], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110, 60, 83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 62], 2)]
           public partial void SEND_CLEAR(System.Int32 _type, nint finish, nint failed); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator SendData(System.String recordData, System.Int32 param1, System.Int32 param2)
            /// </summary>
            /// <param name = "recordData">class System.String</param>
            /// <param name = "param1">struct System.Int32</param>
            /// <param name = "param2">struct System.Int32</param>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 110, 100, 68, 97, 116, 97], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 2)]
           public partial nint SEND_DATA(nint recordData, System.Int32 param1, System.Int32 param2); 
*/
            /// <summary>
            ///   System.Void SendFree(System.Action<Tstd2.Framework.NetConfigResult> finish, System.Action<System.String> failed)
            /// </summary>
            /// <param name = "finish">class System.Action<Tstd2.Framework.NetConfigResult></param>
            /// <param name = "failed">class System.Action<System.String></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 110, 100, 70, 114, 101, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110, 60, 84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 78, 101, 116, 67, 111, 110, 102, 105, 103, 82, 101, 115, 117, 108, 116, 62], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110, 60, 83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 62], 1)]
           public partial void SEND_FREE(nint finish, nint failed); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator SendMsg(System.Collections.Generic.Dictionary<System.String , System.String> jsonMap, System.String action, System.Action<Tstd2.Framework.NetConfigResult> finish, System.Action<System.String> failed, Tstd2.Manager.GameManager.CheckMac _check)
            /// </summary>
            /// <param name = "jsonMap">class System.Collections.Generic.Dictionary<System.String , System.String></param>
            /// <param name = "action">class System.String</param>
            /// <param name = "finish">class System.Action<Tstd2.Framework.NetConfigResult></param>
            /// <param name = "failed">class System.Action<System.String></param>
            /// <param name = "_check">class Tstd2.Manager.GameManager.CheckMac</param>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 110, 100, 77, 115, 103], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 68, 105, 99, 116, 105, 111, 110, 97, 114, 121, 60, 83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 44, 83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 62], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110, 60, 84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 78, 101, 116, 67, 111, 110, 102, 105, 103, 82, 101, 115, 117, 108, 116, 62], 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110, 60, 83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 62], 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 77, 97, 110, 97, 103, 101, 114, 46, 71, 97, 109, 101, 77, 97, 110, 97, 103, 101, 114, 46, 67, 104, 101, 99, 107, 77, 97, 99], 4)]
           public partial nint SEND_MSG(nint jsonMap, nint action, nint finish, nint failed, nint _check); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator SendSaveData(System.Boolean showWait, T saveObject, System.String objName, System.Action<T> finish, System.Action failed)
            /// </summary>
            /// <param name = "showWait">struct System.Boolean</param>
            /// <param name = "saveObject">class T</param>
            /// <param name = "objName">class System.String</param>
            /// <param name = "finish">class System.Action<T></param>
            /// <param name = "failed">class System.Action</param>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 110, 100, 83, 97, 118, 101, 68, 97, 116, 97], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110, 60, 84, 62], 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110], 4)]
           public partial nint SEND_SAVE_DATA(System.Boolean showWait, nint saveObject, nint objName, nint finish, nint failed); 
*/
            /// <summary>
            ///   System.Void SetAdviserBattle(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 116, 65, 100, 118, 105, 115, 101, 114, 66, 97, 116, 116, 108, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial void SET_ADVISER_BATTLE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void SetBGMVolume(System.Single volume)
            /// </summary>
            /// <param name = "volume">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 116, 66, 71, 77, 86, 111, 108, 117, 109, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           public partial void SET_BGM_VOLUME(System.Single volume); 
*/
            /// <summary>
            ///   System.Void SetEventKey(System.String key, System.Int32 value)
            /// </summary>
            /// <param name = "key">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 116, 69, 118, 101, 110, 116, 75, 101, 121], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 1)]
           public partial void SET_EVENT_KEY(nint key, System.Int32 value); 
*/
            /// <summary>
            ///   System.Void SetEventKeys(System.Collections.Generic.List<System.String> onKey, System.Collections.Generic.List<System.String> offKey)
            /// </summary>
            /// <param name = "onKey">class System.Collections.Generic.List<System.String></param>
            /// <param name = "offKey">class System.Collections.Generic.List<System.String></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 116, 69, 118, 101, 110, 116, 75, 101, 121, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 76, 105, 115, 116, 60, 83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 62], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 76, 105, 115, 116, 60, 83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 62], 1)]
           public partial void SET_EVENT_KEYS(nint onKey, nint offKey); 
*/
            /// <summary>
            ///   System.Void SetKeyAlpha(System.Single volume)
            /// </summary>
            /// <param name = "volume">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 116, 75, 101, 121, 65, 108, 112, 104, 97], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           public partial void SET_KEY_ALPHA(System.Single volume); 
*/
            /// <summary>
            ///   System.Void SetPlayedTime(System.Double _playedTime)
            /// </summary>
            /// <param name = "_playedTime">struct System.Double</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 116, 80, 108, 97, 121, 101, 100, 84, 105, 109, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 68, 111, 117, 98, 108, 101], 0)]
           public partial void SET_PLAYED_TIME(System.Double _playedTime); 
*/
            /// <summary>
            ///   System.Void SetSEVolume(System.Single volume)
            /// </summary>
            /// <param name = "volume">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 116, 83, 69, 86, 111, 108, 117, 109, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           public partial void SET_SE_VOLUME(System.Single volume); 
*/
            /// <summary>
            ///   System.Void SetSave(System.String varName, System.Object n)
            /// </summary>
            /// <param name = "varName">class System.String</param>
            /// <param name = "n">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 116, 83, 97, 118, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116], 1)]
           public partial void SET_SAVE(nint varName, nint n); 
*/
            /// <summary>
            ///   System.Void SetTimeScale(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 116, 84, 105, 109, 101, 83, 99, 97, 108, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           public partial void SET_TIME_SCALE(System.Single value); 
*/
            /// <summary>
            ///   System.Void SetUIAnimation(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 116, 85, 73, 65, 110, 105, 109, 97, 116, 105, 111, 110], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial void SET_UI_ANIMATION(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void SetUIMatch(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 116, 85, 73, 77, 97, 116, 99, 104], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           public partial void SET_UI_MATCH(System.Single value); 
*/
            /// <summary>
            ///   System.Void SetUseFCUI(System.Boolean used)
            /// </summary>
            /// <param name = "used">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 116, 85, 115, 101, 70, 67, 85, 73], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial void SET_USE_FCUI(System.Boolean used); 
*/
            /// <summary>
            ///   System.Void SetUseSmokeSkill(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 116, 85, 115, 101, 83, 109, 111, 107, 101, 83, 107, 105, 108, 108], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial void SET_USE_SMOKE_SKILL(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void ShopInScene(System.Action finishCallback)
            /// </summary>
            /// <param name = "finishCallback">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 104, 111, 112, 73, 110, 83, 99, 101, 110, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110], 0)]
           public partial void SHOP_IN_SCENE(nint finishCallback); 
*/
            /// <summary>
            ///   System.Void ShowGetItemsTextUI(System.Collections.Generic.List<Tstd2.Inventory.ItemSlot> itemSlots, System.Int32 money, System.Action callback)
            /// </summary>
            /// <param name = "itemSlots">class System.Collections.Generic.List<Tstd2.Inventory.ItemSlot></param>
            /// <param name = "money">struct System.Int32</param>
            /// <param name = "callback">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 104, 111, 119, 71, 101, 116, 73, 116, 101, 109, 115, 84, 101, 120, 116, 85, 73], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 76, 105, 115, 116, 60, 84, 115, 116, 100, 50, 46, 73, 110, 118, 101, 110, 116, 111, 114, 121, 46, 73, 116, 101, 109, 83, 108, 111, 116, 62], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110], 2)]
           public partial void SHOW_GET_ITEMS_TEXT_UI(nint itemSlots, System.Int32 money, nint callback); 
*/
            /// <summary>
            ///   System.String SimpleDecrypt(System.String encryptedData)
            /// </summary>
            /// <param name = "encryptedData">class System.String</param>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 105, 109, 112, 108, 101, 68, 101, 99, 114, 121, 112, 116], [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial nint SIMPLE_DECRYPT(nint encryptedData); 
*/
            /// <summary>
            ///   System.String SimpleEncrypt(System.String data)
            /// </summary>
            /// <param name = "data">class System.String</param>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 105, 109, 112, 108, 101, 69, 110, 99, 114, 121, 112, 116], [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial nint SIMPLE_ENCRYPT(nint data); 
*/
            /// <summary>
            ///   System.Void SingleInstanceAwake()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 105, 110, 103, 108, 101, 73, 110, 115, 116, 97, 110, 99, 101, 65, 119, 97, 107, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void SINGLE_INSTANCE_AWAKE(); 
*/
            /// <summary>
            ///   System.Void Start()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 116, 97, 114, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void START(); 
*/
            /// <summary>
            ///   System.Void TeamAddHp(System.Single value, System.Int32 type, System.Int32 min)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "min">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([84, 101, 97, 109, 65, 100, 100, 72, 112], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 2)]
           public partial void TEAM_ADD_HP(System.Single value, System.Int32 type, System.Int32 min); 
*/
            /// <summary>
            ///   Tstd2.Framework.TSTDTerrain TerrainByType(Tstd2.Framework.TerrainType type)
            /// </summary>
            /// <param name = "type">enum Tstd2.Framework.TerrainType</param>
            /// <returns>class Tstd2.Framework.TSTDTerrain</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([84, 101, 114, 114, 97, 105, 110, 66, 121, 84, 121, 112, 101], [84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 84, 83, 84, 68, 84, 101, 114, 114, 97, 105, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 70, 114, 97, 109, 101, 119, 111, 114, 107, 46, 84, 101, 114, 114, 97, 105, 110, 84, 121, 112, 101], 0)]
           public partial nint TERRAIN_BY_TYPE(Tstd2.Framework.TerrainType type); 
*/
            /// <summary>
            ///   System.Void Train(System.Int32 lv, System.Action action)
            /// </summary>
            /// <param name = "lv">struct System.Int32</param>
            /// <param name = "action">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([84, 114, 97, 105, 110], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110], 1)]
           public partial void TRAIN(System.Int32 lv, nint action); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator TrainMessage(System.Int32 currentLv, System.Int32 targetLv)
            /// </summary>
            /// <param name = "currentLv">struct System.Int32</param>
            /// <param name = "targetLv">struct System.Int32</param>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([84, 114, 97, 105, 110, 77, 101, 115, 115, 97, 103, 101], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 1)]
           public partial nint TRAIN_MESSAGE(System.Int32 currentLv, System.Int32 targetLv); 
*/
            /// <summary>
            /// static  System.Void UnloadAllEquipments(Tstd2.Characters.Character character)
            /// </summary>
            /// <param name = "character">class Tstd2.Characters.Character</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([85, 110, 108, 111, 97, 100, 65, 108, 108, 69, 113, 117, 105, 112, 109, 101, 110, 116, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115, 46, 67, 104, 97, 114, 97, 99, 116, 101, 114], 0)]
           public partial static void UNLOAD_ALL_EQUIPMENTS(nint character); 
*/
            /// <summary>
            ///   System.Void UpdateNetTime(System.Action finish)
            /// </summary>
            /// <param name = "finish">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([85, 112, 100, 97, 116, 101, 78, 101, 116, 84, 105, 109, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110], 0)]
           public partial void UPDATE_NET_TIME(nint finish); 
*/
            /// <summary>
            ///   System.Boolean UseFCUI()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([85, 115, 101, 70, 67, 85, 73], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean USE_FCUI(); 
*/
            /// <summary>
            ///   System.Boolean UseNormalBufferSkill(Tstd2.Skills.Skill skill)
            /// </summary>
            /// <param name = "skill">class Tstd2.Skills.Skill</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([85, 115, 101, 78, 111, 114, 109, 97, 108, 66, 117, 102, 102, 101, 114, 83, 107, 105, 108, 108], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 83, 107, 105, 108, 108, 115, 46, 83, 107, 105, 108, 108], 0)]
           public partial System.Boolean USE_NORMAL_BUFFER_SKILL(nint skill); 
*/
            /// <summary>
            ///   System.Void UseSmoke()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([85, 115, 101, 83, 109, 111, 107, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void USE_SMOKE(); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator _UpdateNetTime(System.Action finish)
            /// </summary>
            /// <param name = "finish">class System.Action</param>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([95, 85, 112, 100, 97, 116, 101, 78, 101, 116, 84, 105, 109, 101], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110], 0)]
           public partial nint _UPDATE_NET_TIME(nint finish); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator checkLua(System.Action callback)
            /// </summary>
            /// <param name = "callback">class System.Action</param>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([99, 104, 101, 99, 107, 76, 117, 97], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 65, 99, 116, 105, 111, 110], 0)]
           public partial nint CHECK_LUA(nint callback); 
*/
            /// <summary>
            ///   Tstd2.Settings.ChapterData get_Chapter()
            /// </summary>
            /// <returns>class Tstd2.Settings.ChapterData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 67, 104, 97, 112, 116, 101, 114], [84, 115, 116, 100, 50, 46, 83, 101, 116, 116, 105, 110, 103, 115, 46, 67, 104, 97, 112, 116, 101, 114, 68, 97, 116, 97], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_CHAPTER(); 
*/
            /// <summary>
            ///   Tstd2.Battle.BattleInfo get_CurrentBattleInfo()
            /// </summary>
            /// <returns>class Tstd2.Battle.BattleInfo</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 67, 117, 114, 114, 101, 110, 116, 66, 97, 116, 116, 108, 101, 73, 110, 102, 111], [84, 115, 116, 100, 50, 46, 66, 97, 116, 116, 108, 101, 46, 66, 97, 116, 116, 108, 101, 73, 110, 102, 111], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_CURRENT_BATTLE_INFO(); 
*/
            /// <summary>
            ///   Tstd2.Lua.QuestEvent get_CurrentEvent()
            /// </summary>
            /// <returns>class Tstd2.Lua.QuestEvent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 67, 117, 114, 114, 101, 110, 116, 69, 118, 101, 110, 116], [84, 115, 116, 100, 50, 46, 76, 117, 97, 46, 81, 117, 101, 115, 116, 69, 118, 101, 110, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_CURRENT_EVENT(); 
*/
            /// <summary>
            ///   NPC get_CurrentNPC()
            /// </summary>
            /// <returns>class NPC</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 67, 117, 114, 114, 101, 110, 116, 78, 80, 67], [78, 80, 67], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_CURRENT_NPC(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.String> get_CurrentParameters()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 67, 117, 114, 114, 101, 110, 116, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115], [83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 76, 105, 115, 116, 60, 83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103, 62], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_CURRENT_PARAMETERS(); 
*/
            /// <summary>
            ///   Tstd2.SceneManagement.SceneData get_CurrentSceneData()
            /// </summary>
            /// <returns>class Tstd2.SceneManagement.SceneData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 67, 117, 114, 114, 101, 110, 116, 83, 99, 101, 110, 101, 68, 97, 116, 97], [84, 115, 116, 100, 50, 46, 83, 99, 101, 110, 101, 77, 97, 110, 97, 103, 101, 109, 101, 110, 116, 46, 83, 99, 101, 110, 101, 68, 97, 116, 97], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_CURRENT_SCENE_DATA(); 
*/
            /// <summary>
            ///   System.String get_GeneralName()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 71, 101, 110, 101, 114, 97, 108, 78, 97, 109, 101], [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_GENERAL_NAME(); 
*/
            /// <summary>
            ///   UnityEngine.Sprite get_GeneralProfile()
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 71, 101, 110, 101, 114, 97, 108, 80, 114, 111, 102, 105, 108, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 83, 112, 114, 105, 116, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_GENERAL_PROFILE(); 
*/
            /// <summary>
            ///   Tstd2.Settings.GameConfig get_InitConfig()
            /// </summary>
            /// <returns>class Tstd2.Settings.GameConfig</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 73, 110, 105, 116, 67, 111, 110, 102, 105, 103], [84, 115, 116, 100, 50, 46, 83, 101, 116, 116, 105, 110, 103, 115, 46, 71, 97, 109, 101, 67, 111, 110, 102, 105, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_INIT_CONFIG(); 
*/
            /// <summary>
            ///   System.Boolean get_IsAdviserBattle()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 73, 115, 65, 100, 118, 105, 115, 101, 114, 66, 97, 116, 116, 108, 101], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_ADVISER_BATTLE(); 
*/
            /// <summary>
            ///   System.Boolean get_IsAvoidEnemy()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 73, 115, 65, 118, 111, 105, 100, 69, 110, 101, 109, 121], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_AVOID_ENEMY(); 
*/
            /// <summary>
            ///   System.Boolean get_IsAvoidPoison()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 73, 115, 65, 118, 111, 105, 100, 80, 111, 105, 115, 111, 110], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_AVOID_POISON(); 
*/
            /// <summary>
            ///   System.Boolean get_IsTest()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 73, 115, 84, 101, 115, 116], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_TEST(); 
*/
            /// <summary>
            ///   System.Boolean get_IsUseSmokeSkill()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 73, 115, 85, 115, 101, 83, 109, 111, 107, 101, 83, 107, 105, 108, 108], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_USE_SMOKE_SKILL(); 
*/
            /// <summary>
            ///   System.Boolean get_IsUseUIAnimation()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 73, 115, 85, 115, 101, 85, 73, 65, 110, 105, 109, 97, 116, 105, 111, 110], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_USE_UI_ANIMATION(); 
*/
            /// <summary>
            ///   System.String get_TeamName()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 84, 101, 97, 109, 78, 97, 109, 101], [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_TEAM_NAME(); 
*/
            /// <summary>
            ///   System.Int32 get_cloudSaveCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 99, 108, 111, 117, 100, 83, 97, 118, 101, 67, 111, 117, 110, 116], [83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 GET_CLOUD_SAVE_COUNT(); 
*/
            /// <summary>
            /// static  System.Byte[] gzipCompress(System.Byte[] data)
            /// </summary>
            /// <param name = "data">class System.Byte[]</param>
            /// <returns>class System.Byte[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 122, 105, 112, 67, 111, 109, 112, 114, 101, 115, 115], [83, 121, 115, 116, 101, 109, 46, 66, 121, 116, 101, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 121, 116, 101, 91, 93], 0)]
           public partial static nint GZIP_COMPRESS(nint data); 
*/
            /// <summary>
            /// static  System.Byte[] gzipDecompress(System.Byte[] data, System.Int32 index, System.Int32 count)
            /// </summary>
            /// <param name = "data">class System.Byte[]</param>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>class System.Byte[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 122, 105, 112, 68, 101, 99, 111, 109, 112, 114, 101, 115, 115], [83, 121, 115, 116, 101, 109, 46, 66, 121, 116, 101, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 121, 116, 101, 91, 93], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 2)]
           public partial static nint GZIP_DECOMPRESS(nint data, System.Int32 index, System.Int32 count); 
*/
            /// <summary>
            ///   System.Boolean isVIP(System.Int32 type)
            /// </summary>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([105, 115, 86, 73, 80], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           public partial System.Boolean IS_VIP(System.Int32 type); 
*/
            /// <summary>
            ///   System.Void sendRecord(System.String sdata, System.Int32 param1, System.Int32 param2)
            /// </summary>
            /// <param name = "sdata">class System.String</param>
            /// <param name = "param1">struct System.Int32</param>
            /// <param name = "param2">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([115, 101, 110, 100, 82, 101, 99, 111, 114, 100], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 2)]
           public partial void SEND_RECORD(nint sdata, System.Int32 param1, System.Int32 param2); 
*/
            /// <summary>
            ///   System.Void set_Chapter(Tstd2.Settings.ChapterData value)
            /// </summary>
            /// <param name = "value">class Tstd2.Settings.ChapterData</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([115, 101, 116, 95, 67, 104, 97, 112, 116, 101, 114], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 83, 101, 116, 116, 105, 110, 103, 115, 46, 67, 104, 97, 112, 116, 101, 114, 68, 97, 116, 97], 0)]
           public partial void SET_CHAPTER(nint value); 
*/
            /// <summary>
            ///   System.Void set_CurrentBattleInfo(Tstd2.Battle.BattleInfo value)
            /// </summary>
            /// <param name = "value">class Tstd2.Battle.BattleInfo</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([115, 101, 116, 95, 67, 117, 114, 114, 101, 110, 116, 66, 97, 116, 116, 108, 101, 73, 110, 102, 111], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 66, 97, 116, 116, 108, 101, 46, 66, 97, 116, 116, 108, 101, 73, 110, 102, 111], 0)]
           public partial void SET_CURRENT_BATTLE_INFO(nint value); 
*/
            /// <summary>
            ///   System.Void set_CurrentEvent(Tstd2.Lua.QuestEvent value)
            /// </summary>
            /// <param name = "value">class Tstd2.Lua.QuestEvent</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([115, 101, 116, 95, 67, 117, 114, 114, 101, 110, 116, 69, 118, 101, 110, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 76, 117, 97, 46, 81, 117, 101, 115, 116, 69, 118, 101, 110, 116], 0)]
           public partial void SET_CURRENT_EVENT(nint value); 
*/
            /// <summary>
            ///   System.Void set_InitConfig(Tstd2.Settings.GameConfig value)
            /// </summary>
            /// <param name = "value">class Tstd2.Settings.GameConfig</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([115, 101, 116, 95, 73, 110, 105, 116, 67, 111, 110, 102, 105, 103], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 115, 116, 100, 50, 46, 83, 101, 116, 116, 105, 110, 103, 115, 46, 71, 97, 109, 101, 67, 111, 110, 102, 105, 103], 0)]
           public partial void SET_INIT_CONFIG(nint value); 
*/
            /// <summary>
            ///   System.Void set_IsAdviserBattle(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([115, 101, 116, 95, 73, 115, 65, 100, 118, 105, 115, 101, 114, 66, 97, 116, 116, 108, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial void SET_IS_ADVISER_BATTLE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_IsUseSmokeSkill(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([115, 101, 116, 95, 73, 115, 85, 115, 101, 83, 109, 111, 107, 101, 83, 107, 105, 108, 108], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial void SET_IS_USE_SMOKE_SKILL(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_IsUseUIAnimation(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([115, 101, 116, 95, 73, 115, 85, 115, 101, 85, 73, 65, 110, 105, 109, 97, 116, 105, 111, 110], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial void SET_IS_USE_UI_ANIMATION(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_cloudSaveCount(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([115, 101, 116, 95, 99, 108, 111, 117, 100, 83, 97, 118, 101, 67, 111, 117, 110, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           public partial void SET_CLOUD_SAVE_COUNT(System.Int32 value); 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Tstd2.Framework"."SingleInstance`1"]
        /// </summary>
        public unsafe readonly partial struct Ptr_GameManager
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([46, 99, 116, 111, 114], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void _CTOR(); 
*/
            /// <summary>
            ///   System.Void Awake()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([65, 119, 97, 107, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void AWAKE(); 
*/
            /// <summary>
            ///   System.Void SingleInstanceAwake()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 105, 110, 103, 108, 101, 73, 110, 115, 116, 97, 110, 99, 101, 65, 119, 97, 107, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void SINGLE_INSTANCE_AWAKE(); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Behaviour"]
        /// </summary>
        public unsafe readonly partial struct Ptr_GameManager
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([46, 99, 116, 111, 114], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void _CTOR(); 
*/
            /// <summary>
            ///   System.Boolean get_enabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 101, 110, 97, 98, 108, 101, 100], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_ENABLED(); 
*/
            /// <summary>
            ///   System.Boolean get_isActiveAndEnabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 105, 115, 65, 99, 116, 105, 118, 101, 65, 110, 100, 69, 110, 97, 98, 108, 101, 100], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_ACTIVE_AND_ENABLED(); 
*/
            /// <summary>
            ///   System.Void set_enabled(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([115, 101, 116, 95, 101, 110, 97, 98, 108, 101, 100], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial void SET_ENABLED(System.Boolean value); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Component"]
        /// </summary>
        public unsafe readonly partial struct Ptr_GameManager
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([46, 99, 116, 111, 114], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void _CTOR(); 
*/
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "parameter">class System.Object</param>
            /// <param name = "options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([66, 114, 111, 97, 100, 99, 97, 115, 116, 77, 101, 115, 115, 97, 103, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 83, 101, 110, 100, 77, 101, 115, 115, 97, 103, 101, 79, 112, 116, 105, 111, 110, 115], 2)]
           public partial void BROADCAST_MESSAGE(nint methodName, nint parameter, UnityEngine.SendMessageOptions options); 
*/
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "parameter">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([66, 114, 111, 97, 100, 99, 97, 115, 116, 77, 101, 115, 115, 97, 103, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116], 1)]
           public partial void BROADCAST_MESSAGE(nint methodName, nint parameter); 
*/
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([66, 114, 111, 97, 100, 99, 97, 115, 116, 77, 101, 115, 115, 97, 103, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial void BROADCAST_MESSAGE(nint methodName); 
*/
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([66, 114, 111, 97, 100, 99, 97, 115, 116, 77, 101, 115, 115, 97, 103, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 83, 101, 110, 100, 77, 101, 115, 115, 97, 103, 101, 79, 112, 116, 105, 111, 110, 115], 1)]
           public partial void BROADCAST_MESSAGE(nint methodName, UnityEngine.SendMessageOptions options); 
*/
            /// <summary>
            ///   System.Boolean CompareTag(System.String tag)
            /// </summary>
            /// <param name = "tag">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([67, 111, 109, 112, 97, 114, 101, 84, 97, 103], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial System.Boolean COMPARE_TAG(nint tag); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponent(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 109, 112, 111, 110, 101, 110, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           public partial nint GET_COMPONENT(nint type); 
*/
            /// <summary>
            ///   T GetComponent()
            /// </summary>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_COMPONENT(); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponent(System.String type)
            /// </summary>
            /// <param name = "type">class System.String</param>
            /// <returns>class UnityEngine.Component</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 109, 112, 111, 110, 101, 110, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial nint GET_COMPONENT(nint type); 
*/
            /// <summary>
            ///   System.Void GetComponentFastPath(System.Type type, System.IntPtr oneFurtherThanResultValue)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "oneFurtherThanResultValue">struct System.IntPtr</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 70, 97, 115, 116, 80, 97, 116, 104], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 80, 116, 114], 1)]
           public partial void GET_COMPONENT_FAST_PATH(nint type, System.IntPtr oneFurtherThanResultValue); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "t">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 73, 110, 67, 104, 105, 108, 100, 114, 101, 110], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 109, 112, 111, 110, 101, 110, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 1)]
           public partial nint GET_COMPONENT_IN_CHILDREN(nint t, System.Boolean includeInactive); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponentInChildren(System.Type t)
            /// </summary>
            /// <param name = "t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 73, 110, 67, 104, 105, 108, 100, 114, 101, 110], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 109, 112, 111, 110, 101, 110, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           public partial nint GET_COMPONENT_IN_CHILDREN(nint t); 
*/
            /// <summary>
            ///   T GetComponentInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 73, 110, 67, 104, 105, 108, 100, 114, 101, 110], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial nint GET_COMPONENT_IN_CHILDREN(System.Boolean includeInactive); 
*/
            /// <summary>
            ///   T GetComponentInChildren()
            /// </summary>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 73, 110, 67, 104, 105, 108, 100, 114, 101, 110], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_COMPONENT_IN_CHILDREN(); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "t">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 73, 110, 80, 97, 114, 101, 110, 116], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 109, 112, 111, 110, 101, 110, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 1)]
           public partial nint GET_COMPONENT_IN_PARENT(nint t, System.Boolean includeInactive); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponentInParent(System.Type t)
            /// </summary>
            /// <param name = "t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 73, 110, 80, 97, 114, 101, 110, 116], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 109, 112, 111, 110, 101, 110, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           public partial nint GET_COMPONENT_IN_PARENT(nint t); 
*/
            /// <summary>
            ///   T GetComponentInParent(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 73, 110, 80, 97, 114, 101, 110, 116], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial nint GET_COMPONENT_IN_PARENT(System.Boolean includeInactive); 
*/
            /// <summary>
            ///   T GetComponentInParent()
            /// </summary>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 73, 110, 80, 97, 114, 101, 110, 116], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_COMPONENT_IN_PARENT(); 
*/
            /// <summary>
            ///   UnityEngine.Component[] GetComponents(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 109, 112, 111, 110, 101, 110, 116, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           public partial nint GET_COMPONENTS(nint type); 
*/
            /// <summary>
            ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "results">class System.Collections.Generic.List<UnityEngine.Component></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 76, 105, 115, 116, 60, 85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 109, 112, 111, 110, 101, 110, 116, 62], 1)]
           public partial void GET_COMPONENTS(nint type, nint results); 
*/
            /// <summary>
            ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name = "results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 76, 105, 115, 116, 60, 84, 62], 0)]
           public partial void GET_COMPONENTS(nint results); 
*/
            /// <summary>
            ///   T[] GetComponents()
            /// </summary>
            /// <returns>class T[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115], [84, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Void GetComponentsForListInternal(System.Type searchType, System.Object resultList)
            /// </summary>
            /// <param name = "searchType">abstract class System.Type</param>
            /// <param name = "resultList">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115, 70, 111, 114, 76, 105, 115, 116, 73, 110, 116, 101, 114, 110, 97, 108], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116], 1)]
           public partial void GET_COMPONENTS_FOR_LIST_INTERNAL(nint searchType, nint resultList); 
*/
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "t">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115, 73, 110, 67, 104, 105, 108, 100, 114, 101, 110], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 109, 112, 111, 110, 101, 110, 116, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 1)]
           public partial nint GET_COMPONENTS_IN_CHILDREN(nint t, System.Boolean includeInactive); 
*/
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t)
            /// </summary>
            /// <param name = "t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115, 73, 110, 67, 104, 105, 108, 100, 114, 101, 110], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 109, 112, 111, 110, 101, 110, 116, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           public partial nint GET_COMPONENTS_IN_CHILDREN(nint t); 
*/
            /// <summary>
            ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115, 73, 110, 67, 104, 105, 108, 100, 114, 101, 110], [84, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial nint GET_COMPONENTS_IN_CHILDREN(System.Boolean includeInactive); 
*/
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <param name = "result">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115, 73, 110, 67, 104, 105, 108, 100, 114, 101, 110], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 76, 105, 115, 116, 60, 84, 62], 1)]
           public partial void GET_COMPONENTS_IN_CHILDREN(System.Boolean includeInactive, nint result); 
*/
            /// <summary>
            ///   T[] GetComponentsInChildren()
            /// </summary>
            /// <returns>class T[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115, 73, 110, 67, 104, 105, 108, 100, 114, 101, 110], [84, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_COMPONENTS_IN_CHILDREN(); 
*/
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name = "results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115, 73, 110, 67, 104, 105, 108, 100, 114, 101, 110], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 76, 105, 115, 116, 60, 84, 62], 0)]
           public partial void GET_COMPONENTS_IN_CHILDREN(nint results); 
*/
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "t">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115, 73, 110, 80, 97, 114, 101, 110, 116], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 109, 112, 111, 110, 101, 110, 116, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 1)]
           public partial nint GET_COMPONENTS_IN_PARENT(nint t, System.Boolean includeInactive); 
*/
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInParent(System.Type t)
            /// </summary>
            /// <param name = "t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115, 73, 110, 80, 97, 114, 101, 110, 116], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 109, 112, 111, 110, 101, 110, 116, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           public partial nint GET_COMPONENTS_IN_PARENT(nint t); 
*/
            /// <summary>
            ///   T[] GetComponentsInParent(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115, 73, 110, 80, 97, 114, 101, 110, 116], [84, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial nint GET_COMPONENTS_IN_PARENT(System.Boolean includeInactive); 
*/
            /// <summary>
            ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <param name = "results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115, 73, 110, 80, 97, 114, 101, 110, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 46, 76, 105, 115, 116, 60, 84, 62], 1)]
           public partial void GET_COMPONENTS_IN_PARENT(System.Boolean includeInactive, nint results); 
*/
            /// <summary>
            ///   T[] GetComponentsInParent()
            /// </summary>
            /// <returns>class T[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116, 115, 73, 110, 80, 97, 114, 101, 110, 116], [84, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_COMPONENTS_IN_PARENT(); 
*/
            /// <summary>
            ///   System.Void SendMessage(System.String methodName, System.Object value)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 110, 100, 77, 101, 115, 115, 97, 103, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116], 1)]
           public partial void SEND_MESSAGE(nint methodName, nint value); 
*/
            /// <summary>
            ///   System.Void SendMessage(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 110, 100, 77, 101, 115, 115, 97, 103, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial void SEND_MESSAGE(nint methodName); 
*/
            /// <summary>
            ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <param name = "options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 110, 100, 77, 101, 115, 115, 97, 103, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 83, 101, 110, 100, 77, 101, 115, 115, 97, 103, 101, 79, 112, 116, 105, 111, 110, 115], 2)]
           public partial void SEND_MESSAGE(nint methodName, nint value, UnityEngine.SendMessageOptions options); 
*/
            /// <summary>
            ///   System.Void SendMessage(System.String methodName, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 110, 100, 77, 101, 115, 115, 97, 103, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 83, 101, 110, 100, 77, 101, 115, 115, 97, 103, 101, 79, 112, 116, 105, 111, 110, 115], 1)]
           public partial void SEND_MESSAGE(nint methodName, UnityEngine.SendMessageOptions options); 
*/
            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <param name = "options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 110, 100, 77, 101, 115, 115, 97, 103, 101, 85, 112, 119, 97, 114, 100, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 83, 101, 110, 100, 77, 101, 115, 115, 97, 103, 101, 79, 112, 116, 105, 111, 110, 115], 2)]
           public partial void SEND_MESSAGE_UPWARDS(nint methodName, nint value, UnityEngine.SendMessageOptions options); 
*/
            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName, System.Object value)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 110, 100, 77, 101, 115, 115, 97, 103, 101, 85, 112, 119, 97, 114, 100, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116], 1)]
           public partial void SEND_MESSAGE_UPWARDS(nint methodName, nint value); 
*/
            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 110, 100, 77, 101, 115, 115, 97, 103, 101, 85, 112, 119, 97, 114, 100, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial void SEND_MESSAGE_UPWARDS(nint methodName); 
*/
            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 110, 100, 77, 101, 115, 115, 97, 103, 101, 85, 112, 119, 97, 114, 100, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 83, 101, 110, 100, 77, 101, 115, 115, 97, 103, 101, 79, 112, 116, 105, 111, 110, 115], 1)]
           public partial void SEND_MESSAGE_UPWARDS(nint methodName, UnityEngine.SendMessageOptions options); 
*/
            /// <summary>
            ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "component">class UnityEngine.Component&</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([84, 114, 121, 71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 109, 112, 111, 110, 101, 110, 116, 38], 1)]
           public partial System.Boolean TRY_GET_COMPONENT(nint type, nint component); 
*/
            /// <summary>
            ///   System.Boolean TryGetComponent(T& component)
            /// </summary>
            /// <param name = "component">class T&</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([84, 114, 121, 71, 101, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84, 38], 0)]
           public partial System.Boolean TRY_GET_COMPONENT(nint component); 
*/
            /// <summary>
            ///   UnityEngine.GameObject get_gameObject()
            /// </summary>
            /// <returns>class UnityEngine.GameObject</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 103, 97, 109, 101, 79, 98, 106, 101, 99, 116], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 71, 97, 109, 101, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_GAME_OBJECT(); 
*/
            /// <summary>
            ///   System.String get_tag()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 116, 97, 103], [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_TAG(); 
*/
            /// <summary>
            ///   UnityEngine.Transform get_transform()
            /// </summary>
            /// <returns>class UnityEngine.Transform</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 116, 114, 97, 110, 115, 102, 111, 114, 109], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 84, 114, 97, 110, 115, 102, 111, 114, 109], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_TRANSFORM(); 
*/
            /// <summary>
            ///   System.Void set_tag(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([115, 101, 116, 95, 116, 97, 103], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial void SET_TAG(nint value); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Object"]
        /// </summary>
        public unsafe readonly partial struct Ptr_GameManager
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([46, 99, 99, 116, 111, 114], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial static void _CCTOR(); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([46, 99, 116, 111, 114], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void _CTOR(); 
*/
            /// <summary>
            /// static  System.Void CheckNullArgument(System.Object arg, System.String message)
            /// </summary>
            /// <param name = "arg">class System.Object</param>
            /// <param name = "message">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([67, 104, 101, 99, 107, 78, 117, 108, 108, 65, 114, 103, 117, 109, 101, 110, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 1)]
           public partial static void CHECK_NULL_ARGUMENT(nint arg, nint message); 
*/
            /// <summary>
            /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs)
            /// </summary>
            /// <param name = "lhs">class UnityEngine.Object</param>
            /// <param name = "rhs">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([67, 111, 109, 112, 97, 114, 101, 66, 97, 115, 101, 79, 98, 106, 101, 99, 116, 115], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 1)]
           public partial static System.Boolean COMPARE_BASE_OBJECTS(nint lhs, nint rhs); 
*/
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([68, 101, 115, 116, 114, 111, 121], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 1)]
           public partial static void DESTROY(nint obj, System.Single t); 
*/
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([68, 101, 115, 116, 114, 111, 121], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           public partial static void DESTROY(nint obj); 
*/
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "allowDestroyingAssets">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([68, 101, 115, 116, 114, 111, 121, 73, 109, 109, 101, 100, 105, 97, 116, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 1)]
           public partial static void DESTROY_IMMEDIATE(nint obj, System.Boolean allowDestroyingAssets); 
*/
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([68, 101, 115, 116, 114, 111, 121, 73, 109, 109, 101, 100, 105, 97, 116, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           public partial static void DESTROY_IMMEDIATE(nint obj); 
*/
            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([68, 101, 115, 116, 114, 111, 121, 79, 98, 106, 101, 99, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 1)]
           public partial static void DESTROY_OBJECT(nint obj, System.Single t); 
*/
            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([68, 101, 115, 116, 114, 111, 121, 79, 98, 106, 101, 99, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           public partial static void DESTROY_OBJECT(nint obj); 
*/
            /// <summary>
            /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
            /// </summary>
            /// <param name = "target">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([68, 111, 110, 116, 68, 101, 115, 116, 114, 111, 121, 79, 110, 76, 111, 97, 100], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           public partial static void DONT_DESTROY_ON_LOAD(nint target); 
*/
            /// <summary>
            ///   System.Boolean Equals(System.Object other)
            /// </summary>
            /// <param name = "other">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([69, 113, 117, 97, 108, 115], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116], 0)]
           public partial System.Boolean EQUALS(nint other); 
*/
            /// <summary>
            /// static  T FindAnyObjectByType()
            /// </summary>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 65, 110, 121, 79, 98, 106, 101, 99, 116, 66, 121, 84, 121, 112, 101], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial static nint FIND_ANY_OBJECT_BY_TYPE(); 
*/
            /// <summary>
            /// static  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 65, 110, 121, 79, 98, 106, 101, 99, 116, 66, 121, 84, 121, 112, 101], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 73, 110, 97, 99, 116, 105, 118, 101], 0)]
           public partial static nint FIND_ANY_OBJECT_BY_TYPE(UnityEngine.FindObjectsInactive findObjectsInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindAnyObjectByType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 65, 110, 121, 79, 98, 106, 101, 99, 116, 66, 121, 84, 121, 112, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           public partial static nint FIND_ANY_OBJECT_BY_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 65, 110, 121, 79, 98, 106, 101, 99, 116, 66, 121, 84, 121, 112, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 73, 110, 97, 99, 116, 105, 118, 101], 1)]
           public partial static nint FIND_ANY_OBJECT_BY_TYPE(nint type, UnityEngine.FindObjectsInactive findObjectsInactive); 
*/
            /// <summary>
            /// static  T FindFirstObjectByType()
            /// </summary>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 70, 105, 114, 115, 116, 79, 98, 106, 101, 99, 116, 66, 121, 84, 121, 112, 101], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial static nint FIND_FIRST_OBJECT_BY_TYPE(); 
*/
            /// <summary>
            /// static  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 70, 105, 114, 115, 116, 79, 98, 106, 101, 99, 116, 66, 121, 84, 121, 112, 101], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 73, 110, 97, 99, 116, 105, 118, 101], 0)]
           public partial static nint FIND_FIRST_OBJECT_BY_TYPE(UnityEngine.FindObjectsInactive findObjectsInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindFirstObjectByType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 70, 105, 114, 115, 116, 79, 98, 106, 101, 99, 116, 66, 121, 84, 121, 112, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           public partial static nint FIND_FIRST_OBJECT_BY_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 70, 105, 114, 115, 116, 79, 98, 106, 101, 99, 116, 66, 121, 84, 121, 112, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 73, 110, 97, 99, 116, 105, 118, 101], 1)]
           public partial static nint FIND_FIRST_OBJECT_BY_TYPE(nint type, UnityEngine.FindObjectsInactive findObjectsInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name = "instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 70, 114, 111, 109, 73, 110, 115, 116, 97, 110, 99, 101, 73, 68], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           public partial static nint FIND_OBJECT_FROM_INSTANCE_ID(System.Int32 instanceID); 
*/
            /// <summary>
            /// static  T FindObjectOfType()
            /// </summary>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 79, 102, 84, 121, 112, 101], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial static nint FIND_OBJECT_OF_TYPE(); 
*/
            /// <summary>
            /// static  T FindObjectOfType(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 79, 102, 84, 121, 112, 101], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial static nint FIND_OBJECT_OF_TYPE(System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 79, 102, 84, 121, 112, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           public partial static nint FIND_OBJECT_OF_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 79, 102, 84, 121, 112, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 1)]
           public partial static nint FIND_OBJECT_OF_TYPE(nint type, System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 66, 121, 84, 121, 112, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 83, 111, 114, 116, 77, 111, 100, 101], 1)]
           public partial static nint FIND_OBJECTS_BY_TYPE(nint type, UnityEngine.FindObjectsSortMode sortMode); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <param name = "sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 66, 121, 84, 121, 112, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 73, 110, 97, 99, 116, 105, 118, 101], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 83, 111, 114, 116, 77, 111, 100, 101], 2)]
           public partial static nint FIND_OBJECTS_BY_TYPE(nint type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode); 
*/
            /// <summary>
            /// static  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name = "sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class T[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 66, 121, 84, 121, 112, 101], [84, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 83, 111, 114, 116, 77, 111, 100, 101], 0)]
           public partial static nint FIND_OBJECTS_BY_TYPE(UnityEngine.FindObjectsSortMode sortMode); 
*/
            /// <summary>
            /// static  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <param name = "sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class T[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 66, 121, 84, 121, 112, 101], [84, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 73, 110, 97, 99, 116, 105, 118, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 83, 111, 114, 116, 77, 111, 100, 101], 1)]
           public partial static nint FIND_OBJECTS_BY_TYPE(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 79, 102, 84, 121, 112, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           public partial static nint FIND_OBJECTS_OF_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 79, 102, 84, 121, 112, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 1)]
           public partial static nint FIND_OBJECTS_OF_TYPE(nint type, System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  T[] FindObjectsOfType()
            /// </summary>
            /// <returns>class T[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 79, 102, 84, 121, 112, 101], [84, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial static nint FIND_OBJECTS_OF_TYPE(); 
*/
            /// <summary>
            /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 79, 102, 84, 121, 112, 101], [84, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial static nint FIND_OBJECTS_OF_TYPE(System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 79, 102, 84, 121, 112, 101, 65, 108, 108], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           public partial static nint FIND_OBJECTS_OF_TYPE_ALL(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 79, 98, 106, 101, 99, 116, 115, 79, 102, 84, 121, 112, 101, 73, 110, 99, 108, 117, 100, 105, 110, 103, 65, 115, 115, 101, 116, 115], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           public partial static nint FIND_OBJECTS_OF_TYPE_INCLUDING_ASSETS(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindSceneObjectsOfType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 105, 110, 100, 83, 99, 101, 110, 101, 79, 98, 106, 101, 99, 116, 115, 79, 102, 84, 121, 112, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116, 91, 93], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 84, 121, 112, 101], 0)]
           public partial static nint FIND_SCENE_OBJECTS_OF_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object ForceLoadFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name = "instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([70, 111, 114, 99, 101, 76, 111, 97, 100, 70, 114, 111, 109, 73, 110, 115, 116, 97, 110, 99, 101, 73, 68], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], 0)]
           public partial static nint FORCE_LOAD_FROM_INSTANCE_ID(System.Int32 instanceID); 
*/
            /// <summary>
            ///   System.IntPtr GetCachedPtr()
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 67, 97, 99, 104, 101, 100, 80, 116, 114], [83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 80, 116, 114], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.IntPtr GET_CACHED_PTR(); 
*/
            /// <summary>
            ///   System.Int32 GetHashCode()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 72, 97, 115, 104, 67, 111, 100, 101], [83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 GET_HASH_CODE(); 
*/
            /// <summary>
            ///   System.Int32 GetInstanceID()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 73, 110, 115, 116, 97, 110, 99, 101, 73, 68], [83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 GET_INSTANCE_ID(); 
*/
            /// <summary>
            /// static  System.String GetName(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 78, 97, 109, 101], [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           public partial static nint GET_NAME(nint obj); 
*/
            /// <summary>
            /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 79, 102, 102, 115, 101, 116, 79, 102, 73, 110, 115, 116, 97, 110, 99, 101, 73, 68, 73, 110, 67, 80, 108, 117, 115, 80, 108, 117, 115, 79, 98, 106, 101, 99, 116], [83, 121, 115, 116, 101, 109, 46, 73, 110, 116, 51, 50], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial static System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT(); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 115, 116, 97, 110, 116, 105, 97, 116, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 86, 101, 99, 116, 111, 114, 51], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 81, 117, 97, 116, 101, 114, 110, 105, 111, 110], 2)]
           public partial static nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
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
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 115, 116, 97, 110, 116, 105, 97, 116, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 86, 101, 99, 116, 111, 114, 51], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 81, 117, 97, 116, 101, 114, 110, 105, 111, 110], 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 84, 114, 97, 110, 115, 102, 111, 114, 109], 3)]
           public partial static nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 115, 116, 97, 110, 116, 105, 97, 116, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           public partial static nint INSTANTIATE(nint original); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 115, 116, 97, 110, 116, 105, 97, 116, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 84, 114, 97, 110, 115, 102, 111, 114, 109], 1)]
           public partial static nint INSTANTIATE(nint original, nint parent); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "instantiateInWorldSpace">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 115, 116, 97, 110, 116, 105, 97, 116, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 84, 114, 97, 110, 115, 102, 111, 114, 109], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 2)]
           public partial static nint INSTANTIATE(nint original, nint parent, System.Boolean instantiateInWorldSpace); 
*/
            /// <summary>
            /// static  T Instantiate(T original)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 115, 116, 97, 110, 116, 105, 97, 116, 101], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84], 0)]
           public partial static nint INSTANTIATE(nint original); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 115, 116, 97, 110, 116, 105, 97, 116, 101], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 86, 101, 99, 116, 111, 114, 51], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 81, 117, 97, 116, 101, 114, 110, 105, 111, 110], 2)]
           public partial static nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
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
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 115, 116, 97, 110, 116, 105, 97, 116, 101], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 86, 101, 99, 116, 111, 114, 51], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 81, 117, 97, 116, 101, 114, 110, 105, 111, 110], 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 84, 114, 97, 110, 115, 102, 111, 114, 109], 3)]
           public partial static nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 115, 116, 97, 110, 116, 105, 97, 116, 101], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 84, 114, 97, 110, 115, 102, 111, 114, 109], 1)]
           public partial static nint INSTANTIATE(nint original, nint parent); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "worldPositionStays">struct System.Boolean</param>
            /// <returns>class T</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 115, 116, 97, 110, 116, 105, 97, 116, 101], [84], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([84], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 84, 114, 97, 110, 115, 102, 111, 114, 109], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 2)]
           public partial static nint INSTANTIATE(nint original, nint parent, System.Boolean worldPositionStays); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 116, 101, 114, 110, 97, 108, 95, 67, 108, 111, 110, 101, 83, 105, 110, 103, 108, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           public partial static nint INTERNAL_CLONE_SINGLE(nint data); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "worldPositionStays">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 116, 101, 114, 110, 97, 108, 95, 67, 108, 111, 110, 101, 83, 105, 110, 103, 108, 101, 87, 105, 116, 104, 80, 97, 114, 101, 110, 116], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 84, 114, 97, 110, 115, 102, 111, 114, 109], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 2)]
           public partial static nint INTERNAL_CLONE_SINGLE_WITH_PARENT(nint data, nint parent, System.Boolean worldPositionStays); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <param name = "rot">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 116, 101, 114, 110, 97, 108, 95, 73, 110, 115, 116, 97, 110, 116, 105, 97, 116, 101, 83, 105, 110, 103, 108, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 86, 101, 99, 116, 111, 114, 51], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 81, 117, 97, 116, 101, 114, 110, 105, 111, 110], 2)]
           public partial static nint INTERNAL_INSTANTIATE_SINGLE(nint data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot); 
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
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 116, 101, 114, 110, 97, 108, 95, 73, 110, 115, 116, 97, 110, 116, 105, 97, 116, 101, 83, 105, 110, 103, 108, 101, 87, 105, 116, 104, 80, 97, 114, 101, 110, 116], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 84, 114, 97, 110, 115, 102, 111, 114, 109], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 86, 101, 99, 116, 111, 114, 51], 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 81, 117, 97, 116, 101, 114, 110, 105, 111, 110], 3)]
           public partial static nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT(nint data, nint parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot); 
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
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 116, 101, 114, 110, 97, 108, 95, 73, 110, 115, 116, 97, 110, 116, 105, 97, 116, 101, 83, 105, 110, 103, 108, 101, 87, 105, 116, 104, 80, 97, 114, 101, 110, 116, 95, 73, 110, 106, 101, 99, 116, 101, 100], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 84, 114, 97, 110, 115, 102, 111, 114, 109], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 86, 101, 99, 116, 111, 114, 51, 38], 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 81, 117, 97, 116, 101, 114, 110, 105, 111, 110, 38], 3)]
           public partial static nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT_INJECTED(nint data, nint parent, UnityEngine.Vector3 &pos, UnityEngine.Quaternion &rot); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "pos">struct UnityEngine.Vector3&</param>
            /// <param name = "rot">struct UnityEngine.Quaternion&</param>
            /// <returns>class UnityEngine.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 116, 101, 114, 110, 97, 108, 95, 73, 110, 115, 116, 97, 110, 116, 105, 97, 116, 101, 83, 105, 110, 103, 108, 101, 95, 73, 110, 106, 101, 99, 116, 101, 100], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 86, 101, 99, 116, 111, 114, 51, 38], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 81, 117, 97, 116, 101, 114, 110, 105, 111, 110, 38], 2)]
           public partial static nint INTERNAL_INSTANTIATE_SINGLE_INJECTED(nint data, UnityEngine.Vector3 &pos, UnityEngine.Quaternion &rot); 
*/
            /// <summary>
            /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
            /// </summary>
            /// <param name = "o">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 115, 78, 97, 116, 105, 118, 101, 79, 98, 106, 101, 99, 116, 65, 108, 105, 118, 101], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           public partial static System.Boolean IS_NATIVE_OBJECT_ALIVE(nint o); 
*/
            /// <summary>
            /// static  System.Void SetName(UnityEngine.Object obj, System.String name)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 101, 116, 78, 97, 109, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 1)]
           public partial static void SET_NAME(nint obj, nint name); 
*/
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([84, 111, 83, 116, 114, 105, 110, 103], [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint TO_STRING(); 
*/
            /// <summary>
            /// static  System.String ToString(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([84, 111, 83, 116, 114, 105, 110, 103], [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           public partial static nint TO_STRING(nint obj); 
*/
            /// <summary>
            ///   UnityEngine.HideFlags get_hideFlags()
            /// </summary>
            /// <returns>enum UnityEngine.HideFlags</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 104, 105, 100, 101, 70, 108, 97, 103, 115], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 72, 105, 100, 101, 70, 108, 97, 103, 115], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial UnityEngine.HideFlags GET_HIDE_FLAGS(); 
*/
            /// <summary>
            ///   System.String get_name()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 110, 97, 109, 101], [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_NAME(); 
*/
            /// <summary>
            /// static  System.Boolean op_Equality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name = "x">class UnityEngine.Object</param>
            /// <param name = "y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([111, 112, 95, 69, 113, 117, 97, 108, 105, 116, 121], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 1)]
           public partial static System.Boolean OP_EQUALITY(nint x, nint y); 
*/
            /// <summary>
            /// static  System.Boolean op_Implicit(UnityEngine.Object exists)
            /// </summary>
            /// <param name = "exists">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([111, 112, 95, 73, 109, 112, 108, 105, 99, 105, 116], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           public partial static System.Boolean OP_IMPLICIT(nint exists); 
*/
            /// <summary>
            /// static  System.Boolean op_Inequality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name = "x">class UnityEngine.Object</param>
            /// <param name = "y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([111, 112, 95, 73, 110, 101, 113, 117, 97, 108, 105, 116, 121], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 1)]
           public partial static System.Boolean OP_INEQUALITY(nint x, nint y); 
*/
            /// <summary>
            ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.HideFlags</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([115, 101, 116, 95, 104, 105, 100, 101, 70, 108, 97, 103, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 72, 105, 100, 101, 70, 108, 97, 103, 115], 0)]
           public partial void SET_HIDE_FLAGS(UnityEngine.HideFlags value); 
*/
            /// <summary>
            ///   System.Void set_name(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([115, 101, 116, 95, 110, 97, 109, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial void SET_NAME(nint value); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."MonoBehaviour"]
        /// </summary>
        public unsafe readonly partial struct Ptr_GameManager
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([46, 99, 116, 111, 114], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void _CTOR(); 
*/
            /// <summary>
            ///   System.Void CancelInvoke()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([67, 97, 110, 99, 101, 108, 73, 110, 118, 111, 107, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CANCEL_INVOKE(); 
*/
            /// <summary>
            ///   System.Void CancelInvoke(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([67, 97, 110, 99, 101, 108, 73, 110, 118, 111, 107, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial void CANCEL_INVOKE(nint methodName); 
*/
            /// <summary>
            /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([67, 97, 110, 99, 101, 108, 73, 110, 118, 111, 107, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 77, 111, 110, 111, 66, 101, 104, 97, 118, 105, 111, 117, 114], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 1)]
           public partial static void CANCEL_INVOKE(nint self, nint methodName); 
*/
            /// <summary>
            ///   System.String GetScriptClassName()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([71, 101, 116, 83, 99, 114, 105, 112, 116, 67, 108, 97, 115, 115, 78, 97, 109, 101], [83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_SCRIPT_CLASS_NAME(); 
*/
            /// <summary>
            /// static  System.Void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 116, 101, 114, 110, 97, 108, 95, 67, 97, 110, 99, 101, 108, 73, 110, 118, 111, 107, 101, 65, 108, 108], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 77, 111, 110, 111, 66, 101, 104, 97, 118, 105, 111, 117, 114], 0)]
           public partial static void INTERNAL_CANCEL_INVOKE_ALL(nint self); 
*/
            /// <summary>
            /// static  System.Boolean Internal_IsInvokingAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 116, 101, 114, 110, 97, 108, 95, 73, 115, 73, 110, 118, 111, 107, 105, 110, 103, 65, 108, 108], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 77, 111, 110, 111, 66, 101, 104, 97, 118, 105, 111, 117, 114], 0)]
           public partial static System.Boolean INTERNAL_IS_INVOKING_ALL(nint self); 
*/
            /// <summary>
            ///   System.Void Invoke(System.String methodName, System.Single time)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 118, 111, 107, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 1)]
           public partial void INVOKE(nint methodName, System.Single time); 
*/
            /// <summary>
            /// static  System.Void InvokeDelayed(UnityEngine.MonoBehaviour self, System.String methodName, System.Single time, System.Single repeatRate)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "time">struct System.Single</param>
            /// <param name = "repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 118, 111, 107, 101, 68, 101, 108, 97, 121, 101, 100], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 77, 111, 110, 111, 66, 101, 104, 97, 118, 105, 111, 117, 114], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 3)]
           public partial static void INVOKE_DELAYED(nint self, nint methodName, System.Single time, System.Single repeatRate); 
*/
            /// <summary>
            ///   System.Void InvokeRepeating(System.String methodName, System.Single time, System.Single repeatRate)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "time">struct System.Single</param>
            /// <param name = "repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 110, 118, 111, 107, 101, 82, 101, 112, 101, 97, 116, 105, 110, 103], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 105, 110, 103, 108, 101], 2)]
           public partial void INVOKE_REPEATING(nint methodName, System.Single time, System.Single repeatRate); 
*/
            /// <summary>
            ///   System.Boolean IsInvoking()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 115, 73, 110, 118, 111, 107, 105, 110, 103], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean IS_INVOKING(); 
*/
            /// <summary>
            ///   System.Boolean IsInvoking(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 115, 73, 110, 118, 111, 107, 105, 110, 103], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial System.Boolean IS_INVOKING(nint methodName); 
*/
            /// <summary>
            /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 115, 73, 110, 118, 111, 107, 105, 110, 103], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 77, 111, 110, 111, 66, 101, 104, 97, 118, 105, 111, 117, 114], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 1)]
           public partial static System.Boolean IS_INVOKING(nint self, nint methodName); 
*/
            /// <summary>
            /// static  System.Boolean IsObjectMonoBehaviour(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([73, 115, 79, 98, 106, 101, 99, 116, 77, 111, 110, 111, 66, 101, 104, 97, 118, 105, 111, 117, 114], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 79, 98, 106, 101, 99, 116], 0)]
           public partial static System.Boolean IS_OBJECT_MONO_BEHAVIOUR(nint obj); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 116, 97, 114, 116, 67, 111, 114, 111, 117, 116, 105, 110, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 111, 117, 116, 105, 110, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial nint START_COROUTINE(nint methodName); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 116, 97, 114, 116, 67, 111, 114, 111, 117, 116, 105, 110, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 111, 117, 116, 105, 110, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116], 1)]
           public partial nint START_COROUTINE(nint methodName, nint value); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 116, 97, 114, 116, 67, 111, 114, 111, 117, 116, 105, 110, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 111, 117, 116, 105, 110, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], 0)]
           public partial nint START_COROUTINE(nint routine); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged(System.String methodName, System.Object value)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 116, 97, 114, 116, 67, 111, 114, 111, 117, 116, 105, 110, 101, 77, 97, 110, 97, 103, 101, 100], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 111, 117, 116, 105, 110, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116], 1)]
           public partial nint START_COROUTINE_MANAGED(nint methodName, nint value); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator)
            /// </summary>
            /// <param name = "enumerator">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 116, 97, 114, 116, 67, 111, 114, 111, 117, 116, 105, 110, 101, 77, 97, 110, 97, 103, 101, 100, 50], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 111, 117, 116, 105, 110, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], 0)]
           public partial nint START_COROUTINE_MANAGED2(nint enumerator); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 116, 97, 114, 116, 67, 111, 114, 111, 117, 116, 105, 110, 101, 95, 65, 117, 116, 111], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 111, 117, 116, 105, 110, 101], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], 0)]
           public partial nint START_COROUTINE_AUTO(nint routine); 
*/
            /// <summary>
            ///   System.Void StopAllCoroutines()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 116, 111, 112, 65, 108, 108, 67, 111, 114, 111, 117, 116, 105, 110, 101, 115], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void STOP_ALL_COROUTINES(); 
*/
            /// <summary>
            ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 116, 111, 112, 67, 111, 114, 111, 117, 116, 105, 110, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], 0)]
           public partial void STOP_COROUTINE(nint routine); 
*/
            /// <summary>
            ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name = "routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 116, 111, 112, 67, 111, 114, 111, 117, 116, 105, 110, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 111, 117, 116, 105, 110, 101], 0)]
           public partial void STOP_COROUTINE(nint routine); 
*/
            /// <summary>
            ///   System.Void StopCoroutine(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 116, 111, 112, 67, 111, 114, 111, 117, 116, 105, 110, 101], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 83, 116, 114, 105, 110, 103], 0)]
           public partial void STOP_COROUTINE(nint methodName); 
*/
            /// <summary>
            ///   System.Void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 116, 111, 112, 67, 111, 114, 111, 117, 116, 105, 110, 101, 70, 114, 111, 109, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114, 77, 97, 110, 97, 103, 101, 100], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 73, 69, 110, 117, 109, 101, 114, 97, 116, 111, 114], 0)]
           public partial void STOP_COROUTINE_FROM_ENUMERATOR_MANAGED(nint routine); 
*/
            /// <summary>
            ///   System.Void StopCoroutineManaged(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name = "routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([83, 116, 111, 112, 67, 111, 114, 111, 117, 116, 105, 110, 101, 77, 97, 110, 97, 103, 101, 100], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 111, 117, 116, 105, 110, 101], 0)]
           public partial void STOP_COROUTINE_MANAGED(nint routine); 
*/
            /// <summary>
            ///   System.Boolean get_useGUILayout()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([103, 101, 116, 95, 117, 115, 101, 71, 85, 73, 76, 97, 121, 111, 117, 116], [83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_USE_GUI_LAYOUT(); 
*/
            /// <summary>
            /// static  System.Void print(System.Object message)
            /// </summary>
            /// <param name = "message">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([112, 114, 105, 110, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 79, 98, 106, 101, 99, 116], 0)]
           public partial static void PRINT(nint message); 
*/
            /// <summary>
            ///   System.Void set_useGUILayout(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute([115, 101, 116, 95, 117, 115, 101, 71, 85, 73, 76, 97, 121, 111, 117, 116], [83, 121, 115, 116, 101, 109, 46, 86, 111, 105, 100], CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute([83, 121, 115, 116, 101, 109, 46, 66, 111, 111, 108, 101, 97, 110], 0)]
           public partial void SET_USE_GUI_LAYOUT(System.Boolean value); 
*/
        }
    }





}


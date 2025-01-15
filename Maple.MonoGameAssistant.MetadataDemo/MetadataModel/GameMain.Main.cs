namespace Maple.MonoGameAssistant.MetadataDemo.MetadataModel
{
    /// <summary>
    /// class ["Assembly-CSharp"."GameMain"."Main"]
    /// [Utility.GeneralObject.GeneralObject]=>[System.Object]
    /// </summary>
    [MetadataExtensions.MetadataGenerator.ClassParentMetadata<MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Main>, Ptr_Main>]
    [MetadataExtensions.MetadataGenerator.ClassModelMetadata("Assembly-CSharp", "GameMain", "Main", "GameMain.Main")]
    public partial class Main
    {
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Main(nint ptr) : MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint m_Pointer = ptr;
            public nint Ptr => m_Pointer;

            public static implicit operator Ptr_Main(nint ptr) => new Ptr_Main(ptr);
            public static implicit operator nint(Ptr_Main ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_Main ptr) => ptr.m_Pointer != nint.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."GameMain"."Main"]
        /// </summary>
        partial struct Ptr_Main
        {
            /// <summary>
            /// 0x0 GameMain.Main inst
            /// class ["Assembly-CSharp"."GameMain"."Main"]
            /// </summary>
            /// <returns>class GameMain.Main</returns>

            [MetadataExtensions.MetadataGenerator.ClassPropertyMetadata("inst", "GameMain.Main")]
            public static partial nint INST { get; }


            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.Guid , Utility.GeneralObject.GeneralObject> Dict
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Guid , Utility.GeneralObject.GeneralObject></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Dict", "System.Collections.Generic.Dictionary<System.Guid,Utility.GeneralObject.GeneralObject>")]
           public static partial nint DICT { get; set; } 
*/

            /// <summary>
            /// 0x8 GameMain.Main.InitStates <InitState>k__BackingField
            /// enum ["Assembly-CSharp".""."InitStates"]
            /// </summary>
            /// <returns>enum GameMain.Main.InitStates</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<InitState>k__BackingField", "GameMain.Main.InitStates")]
           public static partial GameMain.Main.InitStates INIT_STATE { get; set; } 
*/

            /// <summary>
            /// 0xC System.Boolean <Preloaded>k__BackingField
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Preloaded>k__BackingField", "System.Boolean")]
           public static partial System.Boolean PRELOADED { get; set; } 
*/

            /// <summary>
            /// 0x10 System.Int32 <CurrentSaveSlot>k__BackingField
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CurrentSaveSlot>k__BackingField", "System.Int32")]
           public static partial System.Int32 CURRENT_SAVE_SLOT { get; set; } 
*/

            /// <summary>
            /// 0x18 GameMain.SettingData <SettingData>k__BackingField
            /// class ["Assembly-CSharp"."GameMain"."SettingData"]
            /// </summary>
            /// <returns>class GameMain.SettingData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<SettingData>k__BackingField", "GameMain.SettingData")]
           public static partial nint SETTING_DATA { get; set; } 
*/

            /// <summary>
            /// 0x20 GameMain.Game.SaveData <SaveData>k__BackingField
            /// class ["Assembly-CSharp".""."SaveData"]
            /// </summary>
            /// <returns>class GameMain.Game.SaveData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<SaveData>k__BackingField", "GameMain.Game.SaveData")]
           public static partial nint SAVE_DATA { get; set; } 
*/

            /// <summary>
            /// 0x28 GameMain.GameDataInfo[] <GameSaveDataInfos>k__BackingField
            /// class ["Assembly-CSharp"."GameMain"."GameDataInfo[]"]
            /// </summary>
            /// <returns>class GameMain.GameDataInfo[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<GameSaveDataInfos>k__BackingField", "GameMain.GameDataInfo[]")]
           public static partial nint GAME_SAVE_DATA_INFOS { get; set; } 
*/

            /// <summary>
            /// 0x30 GameMain.CoachNoteData <CoachNoteData>k__BackingField
            /// class ["Assembly-CSharp"."GameMain"."CoachNoteData"]
            /// </summary>
            /// <returns>class GameMain.CoachNoteData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CoachNoteData>k__BackingField", "GameMain.CoachNoteData")]
           public static partial nint COACH_NOTE_DATA { get; set; } 
*/

            /// <summary>
            /// 0x38 GameMain.GameCustomData <GameCustomData>k__BackingField
            /// class ["Assembly-CSharp"."GameMain"."GameCustomData"]
            /// </summary>
            /// <returns>class GameMain.GameCustomData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<GameCustomData>k__BackingField", "GameMain.GameCustomData")]
           public static partial nint GAME_CUSTOM_DATA { get; set; } 
*/

            /// <summary>
            /// 0x40 GameMain.AchievementSystem.AchievementGlobalData <AchievementGlobalData>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.AchievementSystem"."AchievementGlobalData"]
            /// </summary>
            /// <returns>class GameMain.AchievementSystem.AchievementGlobalData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AchievementGlobalData>k__BackingField", "GameMain.AchievementSystem.AchievementGlobalData")]
           public static partial nint ACHIEVEMENT_GLOBAL_DATA { get; set; } 
*/

            /// <summary>
            /// 0x48 GameMain.AchievementSystem.AchievementLocalData <AchievementLocalData>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.AchievementSystem"."AchievementLocalData"]
            /// </summary>
            /// <returns>class GameMain.AchievementSystem.AchievementLocalData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AchievementLocalData>k__BackingField", "GameMain.AchievementSystem.AchievementLocalData")]
           public static partial nint ACHIEVEMENT_LOCAL_DATA { get; set; } 
*/

            /// <summary>
            /// 0x50 GameMain.AthleteSystem.CustomAthleteData <CustomAthleteData>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.AthleteSystem"."CustomAthleteData"]
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.CustomAthleteData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CustomAthleteData>k__BackingField", "GameMain.AthleteSystem.CustomAthleteData")]
           public static partial nint CUSTOM_ATHLETE_DATA { get; set; } 
*/

            /// <summary>
            /// 0x58 System.DateTime <LastSaveTime>k__BackingField
            /// struct ["mscorlib"."System"."DateTime"]
            /// </summary>
            /// <returns>struct System.DateTime</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<LastSaveTime>k__BackingField", "System.DateTime")]
           public static partial System.DateTime LAST_SAVE_TIME { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Boolean <LoadCustom>k__BackingField
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<LoadCustom>k__BackingField", "System.Boolean")]
           public static partial System.Boolean LOAD_CUSTOM { get; set; } 
*/

            /// <summary>
            /// 0x10 Utility.GeneralObject.C_SettingLogic m_cSettingLogic
            /// class ["Utility"."Utility.GeneralObject"."C_SettingLogic"]
            /// </summary>
            /// <returns>class Utility.GeneralObject.C_SettingLogic</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_cSettingLogic", "Utility.GeneralObject.C_SettingLogic")]
           public partial nint M_C_SETTING_LOGIC { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent> m_components
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_components", "System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent>")]
           public partial nint M_COMPONENTS { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent> m_components_public
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_components_public", "System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent>")]
           public partial nint M_COMPONENTS_PUBLIC { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent> m_components_update
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_components_update", "System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent>")]
           public partial nint M_COMPONENTS_UPDATE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent> m_components_temp
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_components_temp", "System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent>")]
           public partial nint M_COMPONENTS_TEMP { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.Dictionary<Utility.GeneralObject.GeneralObject.IComponent , Utility.GeneralObject.GeneralObject.ComponentData> m_componentsData
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<Utility.GeneralObject.GeneralObject.IComponent , Utility.GeneralObject.GeneralObject.ComponentData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_componentsData", "System.Collections.Generic.Dictionary<Utility.GeneralObject.GeneralObject.IComponent,Utility.GeneralObject.GeneralObject.ComponentData>")]
           public partial nint M_COMPONENTS_DATA { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent> <Components>k__BackingField
            /// class ["mscorlib"."System.Collections.ObjectModel"."ReadOnlyCollection`1"]
            /// </summary>
            /// <returns>class System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Components>k__BackingField", "System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent>")]
           public partial nint COMPONENTS { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent> <Components_Update>k__BackingField
            /// class ["mscorlib"."System.Collections.ObjectModel"."ReadOnlyCollection`1"]
            /// </summary>
            /// <returns>class System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Components_Update>k__BackingField", "System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent>")]
           public partial nint COMPONENTS_UPDATE { get; set; } 
*/

            /// <summary>
            /// 0x50 Utility.TimeData <TimeData>k__BackingField
            /// class ["Utility"."Utility"."TimeData"]
            /// </summary>
            /// <returns>class Utility.TimeData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<TimeData>k__BackingField", "Utility.TimeData")]
           public partial nint TIME_DATA { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Boolean m_initialized
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_initialized", "System.Boolean")]
           public partial System.Boolean M_INITIALIZED { get; set; } 
*/

            /// <summary>
            /// 0x59 System.Boolean m_canAddPersistComponent
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_canAddPersistComponent", "System.Boolean")]
           public partial System.Boolean M_CAN_ADD_PERSIST_COMPONENT { get; set; } 
*/

            /// <summary>
            /// 0x5C System.Guid <Id>k__BackingField
            /// struct ["mscorlib"."System"."Guid"]
            /// </summary>
            /// <returns>struct System.Guid</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Id>k__BackingField", "System.Guid")]
           public partial System.Guid ID { get; set; } 
*/

            /// <summary>
            /// 0x6C System.Int32 <Utility.PoolSystem.IPoolItem.SpawnId>k__BackingField
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Utility.PoolSystem.IPoolItem.SpawnId>k__BackingField", "System.Int32")]
           public partial System.Int32 UTILITY_POOL_SYSTEM_I_POOL_ITEM_SPAWN_ID { get; set; } 
*/

            /// <summary>
            /// 0x70 GameMain.Main.FSMComponent <C_FSM>k__BackingField
            /// class ["Assembly-CSharp".""."FSMComponent"]
            /// </summary>
            /// <returns>class GameMain.Main.FSMComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_FSM>k__BackingField", "GameMain.Main.FSMComponent")]
           public partial nint C_FSM { get; set; } 
*/

            /// <summary>
            /// 0x78 GameMain.Main.LogicComponent <C_Logic>k__BackingField
            /// class ["Assembly-CSharp".""."LogicComponent"]
            /// </summary>
            /// <returns>class GameMain.Main.LogicComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Logic>k__BackingField", "GameMain.Main.LogicComponent")]
           public partial nint C_LOGIC { get; set; } 
*/

            /// <summary>
            /// 0x80 GameMain.Main.PreLoadComponent <C_PreLoad>k__BackingField
            /// class ["Assembly-CSharp".""."PreLoadComponent"]
            /// </summary>
            /// <returns>class GameMain.Main.PreLoadComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_PreLoad>k__BackingField", "GameMain.Main.PreLoadComponent")]
           public partial nint C_PRE_LOAD { get; set; } 
*/

            /// <summary>
            /// 0x88 GameMain.Game <Game>k__BackingField
            /// class ["Assembly-CSharp"."GameMain"."Game"]
            /// </summary>
            /// <returns>class GameMain.Game</returns>

            [MetadataExtensions.MetadataGenerator.ClassPropertyMetadata("<Game>k__BackingField", "GameMain.Game")]
            public partial Game.Ptr_Game GAME { get; }


            /// <summary>
            /// 0x90 GameMain.Test.GameProcedureDebugSetting <ProcedureDebugSetting>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.Test"."GameProcedureDebugSetting"]
            /// </summary>
            /// <returns>class GameMain.Test.GameProcedureDebugSetting</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ProcedureDebugSetting>k__BackingField", "GameMain.Test.GameProcedureDebugSetting")]
           public partial nint PROCEDURE_DEBUG_SETTING { get; set; } 
*/

            /// <summary>
            /// 0x98 System.Boolean <IsTestBattle>k__BackingField
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<IsTestBattle>k__BackingField", "System.Boolean")]
           public partial System.Boolean IS_TEST_BATTLE { get; set; } 
*/

            /// <summary>
            /// 0x99 System.Boolean <TestPlayerRed>k__BackingField
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<TestPlayerRed>k__BackingField", "System.Boolean")]
           public partial System.Boolean TEST_PLAYER_RED { get; set; } 
*/

            /// <summary>
            /// 0x9A System.Boolean <IsError>k__BackingField
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<IsError>k__BackingField", "System.Boolean")]
           public partial System.Boolean IS_ERROR { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."GameMain"."Main"]
        /// </summary>
        partial struct Ptr_Main
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
            /// static  System.Collections.Generic.IEnumerator<Utility.MissionSystem.YieldCmd> Co_Init()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerator<Utility.MissionSystem.YieldCmd></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Co_Init", "System.Collections.Generic.IEnumerator<Utility.MissionSystem.YieldCmd>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint CO_INIT(); 
*/
            /// <summary>
            /// static  System.Collections.Generic.IEnumerator<Utility.MissionSystem.YieldCmd> Co_Preload()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerator<Utility.MissionSystem.YieldCmd></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Co_Preload", "System.Collections.Generic.IEnumerator<Utility.MissionSystem.YieldCmd>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint CO_PRELOAD(); 
*/
            /// <summary>
            /// static  GameMain.AchievementSystem.AchievementGlobalData get_AchievementGlobalData()
            /// </summary>
            /// <returns>class GameMain.AchievementSystem.AchievementGlobalData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AchievementGlobalData", "GameMain.AchievementSystem.AchievementGlobalData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_ACHIEVEMENT_GLOBAL_DATA(); 
*/
            /// <summary>
            /// static  GameMain.AchievementSystem.AchievementLocalData get_AchievementLocalData()
            /// </summary>
            /// <returns>class GameMain.AchievementSystem.AchievementLocalData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AchievementLocalData", "GameMain.AchievementSystem.AchievementLocalData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_ACHIEVEMENT_LOCAL_DATA(); 
*/
            /// <summary>
            /// static  GameMain.CoachNoteData get_CoachNoteData()
            /// </summary>
            /// <returns>class GameMain.CoachNoteData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CoachNoteData", "GameMain.CoachNoteData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_COACH_NOTE_DATA(); 
*/
            /// <summary>
            /// static  System.Int32 get_CurrentSaveSlot()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CurrentSaveSlot", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_CURRENT_SAVE_SLOT(); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.CustomAthleteData get_CustomAthleteData()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.CustomAthleteData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CustomAthleteData", "GameMain.AthleteSystem.CustomAthleteData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_CUSTOM_ATHLETE_DATA(); 
*/
            /// <summary>
            /// static  GameMain.GameCustomData get_GameCustomData()
            /// </summary>
            /// <returns>class GameMain.GameCustomData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GameCustomData", "GameMain.GameCustomData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_GAME_CUSTOM_DATA(); 
*/
            /// <summary>
            /// static  GameMain.GameDataInfo[] get_GameSaveDataInfos()
            /// </summary>
            /// <returns>class GameMain.GameDataInfo[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GameSaveDataInfos", "GameMain.GameDataInfo[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_GAME_SAVE_DATA_INFOS(); 
*/
            /// <summary>
            /// static  GameMain.Main.InitStates get_InitState()
            /// </summary>
            /// <returns>enum GameMain.Main.InitStates</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_InitState", "GameMain.Main.InitStates", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial GameMain.Main.InitStates GET_INIT_STATE(); 
*/
            /// <summary>
            /// static  GameMain.Main get_Inst()
            /// </summary>
            /// <returns>class GameMain.Main</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Inst", "GameMain.Main", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_INST(); 
*/
            /// <summary>
            /// static  System.DateTime get_LastSaveTime()
            /// </summary>
            /// <returns>struct System.DateTime</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_LastSaveTime", "System.DateTime", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.DateTime GET_LAST_SAVE_TIME(); 
*/
            /// <summary>
            /// static  System.Boolean get_LoadCustom()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_LoadCustom", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Boolean GET_LOAD_CUSTOM(); 
*/
            /// <summary>
            /// static  System.Boolean get_Preloaded()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Preloaded", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Boolean GET_PRELOADED(); 
*/
            /// <summary>
            /// static  GameMain.Game.SaveData get_SaveData()
            /// </summary>
            /// <returns>class GameMain.Game.SaveData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SaveData", "GameMain.Game.SaveData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_SAVE_DATA(); 
*/
            /// <summary>
            /// static  GameMain.SettingData get_SettingData()
            /// </summary>
            /// <returns>class GameMain.SettingData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SettingData", "GameMain.SettingData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_SETTING_DATA(); 
*/
            /// <summary>
            /// static  System.UInt32 get_SteamAppId()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SteamAppId", "System.UInt32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.UInt32 GET_STEAM_APP_ID(); 
*/
            /// <summary>
            /// static  System.Boolean get_SteamOfficialVersion()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SteamOfficialVersion", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Boolean GET_STEAM_OFFICIAL_VERSION(); 
*/
            /// <summary>
            /// static  System.String GetVersion()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetVersion", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_VERSION(); 
*/
            /// <summary>
            /// static  System.Void set_AchievementGlobalData(GameMain.AchievementSystem.AchievementGlobalData value)
            /// </summary>
            /// <param name = "value">class GameMain.AchievementSystem.AchievementGlobalData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AchievementGlobalData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AchievementSystem.AchievementGlobalData", 0)]
            public static partial void SET_ACHIEVEMENT_GLOBAL_DATA(nint value); 
*/
            /// <summary>
            /// static  System.Void set_AchievementLocalData(GameMain.AchievementSystem.AchievementLocalData value)
            /// </summary>
            /// <param name = "value">class GameMain.AchievementSystem.AchievementLocalData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AchievementLocalData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AchievementSystem.AchievementLocalData", 0)]
            public static partial void SET_ACHIEVEMENT_LOCAL_DATA(nint value); 
*/
            /// <summary>
            /// static  System.Void set_CoachNoteData(GameMain.CoachNoteData value)
            /// </summary>
            /// <param name = "value">class GameMain.CoachNoteData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CoachNoteData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.CoachNoteData", 0)]
            public static partial void SET_COACH_NOTE_DATA(nint value); 
*/
            /// <summary>
            /// static  System.Void set_CurrentSaveSlot(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CurrentSaveSlot", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_CURRENT_SAVE_SLOT(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_CustomAthleteData(GameMain.AthleteSystem.CustomAthleteData value)
            /// </summary>
            /// <param name = "value">class GameMain.AthleteSystem.CustomAthleteData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CustomAthleteData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.CustomAthleteData", 0)]
            public static partial void SET_CUSTOM_ATHLETE_DATA(nint value); 
*/
            /// <summary>
            /// static  System.Void set_GameSaveDataInfos(GameMain.GameDataInfo[] value)
            /// </summary>
            /// <param name = "value">class GameMain.GameDataInfo[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_GameSaveDataInfos", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.GameDataInfo[]", 0)]
            public static partial void SET_GAME_SAVE_DATA_INFOS(nint value); 
*/
            /// <summary>
            /// static  System.Void set_InitState(GameMain.Main.InitStates value)
            /// </summary>
            /// <param name = "value">enum GameMain.Main.InitStates</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_InitState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Main.InitStates", 0)]
            public static partial void SET_INIT_STATE(GameMain.Main.InitStates value); 
*/
            /// <summary>
            /// static  System.Void set_LastSaveTime(System.DateTime value)
            /// </summary>
            /// <param name = "value">struct System.DateTime</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_LastSaveTime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.DateTime", 0)]
            public static partial void SET_LAST_SAVE_TIME(System.DateTime value); 
*/
            /// <summary>
            /// static  System.Void set_LoadCustom(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_LoadCustom", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public static partial void SET_LOAD_CUSTOM(System.Boolean value); 
*/
            /// <summary>
            /// static  System.Void set_Preloaded(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Preloaded", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public static partial void SET_PRELOADED(System.Boolean value); 
*/
            /// <summary>
            /// static  System.Void set_SaveData(GameMain.Game.SaveData value)
            /// </summary>
            /// <param name = "value">class GameMain.Game.SaveData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_SaveData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Game.SaveData", 0)]
            public static partial void SET_SAVE_DATA(nint value); 
*/
            /// <summary>
            /// static  System.Void set_SettingData(GameMain.SettingData value)
            /// </summary>
            /// <param name = "value">class GameMain.SettingData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_SettingData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.SettingData", 0)]
            public static partial void SET_SETTING_DATA(nint value); 
*/
            /// <summary>
            /// static  System.Void TryApplyModConfigsAndRestart(GameMain.SettingData data)
            /// </summary>
            /// <param name = "data">class GameMain.SettingData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryApplyModConfigsAndRestart", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.SettingData", 0)]
            public static partial void TRY_APPLY_MOD_CONFIGS_AND_RESTART(nint data); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void ExitGame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ExitGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void EXIT_GAME(); 
*/
            /// <summary>
            ///   System.Boolean get_AIVsAI()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AIVsAI", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_AI_VS_AI(); 
*/
            /// <summary>
            ///   GameMain.Main.FSMComponent get_C_FSM()
            /// </summary>
            /// <returns>class GameMain.Main.FSMComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_FSM", "GameMain.Main.FSMComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_FSM(); 
*/
            /// <summary>
            ///   GameMain.Main.LogicComponent get_C_Logic()
            /// </summary>
            /// <returns>class GameMain.Main.LogicComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Logic", "GameMain.Main.LogicComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_LOGIC(); 
*/
            /// <summary>
            ///   GameMain.Main.PreLoadComponent get_C_PreLoad()
            /// </summary>
            /// <returns>class GameMain.Main.PreLoadComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_PreLoad", "GameMain.Main.PreLoadComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_PRE_LOAD(); 
*/
            /// <summary>
            ///   GameMain.Game get_Game()
            /// </summary>
            /// <returns>class GameMain.Game</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Game", "GameMain.Game", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_GAME(); 
*/
            /// <summary>
            ///   System.Boolean get_IsError()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsError", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_ERROR(); 
*/
            /// <summary>
            ///   System.Boolean get_IsTestBattle()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsTestBattle", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_TEST_BATTLE(); 
*/
            /// <summary>
            ///   GameMain.Test.GameProcedureDebugSetting get_ProcedureDebugSetting()
            /// </summary>
            /// <returns>class GameMain.Test.GameProcedureDebugSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ProcedureDebugSetting", "GameMain.Test.GameProcedureDebugSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PROCEDURE_DEBUG_SETTING(); 
*/
            /// <summary>
            ///   System.Boolean get_TestPlayerRed()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TestPlayerRed", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_TEST_PLAYER_RED(); 
*/
            /// <summary>
            ///   GameMain.GameSetting GetGameSetting()
            /// </summary>
            /// <returns>class GameMain.GameSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGameSetting", "GameMain.GameSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_GAME_SETTING(); 
*/
            /// <summary>
            ///   System.Void set_Game(GameMain.Game value)
            /// </summary>
            /// <param name = "value">class GameMain.Game</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Game", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Game", 0)]
            public partial void SET_GAME(nint value); 
*/
            /// <summary>
            ///   System.Void set_IsError(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsError", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_IS_ERROR(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_IsTestBattle(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsTestBattle", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_IS_TEST_BATTLE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_ProcedureDebugSetting(GameMain.Test.GameProcedureDebugSetting value)
            /// </summary>
            /// <param name = "value">class GameMain.Test.GameProcedureDebugSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ProcedureDebugSetting", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Test.GameProcedureDebugSetting", 0)]
            public partial void SET_PROCEDURE_DEBUG_SETTING(nint value); 
*/
            /// <summary>
            ///   System.Void set_TestPlayerRed(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_TestPlayerRed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_TEST_PLAYER_RED(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void SetGameProcedureDebugSetting(GameMain.Test.GameProcedureDebugSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.Test.GameProcedureDebugSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetGameProcedureDebugSetting", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Test.GameProcedureDebugSetting", 0)]
            public partial void SET_GAME_PROCEDURE_DEBUG_SETTING(nint setting); 
*/
            /// <summary>
            ///   System.Boolean UpdateGame()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateGame", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean UPDATE_GAME(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility"."Utility.GeneralObject"."GeneralObject"]
        /// </summary>
        partial struct Ptr_Main
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
            /// static  System.Boolean Contains(System.Guid id)
            /// </summary>
            /// <param name = "id">struct System.Guid</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public static partial System.Boolean CONTAINS(System.Guid id); 
*/
            /// <summary>
            /// static  Utility.GeneralObject.GeneralObject Get(System.Guid id)
            /// </summary>
            /// <param name = "id">struct System.Guid</param>
            /// <returns>abstract class Utility.GeneralObject.GeneralObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "Utility.GeneralObject.GeneralObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public static partial nint GET(System.Guid id); 
*/
            /// <summary>
            /// static  T Get(System.Guid id)
            /// </summary>
            /// <param name = "id">struct System.Guid</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public static partial nint GET(System.Guid id); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void AddComponentInternal(Utility.GeneralObject.GeneralObject.IComponent component, System.String name, System.Boolean isPublic, System.Boolean isTemp)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <param name = "name">class System.String</param>
            /// <param name = "isPublic">struct System.Boolean</param>
            /// <param name = "isTemp">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddComponentInternal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial void ADD_COMPONENT_INTERNAL(nint component, nint name, System.Boolean isPublic, System.Boolean isTemp); 
*/
            /// <summary>
            ///   Utility.GeneralObject.GeneralObject.IComponent AddPersistComponent(Utility.GeneralObject.GeneralObject.IComponent component, System.String name, System.Boolean isPublic)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <param name = "name">class System.String</param>
            /// <param name = "isPublic">struct System.Boolean</param>
            /// <returns>interface Utility.GeneralObject.GeneralObject.IComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddPersistComponent", "Utility.GeneralObject.GeneralObject.IComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial nint ADD_PERSIST_COMPONENT(nint component, nint name, System.Boolean isPublic); 
*/
            /// <summary>
            ///   T AddPersistComponent(System.String name, System.Boolean isPublic)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <param name = "isPublic">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddPersistComponent", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint ADD_PERSIST_COMPONENT(nint name, System.Boolean isPublic); 
*/
            /// <summary>
            ///   Utility.GeneralObject.GeneralObject.IComponent AddTempComponent(Utility.GeneralObject.GeneralObject.IComponent component, System.String name, System.Boolean isPublic)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <param name = "name">class System.String</param>
            /// <param name = "isPublic">struct System.Boolean</param>
            /// <returns>interface Utility.GeneralObject.GeneralObject.IComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddTempComponent", "Utility.GeneralObject.GeneralObject.IComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial nint ADD_TEMP_COMPONENT(nint component, nint name, System.Boolean isPublic); 
*/
            /// <summary>
            ///   T AddTempComponent(System.String name, System.Boolean isPublic)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <param name = "isPublic">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddTempComponent", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint ADD_TEMP_COMPONENT(nint name, System.Boolean isPublic); 
*/
            /// <summary>
            ///   System.Void AfterInitInternalComponents()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AfterInitInternalComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void AFTER_INIT_INTERNAL_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Void BeforeInitInternalComponents()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BeforeInitInternalComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void BEFORE_INIT_INTERNAL_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Void Despawn()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Despawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void DESPAWN(); 
*/
            /// <summary>
            ///   System.Void DespawnTempComponents()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DespawnTempComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void DESPAWN_TEMP_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent> get_Components()
            /// </summary>
            /// <returns>class System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Components", "System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent> get_Components_Update()
            /// </summary>
            /// <returns>class System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Components_Update", "System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENTS_UPDATE(); 
*/
            /// <summary>
            ///   System.Guid get_Id()
            /// </summary>
            /// <returns>struct System.Guid</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Id", "System.Guid", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Guid GET_ID(); 
*/
            /// <summary>
            ///   System.Boolean get_KeepUpdate()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_KeepUpdate", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_KEEP_UPDATE(); 
*/
            /// <summary>
            ///   System.String get_Name()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Name", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NAME(); 
*/
            /// <summary>
            ///   Utility.TimeData get_TimeData()
            /// </summary>
            /// <returns>class Utility.TimeData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TimeData", "Utility.TimeData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TIME_DATA(); 
*/
            /// <summary>
            ///   System.Single get_TimeScale()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TimeScale", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_TIME_SCALE(); 
*/
            /// <summary>
            ///   Utility.GeneralObject.GeneralObject.IComponent GetComponent(System.Type componentType)
            /// </summary>
            /// <param name = "componentType">abstract class System.Type</param>
            /// <returns>interface Utility.GeneralObject.GeneralObject.IComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponent", "Utility.GeneralObject.GeneralObject.IComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public partial nint GET_COMPONENT(nint componentType); 
*/
            /// <summary>
            ///   TComponent GetComponent()
            /// </summary>
            /// <returns>class TComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponent", "TComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENT(); 
*/
            /// <summary>
            ///   System.Void GetComponents(System.Type componentType, System.Collections.Generic.ICollection<Utility.GeneralObject.GeneralObject.IComponent> result)
            /// </summary>
            /// <param name = "componentType">abstract class System.Type</param>
            /// <param name = "result">interface System.Collections.Generic.ICollection<Utility.GeneralObject.GeneralObject.IComponent></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.ICollection<Utility.GeneralObject.GeneralObject.IComponent>", 1)]
            public partial void GET_COMPONENTS(nint componentType, nint result); 
*/
            /// <summary>
            ///   System.Void GetComponents(System.Collections.Generic.ICollection<TComponent> result)
            /// </summary>
            /// <param name = "result">interface System.Collections.Generic.ICollection<TComponent></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.ICollection<TComponent>", 0)]
            public partial void GET_COMPONENTS(nint result); 
*/
            /// <summary>
            ///   Utility.SettingSystem.Setting GetSetting()
            /// </summary>
            /// <returns>abstract class Utility.SettingSystem.Setting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSetting", "Utility.SettingSystem.Setting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SETTING(); 
*/
            /// <summary>
            ///   System.Void InitInternalComponents()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitInternalComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_INTERNAL_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Void OnAddComponent(Utility.GeneralObject.GeneralObject.IComponent component)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddComponent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            public partial void ON_ADD_COMPONENT(nint component); 
*/
            /// <summary>
            ///   System.Void OnCreate()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnCreate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_CREATE(); 
*/
            /// <summary>
            ///   System.Void OnDeserializedMethod(System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDeserializedMethod", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 0)]
            public partial void ON_DESERIALIZED_METHOD(System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   System.Void OnDeserializingMethod(System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDeserializingMethod", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 0)]
            public partial void ON_DESERIALIZING_METHOD(System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   System.Void OnDespawn(Utility.PoolSystem.PoolEventContext context)
            /// </summary>
            /// <param name = "context">struct Utility.PoolSystem.PoolEventContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDespawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.PoolSystem.PoolEventContext", 0)]
            public partial void ON_DESPAWN(Utility.PoolSystem.PoolEventContext context); 
*/
            /// <summary>
            ///   System.Void OnRemoveComponent(Utility.GeneralObject.GeneralObject.IComponent component)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveComponent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            public partial void ON_REMOVE_COMPONENT(nint component); 
*/
            /// <summary>
            ///   System.Void OnReset()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnReset", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_RESET(); 
*/
            /// <summary>
            ///   System.Void OnSerializedMethod(System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnSerializedMethod", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 0)]
            public partial void ON_SERIALIZED_METHOD(System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   System.Void OnSerializingMethod(System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnSerializingMethod", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 0)]
            public partial void ON_SERIALIZING_METHOD(System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   System.Void OnSpawn(Utility.PoolSystem.PoolEventContext context)
            /// </summary>
            /// <param name = "context">struct Utility.PoolSystem.PoolEventContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnSpawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.PoolSystem.PoolEventContext", 0)]
            public partial void ON_SPAWN(Utility.PoolSystem.PoolEventContext context); 
*/
            /// <summary>
            ///   System.Void OnStart()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStart", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_START(); 
*/
            /// <summary>
            ///   System.Void OnStart(Utility.UpdaterSystem.UpdateContext context)
            /// </summary>
            /// <param name = "context">struct Utility.UpdaterSystem.UpdateContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStart", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.UpdaterSystem.UpdateContext", 0)]
            public partial void ON_START(Utility.UpdaterSystem.UpdateContext context); 
*/
            /// <summary>
            ///   System.Void OnUpdate(Utility.UpdaterSystem.UpdateContext context)
            /// </summary>
            /// <param name = "context">struct Utility.UpdaterSystem.UpdateContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnUpdate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.UpdaterSystem.UpdateContext", 0)]
            public partial void ON_UPDATE(Utility.UpdaterSystem.UpdateContext context); 
*/
            /// <summary>
            ///   System.Void RemoveComponentInternal(Utility.GeneralObject.GeneralObject.IComponent component, Utility.GeneralObject.GeneralObject.ComponentData data)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <param name = "data">struct Utility.GeneralObject.GeneralObject.ComponentData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveComponentInternal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.ComponentData", 1)]
            public partial void REMOVE_COMPONENT_INTERNAL(nint component, Utility.GeneralObject.GeneralObject.ComponentData data); 
*/
            /// <summary>
            ///   System.Boolean RemoveTempComponent(Utility.GeneralObject.GeneralObject.IComponent component)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveTempComponent", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            public partial System.Boolean REMOVE_TEMP_COMPONENT(nint component); 
*/
            /// <summary>
            ///   System.Void Reset()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reset", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET(); 
*/
            /// <summary>
            ///   System.Void ResetAllComponents()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetAllComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET_ALL_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Void set_Components(System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent> value)
            /// </summary>
            /// <param name = "value">class System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Components", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent>", 0)]
            public partial void SET_COMPONENTS(nint value); 
*/
            /// <summary>
            ///   System.Void set_Components_Update(System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent> value)
            /// </summary>
            /// <param name = "value">class System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Components_Update", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent>", 0)]
            public partial void SET_COMPONENTS_UPDATE(nint value); 
*/
            /// <summary>
            ///   System.Void set_Id(System.Guid value)
            /// </summary>
            /// <param name = "value">struct System.Guid</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Id", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public partial void SET_ID(System.Guid value); 
*/
            /// <summary>
            ///   System.Void SetComponentActive(Utility.GeneralObject.GeneralObject.IComponent component, System.Boolean active)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <param name = "active">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetComponentActive", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SET_COMPONENT_ACTIVE(nint component, System.Boolean active); 
*/
            /// <summary>
            ///   System.Void Utility.IReset.Reset()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.IReset.Reset", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UTILITY_I_RESET_RESET(); 
*/
            /// <summary>
            ///   System.Int32 Utility.PoolSystem.IPoolItem.get_SpawnId()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.PoolSystem.IPoolItem.get_SpawnId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 UTILITY_POOL_SYSTEM_I_POOL_ITEMGET_SPAWN_ID(); 
*/
            /// <summary>
            ///   System.Void Utility.PoolSystem.IPoolItem.OnDespawn(Utility.PoolSystem.PoolEventContext context)
            /// </summary>
            /// <param name = "context">struct Utility.PoolSystem.PoolEventContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.PoolSystem.IPoolItem.OnDespawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.PoolSystem.PoolEventContext", 0)]
            public partial void UTILITY_POOL_SYSTEM_I_POOL_ITEM_ON_DESPAWN(Utility.PoolSystem.PoolEventContext context); 
*/
            /// <summary>
            ///   System.Void Utility.PoolSystem.IPoolItem.OnSpawn(Utility.PoolSystem.PoolEventContext context)
            /// </summary>
            /// <param name = "context">struct Utility.PoolSystem.PoolEventContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.PoolSystem.IPoolItem.OnSpawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.PoolSystem.PoolEventContext", 0)]
            public partial void UTILITY_POOL_SYSTEM_I_POOL_ITEM_ON_SPAWN(Utility.PoolSystem.PoolEventContext context); 
*/
            /// <summary>
            ///   System.Void Utility.PoolSystem.IPoolItem.set_SpawnId(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.PoolSystem.IPoolItem.set_SpawnId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UTILITY_POOL_SYSTEM_I_POOL_ITEMSET_SPAWN_ID(System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean Utility.UpdaterSystem.IUpdatable.get_KeepUpdate()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.UpdaterSystem.IUpdatable.get_KeepUpdate", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean UTILITY_UPDATER_SYSTEM_I_UPDATABLEGET_KEEP_UPDATE(); 
*/
            /// <summary>
            ///   Utility.TimeData Utility.UpdaterSystem.IUpdatable.get_TimeData()
            /// </summary>
            /// <returns>class Utility.TimeData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.UpdaterSystem.IUpdatable.get_TimeData", "Utility.TimeData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint UTILITY_UPDATER_SYSTEM_I_UPDATABLEGET_TIME_DATA(); 
*/
            /// <summary>
            ///   System.Single Utility.UpdaterSystem.IUpdatable.get_TimeScale()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.UpdaterSystem.IUpdatable.get_TimeScale", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single UTILITY_UPDATER_SYSTEM_I_UPDATABLEGET_TIME_SCALE(); 
*/
            /// <summary>
            ///   System.Void Utility.UpdaterSystem.IUpdatable.OnStart(Utility.UpdaterSystem.UpdateContext context)
            /// </summary>
            /// <param name = "context">struct Utility.UpdaterSystem.UpdateContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.UpdaterSystem.IUpdatable.OnStart", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.UpdaterSystem.UpdateContext", 0)]
            public partial void UTILITY_UPDATER_SYSTEM_I_UPDATABLE_ON_START(Utility.UpdaterSystem.UpdateContext context); 
*/
            /// <summary>
            ///   System.Void Utility.UpdaterSystem.IUpdatable.OnUpdate(Utility.UpdaterSystem.UpdateContext context)
            /// </summary>
            /// <param name = "context">struct Utility.UpdaterSystem.UpdateContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.UpdaterSystem.IUpdatable.OnUpdate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.UpdaterSystem.UpdateContext", 0)]
            public partial void UTILITY_UPDATER_SYSTEM_I_UPDATABLE_ON_UPDATE(Utility.UpdaterSystem.UpdateContext context); 
*/
        }
    }



}
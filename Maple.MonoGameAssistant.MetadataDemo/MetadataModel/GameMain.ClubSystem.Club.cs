namespace Maple.MonoGameAssistant.MetadataDemo.MetadataModel
{
    /// <summary>
    /// class ["Assembly-CSharp"."GameMain.ClubSystem"."Club"]
    /// [Utility.GameSystem.LogicFrameworkX.LogicObject<GameMain.ClubSystem.Club , LogicFramework.LogicEntity_Club>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject<GameMain.ClubSystem.Club>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject]=>[Utility.GeneralObject.GeneralObject]=>[System.Object]
    /// </summary>
    [MetadataExtensions.MetadataGenerator.ClassParentMetadata<MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Club>, Ptr_Club>]
    [MetadataExtensions.MetadataGenerator.ClassModelMetadata("Assembly-CSharp", "GameMain.ClubSystem", "Club", "GameMain.ClubSystem.Club")]
    public partial class Club
    {
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Club(nint ptr) : MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint m_Pointer = ptr;
            public nint Ptr => m_Pointer;

            public static implicit operator Ptr_Club(nint ptr) => new Ptr_Club(ptr);
            public static implicit operator nint(Ptr_Club ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_Club ptr) => ptr.m_Pointer != nint.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."GameMain.ClubSystem"."Club"]
        /// </summary>
        public unsafe readonly partial struct Ptr_Club
        {
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
            /// 0x70 Utility.GameSystem.LogicFrameworkX.LogicEntity <Entity>k__BackingField
            /// class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."LogicEntity"]
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicEntity</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Entity>k__BackingField", "Utility.GameSystem.LogicFrameworkX.LogicEntity")]
           public partial nint ENTITY { get; set; } 
*/

            /// <summary>
            /// 0x78 Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.ClubSystem.Club , LogicFramework.LogicEntity_Club , GameMain.ClubSystem.ClubSetting> <C_Setting>k__BackingField
            /// class ["Utility.GameSystem".""."SettingComponent`1"]
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.ClubSystem.Club , LogicFramework.LogicEntity_Club , GameMain.ClubSystem.ClubSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Setting>k__BackingField", "Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.ClubSystem.Club,LogicFramework.LogicEntity_Club,GameMain.ClubSystem.ClubSetting>")]
           public partial nint C_SETTING { get; set; } 
*/

            /// <summary>
            /// 0x80 GameMain.ClubSystem.Club.LogicComponent <C_Logic>k__BackingField
            /// class ["Assembly-CSharp".""."LogicComponent"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club.LogicComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Logic>k__BackingField", "GameMain.ClubSystem.Club.LogicComponent")]
           public partial nint C_LOGIC { get; set; } 
*/

            /// <summary>
            /// 0x88 GameMain.ClubSystem.Club.DataComponent <C_Data>k__BackingField
            /// class ["Assembly-CSharp".""."DataComponent"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club.DataComponent</returns>

            [MetadataExtensions.MetadataGenerator.ClassPropertyMetadata("<C_Data>k__BackingField", "GameMain.ClubSystem.Club.DataComponent")]
            public partial Maple.MonoGameAssistant.MetadataDemo.MetadataModel.DataComponent.Ptr_DataComponent C_DATA { get; }


            /// <summary>
            /// 0x90 GameMain.ClubSystem.Club.AffairComponent <C_Affair>k__BackingField
            /// class ["Assembly-CSharp".""."AffairComponent"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club.AffairComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Affair>k__BackingField", "GameMain.ClubSystem.Club.AffairComponent")]
           public partial nint C_AFFAIR { get; set; } 
*/

            /// <summary>
            /// 0x98 GameMain.ClubSystem.ClubStatusComponent <C_Status>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."ClubStatusComponent"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.ClubStatusComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Status>k__BackingField", "GameMain.ClubSystem.ClubStatusComponent")]
           public partial nint C_STATUS { get; set; } 
*/

            /// <summary>
            /// 0xA0 GameMain.ClubSystem.Club.MilestoneComponent <C_Milestone>k__BackingField
            /// class ["Assembly-CSharp".""."MilestoneComponent"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club.MilestoneComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Milestone>k__BackingField", "GameMain.ClubSystem.Club.MilestoneComponent")]
           public partial nint C_MILESTONE { get; set; } 
*/

            /// <summary>
            /// 0xA8 GameMain.ClubSystem.Club.MedalComponent <C_Medal>k__BackingField
            /// class ["Assembly-CSharp".""."MedalComponent"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club.MedalComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Medal>k__BackingField", "GameMain.ClubSystem.Club.MedalComponent")]
           public partial nint C_MEDAL { get; set; } 
*/

            /// <summary>
            /// 0xB0 GameMain.ClubSystem.Club.RuleComponent <C_Rule>k__BackingField
            /// class ["Assembly-CSharp".""."RuleComponent"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club.RuleComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Rule>k__BackingField", "GameMain.ClubSystem.Club.RuleComponent")]
           public partial nint C_RULE { get; set; } 
*/

            /// <summary>
            /// 0xB8 Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.ClubSystem.Club , LogicFramework.LogicEntity_Club , GameMain.ClubSystem.ClubSelectionSetting> <C_ClubSelectionSetting>k__BackingField
            /// class ["Utility.GameSystem".""."SettingComponent`1"]
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.ClubSystem.Club , LogicFramework.LogicEntity_Club , GameMain.ClubSystem.ClubSelectionSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_ClubSelectionSetting>k__BackingField", "Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.ClubSystem.Club,LogicFramework.LogicEntity_Club,GameMain.ClubSystem.ClubSelectionSetting>")]
           public partial nint C_CLUB_SELECTION_SETTING { get; set; } 
*/

            /// <summary>
            /// 0xC0 GameMain.MatchSystem.DivisionSetting <DivisionSetting>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.MatchSystem"."DivisionSetting"]
            /// </summary>
            /// <returns>class GameMain.MatchSystem.DivisionSetting</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<DivisionSetting>k__BackingField", "GameMain.MatchSystem.DivisionSetting")]
           public partial nint DIVISION_SETTING { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Boolean <IsPlayer>k__BackingField
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<IsPlayer>k__BackingField", "System.Boolean")]
           public partial System.Boolean IS_PLAYER { get; set; } 
*/

            /// <summary>
            /// 0xC9 System.Boolean <IsVirtual>k__BackingField
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<IsVirtual>k__BackingField", "System.Boolean")]
           public partial System.Boolean IS_VIRTUAL { get; set; } 
*/

            /// <summary>
            /// 0xCC System.Int32 <FansBeforeSettlement>k__BackingField
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<FansBeforeSettlement>k__BackingField", "System.Int32")]
           public partial System.Int32 FANS_BEFORE_SETTLEMENT { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.Int32 <MaxSubstitute>k__BackingField
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<MaxSubstitute>k__BackingField", "System.Int32")]
           public partial System.Int32 MAX_SUBSTITUTE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."GameMain.ClubSystem"."Club"]
        /// </summary>
        public unsafe readonly partial struct Ptr_Club
        {
            /// <summary>
            /// static  System.Void AdjustAIClubAthleteAbility(GameMain.ClubSystem.Club club0, GameMain.ClubSystem.Club club1)
            /// </summary>
            /// <param name = "club0">class GameMain.ClubSystem.Club</param>
            /// <param name = "club1">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AdjustAIClubAthleteAbility", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 1)]
            public static partial void ADJUST_AI_CLUB_ATHLETE_ABILITY(nint club0, nint club1); 
*/
            /// <summary>
            /// static  System.Void Despawn(GameMain.ClubSystem.Club club, System.Boolean despawnAthlete)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <param name = "despawnAthlete">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Despawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial void DESPAWN(nint club, System.Boolean despawnAthlete); 
*/
            /// <summary>
            /// static  System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete> GetTargetAthletes(GameMain.ClubSystem.Club start, GameMain.ClubSystem.ClubDialogueSetting.TargetRangeTypes rangeType, System.Collections.Generic.IEnumerable<GameMain.ClubSystem.Club> clubs)
            /// </summary>
            /// <param name = "start">class GameMain.ClubSystem.Club</param>
            /// <param name = "rangeType">enum GameMain.ClubSystem.ClubDialogueSetting.TargetRangeTypes</param>
            /// <param name = "clubs">interface System.Collections.Generic.IEnumerable<GameMain.ClubSystem.Club></param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTargetAthletes", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubDialogueSetting.TargetRangeTypes", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<GameMain.ClubSystem.Club>", 2)]
            public static partial nint GET_TARGET_ATHLETES(nint start, GameMain.ClubSystem.ClubDialogueSetting.TargetRangeTypes rangeType, nint clubs); 
*/
            /// <summary>
            /// static  System.Collections.Generic.IEnumerable<GameMain.ClubSystem.Club> GetTargetClubs(GameMain.ClubSystem.Club start, GameMain.ClubSystem.ClubDialogueSetting.TargetRangeTypes rangeType)
            /// </summary>
            /// <param name = "start">class GameMain.ClubSystem.Club</param>
            /// <param name = "rangeType">enum GameMain.ClubSystem.ClubDialogueSetting.TargetRangeTypes</param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.ClubSystem.Club></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTargetClubs", "System.Collections.Generic.IEnumerable<GameMain.ClubSystem.Club>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubDialogueSetting.TargetRangeTypes", 1)]
            public static partial nint GET_TARGET_CLUBS(nint start, GameMain.ClubSystem.ClubDialogueSetting.TargetRangeTypes rangeType); 
*/
            /// <summary>
            /// static  GameMain.ClubSystem.Club Spawn(GameMain.Game game, GameMain.ClubSystem.ClubSetting setting, System.Boolean player, System.Boolean isTest, GameMain.ClubSystem.ClubClassTypes classType)
            /// </summary>
            /// <param name = "game">class GameMain.Game</param>
            /// <param name = "setting">class GameMain.ClubSystem.ClubSetting</param>
            /// <param name = "player">struct System.Boolean</param>
            /// <param name = "isTest">struct System.Boolean</param>
            /// <param name = "classType">enum GameMain.ClubSystem.ClubClassTypes</param>
            /// <returns>class GameMain.ClubSystem.Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Spawn", "GameMain.ClubSystem.Club", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Game", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubSetting", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubClassTypes", 4)]
            public static partial nint SPAWN(nint game, nint setting, System.Boolean player, System.Boolean isTest, GameMain.ClubSystem.ClubClassTypes classType); 
*/
            /// <summary>
            /// static  GameMain.ClubSystem.Club Spawn(GameMain.Game game, GameMain.ClubSystem.Club.SaveData data)
            /// </summary>
            /// <param name = "game">class GameMain.Game</param>
            /// <param name = "data">class GameMain.ClubSystem.Club.SaveData</param>
            /// <returns>class GameMain.ClubSystem.Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Spawn", "GameMain.ClubSystem.Club", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Game", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club.SaveData", 1)]
            public static partial nint SPAWN(nint game, nint data); 
*/
            /// <summary>
            /// static  GameMain.ClubSystem.Club Spawn(GameMain.Game game)
            /// </summary>
            /// <param name = "game">class GameMain.Game</param>
            /// <returns>class GameMain.ClubSystem.Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Spawn", "GameMain.ClubSystem.Club", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Game", 0)]
            public static partial nint SPAWN(nint game); 
*/
            /// <summary>
            /// static  GameMain.ClubSystem.Club SpawnSimulate(GameMain.Game game)
            /// </summary>
            /// <param name = "game">class GameMain.Game</param>
            /// <returns>class GameMain.ClubSystem.Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SpawnSimulate", "GameMain.ClubSystem.Club", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Game", 0)]
            public static partial nint SPAWN_SIMULATE(nint game); 
*/
            /// <summary>
            /// static  GameMain.ClubSystem.Club SpawnVirtual(GameMain.Game game)
            /// </summary>
            /// <param name = "game">class GameMain.Game</param>
            /// <returns>class GameMain.ClubSystem.Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SpawnVirtual", "GameMain.ClubSystem.Club", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Game", 0)]
            public static partial nint SPAWN_VIRTUAL(nint game); 
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
            ///   System.Boolean CanAddAthlete(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanAddAthlete", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public partial System.Boolean CAN_ADD_ATHLETE(nint athlete); 
*/
            /// <summary>
            ///   GameMainUI.DisabledTip CanKickAthlete(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>enum GameMainUI.DisabledTip</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanKickAthlete", "GameMainUI.DisabledTip", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public partial GameMainUI.DisabledTip CAN_KICK_ATHLETE(nint athlete); 
*/
            /// <summary>
            ///   System.Void CheckAthleteRelations(GameMain.ClubSystem.AthleteRelationData relationData)
            /// </summary>
            /// <param name = "relationData">class GameMain.ClubSystem.AthleteRelationData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckAthleteRelations", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.AthleteRelationData", 0)]
            public partial void CHECK_ATHLETE_RELATIONS(nint relationData); 
*/
            /// <summary>
            ///   System.Void CheckAthletesTrait()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckAthletesTrait", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_ATHLETES_TRAIT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<GameMain.MatchSystem.Competition> Competitions(System.Func<GameMain.MatchSystem.Competition , System.Boolean> condition)
            /// </summary>
            /// <param name = "condition">class System.Func<GameMain.MatchSystem.Competition , System.Boolean></param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.MatchSystem.Competition></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Competitions", "System.Collections.Generic.IEnumerable<GameMain.MatchSystem.Competition>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Func<GameMain.MatchSystem.Competition,System.Boolean>", 0)]
            public partial nint COMPETITIONS(nint condition); 
*/
            /// <summary>
            ///   System.Void CreateClubAthlete(GameMain.UnitSystem.HeroRoleFlags role)
            /// </summary>
            /// <param name = "role">enum GameMain.UnitSystem.HeroRoleFlags</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateClubAthlete", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroRoleFlags", 0)]
            public partial void CREATE_CLUB_ATHLETE(GameMain.UnitSystem.HeroRoleFlags role); 
*/
            /// <summary>
            ///   System.Boolean DemoteClub()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DemoteClub", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean DEMOTE_CLUB(); 
*/
            /// <summary>
            ///   System.Boolean DemoteCoach()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DemoteCoach", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean DEMOTE_COACH(); 
*/
            /// <summary>
            ///   System.String get_Assistant_Portrait_FullBody()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Assistant_Portrait_FullBody", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ASSISTANT_PORTRAIT_FULL_BODY(); 
*/
            /// <summary>
            ///   System.String get_Assistant_Portrait_Head()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Assistant_Portrait_Head", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ASSISTANT_PORTRAIT_HEAD(); 
*/
            /// <summary>
            ///   System.String get_Assistant_Portrait_HeadHex()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Assistant_Portrait_HeadHex", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ASSISTANT_PORTRAIT_HEAD_HEX(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete> get_Athletes()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Athletes", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATHLETES(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete> get_AthletesWithoutOrder()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AthletesWithoutOrder", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATHLETES_WITHOUT_ORDER(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.Club.AffairComponent get_C_Affair()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club.AffairComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Affair", "GameMain.ClubSystem.Club.AffairComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_AFFAIR(); 
*/
            /// <summary>
            ///   Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.ClubSystem.Club , LogicFramework.LogicEntity_Club , GameMain.ClubSystem.ClubSelectionSetting> get_C_ClubSelectionSetting()
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.ClubSystem.Club , LogicFramework.LogicEntity_Club , GameMain.ClubSystem.ClubSelectionSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_ClubSelectionSetting", "Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.ClubSystem.Club,LogicFramework.LogicEntity_Club,GameMain.ClubSystem.ClubSelectionSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_CLUB_SELECTION_SETTING(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.Club.DataComponent get_C_Data()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club.DataComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Data", "GameMain.ClubSystem.Club.DataComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_DATA(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.Club.LogicComponent get_C_Logic()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club.LogicComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Logic", "GameMain.ClubSystem.Club.LogicComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_LOGIC(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.Club.MedalComponent get_C_Medal()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club.MedalComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Medal", "GameMain.ClubSystem.Club.MedalComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_MEDAL(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.Club.MilestoneComponent get_C_Milestone()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club.MilestoneComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Milestone", "GameMain.ClubSystem.Club.MilestoneComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_MILESTONE(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.Club.RuleComponent get_C_Rule()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club.RuleComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Rule", "GameMain.ClubSystem.Club.RuleComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_RULE(); 
*/
            /// <summary>
            ///   Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.ClubSystem.Club , LogicFramework.LogicEntity_Club , GameMain.ClubSystem.ClubSetting> get_C_Setting()
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.ClubSystem.Club , LogicFramework.LogicEntity_Club , GameMain.ClubSystem.ClubSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Setting", "Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.ClubSystem.Club,LogicFramework.LogicEntity_Club,GameMain.ClubSystem.ClubSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_SETTING(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubStatusComponent get_C_Status()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.ClubStatusComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Status", "GameMain.ClubSystem.ClubStatusComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_STATUS(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubClassTypes get_ClubClassType()
            /// </summary>
            /// <returns>enum GameMain.ClubSystem.ClubClassTypes</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ClubClassType", "GameMain.ClubSystem.ClubClassTypes", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.ClubSystem.ClubClassTypes GET_CLUB_CLASS_TYPE(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubName get_ClubName()
            /// </summary>
            /// <returns>struct GameMain.ClubSystem.ClubName</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ClubName", "GameMain.ClubSystem.ClubName", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.ClubSystem.ClubName GET_CLUB_NAME(); 
*/
            /// <summary>
            ///   System.String get_Coach_Portrait_FullBody()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Coach_Portrait_FullBody", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COACH_PORTRAIT_FULL_BODY(); 
*/
            /// <summary>
            ///   System.String get_Coach_Portrait_Head()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Coach_Portrait_Head", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COACH_PORTRAIT_HEAD(); 
*/
            /// <summary>
            ///   System.String get_Coach_Portrait_HeadHex()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Coach_Portrait_HeadHex", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COACH_PORTRAIT_HEAD_HEX(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.CoachClassTypes get_CoachClassType()
            /// </summary>
            /// <returns>enum GameMain.ClubSystem.CoachClassTypes</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CoachClassType", "GameMain.ClubSystem.CoachClassTypes", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.ClubSystem.CoachClassTypes GET_COACH_CLASS_TYPE(); 
*/
            /// <summary>
            ///   GameMain.MatchSystem.Competition get_Competition()
            /// </summary>
            /// <returns>abstract class GameMain.MatchSystem.Competition</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Competition", "GameMain.MatchSystem.Competition", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPETITION(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IReadOnlyDictionary<GameMain.UnitSystem.HeroRoleFlags , GameMain.AthleteSystem.Athlete> get_ContestantRoleDict()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IReadOnlyDictionary<GameMain.UnitSystem.HeroRoleFlags , GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ContestantRoleDict", "System.Collections.Generic.IReadOnlyDictionary<GameMain.UnitSystem.HeroRoleFlags,GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CONTESTANT_ROLE_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IReadOnlyCollection<GameMain.AthleteSystem.Athlete> get_Contestants()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IReadOnlyCollection<GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Contestants", "System.Collections.Generic.IReadOnlyCollection<GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CONTESTANTS(); 
*/
            /// <summary>
            ///   GameMain.MatchSystem.Division get_Division()
            /// </summary>
            /// <returns>class GameMain.MatchSystem.Division</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Division", "GameMain.MatchSystem.Division", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DIVISION(); 
*/
            /// <summary>
            ///   GameMain.MatchSystem.DivisionSetting get_DivisionSetting()
            /// </summary>
            /// <returns>class GameMain.MatchSystem.DivisionSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_DivisionSetting", "GameMain.MatchSystem.DivisionSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DIVISION_SETTING(); 
*/
            /// <summary>
            ///   System.Int32 get_Fans()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Fans", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_FANS(); 
*/
            /// <summary>
            ///   System.Int32 get_FansBeforeSettlement()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_FansBeforeSettlement", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_FANS_BEFORE_SETTLEMENT(); 
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
            ///   System.Boolean get_IsAI()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsAI", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_AI(); 
*/
            /// <summary>
            ///   System.Boolean get_IsAllRole()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsAllRole", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_ALL_ROLE(); 
*/
            /// <summary>
            ///   System.Boolean get_IsFixedClub()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsFixedClub", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_FIXED_CLUB(); 
*/
            /// <summary>
            ///   System.Boolean get_IsPlayer()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsPlayer", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_PLAYER(); 
*/
            /// <summary>
            ///   System.Boolean get_IsSimulate()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsSimulate", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_SIMULATE(); 
*/
            /// <summary>
            ///   System.Boolean get_IsVirtual()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsVirtual", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_VIRTUAL(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.Athlete get_Item(GameMain.UnitSystem.HeroRoleFlags flag)
            /// </summary>
            /// <param name = "flag">enum GameMain.UnitSystem.HeroRoleFlags</param>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Item", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroRoleFlags", 0)]
            public partial nint GET_ITEM(GameMain.UnitSystem.HeroRoleFlags flag); 
*/
            /// <summary>
            ///   System.Int32 get_MaxSubstitute()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MaxSubstitute", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_MAX_SUBSTITUTE(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubClassTypes get_PreviousClubClassType()
            /// </summary>
            /// <returns>enum GameMain.ClubSystem.ClubClassTypes</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_PreviousClubClassType", "GameMain.ClubSystem.ClubClassTypes", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.ClubSystem.ClubClassTypes GET_PREVIOUS_CLUB_CLASS_TYPE(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubSetting get_Setting()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.ClubSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Setting", "GameMain.ClubSystem.ClubSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SETTING(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.Stadium get_Stadium()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Stadium</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Stadium", "GameMain.ClubSystem.Stadium", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_STADIUM(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IReadOnlyList<GameMain.AthleteSystem.Athlete> get_Substitutes()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IReadOnlyList<GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Substitutes", "System.Collections.Generic.IReadOnlyList<GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SUBSTITUTES(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubClassTypes get_TopClassType()
            /// </summary>
            /// <returns>enum GameMain.ClubSystem.ClubClassTypes</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TopClassType", "GameMain.ClubSystem.ClubClassTypes", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.ClubSystem.ClubClassTypes GET_TOP_CLASS_TYPE(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.Athlete GetAthlete(GameMain.UnitSystem.HeroRoleFlags flag)
            /// </summary>
            /// <param name = "flag">enum GameMain.UnitSystem.HeroRoleFlags</param>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAthlete", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroRoleFlags", 0)]
            public partial nint GET_ATHLETE(GameMain.UnitSystem.HeroRoleFlags flag); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.Athlete GetAthleteById(System.Guid id)
            /// </summary>
            /// <param name = "id">struct System.Guid</param>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAthleteById", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public partial nint GET_ATHLETE_BY_ID(System.Guid id); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete> GetCanChangeAthletes(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCanChangeAthletes", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public partial nint GET_CAN_CHANGE_ATHLETES(nint athlete); 
*/
            /// <summary>
            ///   System.Boolean GetCoachCanPromote()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCoachCanPromote", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_COACH_CAN_PROMOTE(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<GameMain.ClubSystem.ClubAffairCoachPromoteItemSetting> GetCoachPromoteItemSettings(GameMain.ClubSystem.CoachClassTypes classType)
            /// </summary>
            /// <param name = "classType">enum GameMain.ClubSystem.CoachClassTypes</param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.ClubSystem.ClubAffairCoachPromoteItemSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCoachPromoteItemSettings", "System.Collections.Generic.IEnumerable<GameMain.ClubSystem.ClubAffairCoachPromoteItemSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.CoachClassTypes", 0)]
            public partial nint GET_COACH_PROMOTE_ITEM_SETTINGS(GameMain.ClubSystem.CoachClassTypes classType); 
*/
            /// <summary>
            ///   System.String GetLogoUrl()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLogoUrl", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_LOGO_URL(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.Athlete GetSubstituteAthlete(GameMain.UnitSystem.HeroRoleFlags flag)
            /// </summary>
            /// <param name = "flag">enum GameMain.UnitSystem.HeroRoleFlags</param>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSubstituteAthlete", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroRoleFlags", 0)]
            public partial nint GET_SUBSTITUTE_ATHLETE(GameMain.UnitSystem.HeroRoleFlags flag); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete> GetSubstituteAthletes(GameMain.UnitSystem.HeroRoleFlags flag)
            /// </summary>
            /// <param name = "flag">enum GameMain.UnitSystem.HeroRoleFlags</param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSubstituteAthletes", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroRoleFlags", 0)]
            public partial nint GET_SUBSTITUTE_ATHLETES(GameMain.UnitSystem.HeroRoleFlags flag); 
*/
            /// <summary>
            ///   System.Void GetTaskCheckCoachPromote(System.Collections.Generic.IReadOnlyList<GameMain.ClubSystem.ClubAffairCoachPromoteItemSetting> settings, System.Collections.Generic.ICollection<System.ValueTuple<System.Double , System.Double>> results)
            /// </summary>
            /// <param name = "settings">interface System.Collections.Generic.IReadOnlyList<GameMain.ClubSystem.ClubAffairCoachPromoteItemSetting></param>
            /// <param name = "results">interface System.Collections.Generic.ICollection<System.ValueTuple<System.Double , System.Double>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTaskCheckCoachPromote", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IReadOnlyList<GameMain.ClubSystem.ClubAffairCoachPromoteItemSetting>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.ICollection<System.ValueTuple<System.Double,System.Double>>", 1)]
            public partial void GET_TASK_CHECK_COACH_PROMOTE(nint settings, nint results); 
*/
            /// <summary>
            ///   System.Void KickAthlete(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KickAthlete", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public partial void KICK_ATHLETE(nint athlete); 
*/
            /// <summary>
            ///   GameMain.MatchSystem.Competition LastCompetition(System.Func<GameMain.MatchSystem.Competition , System.Boolean> condition)
            /// </summary>
            /// <param name = "condition">class System.Func<GameMain.MatchSystem.Competition , System.Boolean></param>
            /// <returns>abstract class GameMain.MatchSystem.Competition</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LastCompetition", "GameMain.MatchSystem.Competition", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Func<GameMain.MatchSystem.Competition,System.Boolean>", 0)]
            public partial nint LAST_COMPETITION(nint condition); 
*/
            /// <summary>
            ///   System.Void LoadClubRules()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadClubRules", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_CLUB_RULES(); 
*/
            /// <summary>
            ///   System.Void OnAddAthlete(GameMain.AthleteSystem.Athlete athlete, System.Boolean isNew)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "isNew">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddAthlete", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ON_ADD_ATHLETE(nint athlete, System.Boolean isNew); 
*/
            /// <summary>
            ///   System.Void OnAddClubEffect(GameMain.ClubSystem.ClubEffect effect)
            /// </summary>
            /// <param name = "effect">class GameMain.ClubSystem.ClubEffect</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddClubEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubEffect", 0)]
            public partial void ON_ADD_CLUB_EFFECT(nint effect); 
*/
            /// <summary>
            ///   System.Void OnAddClubEvent(GameMain.ClubSystem.ClubEvent clubEvent)
            /// </summary>
            /// <param name = "clubEvent">class GameMain.ClubSystem.ClubEvent</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddClubEvent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubEvent", 0)]
            public partial void ON_ADD_CLUB_EVENT(nint clubEvent); 
*/
            /// <summary>
            ///   System.Void OnAddClubMedal(GameMain.ClubSystem.ClubMedal medal)
            /// </summary>
            /// <param name = "medal">class GameMain.ClubSystem.ClubMedal</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddClubMedal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubMedal", 0)]
            public partial void ON_ADD_CLUB_MEDAL(nint medal); 
*/
            /// <summary>
            ///   System.Void OnAddPlayerClubToGame(GameMain.Game game, System.Boolean save)
            /// </summary>
            /// <param name = "game">class GameMain.Game</param>
            /// <param name = "save">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddPlayerClubToGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Game", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ON_ADD_PLAYER_CLUB_TO_GAME(nint game, System.Boolean save); 
*/
            /// <summary>
            ///   System.Void OnAddToGame(GameMain.Game game)
            /// </summary>
            /// <param name = "game">class GameMain.Game</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddToGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Game", 0)]
            public partial void ON_ADD_TO_GAME(nint game); 
*/
            /// <summary>
            ///   System.Void OnAddVirtualClubToGame(GameMain.Game game)
            /// </summary>
            /// <param name = "game">class GameMain.Game</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddVirtualClubToGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Game", 0)]
            public partial void ON_ADD_VIRTUAL_CLUB_TO_GAME(nint game); 
*/
            /// <summary>
            ///   System.Void OnBudgetChange()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnBudgetChange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_BUDGET_CHANGE(); 
*/
            /// <summary>
            ///   System.Void OnRemoveAthlete(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveAthlete", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public partial void ON_REMOVE_ATHLETE(nint athlete); 
*/
            /// <summary>
            ///   System.Void OnRemoveClubEffect(GameMain.ClubSystem.ClubEffect effect)
            /// </summary>
            /// <param name = "effect">class GameMain.ClubSystem.ClubEffect</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveClubEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubEffect", 0)]
            public partial void ON_REMOVE_CLUB_EFFECT(nint effect); 
*/
            /// <summary>
            ///   System.Void OnRemoveClubEvent(GameMain.ClubSystem.ClubEvent clubEvent)
            /// </summary>
            /// <param name = "clubEvent">class GameMain.ClubSystem.ClubEvent</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveClubEvent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubEvent", 0)]
            public partial void ON_REMOVE_CLUB_EVENT(nint clubEvent); 
*/
            /// <summary>
            ///   System.Void OnRemoveClubMedal(GameMain.ClubSystem.ClubMedal medal)
            /// </summary>
            /// <param name = "medal">class GameMain.ClubSystem.ClubMedal</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveClubMedal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubMedal", 0)]
            public partial void ON_REMOVE_CLUB_MEDAL(nint medal); 
*/
            /// <summary>
            ///   System.Void OnRemovedFromGame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemovedFromGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_REMOVED_FROM_GAME(); 
*/
            /// <summary>
            ///   System.Void OnRemovePlayerClubFromGame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemovePlayerClubFromGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_REMOVE_PLAYER_CLUB_FROM_GAME(); 
*/
            /// <summary>
            ///   System.Void OnRemoveVirtualClubFromGame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveVirtualClubFromGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_REMOVE_VIRTUAL_CLUB_FROM_GAME(); 
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
            ///   System.Void ProcessAthlete(GameMain.ClubSystem.ClubSetting setting, GameMain.ClubSystem.ClubClassTypes classType, GameMain.AthleteSystem.Athlete athlete, GameMain.AthleteSystem.AthleteCardCreateArgument arg)
            /// </summary>
            /// <param name = "setting">class GameMain.ClubSystem.ClubSetting</param>
            /// <param name = "classType">enum GameMain.ClubSystem.ClubClassTypes</param>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "arg">class GameMain.AthleteSystem.AthleteCardCreateArgument</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ProcessAthlete", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubClassTypes", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteCardCreateArgument", 3)]
            public partial void PROCESS_ATHLETE(nint setting, GameMain.ClubSystem.ClubClassTypes classType, nint athlete, nint arg); 
*/
            /// <summary>
            ///   System.Boolean PromoteClub()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PromoteClub", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean PROMOTE_CLUB(); 
*/
            /// <summary>
            ///   System.Boolean PromoteCoach()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PromoteCoach", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean PROMOTE_COACH(); 
*/
            /// <summary>
            ///   System.Void ResetAIAthleteSkill(System.Boolean reset)
            /// </summary>
            /// <param name = "reset">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetAIAthleteSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void RESET_AI_ATHLETE_SKILL(System.Boolean reset); 
*/
            /// <summary>
            ///   System.Void ResetAIAthleteSkill(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetAIAthleteSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public partial void RESET_AI_ATHLETE_SKILL(nint athlete); 
*/
            /// <summary>
            ///   System.Void set_DivisionSetting(GameMain.MatchSystem.DivisionSetting value)
            /// </summary>
            /// <param name = "value">class GameMain.MatchSystem.DivisionSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_DivisionSetting", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.MatchSystem.DivisionSetting", 0)]
            public partial void SET_DIVISION_SETTING(nint value); 
*/
            /// <summary>
            ///   System.Void set_FansBeforeSettlement(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_FansBeforeSettlement", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_FANS_BEFORE_SETTLEMENT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_IsPlayer(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsPlayer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_IS_PLAYER(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_IsVirtual(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsVirtual", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_IS_VIRTUAL(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_MaxSubstitute(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_MaxSubstitute", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_MAX_SUBSTITUTE(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void SetClubAthletes(GameMain.ClubSystem.ClubSetting setting, GameMain.ClubSystem.ClubClassTypes classType, System.Boolean randomCards)
            /// </summary>
            /// <param name = "setting">class GameMain.ClubSystem.ClubSetting</param>
            /// <param name = "classType">enum GameMain.ClubSystem.ClubClassTypes</param>
            /// <param name = "randomCards">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetClubAthletes", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubClassTypes", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void SET_CLUB_ATHLETES(nint setting, GameMain.ClubSystem.ClubClassTypes classType, System.Boolean randomCards); 
*/
            /// <summary>
            ///   System.Void SetClubAthletes()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetClubAthletes", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SET_CLUB_ATHLETES(); 
*/
            /// <summary>
            ///   System.Void SetClubBasicInfo(GameMain.ClubSystem.ClubSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.ClubSystem.ClubSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetClubBasicInfo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubSetting", 0)]
            public partial void SET_CLUB_BASIC_INFO(nint setting); 
*/
            /// <summary>
            ///   System.Void SetClubRelation(GameMain.AthleteSystem.Athlete athlete, System.Int32 value)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetClubRelation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SET_CLUB_RELATION(nint athlete, System.Int32 value); 
*/
            /// <summary>
            ///   System.Void SetDivision(GameMain.MatchSystem.DivisionSetting division)
            /// </summary>
            /// <param name = "division">class GameMain.MatchSystem.DivisionSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetDivision", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.MatchSystem.DivisionSetting", 0)]
            public partial void SET_DIVISION(nint division); 
*/
            /// <summary>
            ///   LogicFramework.LogicEntity_Club SpawnEntity()
            /// </summary>
            /// <returns>class LogicFramework.LogicEntity_Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SpawnEntity", "LogicFramework.LogicEntity_Club", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SPAWN_ENTITY(); 
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
            ///   System.Void UpdateClubDivision()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateClubDivision", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_CLUB_DIVISION(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."LogicObject`1"]
        /// </summary>
        public unsafe readonly partial struct Ptr_Club
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."LogicObject`2"]
        /// </summary>
        public unsafe readonly partial struct Ptr_Club
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   LogicFramework.LogicEntity_Club get_Entity()
            /// </summary>
            /// <returns>class LogicFramework.LogicEntity_Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Entity", "LogicFramework.LogicEntity_Club", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ENTITY(); 
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
            ///   System.Void set_Entity(LogicFramework.LogicEntity_Club value)
            /// </summary>
            /// <param name = "value">class LogicFramework.LogicEntity_Club</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Entity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("LogicFramework.LogicEntity_Club", 0)]
            public partial void SET_ENTITY(nint value); 
*/
            /// <summary>
            ///  abstract LogicFramework.LogicEntity_Club SpawnEntity()
            /// </summary>
            /// <returns>class LogicFramework.LogicEntity_Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SpawnEntity", "LogicFramework.LogicEntity_Club", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public abstract partial nint SPAWN_ENTITY(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility"."Utility.GeneralObject"."GeneralObject"]
        /// </summary>
        public unsafe readonly partial struct Ptr_Club
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

        /// <summary>
        /// abstract class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."LogicObject"]
        /// </summary>
        public unsafe readonly partial struct Ptr_Club
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   Utility.GameSystem.LogicFrameworkX.LogicEntity get_Entity()
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicEntity</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Entity", "Utility.GameSystem.LogicFrameworkX.LogicEntity", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ENTITY(); 
*/
            /// <summary>
            ///   System.Void set_Entity(Utility.GameSystem.LogicFrameworkX.LogicEntity value)
            /// </summary>
            /// <param name = "value">class Utility.GameSystem.LogicFrameworkX.LogicEntity</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Entity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GameSystem.LogicFrameworkX.LogicEntity", 0)]
            public partial void SET_ENTITY(nint value); 
*/
        }
    }
}
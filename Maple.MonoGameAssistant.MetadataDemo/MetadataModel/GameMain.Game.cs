namespace Maple.MonoGameAssistant.MetadataDemo.MetadataModel
{
    /// <summary>
    /// class ["Assembly-CSharp"."GameMain"."Game"]
    /// [Utility.GameSystem.LogicFrameworkX.LogicObject<GameMain.Game , LogicFramework.LogicEntity_Game>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject<GameMain.Game>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject]=>[Utility.GeneralObject.GeneralObject]=>[System.Object]
    /// </summary>
    [MetadataExtensions.MetadataGenerator.ClassParentMetadata<MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Game>, Ptr_Game>]
    [MetadataExtensions.MetadataGenerator.ClassModelMetadata("Assembly-CSharp", "GameMain", "Game", "GameMain.Game")]
    public partial class Game
    {
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Game(nint ptr) : MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint m_Pointer = ptr;
            public nint Ptr => m_Pointer;

            public static implicit operator Ptr_Game(nint ptr) => new Ptr_Game(ptr);
            public static implicit operator nint(Ptr_Game ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_Game ptr) => ptr.m_Pointer != nint.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."GameMain"."Game"]
        /// </summary>
        partial struct Ptr_Game
        {
            /// <summary>
            /// 0x0 GameMain.Utility.UISetting m_uiSetting
            /// class ["Assembly-CSharp"."GameMain.Utility"."UISetting"]
            /// </summary>
            /// <returns>class GameMain.Utility.UISetting</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_uiSetting", "GameMain.Utility.UISetting")]
           public static partial nint M_UI_SETTING { get; set; } 
*/

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
            /// 0x8 System.String[] SkillUpgradeKeys
            /// class ["mscorlib"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkillUpgradeKeys", "System.String[]")]
           public static partial nint SKILL_UPGRADE_KEYS { get; set; } 
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
            /// 0x78 Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.Game , LogicFramework.LogicEntity_Game , GameMain.GameSetting> <C_Setting>k__BackingField
            /// class ["Utility.GameSystem".""."SettingComponent`1"]
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.Game , LogicFramework.LogicEntity_Game , GameMain.GameSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Setting>k__BackingField", "Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.Game,LogicFramework.LogicEntity_Game,GameMain.GameSetting>")]
           public partial nint C_SETTING { get; set; } 
*/

            /// <summary>
            /// 0x80 GameMain.Game.FSMComponent <C_FSM>k__BackingField
            /// class ["Assembly-CSharp".""."FSMComponent"]
            /// </summary>
            /// <returns>class GameMain.Game.FSMComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_FSM>k__BackingField", "GameMain.Game.FSMComponent")]
           public partial nint C_FSM { get; set; } 
*/

            /// <summary>
            /// 0x88 GameMain.Game.LogicComponent <C_Logic>k__BackingField
            /// class ["Assembly-CSharp".""."LogicComponent"]
            /// </summary>
            /// <returns>class GameMain.Game.LogicComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Logic>k__BackingField", "GameMain.Game.LogicComponent")]
           public partial nint C_LOGIC { get; set; } 
*/

            /// <summary>
            /// 0x90 GameMain.Game.DataComponent <C_Data>k__BackingField
            /// class ["Assembly-CSharp".""."DataComponent"]
            /// </summary>
            /// <returns>class GameMain.Game.DataComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Data>k__BackingField", "GameMain.Game.DataComponent")]
           public partial nint C_DATA { get; set; } 
*/

            /// <summary>
            /// 0x98 GameMain.Game.RuleComponent <C_Rules>k__BackingField
            /// class ["Assembly-CSharp".""."RuleComponent"]
            /// </summary>
            /// <returns>class GameMain.Game.RuleComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Rules>k__BackingField", "GameMain.Game.RuleComponent")]
           public partial nint C_RULES { get; set; } 
*/

            /// <summary>
            /// 0xA0 GameMain.Game.DivisionComponent <C_Division>k__BackingField
            /// class ["Assembly-CSharp".""."DivisionComponent"]
            /// </summary>
            /// <returns>class GameMain.Game.DivisionComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Division>k__BackingField", "GameMain.Game.DivisionComponent")]
           public partial nint C_DIVISION { get; set; } 
*/

            /// <summary>
            /// 0xA8 GameMain.Game.CompetitionComponent <C_Competition>k__BackingField
            /// class ["Assembly-CSharp".""."CompetitionComponent"]
            /// </summary>
            /// <returns>class GameMain.Game.CompetitionComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Competition>k__BackingField", "GameMain.Game.CompetitionComponent")]
           public partial nint C_COMPETITION { get; set; } 
*/

            /// <summary>
            /// 0xB0 GameMain.Game.MatchComponent <C_Match>k__BackingField
            /// class ["Assembly-CSharp".""."MatchComponent"]
            /// </summary>
            /// <returns>class GameMain.Game.MatchComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Match>k__BackingField", "GameMain.Game.MatchComponent")]
           public partial nint C_MATCH { get; set; } 
*/

            /// <summary>
            /// 0xB8 GameMain.Game.AthleteManagerComponent <C_AthleteManager>k__BackingField
            /// class ["Assembly-CSharp".""."AthleteManagerComponent"]
            /// </summary>
            /// <returns>class GameMain.Game.AthleteManagerComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_AthleteManager>k__BackingField", "GameMain.Game.AthleteManagerComponent")]
           public partial nint C_ATHLETE_MANAGER { get; set; } 
*/

            /// <summary>
            /// 0xC0 GameMain.Game.UIComponent <C_UI>k__BackingField
            /// class ["Assembly-CSharp".""."UIComponent"]
            /// </summary>
            /// <returns>class GameMain.Game.UIComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_UI>k__BackingField", "GameMain.Game.UIComponent")]
           public partial nint C_UI { get; set; } 
*/

            /// <summary>
            /// 0xC8 GameMain.Game.CustomOptionComponent <C_Custom>k__BackingField
            /// class ["Assembly-CSharp".""."CustomOptionComponent"]
            /// </summary>
            /// <returns>class GameMain.Game.CustomOptionComponent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Custom>k__BackingField", "GameMain.Game.CustomOptionComponent")]
           public partial nint C_CUSTOM { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.Collections.Generic.Dictionary<System.Guid , GameMain.ClubSystem.Club> <Clubs>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Guid , GameMain.ClubSystem.Club></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Clubs>k__BackingField", "System.Collections.Generic.Dictionary<System.Guid,GameMain.ClubSystem.Club>")]
           public partial nint CLUBS { get; set; } 
*/

            /// <summary>
            /// 0xD8 GameMain.ClubSystem.Club <ClubPlayer>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."Club"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club</returns>

            [MetadataExtensions.MetadataGenerator.ClassPropertyMetadata("<ClubPlayer>k__BackingField", "GameMain.ClubSystem.Club")]
            public partial Maple.MonoGameAssistant.MetadataDemo.MetadataModel.Club.Ptr_Club C_CLUB_PLAYER { get; }


            /// <summary>
            /// 0xE0 GameMain.ClubSystem.Club <ClubVirtual>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."Club"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ClubVirtual>k__BackingField", "GameMain.ClubSystem.Club")]
           public partial nint CLUB_VIRTUAL { get; set; } 
*/

            /// <summary>
            /// 0xE8 GameMain.CalendarSystem.Calendar <Calendar>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.CalendarSystem"."Calendar"]
            /// </summary>
            /// <returns>class GameMain.CalendarSystem.Calendar</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Calendar>k__BackingField", "GameMain.CalendarSystem.Calendar")]
           public partial nint CALENDAR { get; set; } 
*/

            /// <summary>
            /// 0xF0 GameMain.BattleSystem.Battle <Battle>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.BattleSystem"."Battle"]
            /// </summary>
            /// <returns>class GameMain.BattleSystem.Battle</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Battle>k__BackingField", "GameMain.BattleSystem.Battle")]
           public partial nint BATTLE { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Collections.Generic.List<GameMain.BattleSystem.Battle> <BattleAutos>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.BattleSystem.Battle></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BattleAutos>k__BackingField", "System.Collections.Generic.List<GameMain.BattleSystem.Battle>")]
           public partial nint BATTLE_AUTOS { get; set; } 
*/

            /// <summary>
            /// 0x100 GameMain.BattleSystem.Battle <Scrimmage>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.BattleSystem"."Battle"]
            /// </summary>
            /// <returns>class GameMain.BattleSystem.Battle</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Scrimmage>k__BackingField", "GameMain.BattleSystem.Battle")]
           public partial nint SCRIMMAGE { get; set; } 
*/

            /// <summary>
            /// 0x108 Utility.FSMSystem.FSMState <CurState>k__BackingField
            /// class ["Utility"."Utility.FSMSystem"."FSMState"]
            /// </summary>
            /// <returns>class Utility.FSMSystem.FSMState</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CurState>k__BackingField", "Utility.FSMSystem.FSMState")]
           public partial nint CUR_STATE { get; set; } 
*/

            /// <summary>
            /// 0x110 System.Action <OnAthleteKicked>k__BackingField
            /// class ["mscorlib"."System"."Action"]
            /// </summary>
            /// <returns>class System.Action</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<OnAthleteKicked>k__BackingField", "System.Action")]
           public partial nint ON_ATHLETE_KICKED { get; set; } 
*/

            /// <summary>
            /// 0x118 System.Action <OnBackToMenu>k__BackingField
            /// class ["mscorlib"."System"."Action"]
            /// </summary>
            /// <returns>class System.Action</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<OnBackToMenu>k__BackingField", "System.Action")]
           public partial nint ON_BACK_TO_MENU { get; set; } 
*/

            /// <summary>
            /// 0x120 GameMain.ClubSystem.Club m_clubSimulate
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."Club"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_clubSimulate", "GameMain.ClubSystem.Club")]
           public partial nint M_CLUB_SIMULATE { get; set; } 
*/

            /// <summary>
            /// 0x128 System.Boolean <Loaded>k__BackingField
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Loaded>k__BackingField", "System.Boolean")]
           public partial System.Boolean LOADED { get; set; } 
*/

            /// <summary>
            /// 0x129 System.Boolean <EnterAffairIsLoadGame>k__BackingField
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<EnterAffairIsLoadGame>k__BackingField", "System.Boolean")]
           public partial System.Boolean ENTER_AFFAIR_IS_LOAD_GAME { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."GameMain"."Game"]
        /// </summary>
        partial struct Ptr_Game
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
            /// static  System.Void Despawn(GameMain.Game game)
            /// </summary>
            /// <param name = "game">class GameMain.Game</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Despawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Game", 0)]
            public static partial void DESPAWN(nint game); 
*/
            /// <summary>
            /// static  GameMain.Utility.UISetting get_UISetting()
            /// </summary>
            /// <returns>class GameMain.Utility.UISetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_UISetting", "GameMain.Utility.UISetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_UI_SETTING(); 
*/
            /// <summary>
            /// static  System.Collections.Generic.List<GameMain.UnitSystem.UnitSetting> GetActiveHeroSettings()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.UnitSystem.UnitSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetActiveHeroSettings", "System.Collections.Generic.List<GameMain.UnitSystem.UnitSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_ACTIVE_HERO_SETTINGS(); 
*/
            /// <summary>
            /// static  System.Void GetActiveHeroSettings(System.Collections.Generic.ICollection<GameMain.UnitSystem.UnitSetting> result, System.Func<GameMain.UnitSystem.UnitSetting , System.Boolean> where)
            /// </summary>
            /// <param name = "result">interface System.Collections.Generic.ICollection<GameMain.UnitSystem.UnitSetting></param>
            /// <param name = "where">class System.Func<GameMain.UnitSystem.UnitSetting , System.Boolean></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetActiveHeroSettings", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.ICollection<GameMain.UnitSystem.UnitSetting>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Func<GameMain.UnitSystem.UnitSetting,System.Boolean>", 1)]
            public static partial void GET_ACTIVE_HERO_SETTINGS(nint result, nint where); 
*/
            /// <summary>
            /// static  System.Void GetActiveHeroSettings(System.Collections.Generic.ICollection<GameMain.UnitSystem.UnitSetting> result, System.Int32 index)
            /// </summary>
            /// <param name = "result">interface System.Collections.Generic.ICollection<GameMain.UnitSystem.UnitSetting></param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetActiveHeroSettings", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.ICollection<GameMain.UnitSystem.UnitSetting>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial void GET_ACTIVE_HERO_SETTINGS(nint result, System.Int32 index); 
*/
            /// <summary>
            /// static  GameMain.GameProcedure.GameProcedureTypes GetGameProcedureType()
            /// </summary>
            /// <returns>enum GameMain.GameProcedure.GameProcedureTypes</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGameProcedureType", "GameMain.GameProcedure.GameProcedureTypes", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial GameMain.GameProcedure.GameProcedureTypes GET_GAME_PROCEDURE_TYPE(); 
*/
            /// <summary>
            /// static  System.Int32 GetSeasonSalary(System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete> athletes)
            /// </summary>
            /// <param name = "athletes">interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete></param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSeasonSalary", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete>", 0)]
            public static partial System.Int32 GET_SEASON_SALARY(nint athletes); 
*/
            /// <summary>
            /// static  GameMain.UnitSystem.UnitSetting GetUnitSetting(System.String heroKey)
            /// </summary>
            /// <param name = "heroKey">class System.String</param>
            /// <returns>class GameMain.UnitSystem.UnitSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetUnitSetting", "GameMain.UnitSystem.UnitSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial nint GET_UNIT_SETTING(nint heroKey); 
*/
            /// <summary>
            /// static  System.Boolean ProcedureIsTransfer(System.Boolean excludeInternetCafe)
            /// </summary>
            /// <param name = "excludeInternetCafe">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ProcedureIsTransfer", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public static partial System.Boolean PROCEDURE_IS_TRANSFER(System.Boolean excludeInternetCafe); 
*/
            /// <summary>
            /// static  GameMain.Game Spawn(GameMain.GameSetting setting, System.Guid id)
            /// </summary>
            /// <param name = "setting">class GameMain.GameSetting</param>
            /// <param name = "id">struct System.Guid</param>
            /// <returns>class GameMain.Game</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Spawn", "GameMain.Game", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.GameSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 1)]
            public static partial nint SPAWN(nint setting, System.Guid id); 
*/
            /// <summary>
            /// static  GameMain.Game Spawn(GameMain.Game.SaveData data)
            /// </summary>
            /// <param name = "data">class GameMain.Game.SaveData</param>
            /// <returns>class GameMain.Game</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Spawn", "GameMain.Game", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Game.SaveData", 0)]
            public static partial nint SPAWN(nint data); 
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
            ///   System.Boolean <OnRemoveBattle>g__DisconnectNormalBattle|109_0(GameMain.Game.<>c__DisplayClass109_0& )
            /// </summary>
            /// <param name = "">struct GameMain.Game.<>c__DisplayClass109_0&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<OnRemoveBattle>g__DisconnectNormalBattle|109_0", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Game.<>c__DisplayClass109_0&", 0)]
            public partial System.Boolean ON_REMOVE_BATTLEG__DISCONNECT_NORMAL_BATTLE|109_0(GameMain.Game. < > c__DisplayClass109_0 &); 
*/
            /// <summary>
            ///   System.String BuildErrorMessage(System.String message)
            /// </summary>
            /// <param name = "message">class System.String</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BuildErrorMessage", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint BUILD_ERROR_MESSAGE(nint message); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.Club ClubSimulate(System.Boolean spawnNew)
            /// </summary>
            /// <param name = "spawnNew">struct System.Boolean</param>
            /// <returns>class GameMain.ClubSystem.Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClubSimulate", "GameMain.ClubSystem.Club", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint CLUB_SIMULATE(System.Boolean spawnNew); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AthleteGeneralSetting get_AthleteGeneral()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.AthleteGeneralSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AthleteGeneral", "GameMain.AthleteSystem.AthleteGeneralSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATHLETE_GENERAL(); 
*/
            /// <summary>
            ///   GameMain.BattleSystem.Battle get_Battle()
            /// </summary>
            /// <returns>class GameMain.BattleSystem.Battle</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Battle", "GameMain.BattleSystem.Battle", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BATTLE(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.BattleSystem.Battle> get_BattleAutos()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.BattleSystem.Battle></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BattleAutos", "System.Collections.Generic.List<GameMain.BattleSystem.Battle>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BATTLE_AUTOS(); 
*/
            /// <summary>
            ///   GameMain.Game.AthleteManagerComponent get_C_AthleteManager()
            /// </summary>
            /// <returns>class GameMain.Game.AthleteManagerComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_AthleteManager", "GameMain.Game.AthleteManagerComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_ATHLETE_MANAGER(); 
*/
            /// <summary>
            ///   GameMain.Game.CompetitionComponent get_C_Competition()
            /// </summary>
            /// <returns>class GameMain.Game.CompetitionComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Competition", "GameMain.Game.CompetitionComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_COMPETITION(); 
*/
            /// <summary>
            ///   GameMain.Game.CustomOptionComponent get_C_Custom()
            /// </summary>
            /// <returns>class GameMain.Game.CustomOptionComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Custom", "GameMain.Game.CustomOptionComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_CUSTOM(); 
*/
            /// <summary>
            ///   GameMain.Game.DataComponent get_C_Data()
            /// </summary>
            /// <returns>class GameMain.Game.DataComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Data", "GameMain.Game.DataComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_DATA(); 
*/
            /// <summary>
            ///   GameMain.Game.DivisionComponent get_C_Division()
            /// </summary>
            /// <returns>class GameMain.Game.DivisionComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Division", "GameMain.Game.DivisionComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_DIVISION(); 
*/
            /// <summary>
            ///   GameMain.Game.FSMComponent get_C_FSM()
            /// </summary>
            /// <returns>class GameMain.Game.FSMComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_FSM", "GameMain.Game.FSMComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_FSM(); 
*/
            /// <summary>
            ///   GameMain.Game.LogicComponent get_C_Logic()
            /// </summary>
            /// <returns>class GameMain.Game.LogicComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Logic", "GameMain.Game.LogicComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_LOGIC(); 
*/
            /// <summary>
            ///   GameMain.Game.MatchComponent get_C_Match()
            /// </summary>
            /// <returns>class GameMain.Game.MatchComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Match", "GameMain.Game.MatchComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_MATCH(); 
*/
            /// <summary>
            ///   GameMain.Game.RuleComponent get_C_Rules()
            /// </summary>
            /// <returns>class GameMain.Game.RuleComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Rules", "GameMain.Game.RuleComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_RULES(); 
*/
            /// <summary>
            ///   Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.Game , LogicFramework.LogicEntity_Game , GameMain.GameSetting> get_C_Setting()
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.Game , LogicFramework.LogicEntity_Game , GameMain.GameSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Setting", "Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.Game,LogicFramework.LogicEntity_Game,GameMain.GameSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_SETTING(); 
*/
            /// <summary>
            ///   GameMain.Game.UIComponent get_C_UI()
            /// </summary>
            /// <returns>class GameMain.Game.UIComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_UI", "GameMain.Game.UIComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_UI(); 
*/
            /// <summary>
            ///   GameMain.CalendarSystem.Calendar get_Calendar()
            /// </summary>
            /// <returns>class GameMain.CalendarSystem.Calendar</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Calendar", "GameMain.CalendarSystem.Calendar", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CALENDAR(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.Club get_ClubPlayer()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ClubPlayer", "GameMain.ClubSystem.Club", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CLUB_PLAYER(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.Guid , GameMain.ClubSystem.Club> get_Clubs()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Guid , GameMain.ClubSystem.Club></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Clubs", "System.Collections.Generic.Dictionary<System.Guid,GameMain.ClubSystem.Club>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CLUBS(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.Club get_ClubVirtual()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ClubVirtual", "GameMain.ClubSystem.Club", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CLUB_VIRTUAL(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubAffair get_CurAffair()
            /// </summary>
            /// <returns>abstract class GameMain.ClubSystem.ClubAffair</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CurAffair", "GameMain.ClubSystem.ClubAffair", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CUR_AFFAIR(); 
*/
            /// <summary>
            ///   Utility.FSMSystem.FSMState get_CurState()
            /// </summary>
            /// <returns>class Utility.FSMSystem.FSMState</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CurState", "Utility.FSMSystem.FSMState", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CUR_STATE(); 
*/
            /// <summary>
            ///   System.Boolean get_EnterAffairIsLoadGame()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EnterAffairIsLoadGame", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_ENTER_AFFAIR_IS_LOAD_GAME(); 
*/
            /// <summary>
            ///   System.Boolean get_IsHell()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsHell", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_HELL(); 
*/
            /// <summary>
            ///   System.Boolean get_IsRunning()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsRunning", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_RUNNING(); 
*/
            /// <summary>
            ///   System.Boolean get_Loaded()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Loaded", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_LOADED(); 
*/
            /// <summary>
            ///   System.Action get_OnAthleteKicked()
            /// </summary>
            /// <returns>class System.Action</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_OnAthleteKicked", "System.Action", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ON_ATHLETE_KICKED(); 
*/
            /// <summary>
            ///   System.Action get_OnBackToMenu()
            /// </summary>
            /// <returns>class System.Action</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_OnBackToMenu", "System.Action", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ON_BACK_TO_MENU(); 
*/
            /// <summary>
            ///   GameMain.BattleSystem.Battle get_Scrimmage()
            /// </summary>
            /// <returns>class GameMain.BattleSystem.Battle</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Scrimmage", "GameMain.BattleSystem.Battle", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SCRIMMAGE(); 
*/
            /// <summary>
            ///   GameMain.GameSetting get_Setting()
            /// </summary>
            /// <returns>class GameMain.GameSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Setting", "GameMain.GameSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SETTING(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.YouthScoutGeneralSetting get_YouthScoutGeneral()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.YouthScoutGeneralSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_YouthScoutGeneral", "GameMain.ClubSystem.YouthScoutGeneralSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_YOUTH_SCOUT_GENERAL(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.Club GetClubById(System.Guid id)
            /// </summary>
            /// <param name = "id">struct System.Guid</param>
            /// <returns>class GameMain.ClubSystem.Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetClubById", "GameMain.ClubSystem.Club", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public partial nint GET_CLUB_BY_ID(System.Guid id); 
*/
            /// <summary>
            ///   System.Void OnAddBattle(GameMain.BattleSystem.Battle battle)
            /// </summary>
            /// <param name = "battle">class GameMain.BattleSystem.Battle</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddBattle", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.BattleSystem.Battle", 0)]
            public partial void ON_ADD_BATTLE(nint battle); 
*/
            /// <summary>
            ///   System.Void OnAddCalendar(GameMain.CalendarSystem.Calendar calendar)
            /// </summary>
            /// <param name = "calendar">class GameMain.CalendarSystem.Calendar</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddCalendar", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.CalendarSystem.Calendar", 0)]
            public partial void ON_ADD_CALENDAR(nint calendar); 
*/
            /// <summary>
            ///   System.Void OnAddClub(GameMain.ClubSystem.Club club)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddClub", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            public partial void ON_ADD_CLUB(nint club); 
*/
            /// <summary>
            ///   System.Void OnAddGameRule(GameMain.GameRule rule)
            /// </summary>
            /// <param name = "rule">class GameMain.GameRule</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddGameRule", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.GameRule", 0)]
            public partial void ON_ADD_GAME_RULE(nint rule); 
*/
            /// <summary>
            ///   System.Void OnAddPlayerClub(GameMain.ClubSystem.Club club)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddPlayerClub", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            public partial void ON_ADD_PLAYER_CLUB(nint club); 
*/
            /// <summary>
            ///   System.Void OnAddSimulateClub(GameMain.ClubSystem.Club club)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddSimulateClub", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            public partial void ON_ADD_SIMULATE_CLUB(nint club); 
*/
            /// <summary>
            ///   System.Void OnAddVirtualClub(GameMain.ClubSystem.Club club)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddVirtualClub", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            public partial void ON_ADD_VIRTUAL_CLUB(nint club); 
*/
            /// <summary>
            ///   System.Void OnRemoveBattle(GameMain.BattleSystem.Battle battle)
            /// </summary>
            /// <param name = "battle">class GameMain.BattleSystem.Battle</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveBattle", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.BattleSystem.Battle", 0)]
            public partial void ON_REMOVE_BATTLE(nint battle); 
*/
            /// <summary>
            ///   System.Void OnRemoveCalendar()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveCalendar", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_REMOVE_CALENDAR(); 
*/
            /// <summary>
            ///   System.Void OnRemoveClub(GameMain.ClubSystem.Club club)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveClub", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            public partial void ON_REMOVE_CLUB(nint club); 
*/
            /// <summary>
            ///   System.Void OnRemoveGameRule(GameMain.GameRule rule)
            /// </summary>
            /// <param name = "rule">class GameMain.GameRule</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveGameRule", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.GameRule", 0)]
            public partial void ON_REMOVE_GAME_RULE(nint rule); 
*/
            /// <summary>
            ///   System.Void OnRemovePlayerClub()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemovePlayerClub", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_REMOVE_PLAYER_CLUB(); 
*/
            /// <summary>
            ///   System.Void OnRemoveSimulateClub()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveSimulateClub", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_REMOVE_SIMULATE_CLUB(); 
*/
            /// <summary>
            ///   System.Void OnRemoveVirtualClub()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveVirtualClub", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_REMOVE_VIRTUAL_CLUB(); 
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
            ///   System.Void set_Battle(GameMain.BattleSystem.Battle value)
            /// </summary>
            /// <param name = "value">class GameMain.BattleSystem.Battle</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Battle", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.BattleSystem.Battle", 0)]
            public partial void SET_BATTLE(nint value); 
*/
            /// <summary>
            ///   System.Void set_Calendar(GameMain.CalendarSystem.Calendar value)
            /// </summary>
            /// <param name = "value">class GameMain.CalendarSystem.Calendar</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Calendar", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.CalendarSystem.Calendar", 0)]
            public partial void SET_CALENDAR(nint value); 
*/
            /// <summary>
            ///   System.Void set_ClubPlayer(GameMain.ClubSystem.Club value)
            /// </summary>
            /// <param name = "value">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ClubPlayer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            public partial void SET_CLUB_PLAYER(nint value); 
*/
            /// <summary>
            ///   System.Void set_ClubVirtual(GameMain.ClubSystem.Club value)
            /// </summary>
            /// <param name = "value">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ClubVirtual", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            public partial void SET_CLUB_VIRTUAL(nint value); 
*/
            /// <summary>
            ///   System.Void set_CurState(Utility.FSMSystem.FSMState value)
            /// </summary>
            /// <param name = "value">class Utility.FSMSystem.FSMState</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CurState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.FSMSystem.FSMState", 0)]
            public partial void SET_CUR_STATE(nint value); 
*/
            /// <summary>
            ///   System.Void set_EnterAffairIsLoadGame(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_EnterAffairIsLoadGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_ENTER_AFFAIR_IS_LOAD_GAME(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_Loaded(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Loaded", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_LOADED(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_OnAthleteKicked(System.Action value)
            /// </summary>
            /// <param name = "value">class System.Action</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_OnAthleteKicked", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action", 0)]
            public partial void SET_ON_ATHLETE_KICKED(nint value); 
*/
            /// <summary>
            ///   System.Void set_OnBackToMenu(System.Action value)
            /// </summary>
            /// <param name = "value">class System.Action</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_OnBackToMenu", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action", 0)]
            public partial void SET_ON_BACK_TO_MENU(nint value); 
*/
            /// <summary>
            ///   System.Void set_Scrimmage(GameMain.BattleSystem.Battle value)
            /// </summary>
            /// <param name = "value">class GameMain.BattleSystem.Battle</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Scrimmage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.BattleSystem.Battle", 0)]
            public partial void SET_SCRIMMAGE(nint value); 
*/
            /// <summary>
            ///   LogicFramework.LogicEntity_Game SpawnEntity()
            /// </summary>
            /// <returns>class LogicFramework.LogicEntity_Game</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SpawnEntity", "LogicFramework.LogicEntity_Game", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SPAWN_ENTITY(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."LogicObject`1"]
        /// </summary>
        partial struct Ptr_Game
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
        partial struct Ptr_Game
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
            ///   LogicFramework.LogicEntity_Game get_Entity()
            /// </summary>
            /// <returns>class LogicFramework.LogicEntity_Game</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Entity", "LogicFramework.LogicEntity_Game", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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
            ///   System.Void set_Entity(LogicFramework.LogicEntity_Game value)
            /// </summary>
            /// <param name = "value">class LogicFramework.LogicEntity_Game</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Entity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("LogicFramework.LogicEntity_Game", 0)]
            public partial void SET_ENTITY(nint value); 
*/
            /// <summary>
            ///  abstract LogicFramework.LogicEntity_Game SpawnEntity()
            /// </summary>
            /// <returns>class LogicFramework.LogicEntity_Game</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SpawnEntity", "LogicFramework.LogicEntity_Game", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public abstract partial nint SPAWN_ENTITY(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility"."Utility.GeneralObject"."GeneralObject"]
        /// </summary>
        partial struct Ptr_Game
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
        partial struct Ptr_Game
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
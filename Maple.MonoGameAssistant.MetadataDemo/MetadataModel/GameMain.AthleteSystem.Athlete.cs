namespace Maple.MonoGameAssistant.MetadataDemo.MetadataModel
{
    /// <summary>
    /// class ["Assembly-CSharp"."GameMain.AthleteSystem"."Athlete"]
    /// [Utility.GameSystem.LogicFrameworkX.LogicObject<GameMain.AthleteSystem.Athlete , LogicFramework.LogicEntity_Athlete>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject<GameMain.AthleteSystem.Athlete>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject]=>[Utility.GeneralObject.GeneralObject]=>[System.Object]
    /// </summary>
    [MetadataExtensions.MetadataGenerator.ClassParentMetadata<MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Athlete>, Ptr_Athlete>]
    [MetadataExtensions.MetadataGenerator.ClassModelMetadata("Assembly-CSharp", "GameMain.AthleteSystem", "Athlete", "GameMain.AthleteSystem.Athlete")]
    public partial class Athlete
    {
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Athlete(nint ptr) : MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint m_Pointer = ptr;
            public nint Ptr => m_Pointer;

            public static implicit operator Ptr_Athlete(nint ptr) => new Ptr_Athlete(ptr);
            public static implicit operator nint(Ptr_Athlete ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_Athlete ptr) => ptr.m_Pointer != nint.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."GameMain.AthleteSystem"."Athlete"]
        /// </summary>
        public unsafe readonly partial struct Ptr_Athlete
        {
            /// <summary>
            /// 0x0 UnityEngine.Vector2Int SkipInternetCafeAbilityLimitRange
            /// struct ["UnityEngine.CoreModule"."UnityEngine"."Vector2Int"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector2Int</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkipInternetCafeAbilityLimitRange", "UnityEngine.Vector2Int")]
            public static partial UnityEngine.Vector2Int SKIP_INTERNET_CAFE_ABILITY_LIMIT_RANGE { get; set; } 
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
            /// 0x78 Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.AthleteSystem.Athlete , LogicFramework.LogicEntity_Athlete , GameMain.AthleteSystem.AthleteSetting> <C_Setting>k__BackingField
            /// class ["Utility.GameSystem".""."SettingComponent`1"]
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.AthleteSystem.Athlete , LogicFramework.LogicEntity_Athlete , GameMain.AthleteSystem.AthleteSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Setting>k__BackingField", "Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.AthleteSystem.Athlete,LogicFramework.LogicEntity_Athlete,GameMain.AthleteSystem.AthleteSetting>")]
            public partial nint C_SETTING { get; set; } 
*/

            /// <summary>
            /// 0x80 GameMain.AthleteSystem.Athlete.DataComponent <C_Data>k__BackingField
            /// class ["Assembly-CSharp".""."DataComponent"]
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.Athlete.DataComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Data>k__BackingField", "GameMain.AthleteSystem.Athlete.DataComponent")]
            public partial nint C_DATA { get; set; } 
*/

            /// <summary>
            /// 0x88 GameMain.AthleteSystem.Athlete.TraitsComponent <C_Traits>k__BackingField
            /// class ["Assembly-CSharp".""."TraitsComponent"]
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.Athlete.TraitsComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Traits>k__BackingField", "GameMain.AthleteSystem.Athlete.TraitsComponent")]
            public partial nint C_TRAITS { get; set; } 
*/

            /// <summary>
            /// 0x90 GameMain.AthleteSystem.AthleteStatusComponent <C_Status>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteStatusComponent"]
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.AthleteStatusComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Status>k__BackingField", "GameMain.AthleteSystem.AthleteStatusComponent")]
            public partial nint C_STATUS { get; set; } 
*/

            /// <summary>
            /// 0x98 GameMain.AthleteSystem.Athlete.MilestoneComponent <C_Milestone>k__BackingField
            /// class ["Assembly-CSharp".""."MilestoneComponent"]
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.Athlete.MilestoneComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Milestone>k__BackingField", "GameMain.AthleteSystem.Athlete.MilestoneComponent")]
            public partial nint C_MILESTONE { get; set; } 
*/

            /// <summary>
            /// 0xA0 GameMain.AthleteSystem.Athlete.LogicComponent <C_Logic>k__BackingField
            /// class ["Assembly-CSharp".""."LogicComponent"]
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.Athlete.LogicComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Logic>k__BackingField", "GameMain.AthleteSystem.Athlete.LogicComponent")]
            public partial nint C_LOGIC { get; set; } 
*/

            /// <summary>
            /// 0xA8 GameMain.BattleSystem.BattleTeam <BattleTeam>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.BattleSystem"."BattleTeam"]
            /// </summary>
            /// <returns>class GameMain.BattleSystem.BattleTeam</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BattleTeam>k__BackingField", "GameMain.BattleSystem.BattleTeam")]
            public partial nint BATTLE_TEAM { get; set; } 
*/

            /// <summary>
            /// 0xB0 GameMain.BattleSystem.BattleTeam <BattleTeamAuto>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.BattleSystem"."BattleTeam"]
            /// </summary>
            /// <returns>class GameMain.BattleSystem.BattleTeam</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BattleTeamAuto>k__BackingField", "GameMain.BattleSystem.BattleTeam")]
            public partial nint BATTLE_TEAM_AUTO { get; set; } 
*/

            /// <summary>
            /// 0xB8 GameMain.ClubSystem.Club <Club>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."Club"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Club>k__BackingField", "GameMain.ClubSystem.Club")]
            public partial nint CLUB { get; set; } 
*/

            /// <summary>
            /// 0xC0 GameMain.UnitSystem.Unit <Hero>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.UnitSystem"."Unit"]
            /// </summary>
            /// <returns>class GameMain.UnitSystem.Unit</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Hero>k__BackingField", "GameMain.UnitSystem.Unit")]
            public partial nint HERO { get; set; } 
*/

            /// <summary>
            /// 0xC8 GameMain.UnitSystem.Unit <HeroAuto>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.UnitSystem"."Unit"]
            /// </summary>
            /// <returns>class GameMain.UnitSystem.Unit</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<HeroAuto>k__BackingField", "GameMain.UnitSystem.Unit")]
            public partial nint HERO_AUTO { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.Collections.Generic.List<GameMain.UnitSystem.Unit> <BanPickHeroes>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.UnitSystem.Unit></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BanPickHeroes>k__BackingField", "System.Collections.Generic.List<GameMain.UnitSystem.Unit>")]
            public partial nint BAN_PICK_HEROES { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.Collections.Generic.List<GameMain.UnitSystem.StatisticUnit> <AthleteBattleStatisticDatas>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.UnitSystem.StatisticUnit></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AthleteBattleStatisticDatas>k__BackingField", "System.Collections.Generic.List<GameMain.UnitSystem.StatisticUnit>")]
            public partial nint ATHLETE_BATTLE_STATISTIC_DATAS { get; set; } 
*/

            /// <summary>
            /// 0xE0 GameMain.UnitSystem.HeroRoleFlags <HeroRole>k__BackingField
            /// enum ["Assembly-CSharp"."GameMain.UnitSystem"."HeroRoleFlags"]
            /// </summary>
            /// <returns>enum GameMain.UnitSystem.HeroRoleFlags</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<HeroRole>k__BackingField", "GameMain.UnitSystem.HeroRoleFlags")]
            public partial GameMain.UnitSystem.HeroRoleFlags HERO_ROLE { get; set; } 
*/

            /// <summary>
            /// 0xE4 System.Boolean <IsScrimmage>k__BackingField
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<IsScrimmage>k__BackingField", "System.Boolean")]
            public partial System.Boolean IS_SCRIMMAGE { get; set; } 
*/

            /// <summary>
            /// 0xE8 GameMain.UnitSystem.StatisticUnit <AthleteBattleStatisticData>k__BackingField
            /// struct ["Assembly-CSharp"."GameMain.UnitSystem"."StatisticUnit"]
            /// </summary>
            /// <returns>struct GameMain.UnitSystem.StatisticUnit</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AthleteBattleStatisticData>k__BackingField", "GameMain.UnitSystem.StatisticUnit")]
            public partial GameMain.UnitSystem.StatisticUnit ATHLETE_BATTLE_STATISTIC_DATA { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."GameMain.AthleteSystem"."Athlete"]
        /// </summary>
        public unsafe readonly partial struct Ptr_Athlete
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
            /// static  System.Void <SetAthleteCustom>g__SetAbility|146_1(GameMain.AthleteSystem.Athlete.<>c__DisplayClass146_0& )
            /// </summary>
            /// <param name = "">struct GameMain.AthleteSystem.Athlete.<>c__DisplayClass146_0&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<SetAthleteCustom>g__SetAbility|146_1", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete.<>c__DisplayClass146_0&", 0)]
            public static partial void SET_ATHLETE_CUSTOMG__SET_ABILITY|146_1(GameMain.AthleteSystem.Athlete. < > c__DisplayClass146_0 &); 
*/
            /// <summary>
            /// static  System.Void <SetAthleteCustom>g__SetHero|146_3(GameMain.AthleteSystem.Athlete.<>c__DisplayClass146_0& )
            /// </summary>
            /// <param name = "">struct GameMain.AthleteSystem.Athlete.<>c__DisplayClass146_0&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<SetAthleteCustom>g__SetHero|146_3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete.<>c__DisplayClass146_0&", 0)]
            public static partial void SET_ATHLETE_CUSTOMG__SET_HERO|146_3(GameMain.AthleteSystem.Athlete. < > c__DisplayClass146_0 &); 
*/
            /// <summary>
            /// static  System.Void <SetAthleteCustom>g__SetPersonalData|146_0(GameMain.AthleteSystem.Athlete.<>c__DisplayClass146_0& )
            /// </summary>
            /// <param name = "">struct GameMain.AthleteSystem.Athlete.<>c__DisplayClass146_0&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<SetAthleteCustom>g__SetPersonalData|146_0", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete.<>c__DisplayClass146_0&", 0)]
            public static partial void SET_ATHLETE_CUSTOMG__SET_PERSONAL_DATA|146_0(GameMain.AthleteSystem.Athlete. < > c__DisplayClass146_0 &); 
*/
            /// <summary>
            /// static  System.Void <SetAthleteCustom>g__SetTrait|146_2(GameMain.AthleteSystem.Athlete.<>c__DisplayClass146_0& )
            /// </summary>
            /// <param name = "">struct GameMain.AthleteSystem.Athlete.<>c__DisplayClass146_0&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<SetAthleteCustom>g__SetTrait|146_2", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete.<>c__DisplayClass146_0&", 0)]
            public static partial void SET_ATHLETE_CUSTOMG__SET_TRAIT|146_2(GameMain.AthleteSystem.Athlete. < > c__DisplayClass146_0 &); 
*/
            /// <summary>
            /// static  System.Int32 <SortAthletesByRole>g__GetRoleWeight|172_1(GameMain.UnitSystem.HeroRoleFlags flag)
            /// </summary>
            /// <param name = "flag">enum GameMain.UnitSystem.HeroRoleFlags</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<SortAthletesByRole>g__GetRoleWeight|172_1", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroRoleFlags", 0)]
            public static partial System.Int32 SORT_ATHLETES_BY_ROLEG__GET_ROLE_WEIGHT|172_1(GameMain.UnitSystem.HeroRoleFlags flag); 
*/
            /// <summary>
            /// static  System.Void AdjustAthleteByOpponent(GameMain.AthleteSystem.Athlete athlete, GameMain.AthleteSystem.Athlete opponent)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "opponent">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AdjustAthleteByOpponent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 1)]
            public static partial void ADJUST_ATHLETE_BY_OPPONENT(nint athlete, nint opponent); 
*/
            /// <summary>
            /// static  System.Boolean AthleteAbilityHasFlag(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AthleteAbilityFlags value)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "value">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AthleteAbilityHasFlag", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 1)]
            public static partial System.Boolean ATHLETE_ABILITY_HAS_FLAG(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AthleteAbilityFlags value); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.Athlete Copy(GameMain.AthleteSystem.Athlete source, GameMain.ClubSystem.Club club)
            /// </summary>
            /// <param name = "source">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Copy", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 1)]
            public static partial nint COPY(nint source, nint club); 
*/
            /// <summary>
            /// static  System.Void CreateCardsByScoreDelta(GameMain.AthleteSystem.Athlete athlete, System.Double delta, System.Int32 primeIndex)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "delta">struct System.Double</param>
            /// <param name = "primeIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateCardsByScoreDelta", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Double", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public static partial void CREATE_CARDS_BY_SCORE_DELTA(nint athlete, System.Double delta, System.Int32 primeIndex); 
*/
            /// <summary>
            /// static  System.Void Despawn(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Despawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public static partial void DESPAWN(nint athlete); 
*/
            /// <summary>
            /// static  System.Int32 GetAbilityFlagIndex(GameMain.AthleteSystem.AthleteAbilityFlags flag)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityFlagIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            public static partial System.Int32 GET_ABILITY_FLAG_INDEX(GameMain.AthleteSystem.AthleteAbilityFlags flag); 
*/
            /// <summary>
            /// static  System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteAbilityFlags> GetAbilityFlags(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteAbilityFlags></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityFlags", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteAbilityFlags>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public static partial nint GET_ABILITY_FLAGS(nint athlete); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.AbilityPotentialRank GetAbilityPotentialRank(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AbilityPotentialRank origin, GameMain.AthleteSystem.AthleteTraitSetting setting)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "origin">enum GameMain.AthleteSystem.AbilityPotentialRank</param>
            /// <param name = "setting">class GameMain.AthleteSystem.AthleteTraitSetting</param>
            /// <returns>enum GameMain.AthleteSystem.AbilityPotentialRank</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityPotentialRank", "GameMain.AthleteSystem.AbilityPotentialRank", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AbilityPotentialRank", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteTraitSetting", 2)]
            public static partial GameMain.AthleteSystem.AbilityPotentialRank GET_ABILITY_POTENTIAL_RANK(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AbilityPotentialRank origin, nint setting); 
*/
            /// <summary>
            /// static  System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AbilityPotentialRank> GetAbilityPotentialRanks(System.Boolean containsSubLevel)
            /// </summary>
            /// <param name = "containsSubLevel">struct System.Boolean</param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AbilityPotentialRank></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityPotentialRanks", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AbilityPotentialRank>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public static partial nint GET_ABILITY_POTENTIAL_RANKS(System.Boolean containsSubLevel); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.AthleteCoreType GetAthleteCoreType(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>enum GameMain.AthleteSystem.AthleteCoreType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAthleteCoreType", "GameMain.AthleteSystem.AthleteCoreType", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public static partial GameMain.AthleteSystem.AthleteCoreType GET_ATHLETE_CORE_TYPE(nint athlete); 
*/
            /// <summary>
            /// static  System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteLabelSetting> GetAthleteLabels(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteLabelSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAthleteLabels", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteLabelSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public static partial nint GET_ATHLETE_LABELS(nint athlete); 
*/
            /// <summary>
            /// static  System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteEmotionSetting> GetEmotionSettingsByLevel(GameMain.AthleteSystem.Athlete athlete, System.Int32 level)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "level">struct System.Int32</param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteEmotionSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEmotionSettingsByLevel", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteEmotionSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial nint GET_EMOTION_SETTINGS_BY_LEVEL(nint athlete, System.Int32 level); 
*/
            /// <summary>
            /// static  System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.HeroClassAdaption> GetHeroPotenialAdaption()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.HeroClassAdaption></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroPotenialAdaption", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.HeroClassAdaption>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_HERO_POTENIAL_ADAPTION(); 
*/
            /// <summary>
            /// static  UnityEngine.SystemLanguage GetNameSystemLanguage(GameMain.Game game)
            /// </summary>
            /// <param name = "game">class GameMain.Game</param>
            /// <returns>enum UnityEngine.SystemLanguage</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNameSystemLanguage", "UnityEngine.SystemLanguage", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Game", 0)]
            public static partial UnityEngine.SystemLanguage GET_NAME_SYSTEM_LANGUAGE(nint game); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.AthleteAbilityFlags GetRandomAbilityFlag(System.Boolean getNone, System.Boolean getAll)
            /// </summary>
            /// <param name = "getNone">struct System.Boolean</param>
            /// <param name = "getAll">struct System.Boolean</param>
            /// <returns>enum GameMain.AthleteSystem.AthleteAbilityFlags</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRandomAbilityFlag", "GameMain.AthleteSystem.AthleteAbilityFlags", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial GameMain.AthleteSystem.AthleteAbilityFlags GET_RANDOM_ABILITY_FLAG(System.Boolean getNone, System.Boolean getAll); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.AbilityPotentialRank GetRandomAbilityPotentialRank()
            /// </summary>
            /// <returns>enum GameMain.AthleteSystem.AbilityPotentialRank</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRandomAbilityPotentialRank", "GameMain.AthleteSystem.AbilityPotentialRank", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial GameMain.AthleteSystem.AbilityPotentialRank GET_RANDOM_ABILITY_POTENTIAL_RANK(); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.HeroClassAdaption GetRandomHeroClassAdaption(GameMain.UnitSystem.HeroRoleFlags role, GameMain.UnitSystem.HeroClassTypes classType)
            /// </summary>
            /// <param name = "role">enum GameMain.UnitSystem.HeroRoleFlags</param>
            /// <param name = "classType">enum GameMain.UnitSystem.HeroClassTypes</param>
            /// <returns>enum GameMain.AthleteSystem.HeroClassAdaption</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRandomHeroClassAdaption", "GameMain.AthleteSystem.HeroClassAdaption", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroRoleFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroClassTypes", 1)]
            public static partial GameMain.AthleteSystem.HeroClassAdaption GET_RANDOM_HERO_CLASS_ADAPTION(GameMain.UnitSystem.HeroRoleFlags role, GameMain.UnitSystem.HeroClassTypes classType); 
*/
            /// <summary>
            /// static  System.Int32 GetRelationAdjust(GameMain.AthleteSystem.Athlete athlete1, GameMain.AthleteSystem.Athlete athlete2)
            /// </summary>
            /// <param name = "athlete1">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "athlete2">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRelationAdjust", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 1)]
            public static partial System.Int32 GET_RELATION_ADJUST(nint athlete1, nint athlete2); 
*/
            /// <summary>
            /// static  System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete> GetSameRoleAthletes(System.Guid seasonId, GameMain.UnitSystem.HeroRoleFlags role, System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete> athletes)
            /// </summary>
            /// <param name = "seasonId">struct System.Guid</param>
            /// <param name = "role">enum GameMain.UnitSystem.HeroRoleFlags</param>
            /// <param name = "athletes">interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete></param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSameRoleAthletes", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroRoleFlags", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete>", 2)]
            public static partial nint GET_SAME_ROLE_ATHLETES(System.Guid seasonId, GameMain.UnitSystem.HeroRoleFlags role, nint athletes); 
*/
            /// <summary>
            /// static  System.Void GetValidUnitSetting(GameMain.AthleteSystem.Athlete athlete, System.Collections.Generic.IList<GameMain.UnitSystem.UnitSetting> list, System.Int32 count)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "list">interface System.Collections.Generic.IList<GameMain.UnitSystem.UnitSetting></param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetValidUnitSetting", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IList<GameMain.UnitSystem.UnitSetting>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public static partial void GET_VALID_UNIT_SETTING(nint athlete, nint list, System.Int32 count); 
*/
            /// <summary>
            /// static  System.Collections.Generic.IEnumerable<GameMain.UnitSystem.UnitSetting> GetValidUnitSetting(GameMain.AthleteSystem.Athlete athlete, System.Int32 count)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.UnitSystem.UnitSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetValidUnitSetting", "System.Collections.Generic.IEnumerable<GameMain.UnitSystem.UnitSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial nint GET_VALID_UNIT_SETTING(nint athlete, System.Int32 count); 
*/
            /// <summary>
            /// static  GameMain.UnitSystem.UnitSetting GetValidUnitSetting(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>class GameMain.UnitSystem.UnitSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetValidUnitSetting", "GameMain.UnitSystem.UnitSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public static partial nint GET_VALID_UNIT_SETTING(nint athlete); 
*/
            /// <summary>
            /// static  GameMain.UnitSystem.UnitSetting GetValidUnitSetting(GameMain.AthleteSystem.Athlete athlete, System.Collections.Generic.IEnumerable<GameMain.UnitSystem.UnitSetting> range)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "range">interface System.Collections.Generic.IEnumerable<GameMain.UnitSystem.UnitSetting></param>
            /// <returns>class GameMain.UnitSystem.UnitSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetValidUnitSetting", "GameMain.UnitSystem.UnitSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<GameMain.UnitSystem.UnitSetting>", 1)]
            public static partial nint GET_VALID_UNIT_SETTING(nint athlete, nint range); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.AthleteAbilityFlags MergeAthleteAbilityFlags(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AthleteAbilityFlags parameter)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "parameter">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <returns>enum GameMain.AthleteSystem.AthleteAbilityFlags</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MergeAthleteAbilityFlags", "GameMain.AthleteSystem.AthleteAbilityFlags", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 1)]
            public static partial GameMain.AthleteSystem.AthleteAbilityFlags MERGE_ATHLETE_ABILITY_FLAGS(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AthleteAbilityFlags parameter); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.AthleteAbilityFlags MergeAthleteAbilityFlags(GameMain.AthleteSystem.AthleteAbilityFlags flag, System.Collections.Generic.IList<GameMain.AthleteSystem.AthleteAbilityFlags> flagList)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "flagList">interface System.Collections.Generic.IList<GameMain.AthleteSystem.AthleteAbilityFlags></param>
            /// <returns>enum GameMain.AthleteSystem.AthleteAbilityFlags</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MergeAthleteAbilityFlags", "GameMain.AthleteSystem.AthleteAbilityFlags", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IList<GameMain.AthleteSystem.AthleteAbilityFlags>", 1)]
            public static partial GameMain.AthleteSystem.AthleteAbilityFlags MERGE_ATHLETE_ABILITY_FLAGS(GameMain.AthleteSystem.AthleteAbilityFlags flag, nint flagList); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.AthleteAbilityFlags MergeAthleteAbilityFlags(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AthleteAbilityFlags[] flagParam)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "flagParam">class GameMain.AthleteSystem.AthleteAbilityFlags[]</param>
            /// <returns>enum GameMain.AthleteSystem.AthleteAbilityFlags</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MergeAthleteAbilityFlags", "GameMain.AthleteSystem.AthleteAbilityFlags", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags[]", 1)]
            public static partial GameMain.AthleteSystem.AthleteAbilityFlags MERGE_ATHLETE_ABILITY_FLAGS(GameMain.AthleteSystem.AthleteAbilityFlags flag, nint flagParam); 
*/
            /// <summary>
            /// static  System.Boolean PredicateAthleteCanUseTraitCard(GameMain.AthleteSystem.Athlete athlete, GameMain.AthleteSystem.TraitBattleCardsSetting setting)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "setting">class GameMain.AthleteSystem.TraitBattleCardsSetting</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PredicateAthleteCanUseTraitCard", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.TraitBattleCardsSetting", 1)]
            public static partial System.Boolean PREDICATE_ATHLETE_CAN_USE_TRAIT_CARD(nint athlete, nint setting); 
*/
            /// <summary>
            /// static  System.Void RandomSetHeroPool(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RandomSetHeroPool", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public static partial void RANDOM_SET_HERO_POOL(nint athlete); 
*/
            /// <summary>
            /// static  System.Void RandomSetNameAndPortrait(GameMain.AthleteSystem.Athlete athlete, System.Boolean forPlayer, GameMain.Gender gender, System.Boolean randomPotrait)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "forPlayer">struct System.Boolean</param>
            /// <param name = "gender">enum GameMain.Gender</param>
            /// <param name = "randomPotrait">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RandomSetNameAndPortrait", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Gender", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public static partial void RANDOM_SET_NAME_AND_PORTRAIT(nint athlete, System.Boolean forPlayer, GameMain.Gender gender, System.Boolean randomPotrait); 
*/
            /// <summary>
            /// static  System.Void RecreateAthleteByAbilityValue(GameMain.AthleteSystem.Athlete athlete, System.Int32 abilityValue, System.Int32 abilityLimit, System.Int32 age, System.Int32 heroPool, System.Int32 heroNum)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "abilityValue">struct System.Int32</param>
            /// <param name = "abilityLimit">struct System.Int32</param>
            /// <param name = "age">struct System.Int32</param>
            /// <param name = "heroPool">struct System.Int32</param>
            /// <param name = "heroNum">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RecreateAthleteByAbilityValue", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
            public static partial void RECREATE_ATHLETE_BY_ABILITY_VALUE(nint athlete, System.Int32 abilityValue, System.Int32 abilityLimit, System.Int32 age, System.Int32 heroPool, System.Int32 heroNum); 
*/
            /// <summary>
            /// static  System.Void RecreateAthleteByTemplate(GameMain.AthleteSystem.Athlete athlete, GameMain.AthleteSystem.AthleteCreateArgument argument, System.Boolean highAbilityRange, System.Collections.Generic.IDictionary<GameMain.UnitSystem.HeroRoleFlags , Utility.Buffers.List<GameMain.AthleteSystem.AthleteTraitSetting>> athleteSelectedPrimeTraitSettings, GameMain.AthleteSystem.AthleteCardCreateArgument cardArgument, GameMain.Gender gender, System.Boolean randomPotrait)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "argument">class GameMain.AthleteSystem.AthleteCreateArgument</param>
            /// <param name = "highAbilityRange">struct System.Boolean</param>
            /// <param name = "athleteSelectedPrimeTraitSettings">interface System.Collections.Generic.IDictionary<GameMain.UnitSystem.HeroRoleFlags , Utility.Buffers.List<GameMain.AthleteSystem.AthleteTraitSetting>></param>
            /// <param name = "cardArgument">class GameMain.AthleteSystem.AthleteCardCreateArgument</param>
            /// <param name = "gender">enum GameMain.Gender</param>
            /// <param name = "randomPotrait">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RecreateAthleteByTemplate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteCreateArgument", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IDictionary<GameMain.UnitSystem.HeroRoleFlags,Utility.Buffers.List<GameMain.AthleteSystem.AthleteTraitSetting>>", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteCardCreateArgument", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Gender", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 6)]
            public static partial void RECREATE_ATHLETE_BY_TEMPLATE(nint athlete, nint argument, System.Boolean highAbilityRange, nint athleteSelectedPrimeTraitSettings, nint cardArgument, GameMain.Gender gender, System.Boolean randomPotrait); 
*/
            /// <summary>
            /// static  System.Void RecreateByScore(GameMain.AthleteSystem.Athlete athlete, System.Double score, System.Collections.Generic.IDictionary<GameMain.UnitSystem.HeroRoleFlags , System.Collections.Generic.List<GameMain.AthleteSystem.Athlete>> selectableAthletes, GameMain.AthleteSystem.Athlete origin, GameMain.Gender gender, System.Boolean randomPotrait)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "score">struct System.Double</param>
            /// <param name = "selectableAthletes">interface System.Collections.Generic.IDictionary<GameMain.UnitSystem.HeroRoleFlags , System.Collections.Generic.List<GameMain.AthleteSystem.Athlete>></param>
            /// <param name = "origin">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "gender">enum GameMain.Gender</param>
            /// <param name = "randomPotrait">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RecreateByScore", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Double", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IDictionary<GameMain.UnitSystem.HeroRoleFlags,System.Collections.Generic.List<GameMain.AthleteSystem.Athlete>>", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Gender", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 5)]
            public static partial void RECREATE_BY_SCORE(nint athlete, System.Double score, nint selectableAthletes, nint origin, GameMain.Gender gender, System.Boolean randomPotrait); 
*/
            /// <summary>
            /// static  System.Void ResetAthleteCardAndTrait(GameMain.AthleteSystem.Athlete athlete, System.Collections.Generic.IDictionary<GameMain.UnitSystem.HeroRoleFlags , Utility.Buffers.List<GameMain.AthleteSystem.AthleteTraitSetting>> athleteSelectedPrimeTraitSettings, GameMain.AthleteSystem.AthleteCardCreateArgument cardArgument, GameMain.Gender gender, System.Boolean randomPotrait)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "athleteSelectedPrimeTraitSettings">interface System.Collections.Generic.IDictionary<GameMain.UnitSystem.HeroRoleFlags , Utility.Buffers.List<GameMain.AthleteSystem.AthleteTraitSetting>></param>
            /// <param name = "cardArgument">class GameMain.AthleteSystem.AthleteCardCreateArgument</param>
            /// <param name = "gender">enum GameMain.Gender</param>
            /// <param name = "randomPotrait">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetAthleteCardAndTrait", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IDictionary<GameMain.UnitSystem.HeroRoleFlags,Utility.Buffers.List<GameMain.AthleteSystem.AthleteTraitSetting>>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteCardCreateArgument", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Gender", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            public static partial void RESET_ATHLETE_CARD_AND_TRAIT(nint athlete, nint athleteSelectedPrimeTraitSettings, nint cardArgument, GameMain.Gender gender, System.Boolean randomPotrait); 
*/
            /// <summary>
            /// static  System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteAbilityFlags> SeparateFlag(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteAbilityFlags></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SeparateFlag", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteAbilityFlags>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 1)]
            public static partial nint SEPARATE_FLAG(GameMain.AthleteSystem.AthleteAbilityFlags flag, nint athlete); 
*/
            /// <summary>
            /// static  System.Void SetAthleteCustom(GameMain.AthleteSystem.Athlete athlete, GameMain.AthleteSystem.CustomAthleteArgument argument, System.Boolean abilityHighRange)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "argument">class GameMain.AthleteSystem.CustomAthleteArgument</param>
            /// <param name = "abilityHighRange">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAthleteCustom", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.CustomAthleteArgument", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial void SET_ATHLETE_CUSTOM(nint athlete, nint argument, System.Boolean abilityHighRange); 
*/
            /// <summary>
            /// static  System.Void SortAthletesByRole(System.Collections.Generic.IList<GameMain.AthleteSystem.Athlete> athletes)
            /// </summary>
            /// <param name = "athletes">interface System.Collections.Generic.IList<GameMain.AthleteSystem.Athlete></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SortAthletesByRole", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IList<GameMain.AthleteSystem.Athlete>", 0)]
            public static partial void SORT_ATHLETES_BY_ROLE(nint athletes); 
*/
            /// <summary>
            /// static  System.Void SortHeroByMastery(GameMain.AthleteSystem.Athlete athlete, System.Collections.Generic.IList<GameMain.UnitSystem.UnitSetting> list)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "list">interface System.Collections.Generic.IList<GameMain.UnitSystem.UnitSetting></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SortHeroByMastery", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IList<GameMain.UnitSystem.UnitSetting>", 1)]
            public static partial void SORT_HERO_BY_MASTERY(nint athlete, nint list); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.Athlete Spawn(GameMain.ClubSystem.Club club, GameMain.AthleteSystem.AthleteSetting setting, System.Guid id, System.Nullable<GameMain.UnitSystem.HeroRoleFlags> role)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <param name = "setting">class GameMain.AthleteSystem.AthleteSetting</param>
            /// <param name = "id">struct System.Guid</param>
            /// <param name = "role">struct System.Nullable<GameMain.UnitSystem.HeroRoleFlags></param>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Spawn", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteSetting", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Nullable<GameMain.UnitSystem.HeroRoleFlags>", 3)]
            public static partial nint SPAWN(nint club, nint setting, System.Guid id, System.Nullable<GameMain.UnitSystem.HeroRoleFlags> role); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.Athlete Spawn(GameMain.ClubSystem.Club club, GameMain.UnitSystem.HeroRoleFlags roleFlags, System.Guid id)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <param name = "roleFlags">enum GameMain.UnitSystem.HeroRoleFlags</param>
            /// <param name = "id">struct System.Guid</param>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Spawn", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroRoleFlags", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 2)]
            public static partial nint SPAWN(nint club, GameMain.UnitSystem.HeroRoleFlags roleFlags, System.Guid id); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.Athlete Spawn(GameMain.UnitSystem.HeroRoleFlags flag, System.Guid id)
            /// </summary>
            /// <param name = "flag">enum GameMain.UnitSystem.HeroRoleFlags</param>
            /// <param name = "id">struct System.Guid</param>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Spawn", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroRoleFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 1)]
            public static partial nint SPAWN(GameMain.UnitSystem.HeroRoleFlags flag, System.Guid id); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.Athlete Spawn(GameMain.ClubSystem.Club club, GameMain.AthleteSystem.AthleteSetting setting)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <param name = "setting">class GameMain.AthleteSystem.AthleteSetting</param>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Spawn", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteSetting", 1)]
            public static partial nint SPAWN(nint club, nint setting); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.Athlete Spawn(GameMain.ClubSystem.Club club, GameMain.AthleteSystem.AthleteInfoSetting setting)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <param name = "setting">class GameMain.AthleteSystem.AthleteInfoSetting</param>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Spawn", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteInfoSetting", 1)]
            public static partial nint SPAWN(nint club, nint setting); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.Athlete Spawn(GameMain.AthleteSystem.Athlete masterCopyAthlete)
            /// </summary>
            /// <param name = "masterCopyAthlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Spawn", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public static partial nint SPAWN(nint masterCopyAthlete); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.Athlete SpawnBySaveData(Utility.GameSystem.SaveSystem.LoadContext context, GameMain.ClubSystem.Club club, GameMain.AthleteSystem.Athlete.SaveData saveData)
            /// </summary>
            /// <param name = "context">class Utility.GameSystem.SaveSystem.LoadContext</param>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <param name = "saveData">class GameMain.AthleteSystem.Athlete.SaveData</param>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SpawnBySaveData", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GameSystem.SaveSystem.LoadContext", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete.SaveData", 2)]
            public static partial nint SPAWN_BY_SAVE_DATA(nint context, nint club, nint saveData); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.Athlete SpawnSimulate(GameMain.ClubSystem.Club club, GameMain.AthleteSystem.Athlete.SaveData_SimulateBattle saveData)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <param name = "saveData">class GameMain.AthleteSystem.Athlete.SaveData_SimulateBattle</param>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SpawnSimulate", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete.SaveData_SimulateBattle", 1)]
            public static partial nint SPAWN_SIMULATE(nint club, nint saveData); 
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
            ///   System.Single <CreateAthletePersonality>b__154_0(GameMain.AthleteSystem.AthletePersonalitySetting s)
            /// </summary>
            /// <param name = "s">class GameMain.AthleteSystem.AthletePersonalitySetting</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<CreateAthletePersonality>b__154_0", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthletePersonalitySetting", 0)]
            public partial System.Single CREATE_ATHLETE_PERSONALITYB__154_0(nint s); 
*/
            /// <summary>
            ///   System.Void CheckComprehendOptions()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckComprehendOptions", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_COMPREHEND_OPTIONS(); 
*/
            /// <summary>
            ///   System.Void CreateAbility()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateAbility", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CREATE_ABILITY(); 
*/
            /// <summary>
            ///   System.Void CreateAthleteEmotion()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateAthleteEmotion", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CREATE_ATHLETE_EMOTION(); 
*/
            /// <summary>
            ///   System.Void CreateAthletePersonality()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateAthletePersonality", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CREATE_ATHLETE_PERSONALITY(); 
*/
            /// <summary>
            ///   System.Void CreateContractPrefer()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateContractPrefer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CREATE_CONTRACT_PREFER(); 
*/
            /// <summary>
            ///   System.Void CreateHeroPool()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateHeroPool", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CREATE_HERO_POOL(); 
*/
            /// <summary>
            ///   System.Void CreatePersonalInfo(System.Boolean forPlayer, System.Int32 fans)
            /// </summary>
            /// <param name = "forPlayer">struct System.Boolean</param>
            /// <param name = "fans">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreatePersonalInfo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void CREATE_PERSONAL_INFO(System.Boolean forPlayer, System.Int32 fans); 
*/
            /// <summary>
            ///   System.Void CreatePersonalityAndEmotion()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreatePersonalityAndEmotion", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CREATE_PERSONALITY_AND_EMOTION(); 
*/
            /// <summary>
            ///   System.String get_Age()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Age", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_AGE(); 
*/
            /// <summary>
            ///   System.Int32 get_AgeValue()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AgeValue", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_AGE_VALUE(); 
*/
            /// <summary>
            ///   System.Double get_AthleteAccuracyBattle()
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AthleteAccuracyBattle", "System.Double", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Double GET_ATHLETE_ACCURACY_BATTLE(); 
*/
            /// <summary>
            ///   System.Double get_AthleteAccuracyFight()
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AthleteAccuracyFight", "System.Double", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Double GET_ATHLETE_ACCURACY_FIGHT(); 
*/
            /// <summary>
            ///   GameMain.UnitSystem.StatisticUnit get_AthleteBattleStatisticData()
            /// </summary>
            /// <returns>struct GameMain.UnitSystem.StatisticUnit</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AthleteBattleStatisticData", "GameMain.UnitSystem.StatisticUnit", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.UnitSystem.StatisticUnit GET_ATHLETE_BATTLE_STATISTIC_DATA(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.UnitSystem.StatisticUnit> get_AthleteBattleStatisticDatas()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.UnitSystem.StatisticUnit></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AthleteBattleStatisticDatas", "System.Collections.Generic.List<GameMain.UnitSystem.StatisticUnit>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATHLETE_BATTLE_STATISTIC_DATAS(); 
*/
            /// <summary>
            ///   System.Double get_AthleteEcoEfficiency()
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AthleteEcoEfficiency", "System.Double", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Double GET_ATHLETE_ECO_EFFICIENCY(); 
*/
            /// <summary>
            ///   System.Double get_AthleteEcoTransferEfficiency()
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AthleteEcoTransferEfficiency", "System.Double", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Double GET_ATHLETE_ECO_TRANSFER_EFFICIENCY(); 
*/
            /// <summary>
            ///   System.Double get_AthleteEcoTransferEfficiencyAttack()
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AthleteEcoTransferEfficiencyAttack", "System.Double", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Double GET_ATHLETE_ECO_TRANSFER_EFFICIENCY_ATTACK(); 
*/
            /// <summary>
            ///   System.Double get_AthleteEcoTransferEfficiencyDefense()
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AthleteEcoTransferEfficiencyDefense", "System.Double", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Double GET_ATHLETE_ECO_TRANSFER_EFFICIENCY_DEFENSE(); 
*/
            /// <summary>
            ///   System.Double get_AthleteEvasionBattle()
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AthleteEvasionBattle", "System.Double", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Double GET_ATHLETE_EVASION_BATTLE(); 
*/
            /// <summary>
            ///   System.Double get_AthleteEvasionFight()
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AthleteEvasionFight", "System.Double", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Double GET_ATHLETE_EVASION_FIGHT(); 
*/
            /// <summary>
            ///   System.Double get_AthleteFightSpeed()
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AthleteFightSpeed", "System.Double", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Double GET_ATHLETE_FIGHT_SPEED(); 
*/
            /// <summary>
            ///   System.String get_AthleteName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AthleteName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATHLETE_NAME(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.UnitSystem.Unit> get_BanPickHeroes()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.UnitSystem.Unit></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BanPickHeroes", "System.Collections.Generic.List<GameMain.UnitSystem.Unit>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BAN_PICK_HEROES(); 
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
            ///   GameMain.BattleSystem.BattleTeam get_BattleTeam()
            /// </summary>
            /// <returns>class GameMain.BattleSystem.BattleTeam</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BattleTeam", "GameMain.BattleSystem.BattleTeam", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BATTLE_TEAM(); 
*/
            /// <summary>
            ///   GameMain.BattleSystem.BattleTeam get_BattleTeamAuto()
            /// </summary>
            /// <returns>class GameMain.BattleSystem.BattleTeam</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BattleTeamAuto", "GameMain.BattleSystem.BattleTeam", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BATTLE_TEAM_AUTO(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.Athlete.DataComponent get_C_Data()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.Athlete.DataComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Data", "GameMain.AthleteSystem.Athlete.DataComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_DATA(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.Athlete.LogicComponent get_C_Logic()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.Athlete.LogicComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Logic", "GameMain.AthleteSystem.Athlete.LogicComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_LOGIC(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.Athlete.MilestoneComponent get_C_Milestone()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.Athlete.MilestoneComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Milestone", "GameMain.AthleteSystem.Athlete.MilestoneComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_MILESTONE(); 
*/
            /// <summary>
            ///   Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.AthleteSystem.Athlete , LogicFramework.LogicEntity_Athlete , GameMain.AthleteSystem.AthleteSetting> get_C_Setting()
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.AthleteSystem.Athlete , LogicFramework.LogicEntity_Athlete , GameMain.AthleteSystem.AthleteSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Setting", "Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.AthleteSystem.Athlete,LogicFramework.LogicEntity_Athlete,GameMain.AthleteSystem.AthleteSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_SETTING(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AthleteStatusComponent get_C_Status()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.AthleteStatusComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Status", "GameMain.AthleteSystem.AthleteStatusComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_STATUS(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.Athlete.TraitsComponent get_C_Traits()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.Athlete.TraitsComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Traits", "GameMain.AthleteSystem.Athlete.TraitsComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_TRAITS(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.Club get_Club()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Club", "GameMain.ClubSystem.Club", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CLUB(); 
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
            ///   GameMain.AthleteSystem.AthleteGeneralSetting get_GeneralSetting()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.AthleteGeneralSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GeneralSetting", "GameMain.AthleteSystem.AthleteGeneralSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_GENERAL_SETTING(); 
*/
            /// <summary>
            ///   GameMain.UnitSystem.Unit get_Hero()
            /// </summary>
            /// <returns>class GameMain.UnitSystem.Unit</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Hero", "GameMain.UnitSystem.Unit", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO(); 
*/
            /// <summary>
            ///   GameMain.UnitSystem.Unit get_HeroAuto()
            /// </summary>
            /// <returns>class GameMain.UnitSystem.Unit</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_HeroAuto", "GameMain.UnitSystem.Unit", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO_AUTO(); 
*/
            /// <summary>
            ///   GameMain.UnitSystem.HeroRoleFlags get_HeroRole()
            /// </summary>
            /// <returns>enum GameMain.UnitSystem.HeroRoleFlags</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_HeroRole", "GameMain.UnitSystem.HeroRoleFlags", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.UnitSystem.HeroRoleFlags GET_HERO_ROLE(); 
*/
            /// <summary>
            ///   System.Boolean get_IsScrimmage()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsScrimmage", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_SCRIMMAGE(); 
*/
            /// <summary>
            ///   System.Boolean get_IsSubstitute()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsSubstitute", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_SUBSTITUTE(); 
*/
            /// <summary>
            ///   System.Boolean get_IsYouth()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsYouth", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_YOUTH(); 
*/
            /// <summary>
            ///   System.String get_Portrait_FullBody()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Portrait_FullBody", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PORTRAIT_FULL_BODY(); 
*/
            /// <summary>
            ///   System.String get_Portrait_Head()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Portrait_Head", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PORTRAIT_HEAD(); 
*/
            /// <summary>
            ///   System.String get_Portrait_HeadHex()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Portrait_HeadHex", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PORTRAIT_HEAD_HEX(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AthleteSetting get_Setting()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.AthleteSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Setting", "GameMain.AthleteSystem.AthleteSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SETTING(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteBreakthroughTaskSetting> GetBreakthroughOptions()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteBreakthroughTaskSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBreakthroughOptions", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteBreakthroughTaskSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BREAKTHROUGH_OPTIONS(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.TraitBattleCardsSetting> GetComprehendOptions()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.TraitBattleCardsSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComprehendOptions", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.TraitBattleCardsSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPREHEND_OPTIONS(); 
*/
            /// <summary>
            ///   System.String GetName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NAME(); 
*/
            /// <summary>
            ///   System.Void OnAddAthleteEmotion(GameMain.AthleteSystem.AthleteEmotion emotion)
            /// </summary>
            /// <param name = "emotion">class GameMain.AthleteSystem.AthleteEmotion</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddAthleteEmotion", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteEmotion", 0)]
            public partial void ON_ADD_ATHLETE_EMOTION(nint emotion); 
*/
            /// <summary>
            ///   System.Void OnAddAthleteTrait(GameMain.AthleteSystem.AthleteTrait athleteTrait, System.Int32 primeIndex)
            /// </summary>
            /// <param name = "athleteTrait">class GameMain.AthleteSystem.AthleteTrait</param>
            /// <param name = "primeIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddAthleteTrait", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteTrait", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ON_ADD_ATHLETE_TRAIT(nint athleteTrait, System.Int32 primeIndex); 
*/
            /// <summary>
            ///   System.Void OnAddToBattleTeam(GameMain.BattleSystem.BattleTeam battleTeam, System.Boolean isAuto)
            /// </summary>
            /// <param name = "battleTeam">class GameMain.BattleSystem.BattleTeam</param>
            /// <param name = "isAuto">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddToBattleTeam", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.BattleSystem.BattleTeam", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ON_ADD_TO_BATTLE_TEAM(nint battleTeam, System.Boolean isAuto); 
*/
            /// <summary>
            ///   System.Void OnAddToClub(GameMain.ClubSystem.Club club)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddToClub", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            public partial void ON_ADD_TO_CLUB(nint club); 
*/
            /// <summary>
            ///   System.Void OnAddUnit(GameMain.UnitSystem.Unit unit, System.Boolean isBanPick, System.Boolean isAuto)
            /// </summary>
            /// <param name = "unit">class GameMain.UnitSystem.Unit</param>
            /// <param name = "isBanPick">struct System.Boolean</param>
            /// <param name = "isAuto">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddUnit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.Unit", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void ON_ADD_UNIT(nint unit, System.Boolean isBanPick, System.Boolean isAuto); 
*/
            /// <summary>
            ///   System.Void OnBreakthroughEnd()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnBreakthroughEnd", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_BREAKTHROUGH_END(); 
*/
            /// <summary>
            ///   System.Void OnBreakthroughSelectEnd(GameMain.AthleteSystem.AthleteBreakthroughTaskSetting taskSetting)
            /// </summary>
            /// <param name = "taskSetting">class GameMain.AthleteSystem.AthleteBreakthroughTaskSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnBreakthroughSelectEnd", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteBreakthroughTaskSetting", 0)]
            public partial void ON_BREAKTHROUGH_SELECT_END(nint taskSetting); 
*/
            /// <summary>
            ///   System.Void OnBreakthroughSelectStart()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnBreakthroughSelectStart", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_BREAKTHROUGH_SELECT_START(); 
*/
            /// <summary>
            ///   System.Void OnComprehendEnd(System.Boolean isSpecial)
            /// </summary>
            /// <param name = "isSpecial">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnComprehendEnd", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void ON_COMPREHEND_END(System.Boolean isSpecial); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubAffairAthleteComprehend OnComprehendStart(System.Boolean isSpecial)
            /// </summary>
            /// <param name = "isSpecial">struct System.Boolean</param>
            /// <returns>class GameMain.ClubSystem.ClubAffairAthleteComprehend</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnComprehendStart", "GameMain.ClubSystem.ClubAffairAthleteComprehend", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint ON_COMPREHEND_START(System.Boolean isSpecial); 
*/
            /// <summary>
            ///   System.Void OnRemoveAthleteEmotion()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveAthleteEmotion", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_REMOVE_ATHLETE_EMOTION(); 
*/
            /// <summary>
            ///   System.Void OnRemoveAthleteTrait(GameMain.AthleteSystem.AthleteTrait athleteTrait)
            /// </summary>
            /// <param name = "athleteTrait">class GameMain.AthleteSystem.AthleteTrait</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveAthleteTrait", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteTrait", 0)]
            public partial void ON_REMOVE_ATHLETE_TRAIT(nint athleteTrait); 
*/
            /// <summary>
            ///   System.Void OnRemovedFromBattleTeam(System.Boolean isAuto)
            /// </summary>
            /// <param name = "isAuto">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemovedFromBattleTeam", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void ON_REMOVED_FROM_BATTLE_TEAM(System.Boolean isAuto); 
*/
            /// <summary>
            ///   System.Void OnRemovedFromClub()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemovedFromClub", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_REMOVED_FROM_CLUB(); 
*/
            /// <summary>
            ///   System.Void OnRemoveUnit(GameMain.UnitSystem.Unit unit, System.Boolean isBanPick)
            /// </summary>
            /// <param name = "unit">class GameMain.UnitSystem.Unit</param>
            /// <param name = "isBanPick">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveUnit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.Unit", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ON_REMOVE_UNIT(nint unit, System.Boolean isBanPick); 
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
            ///   System.Void set_AthleteBattleStatisticData(GameMain.UnitSystem.StatisticUnit value)
            /// </summary>
            /// <param name = "value">struct GameMain.UnitSystem.StatisticUnit</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AthleteBattleStatisticData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.StatisticUnit", 0)]
            public partial void SET_ATHLETE_BATTLE_STATISTIC_DATA(GameMain.UnitSystem.StatisticUnit value); 
*/
            /// <summary>
            ///   System.Void set_BattleTeam(GameMain.BattleSystem.BattleTeam value)
            /// </summary>
            /// <param name = "value">class GameMain.BattleSystem.BattleTeam</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BattleTeam", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.BattleSystem.BattleTeam", 0)]
            public partial void SET_BATTLE_TEAM(nint value); 
*/
            /// <summary>
            ///   System.Void set_BattleTeamAuto(GameMain.BattleSystem.BattleTeam value)
            /// </summary>
            /// <param name = "value">class GameMain.BattleSystem.BattleTeam</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BattleTeamAuto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.BattleSystem.BattleTeam", 0)]
            public partial void SET_BATTLE_TEAM_AUTO(nint value); 
*/
            /// <summary>
            ///   System.Void set_C_Traits(GameMain.AthleteSystem.Athlete.TraitsComponent value)
            /// </summary>
            /// <param name = "value">class GameMain.AthleteSystem.Athlete.TraitsComponent</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_C_Traits", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete.TraitsComponent", 0)]
            public partial void SET_C_TRAITS(nint value); 
*/
            /// <summary>
            ///   System.Void set_Club(GameMain.ClubSystem.Club value)
            /// </summary>
            /// <param name = "value">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Club", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            public partial void SET_CLUB(nint value); 
*/
            /// <summary>
            ///   System.Void set_Hero(GameMain.UnitSystem.Unit value)
            /// </summary>
            /// <param name = "value">class GameMain.UnitSystem.Unit</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Hero", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.Unit", 0)]
            public partial void SET_HERO(nint value); 
*/
            /// <summary>
            ///   System.Void set_HeroAuto(GameMain.UnitSystem.Unit value)
            /// </summary>
            /// <param name = "value">class GameMain.UnitSystem.Unit</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_HeroAuto", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.Unit", 0)]
            public partial void SET_HERO_AUTO(nint value); 
*/
            /// <summary>
            ///   System.Void set_HeroRole(GameMain.UnitSystem.HeroRoleFlags value)
            /// </summary>
            /// <param name = "value">enum GameMain.UnitSystem.HeroRoleFlags</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_HeroRole", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroRoleFlags", 0)]
            public partial void SET_HERO_ROLE(GameMain.UnitSystem.HeroRoleFlags value); 
*/
            /// <summary>
            ///   System.Void set_IsScrimmage(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsScrimmage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_IS_SCRIMMAGE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void SetClub(GameMain.ClubSystem.Club club)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetClub", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            public partial void SET_CLUB(nint club); 
*/
            /// <summary>
            ///   System.Void SetHeroRole(GameMain.UnitSystem.HeroRoleFlags flag)
            /// </summary>
            /// <param name = "flag">enum GameMain.UnitSystem.HeroRoleFlags</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHeroRole", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroRoleFlags", 0)]
            public partial void SET_HERO_ROLE(GameMain.UnitSystem.HeroRoleFlags flag); 
*/
            /// <summary>
            ///   System.Void SetName(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetName", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_NAME(nint name); 
*/
            /// <summary>
            ///   LogicFramework.LogicEntity_Athlete SpawnEntity()
            /// </summary>
            /// <returns>class LogicFramework.LogicEntity_Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SpawnEntity", "LogicFramework.LogicEntity_Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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
        }

        /// <summary>
        /// abstract class ["Utility"."Utility.GeneralObject"."GeneralObject"]
        /// </summary>
        public unsafe readonly partial struct Ptr_Athlete
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
        /// abstract class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."LogicObject`1"]
        /// </summary>
        public unsafe readonly partial struct Ptr_Athlete
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
        public unsafe readonly partial struct Ptr_Athlete
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
            ///   LogicFramework.LogicEntity_Athlete get_Entity()
            /// </summary>
            /// <returns>class LogicFramework.LogicEntity_Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Entity", "LogicFramework.LogicEntity_Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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
            ///   System.Void set_Entity(LogicFramework.LogicEntity_Athlete value)
            /// </summary>
            /// <param name = "value">class LogicFramework.LogicEntity_Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Entity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("LogicFramework.LogicEntity_Athlete", 0)]
            public partial void SET_ENTITY(nint value); 
*/
            /// <summary>
            ///  abstract LogicFramework.LogicEntity_Athlete SpawnEntity()
            /// </summary>
            /// <returns>class LogicFramework.LogicEntity_Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SpawnEntity", "LogicFramework.LogicEntity_Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public abstract partial nint SPAWN_ENTITY(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."LogicObject"]
        /// </summary>
        public unsafe readonly partial struct Ptr_Athlete
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
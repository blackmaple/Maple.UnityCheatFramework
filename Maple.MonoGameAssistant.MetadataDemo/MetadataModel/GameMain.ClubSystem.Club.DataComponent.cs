namespace Maple.MonoGameAssistant.MetadataDemo.MetadataModel
{
    /// <summary>
    /// class ["Assembly-CSharp".""."DataComponent"]
    /// [Utility.GameSystem.LogicFrameworkX.LogicObject.BaseDataComponent<GameMain.ClubSystem.Club , LogicFramework.LogicEntity_Club , GameMain.ClubSystem.Club.SaveData>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject.BaseDataComponent<GameMain.ClubSystem.Club , LogicFramework.LogicEntity_Club>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject.BaseComponent<GameMain.ClubSystem.Club , LogicFramework.LogicEntity_Club>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject.BaseComponent<GameMain.ClubSystem.Club>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject.BaseComponent]=>[Utility.GeneralObject.GeneralObject.BaseComponent]=>[System.Object]
    /// [GameMain.Career.IImplementClubToData]=>[GameMain.Career.IOperationClub]=>[GameMain.Career.IImplementAthleteToData]=>[GameMain.Career.IOperationAthlete]
    /// </summary>
    [MetadataExtensions.MetadataGenerator.ClassParentMetadata<MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_DataComponent>, Ptr_DataComponent>]
    [MetadataExtensions.MetadataGenerator.ClassModelMetadata("Assembly-CSharp", "", "DataComponent", "GameMain.ClubSystem.Club.DataComponent")]
    public partial class DataComponent
    {
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_DataComponent(nint ptr) : MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint m_Pointer = ptr;
            public nint Ptr => m_Pointer;

            public static implicit operator Ptr_DataComponent(nint ptr) => new Ptr_DataComponent(ptr);
            public static implicit operator nint(Ptr_DataComponent ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_DataComponent ptr) => ptr.m_Pointer != nint.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."DataComponent"]
        /// </summary>
        public unsafe readonly partial struct Ptr_DataComponent
        {
            /// <summary>
            /// 0x10 System.String <Name>k__BackingField
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Name>k__BackingField", "System.String")]
           public partial nint NAME { get; set; } 
*/

            /// <summary>
            /// 0x18 Utility.GeneralObject.GeneralObject <Obj>k__BackingField
            /// abstract class ["Utility"."Utility.GeneralObject"."GeneralObject"]
            /// </summary>
            /// <returns>abstract class Utility.GeneralObject.GeneralObject</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Obj>k__BackingField", "Utility.GeneralObject.GeneralObject")]
           public partial nint OBJ { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Boolean <IsActive>k__BackingField
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<IsActive>k__BackingField", "System.Boolean")]
           public partial System.Boolean IS_ACTIVE { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Int32 <Utility.PoolSystem.IPoolItem.SpawnId>k__BackingField
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Utility.PoolSystem.IPoolItem.SpawnId>k__BackingField", "System.Int32")]
           public partial System.Int32 UTILITY_POOL_SYSTEM_I_POOL_ITEM_SPAWN_ID { get; set; } 
*/

            /// <summary>
            /// 0x28 GameMain.ClubSystem.ClubInfoData infoData
            /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."ClubInfoData"]
            /// </summary>
            /// <returns>struct GameMain.ClubSystem.ClubInfoData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("infoData", "GameMain.ClubSystem.ClubInfoData")]
           public partial GameMain.ClubSystem.ClubInfoData INFO_DATA { get; set; } 
*/

            /// <summary>
            /// 0x138 GameMain.ClubSystem.ClubAthleteData athleteData
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."ClubAthleteData"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.ClubAthleteData</returns>

            [MetadataExtensions.MetadataGenerator.ClassPropertyMetadata("athleteData", "GameMain.ClubSystem.ClubAthleteData")]
            public partial ClubAthleteData.Ptr_ClubAthleteData ATHLETE_DATA { get; }


            /// <summary>
            /// 0x140 System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubAffairTypes , GameMain.ClubSystem.ClubAffairExpData> clubAffairExpDict
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubAffairTypes , GameMain.ClubSystem.ClubAffairExpData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("clubAffairExpDict", "System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubAffairTypes,GameMain.ClubSystem.ClubAffairExpData>")]
           public partial nint CLUB_AFFAIR_EXP_DICT { get; set; } 
*/

            /// <summary>
            /// 0x148 GameMain.ClubSystem.ClubEffect effectFestival
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."ClubEffect"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.ClubEffect</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("effectFestival", "GameMain.ClubSystem.ClubEffect")]
           public partial nint EFFECT_FESTIVAL { get; set; } 
*/

            /// <summary>
            /// 0x150 GameMain.ClubSystem.ClubEffect effectWeekly
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."ClubEffect"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.ClubEffect</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("effectWeekly", "GameMain.ClubSystem.ClubEffect")]
           public partial nint EFFECT_WEEKLY { get; set; } 
*/

            /// <summary>
            /// 0x158 GameMain.Career.CareerClub career
            /// class ["Assembly-CSharp"."GameMain.Career"."CareerClub"]
            /// </summary>
            /// <returns>class GameMain.Career.CareerClub</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("career", "GameMain.Career.CareerClub")]
           public partial nint CAREER { get; set; } 
*/

            /// <summary>
            /// 0x160 UnityEngine.Texture2D <SimulateLogo>k__BackingField
            /// class ["UnityEngine.CoreModule"."UnityEngine"."Texture2D"]
            /// </summary>
            /// <returns>class UnityEngine.Texture2D</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<SimulateLogo>k__BackingField", "UnityEngine.Texture2D")]
           public partial nint SIMULATE_LOGO { get; set; } 
*/

            /// <summary>
            /// 0x168 System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairMonthlyPlanSetting> <UnlockMonthlyPlanSettingSet>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairMonthlyPlanSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<UnlockMonthlyPlanSettingSet>k__BackingField", "System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairMonthlyPlanSetting>")]
           public partial nint UNLOCK_MONTHLY_PLAN_SETTING_SET { get; set; } 
*/

            /// <summary>
            /// 0x170 System.Collections.Generic.List<GameMain.ClubSystem.MonthlyPlan> monthlyPlans
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.MonthlyPlan></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthlyPlans", "System.Collections.Generic.List<GameMain.ClubSystem.MonthlyPlan>")]
           public partial nint MONTHLY_PLANS { get; set; } 
*/

            /// <summary>
            /// 0x178 System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairMonthlyPlanSetting> tempMonthlyPlanSettings
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairMonthlyPlanSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tempMonthlyPlanSettings", "System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairMonthlyPlanSetting>")]
           public partial nint TEMP_MONTHLY_PLAN_SETTINGS { get; set; } 
*/

            /// <summary>
            /// 0x180 System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubAffairMonthlyPlanSetting , System.ValueTuple<GameMain.ClubSystem.ClubRewardSetting , GameMain.ClubSystem.ClubRewardSetting , GameMain.ClubSystem.ClubRewardSetting>> aClubClassMonthlyPlanReward
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubAffairMonthlyPlanSetting , System.ValueTuple<GameMain.ClubSystem.ClubRewardSetting , GameMain.ClubSystem.ClubRewardSetting , GameMain.ClubSystem.ClubRewardSetting>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("aClubClassMonthlyPlanReward", "System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubAffairMonthlyPlanSetting,System.ValueTuple<GameMain.ClubSystem.ClubRewardSetting,GameMain.ClubSystem.ClubRewardSetting,GameMain.ClubSystem.ClubRewardSetting>>")]
           public partial nint A_CLUB_CLASS_MONTHLY_PLAN_REWARD { get; set; } 
*/

            /// <summary>
            /// 0x188 System.Collections.Generic.List<GameMain.ClubSystem.TrainingGroup> trainingGroups
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.TrainingGroup></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("trainingGroups", "System.Collections.Generic.List<GameMain.ClubSystem.TrainingGroup>")]
           public partial nint TRAINING_GROUPS { get; set; } 
*/

            /// <summary>
            /// 0x190 System.Collections.Generic.HashSet<GameMain.ClubSystem.TrainingGroup> newTrainingGroups
            /// class ["System.Core"."System.Collections.Generic"."HashSet`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.HashSet<GameMain.ClubSystem.TrainingGroup></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("newTrainingGroups", "System.Collections.Generic.HashSet<GameMain.ClubSystem.TrainingGroup>")]
           public partial nint NEW_TRAINING_GROUPS { get; set; } 
*/

            /// <summary>
            /// 0x198 GameMain.ClubSystem.TrainingTable trainingTable
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."TrainingTable"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.TrainingTable</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("trainingTable", "GameMain.ClubSystem.TrainingTable")]
           public partial nint TRAINING_TABLE { get; set; } 
*/

            /// <summary>
            /// 0x1A0 System.Collections.Generic.Dictionary<GameMain.AthleteSystem.AthleteAbilityFlags , GameMain.ClubSystem.AbilityExpData> abilityExpDict
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.AthleteSystem.AthleteAbilityFlags , GameMain.ClubSystem.AbilityExpData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("abilityExpDict", "System.Collections.Generic.Dictionary<GameMain.AthleteSystem.AthleteAbilityFlags,GameMain.ClubSystem.AbilityExpData>")]
           public partial nint ABILITY_EXP_DICT { get; set; } 
*/

            /// <summary>
            /// 0x1A8 System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairAdvancedTrainingItemSetting> advancedTrainingItemSettings
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairAdvancedTrainingItemSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("advancedTrainingItemSettings", "System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairAdvancedTrainingItemSetting>")]
           public partial nint ADVANCED_TRAINING_ITEM_SETTINGS { get; set; } 
*/

            /// <summary>
            /// 0x1B0 System.Collections.Generic.List<GameMain.ClubSystem.AdvancedTrainingData> advancedTrainingDatas
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.AdvancedTrainingData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("advancedTrainingDatas", "System.Collections.Generic.List<GameMain.ClubSystem.AdvancedTrainingData>")]
           public partial nint ADVANCED_TRAINING_DATAS { get; set; } 
*/

            /// <summary>
            /// 0x1B8 GameMain.ClubSystem.ClubUpgradeItemData upgradeItemData
            /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."ClubUpgradeItemData"]
            /// </summary>
            /// <returns>struct GameMain.ClubSystem.ClubUpgradeItemData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("upgradeItemData", "GameMain.ClubSystem.ClubUpgradeItemData")]
           public partial GameMain.ClubSystem.ClubUpgradeItemData UPGRADE_ITEM_DATA { get; set; } 
*/

            /// <summary>
            /// 0x1D0 System.Collections.Generic.HashSet<GameMain.ClubSystem.ClubAffairUpgradeItemSetting> completedUpgradeItemSettings
            /// class ["System.Core"."System.Collections.Generic"."HashSet`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.HashSet<GameMain.ClubSystem.ClubAffairUpgradeItemSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("completedUpgradeItemSettings", "System.Collections.Generic.HashSet<GameMain.ClubSystem.ClubAffairUpgradeItemSetting>")]
           public partial nint COMPLETED_UPGRADE_ITEM_SETTINGS { get; set; } 
*/

            /// <summary>
            /// 0x1D8 System.Collections.Generic.HashSet<GameMain.ClubSystem.ClubAffairUpgradeItemSetting> unlockedUpgradeItemSettings
            /// class ["System.Core"."System.Collections.Generic"."HashSet`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.HashSet<GameMain.ClubSystem.ClubAffairUpgradeItemSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("unlockedUpgradeItemSettings", "System.Collections.Generic.HashSet<GameMain.ClubSystem.ClubAffairUpgradeItemSetting>")]
           public partial nint UNLOCKED_UPGRADE_ITEM_SETTINGS { get; set; } 
*/

            /// <summary>
            /// 0x1E0 System.Collections.Generic.List<GameMain.ClubSystem.ClubDialogueData> dialogueDatas
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.ClubDialogueData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("dialogueDatas", "System.Collections.Generic.List<GameMain.ClubSystem.ClubDialogueData>")]
           public partial nint DIALOGUE_DATAS { get; set; } 
*/

            /// <summary>
            /// 0x1E8 System.Collections.Generic.Dictionary<System.String , System.Int32> newsCooldown
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("newsCooldown", "System.Collections.Generic.Dictionary<System.String,System.Int32>")]
           public partial nint NEWS_COOLDOWN { get; set; } 
*/

            /// <summary>
            /// 0x1F0 System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairTrashTalkSetting> selectedTrashTalkSettings
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairTrashTalkSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("selectedTrashTalkSettings", "System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairTrashTalkSetting>")]
           public partial nint SELECTED_TRASH_TALK_SETTINGS { get; set; } 
*/

            /// <summary>
            /// 0x1F8 GameMain.ClubSystem.ClubTrashTalkData trashTalkData
            /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."ClubTrashTalkData"]
            /// </summary>
            /// <returns>struct GameMain.ClubSystem.ClubTrashTalkData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("trashTalkData", "GameMain.ClubSystem.ClubTrashTalkData")]
           public partial GameMain.ClubSystem.ClubTrashTalkData TRASH_TALK_DATA { get; set; } 
*/

            /// <summary>
            /// 0x208 System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubEventSwitchSetting , GameMain.Procedure.DataEvent> eventDataDict
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubEventSwitchSetting , GameMain.Procedure.DataEvent></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("eventDataDict", "System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubEventSwitchSetting,GameMain.Procedure.DataEvent>")]
           public partial nint EVENT_DATA_DICT { get; set; } 
*/

            /// <summary>
            /// 0x210 System.Collections.Generic.List<GameMain.Procedure.DataEvent> delayedEvents
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.Procedure.DataEvent></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("delayedEvents", "System.Collections.Generic.List<GameMain.Procedure.DataEvent>")]
           public partial nint DELAYED_EVENTS { get; set; } 
*/

            /// <summary>
            /// 0x218 System.Collections.Generic.HashSet<System.String> selectedOptionKeys
            /// class ["System.Core"."System.Collections.Generic"."HashSet`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.HashSet<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("selectedOptionKeys", "System.Collections.Generic.HashSet<System.String>")]
           public partial nint SELECTED_OPTION_KEYS { get; set; } 
*/

            /// <summary>
            /// 0x220 System.Collections.Generic.List<GameMain.ClubSystem.RecordScrimmageClub> scrimmageData
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.RecordScrimmageClub></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("scrimmageData", "System.Collections.Generic.List<GameMain.ClubSystem.RecordScrimmageClub>")]
           public partial nint SCRIMMAGE_DATA { get; set; } 
*/

            /// <summary>
            /// 0x228 System.Collections.Generic.List<GameMain.ClubSystem.ClubCompetitionData> competitionData
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.ClubCompetitionData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("competitionData", "System.Collections.Generic.List<GameMain.ClubSystem.ClubCompetitionData>")]
           public partial nint COMPETITION_DATA { get; set; } 
*/

            /// <summary>
            /// 0x230 System.Collections.Generic.Dictionary<System.Guid , System.Int32> SeasonStartFans
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Guid , System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SeasonStartFans", "System.Collections.Generic.Dictionary<System.Guid,System.Int32>")]
           public partial nint SEASON_START_FANS { get; set; } 
*/

            /// <summary>
            /// 0x238 GameMain.ClubSystem.MatchShowSupportData matchShowSupportData
            /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."MatchShowSupportData"]
            /// </summary>
            /// <returns>struct GameMain.ClubSystem.MatchShowSupportData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("matchShowSupportData", "GameMain.ClubSystem.MatchShowSupportData")]
           public partial GameMain.ClubSystem.MatchShowSupportData MATCH_SHOW_SUPPORT_DATA { get; set; } 
*/

            /// <summary>
            /// 0x250 GameMain.ClubSystem.ClubAssistantDialogueSetting dialogSetting
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."ClubAssistantDialogueSetting"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.ClubAssistantDialogueSetting</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("dialogSetting", "GameMain.ClubSystem.ClubAssistantDialogueSetting")]
           public partial nint DIALOG_SETTING { get; set; } 
*/

            /// <summary>
            /// 0x258 System.Collections.Generic.HashSet<GameMain.ClubSystem.CoachCareer> coachCareers
            /// class ["System.Core"."System.Collections.Generic"."HashSet`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.HashSet<GameMain.ClubSystem.CoachCareer></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("coachCareers", "System.Collections.Generic.HashSet<GameMain.ClubSystem.CoachCareer>")]
           public partial nint COACH_CAREERS { get; set; } 
*/

            /// <summary>
            /// 0x260 GameMain.ClubSystem.ClubAffairSponsorSetting signedSponsor
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."ClubAffairSponsorSetting"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.ClubAffairSponsorSetting</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("signedSponsor", "GameMain.ClubSystem.ClubAffairSponsorSetting")]
           public partial nint SIGNED_SPONSOR { get; set; } 
*/

            /// <summary>
            /// 0x268 System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags , System.Int32> <HpWarningPercentage>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags , System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<HpWarningPercentage>k__BackingField", "System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags,System.Int32>")]
           public partial nint HP_WARNING_PERCENTAGE { get; set; } 
*/

            /// <summary>
            /// 0x270 System.Collections.Generic.List<GameMain.MatchSystem.MatchMedalSetting> <MatchMedals>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.MatchSystem.MatchMedalSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<MatchMedals>k__BackingField", "System.Collections.Generic.List<GameMain.MatchSystem.MatchMedalSetting>")]
           public partial nint MATCH_MEDALS { get; set; } 
*/

            /// <summary>
            /// 0x278 System.Collections.Generic.Dictionary<GameMain.AthleteSystem.Athlete , System.Int32> <ClubAttitudes>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.AthleteSystem.Athlete , System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ClubAttitudes>k__BackingField", "System.Collections.Generic.Dictionary<GameMain.AthleteSystem.Athlete,System.Int32>")]
           public partial nint CLUB_ATTITUDES { get; set; } 
*/

            /// <summary>
            /// 0x280 System.Collections.Generic.List<GameMain.AthleteSystem.Athlete> <MatchAthletes>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.Athlete></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<MatchAthletes>k__BackingField", "System.Collections.Generic.List<GameMain.AthleteSystem.Athlete>")]
           public partial nint MATCH_ATHLETES { get; set; } 
*/

            /// <summary>
            /// 0x288 GameMain.ClubSystem.Stadium <Stadium>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."Stadium"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Stadium</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Stadium>k__BackingField", "GameMain.ClubSystem.Stadium")]
           public partial nint STADIUM { get; set; } 
*/

            /// <summary>
            /// 0x290 System.Collections.Generic.List<GameMain.ClubSystem.StadiumData> <StadiumDataList>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.StadiumData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<StadiumDataList>k__BackingField", "System.Collections.Generic.List<GameMain.ClubSystem.StadiumData>")]
           public partial nint STADIUM_DATA_LIST { get; set; } 
*/

            /// <summary>
            /// 0x298 System.Collections.Generic.List<GameMain.ClubSystem.StadiumBuildingSetting> <StadiumBuildingStorage>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.StadiumBuildingSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<StadiumBuildingStorage>k__BackingField", "System.Collections.Generic.List<GameMain.ClubSystem.StadiumBuildingSetting>")]
           public partial nint STADIUM_BUILDING_STORAGE { get; set; } 
*/

            /// <summary>
            /// 0x2A0 System.Collections.Generic.List<GameMain.ClubSystem.StadiumBuildingSetting> <StadiumBuildingStorageTemp>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.StadiumBuildingSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<StadiumBuildingStorageTemp>k__BackingField", "System.Collections.Generic.List<GameMain.ClubSystem.StadiumBuildingSetting>")]
           public partial nint STADIUM_BUILDING_STORAGE_TEMP { get; set; } 
*/

            /// <summary>
            /// 0x2A8 System.Collections.Generic.List<GameMain.ClubSystem.StadiumSetting> <StadiumStorage>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.StadiumSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<StadiumStorage>k__BackingField", "System.Collections.Generic.List<GameMain.ClubSystem.StadiumSetting>")]
           public partial nint STADIUM_STORAGE { get; set; } 
*/

            /// <summary>
            /// 0x2B0 System.Collections.Generic.List<GameMain.ClubSystem.SwayChip> <SwayChips>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.SwayChip></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<SwayChips>k__BackingField", "System.Collections.Generic.List<GameMain.ClubSystem.SwayChip>")]
           public partial nint SWAY_CHIPS { get; set; } 
*/

            /// <summary>
            /// 0x2B8 GameMain.ClubSystem.YouthScout <Scout>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."YouthScout"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.YouthScout</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Scout>k__BackingField", "GameMain.ClubSystem.YouthScout")]
           public partial nint SCOUT { get; set; } 
*/

            /// <summary>
            /// 0x2C0 GameMain.ClubSystem.YouthScoutSearchingData <SearchingData>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."YouthScoutSearchingData"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.YouthScoutSearchingData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<SearchingData>k__BackingField", "GameMain.ClubSystem.YouthScoutSearchingData")]
           public partial nint SEARCHING_DATA { get; set; } 
*/

            /// <summary>
            /// 0x2C8 GameMain.ClubSystem.ClubCandidateFollowAI <CandidateFollowAI>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."ClubCandidateFollowAI"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.ClubCandidateFollowAI</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CandidateFollowAI>k__BackingField", "GameMain.ClubSystem.ClubCandidateFollowAI")]
           public partial nint CANDIDATE_FOLLOW_AI { get; set; } 
*/

            /// <summary>
            /// 0x2D0 System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubAffairTeamBuildingItemSetting , GameMain.ClubSystem.ClubAffairTeamBuildingItemRecord> <TeamBuildingItemRecord>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubAffairTeamBuildingItemSetting , GameMain.ClubSystem.ClubAffairTeamBuildingItemRecord></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<TeamBuildingItemRecord>k__BackingField", "System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubAffairTeamBuildingItemSetting,GameMain.ClubSystem.ClubAffairTeamBuildingItemRecord>")]
           public partial nint TEAM_BUILDING_ITEM_RECORD { get; set; } 
*/

            /// <summary>
            /// 0x2D8 GameMain.ClubSystem.ClubLoansData <LoansData>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.ClubSystem"."ClubLoansData"]
            /// </summary>
            /// <returns>class GameMain.ClubSystem.ClubLoansData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<LoansData>k__BackingField", "GameMain.ClubSystem.ClubLoansData")]
           public partial nint LOANS_DATA { get; set; } 
*/

            /// <summary>
            /// 0x2E0 System.Int32 coachPoint
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("coachPoint", "System.Int32")]
           public partial System.Int32 COACH_POINT { get; set; } 
*/

            /// <summary>
            /// 0x2E4 System.Int32 trainPoint
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("trainPoint", "System.Int32")]
           public partial System.Int32 TRAIN_POINT { get; set; } 
*/

            /// <summary>
            /// 0x2E8 System.Int32 budget
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("budget", "System.Int32")]
           public partial System.Int32 BUDGET { get; set; } 
*/

            /// <summary>
            /// 0x2EC GameMain.ClubSystem.ClubBPDynamicWeight bpDynamicWeight
            /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."ClubBPDynamicWeight"]
            /// </summary>
            /// <returns>struct GameMain.ClubSystem.ClubBPDynamicWeight</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bpDynamicWeight", "GameMain.ClubSystem.ClubBPDynamicWeight")]
           public partial GameMain.ClubSystem.ClubBPDynamicWeight BP_DYNAMIC_WEIGHT { get; set; } 
*/

            /// <summary>
            /// 0x2F8 System.Int32 monthlyPlansSelectableNum
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthlyPlansSelectableNum", "System.Int32")]
           public partial System.Int32 MONTHLY_PLANS_SELECTABLE_NUM { get; set; } 
*/

            /// <summary>
            /// 0x2FC System.Int32 clubSlotCount
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("clubSlotCount", "System.Int32")]
           public partial System.Int32 CLUB_SLOT_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x300 System.Boolean autoReplace
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("autoReplace", "System.Boolean")]
           public partial System.Boolean AUTO_REPLACE { get; set; } 
*/

            /// <summary>
            /// 0x304 System.Int32 trainingResearchCount
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("trainingResearchCount", "System.Int32")]
           public partial System.Int32 TRAINING_RESEARCH_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x308 System.Int32 trainingResearchLevel
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("trainingResearchLevel", "System.Int32")]
           public partial System.Int32 TRAINING_RESEARCH_LEVEL { get; set; } 
*/

            /// <summary>
            /// 0x30C UnityEngine.Vector3Int advancedTrainingCount
            /// struct ["UnityEngine.CoreModule"."UnityEngine"."Vector3Int"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3Int</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("advancedTrainingCount", "UnityEngine.Vector3Int")]
           public partial UnityEngine.Vector3Int ADVANCED_TRAINING_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x318 UnityEngine.Vector3 advancedTrainingBetterSuccessRate
            /// struct ["UnityEngine.CoreModule"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("advancedTrainingBetterSuccessRate", "UnityEngine.Vector3")]
           public partial UnityEngine.Vector3 ADVANCED_TRAINING_BETTER_SUCCESS_RATE { get; set; } 
*/

            /// <summary>
            /// 0x324 System.Int32 counterInterview
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("counterInterview", "System.Int32")]
           public partial System.Int32 COUNTER_INTERVIEW { get; set; } 
*/

            /// <summary>
            /// 0x328 System.Boolean isCanPromote
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isCanPromote", "System.Boolean")]
           public partial System.Boolean IS_CAN_PROMOTE { get; set; } 
*/

            /// <summary>
            /// 0x329 System.Boolean pickRedSide
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("pickRedSide", "System.Boolean")]
           public partial System.Boolean PICK_RED_SIDE { get; set; } 
*/

            /// <summary>
            /// 0x32C System.Nullable<GameMain.BattleSystem.BattleRegionTags> <JugUnitPath>k__BackingField
            /// struct ["mscorlib"."System"."Nullable`1"]
            /// </summary>
            /// <returns>struct System.Nullable<GameMain.BattleSystem.BattleRegionTags></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<JugUnitPath>k__BackingField", "System.Nullable<GameMain.BattleSystem.BattleRegionTags>")]
           public partial System.Nullable<GameMain.BattleSystem.BattleRegionTags> JUG_UNIT_PATH { get; set; } 
*/

            /// <summary>
            /// 0x334 GameMain.CalendarSystem.CalendarDate playOffsConfirm
            /// struct ["Assembly-CSharp"."GameMain.CalendarSystem"."CalendarDate"]
            /// </summary>
            /// <returns>struct GameMain.CalendarSystem.CalendarDate</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("playOffsConfirm", "GameMain.CalendarSystem.CalendarDate")]
           public partial GameMain.CalendarSystem.CalendarDate PLAY_OFFS_CONFIRM { get; set; } 
*/

            /// <summary>
            /// 0x340 System.Boolean <ExtraDevelopAI>k__BackingField
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ExtraDevelopAI>k__BackingField", "System.Boolean")]
           public partial System.Boolean EXTRA_DEVELOP_AI { get; set; } 
*/

            /// <summary>
            /// 0x344 System.Int32 <FreeRerollCount>k__BackingField
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<FreeRerollCount>k__BackingField", "System.Int32")]
           public partial System.Int32 FREE_REROLL_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x348 System.Int32 <RerollCount>k__BackingField
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<RerollCount>k__BackingField", "System.Int32")]
           public partial System.Int32 REROLL_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x34C System.Int32 <SeasonBudgetGained>k__BackingField
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<SeasonBudgetGained>k__BackingField", "System.Int32")]
           public partial System.Int32 SEASON_BUDGET_GAINED { get; set; } 
*/

            /// <summary>
            /// 0x350 System.Int32 <CoachLevelSeasonCount>k__BackingField
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CoachLevelSeasonCount>k__BackingField", "System.Int32")]
           public partial System.Int32 COACH_LEVEL_SEASON_COUNT { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."DataComponent"]
        /// </summary>
        public unsafe readonly partial struct Ptr_DataComponent
        {
            /// <summary>
            /// static  System.Void <AddEventSwitch>g__SetParams|207_0(GameMain.Procedure.DataEvent& dataEvent, GameMain.ClubSystem.Club.DataComponent.<>c__DisplayClass207_0& )
            /// </summary>
            /// <param name = "dataEvent">struct GameMain.Procedure.DataEvent&</param>
            /// <param name = "">struct GameMain.ClubSystem.Club.DataComponent.<>c__DisplayClass207_0&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<AddEventSwitch>g__SetParams|207_0", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.Procedure.DataEvent&", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club.DataComponent.<>c__DisplayClass207_0&", 1)]
            public static partial void ADD_EVENT_SWITCHG__SET_PARAMS|207_0(GameMain.Procedure.DataEvent &dataEvent, GameMain.ClubSystem.Club.DataComponent. < > c__DisplayClass207_0 &); 
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
            ///   System.Boolean <AddAdvancedTrainingSetting>g__CustomCanAdd|191_0(GameMain.ClubSystem.Club.DataComponent.<>c__DisplayClass191_0& )
            /// </summary>
            /// <param name = "">struct GameMain.ClubSystem.Club.DataComponent.<>c__DisplayClass191_0&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<AddAdvancedTrainingSetting>g__CustomCanAdd|191_0", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club.DataComponent.<>c__DisplayClass191_0&", 0)]
            public partial System.Boolean ADD_ADVANCED_TRAINING_SETTINGG__CUSTOM_CAN_ADD|191_0(GameMain.ClubSystem.Club.DataComponent. < > c__DisplayClass191_0 &); 
*/
            /// <summary>
            ///   System.Void <ChangeContestant>g__SetContestant|147_0(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<ChangeContestant>g__SetContestant|147_0", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public partial void CHANGE_CONTESTANTG__SET_CONTESTANT|147_0(nint athlete); 
*/
            /// <summary>
            ///   System.Boolean <CheckDemote>b__142_0(System.ValueTuple<GameMain.ClubSystem.Club , GameMain.ClubSystem.ClubCompetitionData> t)
            /// </summary>
            /// <param name = "t">struct System.ValueTuple<GameMain.ClubSystem.Club , GameMain.ClubSystem.ClubCompetitionData></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<CheckDemote>b__142_0", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.ValueTuple<GameMain.ClubSystem.Club,GameMain.ClubSystem.ClubCompetitionData>", 0)]
            public partial System.Boolean CHECK_DEMOTEB__142_0(System.ValueTuple<GameMain.ClubSystem.Club, GameMain.ClubSystem.ClubCompetitionData> t); 
*/
            /// <summary>
            ///   System.Void <GetAthleteCareerLifeCostDict>g__AfterChange|248_1(GameMain.ClubSystem.Club.DataComponent.<>c__DisplayClass248_0& )
            /// </summary>
            /// <param name = "">struct GameMain.ClubSystem.Club.DataComponent.<>c__DisplayClass248_0&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<GetAthleteCareerLifeCostDict>g__AfterChange|248_1", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club.DataComponent.<>c__DisplayClass248_0&", 0)]
            public partial void GET_ATHLETE_CAREER_LIFE_COST_DICTG__AFTER_CHANGE|248_1(GameMain.ClubSystem.Club.DataComponent. < > c__DisplayClass248_0 &); 
*/
            /// <summary>
            ///   System.Void <GetAthleteCareerLifeCostDict>g__BeforeChange|248_0(GameMain.ClubSystem.Club.DataComponent.<>c__DisplayClass248_0& )
            /// </summary>
            /// <param name = "">struct GameMain.ClubSystem.Club.DataComponent.<>c__DisplayClass248_0&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<GetAthleteCareerLifeCostDict>g__BeforeChange|248_0", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club.DataComponent.<>c__DisplayClass248_0&", 0)]
            public partial void GET_ATHLETE_CAREER_LIFE_COST_DICTG__BEFORE_CHANGE|248_0(GameMain.ClubSystem.Club.DataComponent. < > c__DisplayClass248_0 &); 
*/
            /// <summary>
            ///   System.Boolean <GetStadiumRecommended>b__239_0(GameMain.ClubSystem.StadiumSetting s)
            /// </summary>
            /// <param name = "s">class GameMain.ClubSystem.StadiumSetting</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<GetStadiumRecommended>b__239_0", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.StadiumSetting", 0)]
            public partial System.Boolean GET_STADIUM_RECOMMENDEDB__239_0(nint s); 
*/
            /// <summary>
            ///   System.Boolean <GetStadiumRecommended>b__239_1(GameMain.ClubSystem.StadiumSetting s)
            /// </summary>
            /// <param name = "s">class GameMain.ClubSystem.StadiumSetting</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<GetStadiumRecommended>b__239_1", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.StadiumSetting", 0)]
            public partial System.Boolean GET_STADIUM_RECOMMENDEDB__239_1(nint s); 
*/
            /// <summary>
            ///   System.Void AddAdvancedTrainingCountBase(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddAdvancedTrainingCountBase", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_ADVANCED_TRAINING_COUNT_BASE(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void AddAdvancedTrainingCountCurrent(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddAdvancedTrainingCountCurrent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_ADVANCED_TRAINING_COUNT_CURRENT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean AddAdvancedTrainingSetting(GameMain.ClubSystem.ClubAffairAdvancedTrainingItemSetting itemSetting)
            /// </summary>
            /// <param name = "itemSetting">class GameMain.ClubSystem.ClubAffairAdvancedTrainingItemSetting</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddAdvancedTrainingSetting", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubAffairAdvancedTrainingItemSetting", 0)]
            public partial System.Boolean ADD_ADVANCED_TRAINING_SETTING(nint itemSetting); 
*/
            /// <summary>
            ///   System.Void AddCoachCareer(GameMain.ClubSystem.CoachCareerType type)
            /// </summary>
            /// <param name = "type">enum GameMain.ClubSystem.CoachCareerType</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddCoachCareer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.CoachCareerType", 0)]
            public partial void ADD_COACH_CAREER(GameMain.ClubSystem.CoachCareerType type); 
*/
            /// <summary>
            ///   System.Void AddCompetitionData(GameMain.ClubSystem.ClubCompetitionData data)
            /// </summary>
            /// <param name = "data">struct GameMain.ClubSystem.ClubCompetitionData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddCompetitionData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubCompetitionData", 0)]
            public partial void ADD_COMPETITION_DATA(GameMain.ClubSystem.ClubCompetitionData data); 
*/
            /// <summary>
            ///   System.Void AddDailyTrainingGroup(GameMain.ClubSystem.TrainingGroup group)
            /// </summary>
            /// <param name = "group">class GameMain.ClubSystem.TrainingGroup</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddDailyTrainingGroup", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.TrainingGroup", 0)]
            public partial void ADD_DAILY_TRAINING_GROUP(nint group); 
*/
            /// <summary>
            ///   System.Void AddDelayedEventSwitch(GameMain.ClubSystem.ClubEventSwitchSetting eventSwitchSetting, System.Int32 delayedWeek)
            /// </summary>
            /// <param name = "eventSwitchSetting">class GameMain.ClubSystem.ClubEventSwitchSetting</param>
            /// <param name = "delayedWeek">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddDelayedEventSwitch", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubEventSwitchSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_DELAYED_EVENT_SWITCH(nint eventSwitchSetting, System.Int32 delayedWeek); 
*/
            /// <summary>
            ///   System.Void AddEventSwitch(GameMain.ClubSystem.ClubEventSwitchSetting eventSwitchSetting, Utility.ValueStruct.Value[] ps)
            /// </summary>
            /// <param name = "eventSwitchSetting">class GameMain.ClubSystem.ClubEventSwitchSetting</param>
            /// <param name = "ps">class Utility.ValueStruct.Value[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddEventSwitch", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubEventSwitchSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.ValueStruct.Value[]", 1)]
            public partial void ADD_EVENT_SWITCH(nint eventSwitchSetting, nint ps); 
*/
            /// <summary>
            ///   System.Void AddMonthlyPlanRecord()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddMonthlyPlanRecord", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ADD_MONTHLY_PLAN_RECORD(); 
*/
            /// <summary>
            ///   System.Void AddMonthlyPlanSelectableNum(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddMonthlyPlanSelectableNum", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_MONTHLY_PLAN_SELECTABLE_NUM(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void AddRecordBattle(GameMain.UnitSystem.RecordDestroy[] recordDestroys, System.Int32 allGB, GameMain.ClubSystem.RecordBattleClub& recordBattle, GameMain.BattleSystem.StatisticBattle& statisticBattle)
            /// </summary>
            /// <param name = "recordDestroys">class GameMain.UnitSystem.RecordDestroy[]</param>
            /// <param name = "allGB">struct System.Int32</param>
            /// <param name = "recordBattle">struct GameMain.ClubSystem.RecordBattleClub&</param>
            /// <param name = "statisticBattle">struct GameMain.BattleSystem.StatisticBattle&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddRecordBattle", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.RecordDestroy[]", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.RecordBattleClub&", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.BattleSystem.StatisticBattle&", 3)]
            public partial void ADD_RECORD_BATTLE(nint recordDestroys, System.Int32 allGB, GameMain.ClubSystem.RecordBattleClub &recordBattle, GameMain.BattleSystem.StatisticBattle &statisticBattle); 
*/
            /// <summary>
            ///   System.Void AddSeasonStartFans(System.Guid id, System.Int32 fans)
            /// </summary>
            /// <param name = "id">struct System.Guid</param>
            /// <param name = "fans">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddSeasonStartFans", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_SEASON_START_FANS(System.Guid id, System.Int32 fans); 
*/
            /// <summary>
            ///   System.Void AddStadiumBuildingStorage(GameMain.ClubSystem.StadiumBuildingSetting setting, System.Boolean isTemp)
            /// </summary>
            /// <param name = "setting">class GameMain.ClubSystem.StadiumBuildingSetting</param>
            /// <param name = "isTemp">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddStadiumBuildingStorage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.StadiumBuildingSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ADD_STADIUM_BUILDING_STORAGE(nint setting, System.Boolean isTemp); 
*/
            /// <summary>
            ///   System.Void AddStadiumStorage(GameMain.ClubSystem.StadiumSetting setting, System.Boolean cost)
            /// </summary>
            /// <param name = "setting">class GameMain.ClubSystem.StadiumSetting</param>
            /// <param name = "cost">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddStadiumStorage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.StadiumSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ADD_STADIUM_STORAGE(nint setting, System.Boolean cost); 
*/
            /// <summary>
            ///   System.Void AddSwayChip(GameMain.ClubSystem.SwayChip chip)
            /// </summary>
            /// <param name = "chip">class GameMain.ClubSystem.SwayChip</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddSwayChip", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.SwayChip", 0)]
            public partial void ADD_SWAY_CHIP(nint chip); 
*/
            /// <summary>
            ///   System.Void AddTrashTalkClub(GameMain.ClubSystem.Club club)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddTrashTalkClub", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            public partial void ADD_TRASH_TALK_CLUB(nint club); 
*/
            /// <summary>
            ///   System.Void AddTrashTalkCount(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddTrashTalkCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_TRASH_TALK_COUNT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean CanConsumeBudget(System.Int32 value, System.Boolean isEffect)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "isEffect">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanConsumeBudget", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Boolean CAN_CONSUME_BUDGET(System.Int32 value, System.Boolean isEffect); 
*/
            /// <summary>
            ///   System.Boolean CanConsumeCoachPoint(System.Int32 value, System.Boolean isEffect)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "isEffect">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanConsumeCoachPoint", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Boolean CAN_CONSUME_COACH_POINT(System.Int32 value, System.Boolean isEffect); 
*/
            /// <summary>
            ///   System.Boolean CanConsumeTrainPoint(System.Int32 value, System.Boolean isEffect)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "isEffect">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanConsumeTrainPoint", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Boolean CAN_CONSUME_TRAIN_POINT(System.Int32 value, System.Boolean isEffect); 
*/
            /// <summary>
            ///   System.Void ChangeAthlete(GameMain.AthleteSystem.Athlete contestant, GameMain.AthleteSystem.Athlete substitute)
            /// </summary>
            /// <param name = "contestant">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "substitute">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeAthlete", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 1)]
            public partial void CHANGE_ATHLETE(nint contestant, nint substitute); 
*/
            /// <summary>
            ///   System.Void ChangeClubAttitude(GameMain.AthleteSystem.Athlete athlete, System.Int32 value)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeClubAttitude", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void CHANGE_CLUB_ATTITUDE(nint athlete, System.Int32 value); 
*/
            /// <summary>
            ///   System.Void ChangeContestant(GameMain.AthleteSystem.Athlete athlete0, GameMain.AthleteSystem.Athlete athlete1)
            /// </summary>
            /// <param name = "athlete0">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "athlete1">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeContestant", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 1)]
            public partial void CHANGE_CONTESTANT(nint athlete0, nint athlete1); 
*/
            /// <summary>
            ///   System.Void CheckContestant()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckContestant", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_CONTESTANT(); 
*/
            /// <summary>
            ///   System.Boolean CheckDemote()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckDemote", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean CHECK_DEMOTE(); 
*/
            /// <summary>
            ///   System.Boolean CheckHaveTrainingMatch(GameMain.ClubSystem.Club club)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckHaveTrainingMatch", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            public partial System.Boolean CHECK_HAVE_TRAINING_MATCH(nint club); 
*/
            /// <summary>
            ///   System.Boolean CheckIsCanPromote()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckIsCanPromote", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean CHECK_IS_CAN_PROMOTE(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<System.ValueTuple<GameMain.ClubSystem.MonthlyPlan , System.Boolean>> CheckMonthlyPlans(System.Boolean keepMode)
            /// </summary>
            /// <param name = "keepMode">struct System.Boolean</param>
            /// <returns>interface System.Collections.Generic.IEnumerable<System.ValueTuple<GameMain.ClubSystem.MonthlyPlan , System.Boolean>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckMonthlyPlans", "System.Collections.Generic.IEnumerable<System.ValueTuple<GameMain.ClubSystem.MonthlyPlan,System.Boolean>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint CHECK_MONTHLY_PLANS(System.Boolean keepMode); 
*/
            /// <summary>
            ///   System.Void CheckSearchDataValid()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckSearchDataValid", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_SEARCH_DATA_VALID(); 
*/
            /// <summary>
            ///   System.Void CheckSwayChipLimit()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckSwayChipLimit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_SWAY_CHIP_LIMIT(); 
*/
            /// <summary>
            ///   System.Void ClearSwayChip(GameMain.ClubSystem.SwayChipSpawnReason reason)
            /// </summary>
            /// <param name = "reason">enum GameMain.ClubSystem.SwayChipSpawnReason</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearSwayChip", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.SwayChipSpawnReason", 0)]
            public partial void CLEAR_SWAY_CHIP(GameMain.ClubSystem.SwayChipSpawnReason reason); 
*/
            /// <summary>
            ///   System.Void ConsumeBudget(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ConsumeBudget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void CONSUME_BUDGET(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void ConsumeCoachPoint(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ConsumeCoachPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void CONSUME_COACH_POINT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void ConsumeTrainPoint(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ConsumeTrainPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void CONSUME_TRAIN_POINT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean ContainsEventSwitch(GameMain.ClubSystem.ClubEventSwitchSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.ClubSystem.ClubEventSwitchSetting</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ContainsEventSwitch", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubEventSwitchSetting", 0)]
            public partial System.Boolean CONTAINS_EVENT_SWITCH(nint setting); 
*/
            /// <summary>
            ///   System.Int32 CountClubAffairType(GameMain.ClubSystem.ClubAffairTypes affairType)
            /// </summary>
            /// <param name = "affairType">enum GameMain.ClubSystem.ClubAffairTypes</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CountClubAffairType", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubAffairTypes", 0)]
            public partial System.Int32 COUNT_CLUB_AFFAIR_TYPE(GameMain.ClubSystem.ClubAffairTypes affairType); 
*/
            /// <summary>
            ///   System.Void GainBudget(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GainBudget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void GAIN_BUDGET(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void GainCoachPoint(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GainCoachPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void GAIN_COACH_POINT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void GainTrainPoint(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GainTrainPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void GAIN_TRAIN_POINT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<GameMain.Career.IOperationAthlete> GameMain.Career.IImplementAthleteToData.get_Operations()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.Career.IOperationAthlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GameMain.Career.IImplementAthleteToData.get_Operations", "System.Collections.Generic.IEnumerable<GameMain.Career.IOperationAthlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GAME_MAIN_CAREER_I_IMPLEMENT_ATHLETE_TO_DATAGET_OPERATIONS(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<GameMain.Career.IOperationClub> GameMain.Career.IImplementClubToData.get_Operations()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.Career.IOperationClub></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GameMain.Career.IImplementClubToData.get_Operations", "System.Collections.Generic.IEnumerable<GameMain.Career.IOperationClub>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GAME_MAIN_CAREER_I_IMPLEMENT_CLUB_TO_DATAGET_OPERATIONS(); 
*/
            /// <summary>
            ///   System.Void GenerateAthleteRelation()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateAthleteRelation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void GENERATE_ATHLETE_RELATION(); 
*/
            /// <summary>
            ///   System.Void GenerateClubAttitude()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateClubAttitude", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void GENERATE_CLUB_ATTITUDE(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubCandidateFollowAI get_CandidateFollowAI()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.ClubCandidateFollowAI</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CandidateFollowAI", "GameMain.ClubSystem.ClubCandidateFollowAI", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CANDIDATE_FOLLOW_AI(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<GameMain.AthleteSystem.Athlete , System.Int32> get_ClubAttitudes()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.AthleteSystem.Athlete , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ClubAttitudes", "System.Collections.Generic.Dictionary<GameMain.AthleteSystem.Athlete,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CLUB_ATTITUDES(); 
*/
            /// <summary>
            ///   System.Int32 get_CoachLevelSeasonCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CoachLevelSeasonCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_COACH_LEVEL_SEASON_COUNT(); 
*/
            /// <summary>
            ///   System.Boolean get_ExtraDevelopAI()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ExtraDevelopAI", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_EXTRA_DEVELOP_AI(); 
*/
            /// <summary>
            ///   System.Int32 get_FreeRerollCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_FreeRerollCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_FREE_REROLL_COUNT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags , System.Int32> get_HpWarningPercentage()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_HpWarningPercentage", "System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HP_WARNING_PERCENTAGE(); 
*/
            /// <summary>
            ///   System.Nullable<GameMain.BattleSystem.BattleRegionTags> get_JugUnitPath()
            /// </summary>
            /// <returns>struct System.Nullable<GameMain.BattleSystem.BattleRegionTags></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_JugUnitPath", "System.Nullable<GameMain.BattleSystem.BattleRegionTags>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Nullable<GameMain.BattleSystem.BattleRegionTags> GET_JUG_UNIT_PATH(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubLoansData get_LoansData()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.ClubLoansData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_LoansData", "GameMain.ClubSystem.ClubLoansData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_LOANS_DATA(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.AthleteSystem.Athlete> get_MatchAthletes()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MatchAthletes", "System.Collections.Generic.List<GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MATCH_ATHLETES(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.MatchSystem.MatchMedalSetting> get_MatchMedals()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.MatchSystem.MatchMedalSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MatchMedals", "System.Collections.Generic.List<GameMain.MatchSystem.MatchMedalSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MATCH_MEDALS(); 
*/
            /// <summary>
            ///   System.String get_Portrait_Assistant()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Portrait_Assistant", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PORTRAIT_ASSISTANT(); 
*/
            /// <summary>
            ///   System.String get_Portrait_Coach()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Portrait_Coach", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PORTRAIT_COACH(); 
*/
            /// <summary>
            ///   System.Int32 get_RerollCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RerollCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_REROLL_COUNT(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.YouthScout get_Scout()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.YouthScout</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Scout", "GameMain.ClubSystem.YouthScout", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SCOUT(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.YouthScoutSearchingData get_SearchingData()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.YouthScoutSearchingData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SearchingData", "GameMain.ClubSystem.YouthScoutSearchingData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SEARCHING_DATA(); 
*/
            /// <summary>
            ///   System.Int32 get_SeasonBudgetGained()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SeasonBudgetGained", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_SEASON_BUDGET_GAINED(); 
*/
            /// <summary>
            ///   UnityEngine.Texture2D get_SimulateLogo()
            /// </summary>
            /// <returns>class UnityEngine.Texture2D</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SimulateLogo", "UnityEngine.Texture2D", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SIMULATE_LOGO(); 
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
            ///   System.Collections.Generic.List<GameMain.ClubSystem.StadiumBuildingSetting> get_StadiumBuildingStorage()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.StadiumBuildingSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StadiumBuildingStorage", "System.Collections.Generic.List<GameMain.ClubSystem.StadiumBuildingSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_STADIUM_BUILDING_STORAGE(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.ClubSystem.StadiumBuildingSetting> get_StadiumBuildingStorageTemp()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.StadiumBuildingSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StadiumBuildingStorageTemp", "System.Collections.Generic.List<GameMain.ClubSystem.StadiumBuildingSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_STADIUM_BUILDING_STORAGE_TEMP(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.ClubSystem.StadiumData> get_StadiumDataList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.StadiumData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StadiumDataList", "System.Collections.Generic.List<GameMain.ClubSystem.StadiumData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_STADIUM_DATA_LIST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.ClubSystem.StadiumSetting> get_StadiumStorage()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.StadiumSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StadiumStorage", "System.Collections.Generic.List<GameMain.ClubSystem.StadiumSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_STADIUM_STORAGE(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.ClubSystem.SwayChip> get_SwayChips()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.SwayChip></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SwayChips", "System.Collections.Generic.List<GameMain.ClubSystem.SwayChip>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SWAY_CHIPS(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubAffairTeamBuildingItemSetting , GameMain.ClubSystem.ClubAffairTeamBuildingItemRecord> get_TeamBuildingItemRecord()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubAffairTeamBuildingItemSetting , GameMain.ClubSystem.ClubAffairTeamBuildingItemRecord></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TeamBuildingItemRecord", "System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubAffairTeamBuildingItemSetting,GameMain.ClubSystem.ClubAffairTeamBuildingItemRecord>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TEAM_BUILDING_ITEM_RECORD(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairMonthlyPlanSetting> get_UnlockMonthlyPlanSettingSet()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairMonthlyPlanSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_UnlockMonthlyPlanSettingSet", "System.Collections.Generic.List<GameMain.ClubSystem.ClubAffairMonthlyPlanSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_UNLOCK_MONTHLY_PLAN_SETTING_SET(); 
*/
            /// <summary>
            ///   System.Int32 GetAdvancedTrainingCountBase()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAdvancedTrainingCountBase", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ADVANCED_TRAINING_COUNT_BASE(); 
*/
            /// <summary>
            ///   System.Boolean GetAdvancedTrainingCountBetterSuccess(System.Single athleteFactor)
            /// </summary>
            /// <param name = "athleteFactor">struct System.Single</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAdvancedTrainingCountBetterSuccess", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Boolean GET_ADVANCED_TRAINING_COUNT_BETTER_SUCCESS(System.Single athleteFactor); 
*/
            /// <summary>
            ///   System.Int32 GetAdvancedTrainingCountCurrent()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAdvancedTrainingCountCurrent", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ADVANCED_TRAINING_COUNT_CURRENT(); 
*/
            /// <summary>
            ///   System.String GetAssistantName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAssistantName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ASSISTANT_NAME(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<GameMain.AthleteSystem.Athlete , UnityEngine.Vector2Int> GetAthleteCareerLifeCostDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.AthleteSystem.Athlete , UnityEngine.Vector2Int></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAthleteCareerLifeCostDict", "System.Collections.Generic.Dictionary<GameMain.AthleteSystem.Athlete,UnityEngine.Vector2Int>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATHLETE_CAREER_LIFE_COST_DICT(); 
*/
            /// <summary>
            ///   System.Int32 GetBudget()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBudget", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_BUDGET(); 
*/
            /// <summary>
            ///   System.Int32 GetClubAttitude(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetClubAttitude", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public partial System.Int32 GET_CLUB_ATTITUDE(nint athlete); 
*/
            /// <summary>
            ///   System.String GetClubAttitudeString(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetClubAttitudeString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public partial nint GET_CLUB_ATTITUDE_STRING(nint athlete); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubClassTypes GetClubClassType()
            /// </summary>
            /// <returns>enum GameMain.ClubSystem.ClubClassTypes</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetClubClassType", "GameMain.ClubSystem.ClubClassTypes", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.ClubSystem.ClubClassTypes GET_CLUB_CLASS_TYPE(); 
*/
            /// <summary>
            ///   System.String GetClubLogoUrl()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetClubLogoUrl", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CLUB_LOGO_URL(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.CoachClassTypes GetCoachClassType()
            /// </summary>
            /// <returns>enum GameMain.ClubSystem.CoachClassTypes</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCoachClassType", "GameMain.ClubSystem.CoachClassTypes", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.ClubSystem.CoachClassTypes GET_COACH_CLASS_TYPE(); 
*/
            /// <summary>
            ///   System.String GetCoachName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCoachName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COACH_NAME(); 
*/
            /// <summary>
            ///   System.Int32 GetCoachPoint()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCoachPoint", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_COACH_POINT(); 
*/
            /// <summary>
            ///   System.Nullable<System.Int32> GetEventSwitch(GameMain.ClubSystem.ClubEventSwitchSetting eventSwitchSetting)
            /// </summary>
            /// <param name = "eventSwitchSetting">class GameMain.ClubSystem.ClubEventSwitchSetting</param>
            /// <returns>struct System.Nullable<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEventSwitch", "System.Nullable<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubEventSwitchSetting", 0)]
            public partial System.Nullable<System.Int32> GET_EVENT_SWITCH(nint eventSwitchSetting); 
*/
            /// <summary>
            ///   System.Nullable<GameMain.Procedure.DataEvent> GetEventSwitchData(GameMain.ClubSystem.ClubEventSwitchSetting eventSwitchSetting)
            /// </summary>
            /// <param name = "eventSwitchSetting">class GameMain.ClubSystem.ClubEventSwitchSetting</param>
            /// <returns>struct System.Nullable<GameMain.Procedure.DataEvent></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEventSwitchData", "System.Nullable<GameMain.Procedure.DataEvent>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubEventSwitchSetting", 0)]
            public partial System.Nullable<GameMain.Procedure.DataEvent> GET_EVENT_SWITCH_DATA(nint eventSwitchSetting); 
*/
            /// <summary>
            ///   System.Single GetHeroHpWarning(GameMain.UnitSystem.Unit unit)
            /// </summary>
            /// <param name = "unit">class GameMain.UnitSystem.Unit</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroHpWarning", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.Unit", 0)]
            public partial System.Single GET_HERO_HP_WARNING(nint unit); 
*/
            /// <summary>
            ///   System.Nullable<GameMain.BattleSystem.BattleRegionTags> GetJugPathTag()
            /// </summary>
            /// <returns>struct System.Nullable<GameMain.BattleSystem.BattleRegionTags></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetJugPathTag", "System.Nullable<GameMain.BattleSystem.BattleRegionTags>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Nullable<GameMain.BattleSystem.BattleRegionTags> GET_JUG_PATH_TAG(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubAffairTeamBuildingItemRecord GetLastUsingTeamBuilding()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.ClubAffairTeamBuildingItemRecord</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLastUsingTeamBuilding", "GameMain.ClubSystem.ClubAffairTeamBuildingItemRecord", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_LAST_USING_TEAM_BUILDING(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IReadOnlyList<GameMain.ClubSystem.MonthlyPlan> GetMonthlyPlan()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IReadOnlyList<GameMain.ClubSystem.MonthlyPlan></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMonthlyPlan", "System.Collections.Generic.IReadOnlyList<GameMain.ClubSystem.MonthlyPlan>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MONTHLY_PLAN(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubClassTypes GetPreviousClubClassType()
            /// </summary>
            /// <returns>enum GameMain.ClubSystem.ClubClassTypes</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPreviousClubClassType", "GameMain.ClubSystem.ClubClassTypes", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.ClubSystem.ClubClassTypes GET_PREVIOUS_CLUB_CLASS_TYPE(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.TrainingGroup GetRandomDailyTrainingGroup(GameMain.ClubSystem.DailyTrainingGrade grade, System.Boolean add)
            /// </summary>
            /// <param name = "grade">enum GameMain.ClubSystem.DailyTrainingGrade</param>
            /// <param name = "add">struct System.Boolean</param>
            /// <returns>class GameMain.ClubSystem.TrainingGroup</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRandomDailyTrainingGroup", "GameMain.ClubSystem.TrainingGroup", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.DailyTrainingGrade", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_RANDOM_DAILY_TRAINING_GROUP(GameMain.ClubSystem.DailyTrainingGrade grade, System.Boolean add); 
*/
            /// <summary>
            ///   System.Int32 GetSeasonStartFans(System.Guid seasonId)
            /// </summary>
            /// <param name = "seasonId">struct System.Guid</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSeasonStartFans", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public partial System.Int32 GET_SEASON_START_FANS(System.Guid seasonId); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubAffairSponsorSetting GetSignedSponsor()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.ClubAffairSponsorSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSignedSponsor", "GameMain.ClubSystem.ClubAffairSponsorSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SIGNED_SPONSOR(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.StadiumSetting GetStadiumRecommended()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.StadiumSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStadiumRecommended", "GameMain.ClubSystem.StadiumSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_STADIUM_RECOMMENDED(); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubAffairTeamBuildingItemRecord GetTeamBuildingItemRecord(GameMain.ClubSystem.ClubAffairTeamBuildingItemSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.ClubSystem.ClubAffairTeamBuildingItemSetting</param>
            /// <returns>class GameMain.ClubSystem.ClubAffairTeamBuildingItemRecord</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTeamBuildingItemRecord", "GameMain.ClubSystem.ClubAffairTeamBuildingItemRecord", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubAffairTeamBuildingItemSetting", 0)]
            public partial nint GET_TEAM_BUILDING_ITEM_RECORD(nint setting); 
*/
            /// <summary>
            ///   GameMain.ClubSystem.ClubClassTypes GetTopClassType()
            /// </summary>
            /// <returns>enum GameMain.ClubSystem.ClubClassTypes</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTopClassType", "GameMain.ClubSystem.ClubClassTypes", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.ClubSystem.ClubClassTypes GET_TOP_CLASS_TYPE(); 
*/
            /// <summary>
            ///   System.Int32 GetTrainPoint()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTrainPoint", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_TRAIN_POINT(); 
*/
            /// <summary>
            ///   System.Int32 GetTrainPointAfterBattle()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTrainPointAfterBattle", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_TRAIN_POINT_AFTER_BATTLE(); 
*/
            /// <summary>
            ///   System.Void Init(GameMain.ClubSystem.ClubSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.ClubSystem.ClubSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Init", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubSetting", 0)]
            public partial void INIT(nint setting); 
*/
            /// <summary>
            ///   System.Boolean IsClubAffairFirst(GameMain.ClubSystem.ClubAffairTypes affairType)
            /// </summary>
            /// <param name = "affairType">enum GameMain.ClubSystem.ClubAffairTypes</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsClubAffairFirst", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubAffairTypes", 0)]
            public partial System.Boolean IS_CLUB_AFFAIR_FIRST(GameMain.ClubSystem.ClubAffairTypes affairType); 
*/
            /// <summary>
            ///   System.Boolean IsSelectedOption(System.String key)
            /// </summary>
            /// <param name = "key">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsSelectedOption", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean IS_SELECTED_OPTION(nint key); 
*/
            /// <summary>
            ///   System.Void LockAffair(GameMain.ClubSystem.ClubAffairTypes affairType)
            /// </summary>
            /// <param name = "affairType">enum GameMain.ClubSystem.ClubAffairTypes</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LockAffair", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubAffairTypes", 0)]
            public partial void LOCK_AFFAIR(GameMain.ClubSystem.ClubAffairTypes affairType); 
*/
            /// <summary>
            ///   System.Void NewSeason(System.Guid seasonId)
            /// </summary>
            /// <param name = "seasonId">struct System.Guid</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("NewSeason", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public partial void NEW_SEASON(System.Guid seasonId); 
*/
            /// <summary>
            ///   System.Void OnBattleEnd(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnBattleEnd", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void ON_BATTLE_END(System.Single value); 
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
            ///   System.Void RecordSelectedOption(System.String key)
            /// </summary>
            /// <param name = "key">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RecordSelectedOption", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void RECORD_SELECTED_OPTION(nint key); 
*/
            /// <summary>
            ///   System.Void RecordTeamBuildItem(GameMain.ClubSystem.ClubAffairTeamBuilding.Item item, System.Boolean executeItem, System.Boolean skip)
            /// </summary>
            /// <param name = "item">class GameMain.ClubSystem.ClubAffairTeamBuilding.Item</param>
            /// <param name = "executeItem">struct System.Boolean</param>
            /// <param name = "skip">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RecordTeamBuildItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubAffairTeamBuilding.Item", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void RECORD_TEAM_BUILD_ITEM(nint item, System.Boolean executeItem, System.Boolean skip); 
*/
            /// <summary>
            ///   System.Void RemoveEventSwitch(GameMain.ClubSystem.ClubEventSwitchSetting eventSwitchSetting)
            /// </summary>
            /// <param name = "eventSwitchSetting">class GameMain.ClubSystem.ClubEventSwitchSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveEventSwitch", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubEventSwitchSetting", 0)]
            public partial void REMOVE_EVENT_SWITCH(nint eventSwitchSetting); 
*/
            /// <summary>
            ///   System.Void RemovePointSwitch(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemovePointSwitch", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void REMOVE_POINT_SWITCH(System.Int32 index); 
*/
            /// <summary>
            ///   System.Void RemoveSwayChip(GameMain.ClubSystem.SwayChip chip)
            /// </summary>
            /// <param name = "chip">class GameMain.ClubSystem.SwayChip</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveSwayChip", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.SwayChip", 0)]
            public partial void REMOVE_SWAY_CHIP(nint chip); 
*/
            /// <summary>
            ///   System.Void RemoveUnrecordedTeamBuildItem(System.Collections.Generic.ISet<GameMain.ClubSystem.ClubAffairTeamBuildingItemSetting> keys)
            /// </summary>
            /// <param name = "keys">interface System.Collections.Generic.ISet<GameMain.ClubSystem.ClubAffairTeamBuildingItemSetting></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveUnrecordedTeamBuildItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.ISet<GameMain.ClubSystem.ClubAffairTeamBuildingItemSetting>", 0)]
            public partial void REMOVE_UNRECORDED_TEAM_BUILD_ITEM(nint keys); 
*/
            /// <summary>
            ///   System.Void ResetMonthlyPlan(System.Boolean record)
            /// </summary>
            /// <param name = "record">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetMonthlyPlan", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void RESET_MONTHLY_PLAN(System.Boolean record); 
*/
            /// <summary>
            ///   System.Void ResetTeamBuildingRecordOnNewSeason()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetTeamBuildingRecordOnNewSeason", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET_TEAM_BUILDING_RECORD_ON_NEW_SEASON(); 
*/
            /// <summary>
            ///   System.Void SaveSpareAbilityExp(GameMain.AthleteSystem.AthleteAbilityFlags flag, System.Int32 exp)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "exp">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveSpareAbilityExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SAVE_SPARE_ABILITY_EXP(GameMain.AthleteSystem.AthleteAbilityFlags flag, System.Int32 exp); 
*/
            /// <summary>
            ///   System.Void set_CoachLevelSeasonCount(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CoachLevelSeasonCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_COACH_LEVEL_SEASON_COUNT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_ExtraDevelopAI(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ExtraDevelopAI", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_EXTRA_DEVELOP_AI(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_FreeRerollCount(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_FreeRerollCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_FREE_REROLL_COUNT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_JugUnitPath(System.Nullable<GameMain.BattleSystem.BattleRegionTags> value)
            /// </summary>
            /// <param name = "value">struct System.Nullable<GameMain.BattleSystem.BattleRegionTags></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_JugUnitPath", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Nullable<GameMain.BattleSystem.BattleRegionTags>", 0)]
            public partial void SET_JUG_UNIT_PATH(System.Nullable<GameMain.BattleSystem.BattleRegionTags> value); 
*/
            /// <summary>
            ///   System.Void set_RerollCount(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_RerollCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_REROLL_COUNT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_Scout(GameMain.ClubSystem.YouthScout value)
            /// </summary>
            /// <param name = "value">class GameMain.ClubSystem.YouthScout</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Scout", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.YouthScout", 0)]
            public partial void SET_SCOUT(nint value); 
*/
            /// <summary>
            ///   System.Void set_SearchingData(GameMain.ClubSystem.YouthScoutSearchingData value)
            /// </summary>
            /// <param name = "value">class GameMain.ClubSystem.YouthScoutSearchingData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_SearchingData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.YouthScoutSearchingData", 0)]
            public partial void SET_SEARCHING_DATA(nint value); 
*/
            /// <summary>
            ///   System.Void set_SeasonBudgetGained(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_SeasonBudgetGained", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_SEASON_BUDGET_GAINED(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_SimulateLogo(UnityEngine.Texture2D value)
            /// </summary>
            /// <param name = "value">class UnityEngine.Texture2D</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_SimulateLogo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
            public partial void SET_SIMULATE_LOGO(nint value); 
*/
            /// <summary>
            ///   System.Void set_Stadium(GameMain.ClubSystem.Stadium value)
            /// </summary>
            /// <param name = "value">class GameMain.ClubSystem.Stadium</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Stadium", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Stadium", 0)]
            public partial void SET_STADIUM(nint value); 
*/
            /// <summary>
            ///   System.Void SetAClubClassMonthlyPlanReward()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAClubClassMonthlyPlanReward", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SET_A_CLUB_CLASS_MONTHLY_PLAN_REWARD(); 
*/
            /// <summary>
            ///   System.Void SetAdvancedTrainingCountBase(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAdvancedTrainingCountBase", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_ADVANCED_TRAINING_COUNT_BASE(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void SetAdvancedTrainingCountCurrent(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAdvancedTrainingCountCurrent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_ADVANCED_TRAINING_COUNT_CURRENT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void SetAssistantAI(GameMain.ClubSystem.ClubSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.ClubSystem.ClubSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAssistantAI", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubSetting", 0)]
            public partial void SET_ASSISTANT_AI(nint setting); 
*/
            /// <summary>
            ///   System.Void SetAssistantName(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAssistantName", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_ASSISTANT_NAME(nint name); 
*/
            /// <summary>
            ///   System.Void SetAssistantPortrait(System.String portraitName)
            /// </summary>
            /// <param name = "portraitName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAssistantPortrait", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_ASSISTANT_PORTRAIT(nint portraitName); 
*/
            /// <summary>
            ///   System.Void SetBudget(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetBudget", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_BUDGET(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void SetClubClassType(GameMain.ClubSystem.ClubClassTypes classType)
            /// </summary>
            /// <param name = "classType">enum GameMain.ClubSystem.ClubClassTypes</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetClubClassType", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubClassTypes", 0)]
            public partial void SET_CLUB_CLASS_TYPE(GameMain.ClubSystem.ClubClassTypes classType); 
*/
            /// <summary>
            ///   System.Void SetCoachAI(GameMain.ClubSystem.ClubSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.ClubSystem.ClubSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetCoachAI", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubSetting", 0)]
            public partial void SET_COACH_AI(nint setting); 
*/
            /// <summary>
            ///   System.Void SetCoachClassType(GameMain.ClubSystem.CoachClassTypes classType)
            /// </summary>
            /// <param name = "classType">enum GameMain.ClubSystem.CoachClassTypes</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetCoachClassType", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.CoachClassTypes", 0)]
            public partial void SET_COACH_CLASS_TYPE(GameMain.ClubSystem.CoachClassTypes classType); 
*/
            /// <summary>
            ///   System.Void SetCoachName(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetCoachName", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_COACH_NAME(nint name); 
*/
            /// <summary>
            ///   System.Void SetCoachPoint(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetCoachPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_COACH_POINT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void SetCoachPortrait(System.String portraitName)
            /// </summary>
            /// <param name = "portraitName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetCoachPortrait", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_COACH_PORTRAIT(nint portraitName); 
*/
            /// <summary>
            ///   System.Void SetDialogSetting(GameMain.ClubSystem.ClubAssistantDialogueSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.ClubSystem.ClubAssistantDialogueSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetDialogSetting", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubAssistantDialogueSetting", 0)]
            public partial void SET_DIALOG_SETTING(nint setting); 
*/
            /// <summary>
            ///   System.Single SetHeroHpWarning(GameMain.UnitSystem.HeroRoleFlags role, System.Single value)
            /// </summary>
            /// <param name = "role">enum GameMain.UnitSystem.HeroRoleFlags</param>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHeroHpWarning", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroRoleFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial System.Single SET_HERO_HP_WARNING(GameMain.UnitSystem.HeroRoleFlags role, System.Single value); 
*/
            /// <summary>
            ///   System.Void SetMonthlyPlan(System.Collections.Generic.IEnumerable<GameMain.ClubSystem.MonthlyPlan> plans)
            /// </summary>
            /// <param name = "plans">interface System.Collections.Generic.IEnumerable<GameMain.ClubSystem.MonthlyPlan></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetMonthlyPlan", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<GameMain.ClubSystem.MonthlyPlan>", 0)]
            public partial void SET_MONTHLY_PLAN(nint plans); 
*/
            /// <summary>
            ///   System.Void SetPlayerClubIcon(System.String clubFullName, System.String clubShortName, GameMain.ClubSystem.Create.ClubLogoData logoData)
            /// </summary>
            /// <param name = "clubFullName">class System.String</param>
            /// <param name = "clubShortName">class System.String</param>
            /// <param name = "logoData">struct GameMain.ClubSystem.Create.ClubLogoData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPlayerClubIcon", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Create.ClubLogoData", 2)]
            public partial void SET_PLAYER_CLUB_ICON(nint clubFullName, nint clubShortName, GameMain.ClubSystem.Create.ClubLogoData logoData); 
*/
            /// <summary>
            ///   System.Void SetPreviousClubClassType(GameMain.ClubSystem.ClubClassTypes classType)
            /// </summary>
            /// <param name = "classType">enum GameMain.ClubSystem.ClubClassTypes</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPreviousClubClassType", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubClassTypes", 0)]
            public partial void SET_PREVIOUS_CLUB_CLASS_TYPE(GameMain.ClubSystem.ClubClassTypes classType); 
*/
            /// <summary>
            ///   System.Void SetSearchingData(GameMain.ClubSystem.YouthScoutSearchingData data)
            /// </summary>
            /// <param name = "data">class GameMain.ClubSystem.YouthScoutSearchingData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSearchingData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.YouthScoutSearchingData", 0)]
            public partial void SET_SEARCHING_DATA(nint data); 
*/
            /// <summary>
            ///   System.Void SetSignedSponsor(GameMain.ClubSystem.ClubAffairSponsorSetting sponsor)
            /// </summary>
            /// <param name = "sponsor">class GameMain.ClubSystem.ClubAffairSponsorSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSignedSponsor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubAffairSponsorSetting", 0)]
            public partial void SET_SIGNED_SPONSOR(nint sponsor); 
*/
            /// <summary>
            ///   System.Void SetStadium(GameMain.ClubSystem.StadiumSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.ClubSystem.StadiumSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetStadium", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.StadiumSetting", 0)]
            public partial void SET_STADIUM(nint setting); 
*/
            /// <summary>
            ///   System.Void SetTrainPoint(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetTrainPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_TRAIN_POINT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Nullable<GameMain.BattleSystem.BattleRegionTags> SetUnitJugPathTag(System.Nullable<GameMain.BattleSystem.BattleRegionTags> value)
            /// </summary>
            /// <param name = "value">struct System.Nullable<GameMain.BattleSystem.BattleRegionTags></param>
            /// <returns>struct System.Nullable<GameMain.BattleSystem.BattleRegionTags></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetUnitJugPathTag", "System.Nullable<GameMain.BattleSystem.BattleRegionTags>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Nullable<GameMain.BattleSystem.BattleRegionTags>", 0)]
            public partial System.Nullable<GameMain.BattleSystem.BattleRegionTags> SET_UNIT_JUG_PATH_TAG(System.Nullable<GameMain.BattleSystem.BattleRegionTags> value); 
*/
            /// <summary>
            ///   System.Int32 SwayChipColorNum()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SwayChipColorNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 SWAY_CHIP_COLOR_NUM(); 
*/
            /// <summary>
            ///   System.Boolean TriggerInterview()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TriggerInterview", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean TRIGGER_INTERVIEW(); 
*/
            /// <summary>
            ///   System.Boolean TriggerTrashTalk(GameMain.ClubSystem.Club club)
            /// </summary>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TriggerTrashTalk", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            public partial System.Boolean TRIGGER_TRASH_TALK(nint club); 
*/
            /// <summary>
            ///   System.Void UnlockAffair(GameMain.ClubSystem.ClubAffairTypes affairType)
            /// </summary>
            /// <param name = "affairType">enum GameMain.ClubSystem.ClubAffairTypes</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnlockAffair", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubAffairTypes", 0)]
            public partial void UNLOCK_AFFAIR(GameMain.ClubSystem.ClubAffairTypes affairType); 
*/
            /// <summary>
            ///   System.Void UnlockMonthlyPlanSetting(GameMain.ClubSystem.ClubAffairMonthlyPlanSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.ClubSystem.ClubAffairMonthlyPlanSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnlockMonthlyPlanSetting", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubAffairMonthlyPlanSetting", 0)]
            public partial void UNLOCK_MONTHLY_PLAN_SETTING(nint setting); 
*/
            /// <summary>
            ///   System.Void UpdateClubAffairExpData(GameMain.ClubSystem.ClubAffairTypes affairType)
            /// </summary>
            /// <param name = "affairType">enum GameMain.ClubSystem.ClubAffairTypes</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateClubAffairExpData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubAffairTypes", 0)]
            public partial void UPDATE_CLUB_AFFAIR_EXP_DATA(GameMain.ClubSystem.ClubAffairTypes affairType); 
*/
            /// <summary>
            ///   System.Void UpdateDelayedEventSwitch()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateDelayedEventSwitch", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_DELAYED_EVENT_SWITCH(); 
*/
            /// <summary>
            ///   System.Void UpdateDialogueData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateDialogueData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_DIALOGUE_DATA(); 
*/
            /// <summary>
            ///   System.Void UpdateEventSwitch()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateEventSwitch", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_EVENT_SWITCH(); 
*/
            /// <summary>
            ///   System.Void UpdateOnWeek()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateOnWeek", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_ON_WEEK(); 
*/
            /// <summary>
            ///   System.Void UpDateSupportData(GameMain.ClubSystem.RecordBattleClub record)
            /// </summary>
            /// <param name = "record">struct GameMain.ClubSystem.RecordBattleClub</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpDateSupportData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.RecordBattleClub", 0)]
            public partial void UP_DATE_SUPPORT_DATA(GameMain.ClubSystem.RecordBattleClub record); 
*/
            /// <summary>
            ///   System.Void UpdateSwayChipNew()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateSwayChipNew", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_SWAY_CHIP_NEW(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem".""."BaseDataComponent"]
        /// </summary>
        public unsafe readonly partial struct Ptr_DataComponent
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
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem".""."BaseDataComponent`1"]
        /// </summary>
        public unsafe readonly partial struct Ptr_DataComponent
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
            ///   System.Type get_SaveDataType()
            /// </summary>
            /// <returns>abstract class System.Type</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SaveDataType", "System.Type", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SAVE_DATA_TYPE(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem".""."BaseComponent"]
        /// </summary>
        public unsafe readonly partial struct Ptr_DataComponent
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
            ///   GameMain.ClubSystem.Club get_Obj()
            /// </summary>
            /// <returns>class GameMain.ClubSystem.Club</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Obj", "GameMain.ClubSystem.Club", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_OBJ(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem".""."BaseComponent"]
        /// </summary>
        public unsafe readonly partial struct Ptr_DataComponent
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
        }

        /// <summary>
        /// abstract class ["Utility".""."BaseComponent"]
        /// </summary>
        public unsafe readonly partial struct Ptr_DataComponent
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
            ///   System.Guid get_Id()
            /// </summary>
            /// <returns>struct System.Guid</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Id", "System.Guid", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Guid GET_ID(); 
*/
            /// <summary>
            ///   System.Boolean get_IsActive()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsActive", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_ACTIVE(); 
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
            ///   Utility.GeneralObject.GeneralObject get_Obj()
            /// </summary>
            /// <returns>abstract class Utility.GeneralObject.GeneralObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Obj", "Utility.GeneralObject.GeneralObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_OBJ(); 
*/
            /// <summary>
            ///   System.Void OnCreate(Utility.GeneralObject.GeneralObject obj)
            /// </summary>
            /// <param name = "obj">abstract class Utility.GeneralObject.GeneralObject</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnCreate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject", 0)]
            public partial void ON_CREATE(nint obj); 
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
            ///   System.Void OnObjStart()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnObjStart", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_OBJ_START(); 
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
            ///   System.Void set_IsActive(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsActive", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_IS_ACTIVE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_Name(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Name", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_NAME(nint value); 
*/
            /// <summary>
            ///   System.Void set_Obj(Utility.GeneralObject.GeneralObject value)
            /// </summary>
            /// <param name = "value">abstract class Utility.GeneralObject.GeneralObject</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Obj", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject", 0)]
            public partial void SET_OBJ(nint value); 
*/
            /// <summary>
            ///   System.Boolean Utility.GeneralObject.GeneralObject.IComponent.get_IsActive()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent.get_IsActive", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean UTILITY_GENERAL_OBJECT_GENERAL_OBJECT_I_COMPONENTGET_IS_ACTIVE(); 
*/
            /// <summary>
            ///   System.Void Utility.GeneralObject.GeneralObject.IComponent.OnAddToObject(Utility.GeneralObject.GeneralObject obj, System.String name)
            /// </summary>
            /// <param name = "obj">abstract class Utility.GeneralObject.GeneralObject</param>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent.OnAddToObject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void UTILITY_GENERAL_OBJECT_GENERAL_OBJECT_I_COMPONENT_ON_ADD_TO_OBJECT(nint obj, nint name); 
*/
            /// <summary>
            ///   System.Void Utility.GeneralObject.GeneralObject.IComponent.OnObjStart()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent.OnObjStart", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UTILITY_GENERAL_OBJECT_GENERAL_OBJECT_I_COMPONENT_ON_OBJ_START(); 
*/
            /// <summary>
            ///   System.Void Utility.GeneralObject.GeneralObject.IComponent.set_IsActive(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent.set_IsActive", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void UTILITY_GENERAL_OBJECT_GENERAL_OBJECT_I_COMPONENTSET_IS_ACTIVE(System.Boolean value); 
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
        /// abstract class ["Utility.GameSystem".""."BaseComponent"]
        /// </summary>
        public unsafe readonly partial struct Ptr_DataComponent
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
            ///   Utility.GameSystem.LogicFrameworkX.LogicObject get_Obj()
            /// </summary>
            /// <returns>abstract class Utility.GameSystem.LogicFrameworkX.LogicObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Obj", "Utility.GameSystem.LogicFrameworkX.LogicObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_OBJ(); 
*/
        }
    }
}
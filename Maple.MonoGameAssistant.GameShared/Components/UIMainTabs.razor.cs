using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Shared;
using Masa.Blazor;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UIMainTabs
    {
        public static StringNumber Tab_Default => Tab_Currency;
        public static StringNumber Tab_Currency { get; } = (int)EnumGameUITabKey.Tab_Currency;
        public static StringNumber Tab_Inventory { get; } = (int)EnumGameUITabKey.Tab_Inventory;
        public static StringNumber Tab_Character { get; } = (int)EnumGameUITabKey.Tab_Character;
        public static StringNumber Tab_Misc { get; } = (int)EnumGameUITabKey.Tab_Misc;
        public static StringNumber Tab_Monster { get; } = (int)EnumGameUITabKey.Tab_Monster;
        //public static StringNumber Tab_Quest { get; } = (int)EnumGameUITabKey.Tab_Quest;
        public static StringNumber Tab_Skill { get; } = (int)EnumGameUITabKey.Tab_Skill;
        //public static StringNumber Tab_Forge { get; } = (int)EnumGameUITabKey.Tab_Forge;


        [NotNull]
        [CascadingParameter]
        public MainLayout? Main { set; get; }


        [NotNull]
        public StringNumber? NavTab
        {
            get => Main.NavTab;
            set => Main.NavTab = value;
        }

    }
}
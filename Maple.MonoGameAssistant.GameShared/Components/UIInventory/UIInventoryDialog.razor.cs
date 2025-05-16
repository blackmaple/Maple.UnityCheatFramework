using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components.UIInventory
{
    public partial class UIInventoryDialog
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        public GameInventoryDisplayDTO InventoryDisplay => InventoryView.InventoryDisplay;

        public GameInventoryInfoDTO InventoryInfo => InventoryView.InventoryInfo;



        [Parameter, EditorRequired, NotNull]
        public GameInventoryView? InventoryView { get; set; }

        private bool Loading { set; get; } = false;
        private async Task OnUpdateInventoryInfo()
        {
            try
            {
                Loading = true;
                //  await Core.OnUpdateInventory(InventoryDisplay.DisplayCategory, InventoryInfo);
                await Core.OnUpdateInventory(InventoryView);
            }
            finally
            {
                Loading = false;
            }
        }



    }
}
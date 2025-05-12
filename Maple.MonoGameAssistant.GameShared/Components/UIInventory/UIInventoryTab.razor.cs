using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components.UIInventory
{
    public partial class UIInventoryTab
    {

        protected sealed override ValueTask OnSearch()
        {
            Core.OnSearchInventory(SearchContent);
            return ValueTask.CompletedTask;

        }

        protected sealed override async Task OnReload()
        {
            using (Core.ShowWait())
            {
                await Core.GetListInventoryDisplayAsync();
            }
        }

        private async Task OnSelected(GameInventoryDisplayDTO gameInventory)
        {
            try
            {
                gameInventory.Loading = true;
                await Core.OnSelectedInventory(gameInventory);
            }
            finally
            {
                gameInventory.Loading = false;
            }

        }
    }
}
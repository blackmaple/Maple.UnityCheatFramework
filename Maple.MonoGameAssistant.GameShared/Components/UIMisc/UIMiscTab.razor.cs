using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components.UIMisc
{
    public partial class UIMiscTab
    {

        protected sealed override ValueTask OnSearch()
        {
            Core.OnSearchSwitch(SearchContent);
            return ValueTask.CompletedTask;
        }

        protected sealed override async Task OnReload()
        {
            using (Core.ShowWait())
            {
                await Core.GetListSwitchDisplayAsync();
            }
        }

        private async Task OnChange(GameSwitchDisplayDTO gameSwitchDisplay, bool mSwitch = false)
        {
            try
            {
                gameSwitchDisplay.Loading = true;
                await Core.UpdateSwitchDisplay(gameSwitchDisplay, mSwitch);
            }
            finally
            {
                gameSwitchDisplay.Loading = false;
            }
        }

    }
}
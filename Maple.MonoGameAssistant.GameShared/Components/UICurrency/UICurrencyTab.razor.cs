using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components.UICurrency
{
    public partial class UICurrencyTab
    {

        protected sealed override ValueTask OnSearch()
        {
            Core.OnSearchCurrency(SearchContent);
            return ValueTask.CompletedTask;
        }

        protected sealed override async Task OnReload()
        {
            using (Core.ShowWait())
            {
                await Core.GetListCurrencyDisplayAsync();
            }
        }

        private async Task OnSelected(GameCurrencyDisplayDTO gameCurrency)
        {
            try
            {
                gameCurrency.Loading = true;
                await Core.OnSelectedCurrency(gameCurrency);

            }
            finally
            {
                gameCurrency.Loading = false;
            }

        }
    }
}
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.ModelView;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components.UICurrency
{
    public partial class UICurrencyDialog
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        public GameCurrencyDisplayDTO CurrencyDisplay => CurrencyView.CurrencyDisplay;
        public GameCurrencyInfoDTO CurrencyInfo => CurrencyView.CurrencyInfo;

        [Parameter, EditorRequired, NotNull]
        public GameCurrencyView? CurrencyView { get; set; }


        private async Task OnUpdateCurrency()
        {
            try
            {
                CurrencyDisplay.Loading = true;
       //         await Core.OnUpdateCurrency(CurrencyInfo, CurrencyDisplay.DisplayCategory);
                await Core.OnUpdateCurrency(this.CurrencyView);
            }
            finally
            {
                CurrencyDisplay.Loading = false;
            }
        }



    }
}
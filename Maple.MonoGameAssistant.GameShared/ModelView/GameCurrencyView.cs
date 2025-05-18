using Maple.MonoGameAssistant.GameDTO;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.GameShared.ModelView
{
    public class GameCurrencyView
    {
        public required GameCurrencyDisplayDTO CurrencyDisplay { get; init; }
        public required GameCurrencyInfoDTO CurrencyInfo { get; init; }

        public void Update(GameCurrencyInfoDTO content) => CurrencyInfo.DisplayValue = content.DisplayValue;
        public sealed override string ToString()
        {
            return $"{CurrencyDisplay.DisplayName}:{CurrencyInfo.DisplayValue}";
        }
    }
}

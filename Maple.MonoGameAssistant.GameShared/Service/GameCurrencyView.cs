using Maple.MonoGameAssistant.GameDTO;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.GameShared.Service
{
    public class GameCurrencyView
    {
        public required GameCurrencyDisplayDTO CurrencyDisplay { get; init; }
        public required GameCurrencyInfoDTO CurrencyInfo { get; init; }

        public void Update(GameCurrencyInfoDTO content) => this.CurrencyInfo.DisplayValue = content.DisplayValue;
        public sealed override string ToString()
        {
            return $"{this.CurrencyDisplay.DisplayName} + {this.CurrencyInfo.DisplayValue}";
        }
    }

    public class GameInventoryView
    {
         
        public required GameInventoryDisplayDTO InventoryDisplay { get; init; }
        public required GameInventoryInfoDTO InventoryInfo { get; init; }

        public void Update(GameInventoryInfoDTO content) => this.InventoryInfo.DisplayValue = content.DisplayValue;
        public sealed override string ToString()
        {
            return $"{this.InventoryDisplay.DisplayName} + {this.InventoryInfo.DisplayValue}";
        }
    }
}

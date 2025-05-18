using Maple.MonoGameAssistant.GameDTO;

namespace Maple.MonoGameAssistant.GameShared.ModelView
{
    public class GameInventoryView
    {

        public required GameInventoryDisplayDTO InventoryDisplay { get; init; }
        public required GameInventoryInfoDTO InventoryInfo { get; init; }

        public void Update(GameInventoryInfoDTO content) => InventoryInfo.DisplayValue = content.DisplayValue;
        public sealed override string ToString()
        {
            return $"{InventoryDisplay.DisplayName}:{InventoryInfo.DisplayValue}";
        }
    }
}

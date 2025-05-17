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


    public class GameCharacterSkillView(GameCharacterDisplayDTO characterDisplayDTO, GameCharacterSkillDTO skillDTO)
    {
        public GameCharacterDisplayDTO CharacterDisplay { get; } = characterDisplayDTO;

        public GameCharacterSkillDTO CharacterSkill { get; } = skillDTO;

        public List<GameSkillInfoDTO> SkillInfos { get; } = skillDTO.SkillInfos is not null ? [.. skillDTO.SkillInfos] : [];
    }


    public class GameCharacterStatusView(GameCharacterDisplayDTO characterDisplayDTO, GameCharacterStatusDTO statusDTO)
    {
        public GameCharacterDisplayDTO CharacterDisplay { get; } = characterDisplayDTO;
        public GameCharacterStatusDTO CharacterStatus { get; } = statusDTO;

        public List<GameSwitchDisplayDTO> CharacterAttributes { get; } = statusDTO.CharacterAttributes is not null ? [.. statusDTO.CharacterAttributes] : [];
    }
}

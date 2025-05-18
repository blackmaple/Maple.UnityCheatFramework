using Maple.MonoGameAssistant.GameDTO;

namespace Maple.MonoGameAssistant.GameShared.ModelView
{
    public class GameCharacterStatusView(GameCharacterDisplayDTO characterDisplayDTO, GameCharacterStatusDTO statusDTO)
    {
        public GameCharacterDisplayDTO CharacterDisplay { get; } = characterDisplayDTO;
        public GameCharacterStatusDTO CharacterStatus { get; } = statusDTO;

        public List<GameSwitchDisplayDTO> CharacterAttributes { get; } = statusDTO.CharacterAttributes is not null ? [.. statusDTO.CharacterAttributes] : [];
    }
}

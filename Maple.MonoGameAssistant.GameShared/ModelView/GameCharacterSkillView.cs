using Maple.MonoGameAssistant.GameDTO;

namespace Maple.MonoGameAssistant.GameShared.ModelView
{
    public class GameCharacterSkillView(GameCharacterDisplayDTO characterDisplayDTO, GameCharacterSkillDTO skillDTO)
    {
        public GameCharacterDisplayDTO CharacterDisplay { get; } = characterDisplayDTO;

        public GameCharacterSkillDTO CharacterSkill { get; } = skillDTO;

        public List<GameSkillInfoDTO> SkillInfos { get; } = skillDTO.SkillInfos is not null ? [.. skillDTO.SkillInfos] : [];
    }
}

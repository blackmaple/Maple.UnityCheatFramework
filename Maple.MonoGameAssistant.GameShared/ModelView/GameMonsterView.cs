using Maple.MonoGameAssistant.GameDTO;

namespace Maple.MonoGameAssistant.GameShared.ModelView
{
    public class GameMonsterView(GameMonsterDisplayDTO monsterDisplayDTO)
    {
        public GameMonsterDisplayDTO MonsterDisplayDTO { get; } = monsterDisplayDTO;

        public List<GameSkillInfoDTO> SkillInfos { get; } = monsterDisplayDTO.SkillInfos is not null ? [.. monsterDisplayDTO.SkillInfos] : [];

    }
}

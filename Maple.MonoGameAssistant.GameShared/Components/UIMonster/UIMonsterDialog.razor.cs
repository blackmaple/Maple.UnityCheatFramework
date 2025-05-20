using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.ModelView;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components.UIMonster
{
    public partial class UIMonsterDialog
    {

        public GameMonsterDisplayDTO MonsterDisplayDTO => View.MonsterDisplayDTO;
        public GameValueInfoDTO[]? MonsterAttributes => MonsterDisplayDTO.MonsterAttributes;

        public List<GameSkillInfoDTO> Skills => View.SkillInfos;

        [Parameter, EditorRequired, NotNull]
        public required GameMonsterView View { get; set; }



    }
}
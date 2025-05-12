using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components.UICharacter
{
    public partial class UICharacterSkillDialog
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        [Parameter, EditorRequired, NotNull]
        public GameCharacterDisplayDTO? CharacterDisplay { get; set; }

        [Parameter, EditorRequired, NotNull]
        public GameCharacterSkillDTO? CharacterSkill { get; set; }

        public List<GameSkillInfoDTO> SkillInfos { get; set; } = [];

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if (CharacterSkill is not null && CharacterSkill.SkillInfos is not null)
            {
                SkillInfos.AddRange(CharacterSkill.SkillInfos);
            }
        }

        private bool Loading { set; get; } = false;
        private async Task OnUpdateCharacterSkill(GameSkillInfoDTO selectedData, bool remove)
        {
            try
            {
                Loading = true;
                await Core.OnUpdateCharacterSkill(CharacterDisplay, selectedData, remove);
            }
            finally
            {
                Loading = false;
            }
        }



    }
}
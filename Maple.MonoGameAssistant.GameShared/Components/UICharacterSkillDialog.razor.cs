using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
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
                this.SkillInfos.AddRange(CharacterSkill.SkillInfos);
            }
        }

        private bool Loading { set; get; } = false;
        private async Task OnUpdateCharacterSkill(GameSkillInfoDTO selectedData, bool remove)
        {
            try
            {
                this.Loading = true;
                await this.Core.OnUpdateCharacterSkill(CharacterDisplay, selectedData, remove);
            }
            finally
            {
                this.Loading = false;
            }
        }



    }
}
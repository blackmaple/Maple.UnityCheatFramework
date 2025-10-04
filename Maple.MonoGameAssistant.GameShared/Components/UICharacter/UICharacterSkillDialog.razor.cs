using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.ModelView;
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

        public GameCharacterDisplayDTO CharacterDisplay => this.SkillView.CharacterDisplay;

        public GameCharacterSkillDTO CharacterSkill => this.SkillView.CharacterSkill;

        public List<GameSkillInfoDTO> SkillInfos => this.SkillView.SkillInfos;

        [Parameter, EditorRequired, NotNull]
        public GameCharacterSkillView? SkillView { get; set; }



        private async Task OnUpdateCharacterSkill(GameSkillInfoDTO selectedData, bool remove)
        {
            try
            {
                selectedData.Loading = true;
                var skills = await Core.OnUpdateCharacterSkillEx(SkillView, selectedData, remove);
                if (skills is not null)
                {
                    this.SkillInfos.ReplaceRange(skills);
                }
            }
            finally
            {
                selectedData.Loading = false;
            }
        }



    }
}
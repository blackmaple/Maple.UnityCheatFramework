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



        private bool Loading { set; get; } = false;
        private async Task OnUpdateCharacterSkill()
        {
            try
            {
                this.Loading = true;
                await Task.Delay(5000);
            }
            finally
            {
                this.Loading = false;
            }
        }

    }
}
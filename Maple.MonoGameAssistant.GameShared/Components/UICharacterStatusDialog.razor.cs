using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components
{
    public partial class UICharacterStatusDialog
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        [Parameter, EditorRequired, NotNull]
        public GameCharacterDisplayDTO? CharacterDisplay { get; set; }

        [Parameter, EditorRequired, NotNull]
        public GameCharacterStatusDTO? CharacterStatus { get; set; }

        public List<GameSwitchDisplayDTO> CharacterAttributes { set; get; } = [];

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if (CharacterStatus is not null && CharacterStatus.CharacterAttributes is not null)
            {
                CharacterAttributes.AddRange(CharacterStatus.CharacterAttributes);
            }
        }

        private async Task OnUpdateCharacterStatus(GameSwitchDisplayDTO gameValue)
        {
            try
            {
                gameValue.Loading = true;

                await this.Core.OnUpdateCharacteStatus(CharacterDisplay, CharacterStatus, gameValue);

            }
            finally
            {
                gameValue.Loading = false;
            }
        }

    }
}
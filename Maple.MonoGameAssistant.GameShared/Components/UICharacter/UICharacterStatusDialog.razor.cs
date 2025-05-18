using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.ModelView;
using Maple.MonoGameAssistant.GameShared.Service;
using Masa.Blazor;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components.UICharacter
{
    public partial class UICharacterStatusDialog
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        public GameCharacterDisplayDTO CharacterDisplay => StatusView.CharacterDisplay;

        public GameCharacterStatusDTO CharacterStatus => StatusView.CharacterStatus;

        public List<GameSwitchDisplayDTO> CharacterAttributes => StatusView.CharacterAttributes;


        [Parameter, EditorRequired, NotNull]
        public GameCharacterStatusView StatusView { get; set; }


        private async Task OnUpdateCharacterStatus(GameSwitchDisplayDTO gameValue)
        {
            try
            {
                gameValue.Loading = true;

                await Core.OnUpdateCharacteStatus(this.StatusView, gameValue);

            }
            finally
            {
                gameValue.Loading = false;
            }
        }
        private Task OnUpdateCharacterStatus(GameSwitchDisplayDTO gameValue, GameValueInfoDTO value, bool isMultiple)
        {
            if (isMultiple)
            {
                if (gameValue.MultipleIsActive(value))
                {
                    gameValue.ContentValue = gameValue.MultipleRemoveActive(value);
                }
                else
                {
                    gameValue.ContentValue = gameValue.MultipleAddActive(value);

                }
            }
            else
            {
                gameValue.ContentValue = value.DisplayValue;
            }
           // return Task.CompletedTask;

            return OnUpdateCharacterStatus(gameValue);
        }

    }
}
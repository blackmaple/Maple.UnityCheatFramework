using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Components.UIBase;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components.UICharacter
{
    public partial class UICharacterTab
    {

        protected sealed override ValueTask OnSearch()
        {
            Core.OnSearchCharacter(SearchContent);
            return ValueTask.CompletedTask;
        }

        protected sealed override async Task OnReload()
        {
            using (Core.ShowWait())
            {
                await Core.GetListCharacterDisplayAsync();
            }
        }

        private async Task OnSelectedCharacterStatus(GameCharacterDisplayDTO gameCharacter)
        {
            try
            {
                gameCharacter.Loading = true;
                await Core.OnSelectedCharacterStatus(gameCharacter);

            }
            finally
            {
                gameCharacter.Loading = false;
            }
        }

        private async Task OnSelectedCharacterSkill(GameCharacterDisplayDTO gameCharacter)
        {
            try
            {
                gameCharacter.Loading = true;
                await Core.OnSelectedCharacterSkill(gameCharacter);
            }
            finally
            {
                gameCharacter.Loading = false;
            }
        }

        [Obsolete("remove...")]
        private async Task OnSelectedCharacterEquipment(GameCharacterDisplayDTO gameCharacter)
        {
            try
            {
                gameCharacter.Loading = true;
                await Core.OnSelectedCharacterEquipment(gameCharacter);
            }
            finally
            {
                gameCharacter.Loading = false;
            }
        }
    }
}
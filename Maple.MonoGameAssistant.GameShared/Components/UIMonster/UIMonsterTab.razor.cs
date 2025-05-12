using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Masa.Blazor;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components.UIMonster
{
    public partial class UIMonsterTab
    {
        protected sealed override ValueTask OnSearch()
        {
            Core.OnSearchMonster(SearchContent);
            return ValueTask.CompletedTask;
        }

        protected sealed override async Task OnReload()
        {
            using (Core.ShowWait())
            {
                await Core.GetListMonsterDisplayAsync();
            }
        }

        private async Task OnSelected(GameMonsterDisplayDTO gameMonster)
        {
            await Core.OnSelectedMonster(gameMonster);
        }

        private async Task OnAddMonsterMember(GameMonsterDisplayDTO gameMonster)
        {

            await Core.OnAddMonsterMember(gameMonster);
        }

    }
}
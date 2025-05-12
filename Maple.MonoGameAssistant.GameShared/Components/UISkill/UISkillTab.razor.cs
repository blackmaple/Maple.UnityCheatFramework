using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components.UISkill
{
    public partial class UISkillTab
    {


        protected sealed override ValueTask OnSearch()
        {
            Core.OnSearchSkill(SearchContent);
            return ValueTask.CompletedTask;
        }

        protected sealed override async Task OnReload()
        {
            using (Core.ShowWait())
            {
                await Core.GetListSkillDisplayAsync();
            }
        }
        private async Task OnUpdate(GameSkillDisplayDTO gameSkillDisplay)
        {
            try
            {
                gameSkillDisplay.Loading = true;
                await Core.AddSkillDisplayAsync(gameSkillDisplay);
            }
            finally
            {
                gameSkillDisplay.Loading = false;
            }

        }
    }
}
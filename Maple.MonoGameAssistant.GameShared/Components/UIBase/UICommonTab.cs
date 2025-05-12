using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components.UIBase
{
    public class UICommonTab : ComponentBase
    {
        [Inject]
        [NotNull]
        protected GameCoreService? Core { get; set; }
        protected string? SearchContent { set; get; }
        //[Parameter]
        //public EnumGameUITabKey TabKey { set; get; }
        protected virtual ValueTask OnSearch()
        {
            return ValueTask.CompletedTask;
        }
        protected virtual ValueTask OnSearch(string? displayCategory)
        {
            this.SearchContent = displayCategory;
            return this.OnSearch();

        }
        protected virtual Task OnReload()
        {
            return Task.CompletedTask;
        }
    }
}
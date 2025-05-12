using Microsoft.AspNetCore.Components;

namespace Maple.MonoGameAssistant.GameShared.Components.UIBase
{
    public partial class UIDynamicHeight
    {
        [Parameter]
        public required RenderFragment ChildContent { get; set; }
    }
}
using Maple.MonoGameAssistant.GameShared.Service;
using Maple.MonoGameAssistant.GameShared.Shared;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Pages
{
    public partial class Index
    {
        [NotNull]
        [Inject]
        public GameCoreService? Core { set; get; }

        [NotNull]
        [CascadingParameter]
        public MainLayout? Main { set; get; }

        public EnumGameServiceStatus Status
        {
            get => Main.Status;
            set => Main.Status = value;
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await LoadServiceDataAsync();
        }

        public bool Loading { set; get; }

        public async Task LoadServiceDataAsync()
        {
            try
            {
                this.Loading = true;
                var status = await this.Core.OnInitializedAsync();
                this.Main.UppdateNavTabs(status);

            }
            finally
            {
                this.Loading = false;
            }
        }


    }
}
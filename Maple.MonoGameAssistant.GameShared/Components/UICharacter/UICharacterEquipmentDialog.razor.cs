using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components.UICharacter
{
    [Obsolete("remove...")]
    public partial class UICharacterEquipmentDialog
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        [Parameter, EditorRequired, NotNull]
        public GameCharacterDisplayDTO? CharacterDisplay { get; set; }

        [Parameter, EditorRequired, NotNull]
        public GameCharacterEquipmentDTO? CharacterEquipment { get; set; }



        private bool Loading { set; get; } = false;
        [Obsolete("remove...")]
        private async Task OnUpdateCharacterEquipment(GameEquipmentInfoDTO selectedData, bool remove)
        {
            try
            {
                Loading = true;
                await Core.OnUpdateCharacterEquipment(CharacterDisplay, selectedData, remove);
              
            }
            finally
            {
                Loading = false;
            }
        }


    }
}
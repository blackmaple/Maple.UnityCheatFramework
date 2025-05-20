using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.GameShared.Service;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.GameShared.Components.UIDialog
{
    public partial class UIVersionDialog
    {
        [Inject]
        [NotNull]
        private GameCoreService? Core { get; set; }

        [NotNull, Parameter, EditorRequired]
        public required GameCharacterDisplayDTO GameCharacter { get; set; }


        public List<GameValueInfoDTO> Items => GameCharacter.CharacterAttributes is not null ? ([.. GameCharacter.CharacterAttributes]) : [];

    }
}
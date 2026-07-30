using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UILogic;

public sealed class GameFieldInfo : GameBaseInfo
{
    [NotNull]
    public MonoFieldInfoDTO? RawFieldInfo { get; set; }

}
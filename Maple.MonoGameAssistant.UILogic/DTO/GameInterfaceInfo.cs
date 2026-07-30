using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UILogic;

public sealed class GameInterfaceInfo : GameBaseInfo
{
    [NotNull]
    public MonoInterfaceInfoDTO? RawInterfaceInfo { get; set; }

}
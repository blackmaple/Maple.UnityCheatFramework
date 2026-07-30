using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UILogic;

public sealed class GameParentClassInfo : GameBaseInfo
{
    [NotNull]
    public MonoClassInfoDTO? RawClassInfo { get; set; }

}

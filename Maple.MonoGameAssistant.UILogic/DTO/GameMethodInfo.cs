using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.UILogic;


public sealed class GameMethodInfo: GameBaseInfo
{
    [NotNull]
    public MonoMethodInfoDTO? RawMethodInfo { get; set; }


    public List<GameParameterType>? ParameterTypes { get; set; } 
}

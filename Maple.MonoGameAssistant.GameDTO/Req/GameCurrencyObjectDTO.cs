namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameCurrencyObjectDTO : GameSessionObjectDTO
    {
        public string? CurrencyCategory { set; get; }

        public required string CurrencyObject { set; get; }
    }

}

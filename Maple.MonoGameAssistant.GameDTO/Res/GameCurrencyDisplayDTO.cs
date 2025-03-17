using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameCurrencyDisplayDTO : GameObjectDisplayDTO
    {

        /// <summary>
        /// 资产属性集合
        /// </summary>
        public GameValueInfoDTO[]? CurrencyAttributes { set; get; }


        [JsonIgnore]
        public bool Loading { set; get; }
    }
}

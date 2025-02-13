using Maple.MonoGameAssistant.Model;
using System.Text.Json.Serialization;

namespace Maple.MonoGameAssistant.GameDTO
{
    public class GameSkillInfoDTO : GameObjectDisplayDTO
    {



        ///// <summary>
        ///// 技能类型
        ///// </summary>
        //public string? DisplayCategory { set; get; }

        /// <summary>
        /// 技能属性
        /// </summary>
        public GameValueInfoDTO[]? SkillAttributes { set; get; }


        public bool CanWrite { set; get; }

        [JsonIgnore]
        public bool Loading { set; get; }
    }
}

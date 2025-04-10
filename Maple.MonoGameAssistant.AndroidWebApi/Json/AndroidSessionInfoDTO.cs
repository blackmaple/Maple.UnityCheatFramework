using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public class AndroidSessionInfoDTO : GameSessionInfoDTO
    {
        public bool Add { set; get; }
        public string? Address { get; set; }
    }
}

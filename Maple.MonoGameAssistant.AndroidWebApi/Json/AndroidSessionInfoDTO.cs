using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public class AndroidSessionInfoDTO : GameSessionInfoDTO
    {
        public bool Status { set; get; }
        public string? Address { get; set; }
    }
}

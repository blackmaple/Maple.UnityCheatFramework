using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector
{
    [Obsolete("remove...")]
    public class MonoCollectorImageInfo(MonoImageInfoDTO imageInfoDTO)
    {
        public MonoImageInfoDTO ImageInfoDTO { get; } = imageInfoDTO;
        public List<MonoCollectorClassInfo> ListClassInfo { get; } = [];
    }
}

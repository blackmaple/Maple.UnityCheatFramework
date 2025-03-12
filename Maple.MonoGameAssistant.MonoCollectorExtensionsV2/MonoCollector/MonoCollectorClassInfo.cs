using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.MonoCollectorExtensionsV2.MonoCollector
{
    public class MonoCollectorClassInfo(MonoClassInfoDTO classInfoDTO)
    {
        public MonoClassInfoDTO ClassInfoDTO { get; } = classInfoDTO;

        public List<MonoClassInfoDTO> ParentClasses { get; } = [];
        public List<MonoMethodInfoDTO> MethodInfos { get; } = [];
        public List<MonoFieldInfoDTO> FieldInfos { get; } = [];

    }
}

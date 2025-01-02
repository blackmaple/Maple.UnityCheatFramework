 

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{
#if MetadataSourceGenerator
    internal class MonoJsonMethodDTO (ulong code, byte[]? utf8name, byte[]?[]? utf8Parameters, byte[]? utf8ReturnType)
    {
 
    }
#else
    public class MonoJsonMethodDTO : Maple.MonoGameAssistant.Model.MonoDescriptionMethodDTO
    {
        public MonoJsonMethodDTO(ulong code, byte[]? utf8name, byte[]?[]? utf8Parameters, byte[]? utf8ReturnType)
        {

            this.Code = code;
            this.Utf8Name = utf8name;
            this.Utf8Parameters = utf8Parameters;
            this.Utf8ReturnType = utf8ReturnType;

        }
    }
#endif 


}

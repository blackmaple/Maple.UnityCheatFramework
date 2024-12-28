using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon
{
    public sealed class MonoClassMetadataCollection
    {
        public required MonoClassInfoDTO ClassInfo { get; init; }
        public required MonoMethodInfoDTO[] MethodInfos { get; init; }
        public required MonoFieldInfoDTO[] FieldInfos { get; init; }


        public IEnumerable<MonoFieldInfoDTO> EnumMemberFieldInfos()
        {
            if (ClassInfo.IsEnum == false)
            {
                foreach (var field in FieldInfos)
                {
                    if (field.IsStatic == false)
                    {
                        yield return field;
                    }
                }
            }
        }

        public IEnumerable<MonoFieldInfoDTO> EnumStaticFieldInfos()
        {
            if (ClassInfo.IsEnum == false)
            {
                foreach (var field in FieldInfos)
                {
                    if (field.IsStatic && field.IsConst == false)
                    {
                        yield return field;
                    }
                }
            }
        }

    }
}

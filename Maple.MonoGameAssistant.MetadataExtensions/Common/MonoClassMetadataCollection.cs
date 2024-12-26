namespace Maple.MonoGameAssistant.Model
{
    public sealed class MonoClassMetadataCollection
    {
        public required MonoClassInfoDTO ClassInfo { get; init; }
        public required MonoMethodInfoDTO[] MethodInfos { get; init; }
        public required MonoFieldInfoDTO[] FieldInfos { get; init; }


        public IEnumerable<MonoFieldInfoDTO> EnumMemberFieldInfos()
        {
            if (this.ClassInfo.IsEnum == false)
            {
                foreach (var field in this.FieldInfos)
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
            if (this.ClassInfo.IsEnum == false)
            {
                foreach (var field in this.FieldInfos)
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

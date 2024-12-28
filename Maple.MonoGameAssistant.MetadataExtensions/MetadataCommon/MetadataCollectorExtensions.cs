using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon
{


    internal static class MetadataCollectorExtensions
    {


        public static bool EqualImageName(this MonoObjectNameDTO imageNameDTO, MonoDescriptionClassDTO searchClassDTO)
        {
            var imageName = imageNameDTO.Utf8Name.AsSpan();
            var searchImageName = searchClassDTO.Utf8ImageName.AsSpan();
            if (MemoryExtensions.SequenceEqual(imageName, searchImageName))
            {
                return true;
            }
            return searchImageName.EndsWith(".dll"u8) && MemoryExtensions.SequenceEqual(imageName, searchImageName[..^4]);
        }

        public static bool EqualMethodName(this MonoMethodInfoDTO methodInfoDTO, MonoDescriptionMethodDTO descriptionMethodDTO)
        {
            if (descriptionMethodDTO.Utf8Name is null)
            {
                return true;
            }
            return MemoryExtensions.SequenceEqual(methodInfoDTO.Utf8Name, descriptionMethodDTO.Utf8Name);
        }
        public static bool EqualMethodReturnType(this MonoMethodInfoDTO methodInfoDTO, MonoDescriptionMethodDTO descriptionMethodDTO)
        {
            if (descriptionMethodDTO.Utf8ReturnType is null)
            {
                return true;
            }
            return MemoryExtensions.SequenceEqual(methodInfoDTO.ReturnType.Utf8FullName, descriptionMethodDTO.Utf8ReturnType);

        }
        public static bool EqualMethodParameterTypes(this MonoMethodInfoDTO methodInfoDTO, MonoDescriptionMethodDTO descriptionMethodDTO)
        {
            if (descriptionMethodDTO.Utf8Parameters is null)
            {
                return true;
            }
            var searchArray = descriptionMethodDTO.Utf8Parameters.AsSpan();
            var parameterTypes = methodInfoDTO.ParameterTypes.AsSpan();
            var rawCount = parameterTypes.Length;
            if (rawCount != searchArray.Length)
            {
                return false;
            }


            for (int i = 0; i < rawCount; ++i)
            {
                var fullName = parameterTypes[i % rawCount].Utf8FullName;
                var searchName = searchArray[i % rawCount];
                if (false == MemoryExtensions.SequenceEqual(fullName, searchName))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool EqualFieldName(this MonoFieldInfoDTO fieldInfoDTO, MonoDescriptionFieldDTO descriptionFieldDTO)
        {
            if (descriptionFieldDTO.Utf8Name is null)
            {
                return true;
            }
            return MemoryExtensions.SequenceEqual(fieldInfoDTO.Utf8Name, descriptionFieldDTO.Utf8Name);
        }
        public static bool EqualFieldType(this MonoFieldInfoDTO fieldInfoDTO, MonoDescriptionFieldDTO descriptionFieldDTO)
        {
            if (descriptionFieldDTO.Utf8FieldType is null)
            {
                return true;
            }
            return MemoryExtensions.SequenceEqual(fieldInfoDTO.FieldType.Utf8FullName, descriptionFieldDTO.Utf8FieldType);
        }


    }
}

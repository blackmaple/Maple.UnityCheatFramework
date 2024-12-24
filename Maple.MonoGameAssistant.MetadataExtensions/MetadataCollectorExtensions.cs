using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public static class MetadataCollectorExtensions
    {
        public static bool IsNotNull<T_PTR>(this T_PTR @this) where T_PTR : unmanaged, IPtrMetadata
            => @this.Ptr != nint.Zero;
        public static bool IsNull<T_PTR>(this T_PTR @this) where T_PTR : unmanaged, IPtrMetadata
            => @this.Ptr == nint.Zero;

        public static bool EqualImageName(this MonoObjectNameDTO imageNameDTO, MonoSearchClassDTO searchClassDTO)
        {
            var imageName = imageNameDTO.Utf8Name.AsSpan();
            var searchImageName = searchClassDTO.Utf8ImageName.AsSpan();
            if (MemoryExtensions.SequenceEqual(imageName, searchImageName))
            {
                return true;
            }
            return searchImageName.EndsWith(".dll"u8) && MemoryExtensions.SequenceEqual(imageName, searchImageName[..^4]);
        }

        public static bool EqualMethodName(this MonoMethodInfoDTO methodInfoDTO, MonoSearchMethodDTO searchMethodDTO)
        {
            return MemoryExtensions.SequenceEqual(methodInfoDTO.Utf8Name, searchMethodDTO.Utf8Name);
        }
        public static bool EqualMethodReturnType(this MonoMethodInfoDTO methodInfoDTO, MonoSearchMethodDTO searchMethodDTO)
        {
            return MemoryExtensions.SequenceEqual(methodInfoDTO.ReturnType.Utf8FullName, searchMethodDTO.Utf8ReturnType);

        }
        public static bool EqualMethodParameterTypes(this MonoMethodInfoDTO methodInfoDTO, MonoSearchMethodDTO searchMethodDTO)
        {
            var searchArray = searchMethodDTO.Utf8Signature.AsSpan();
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

        public static bool EqualFieldName(this MonoFieldInfoDTO fieldInfoDTO, MonoSearchFieldDTO searchFieldDTO)
        {
            return MemoryExtensions.SequenceEqual(fieldInfoDTO.Utf8Name, searchFieldDTO.Utf8Name);
        }
        public static bool EqualFieldType(this MonoFieldInfoDTO fieldInfoDTO, MonoSearchFieldDTO searchFieldDTO)
        {
            return MemoryExtensions.SequenceEqual(fieldInfoDTO.FieldType.Utf8FullName, searchFieldDTO.Utf8FieldType);
        }
 
        public static IEnumerable<MonoFieldInfoDTO> EnumMemberFieldInfos(this MonoClassMetadataCollection  classMetadataCollection )
        {
            if (classMetadataCollection.ClassInfo.IsEnum == false)
            {
                foreach (var field in classMetadataCollection.FieldInfos)
                {
                    if (field.IsStatic == false)
                    {
                        yield return field;
                    }
                }
            }
        }
        public static IEnumerable<MonoFieldInfoDTO> EnumStaticFieldInfos(this MonoClassMetadataCollection classMetadataCollection)
        {
            if (classMetadataCollection.ClassInfo.IsEnum == false)
            {
                foreach (var field in classMetadataCollection.FieldInfos)
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

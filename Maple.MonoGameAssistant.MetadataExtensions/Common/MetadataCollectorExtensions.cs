using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Reflection;
using System.Runtime.CompilerServices;
using Maple.MonoGameAssistant.Core;

namespace Maple.MonoGameAssistant.MetadataExtensions.Common
{


    internal static class MetadataCollectorExtensions
    {
        public static bool IsNotNull<T_PTR>(this T_PTR @this) where T_PTR : unmanaged, IPtrMetadata
            => @this.Ptr != nint.Zero;
        public static bool IsNull<T_PTR>(this T_PTR @this) where T_PTR : unmanaged, IPtrMetadata
            => @this.Ptr == nint.Zero;

        public static bool EqualImageName(this MonoObjectNameDTO imageNameDTO, MonoDescriptionClassDTO searchClassDTO)
        {
            var imageName = imageNameDTO.Utf8Name.AsSpan();
            var searchImageName = searchClassDTO.Utf8ImageName.AsSpan();
            if (imageName.SequenceEqual(searchImageName))
            {
                return true;
            }
            return searchImageName.EndsWith(".dll"u8) && imageName.SequenceEqual(searchImageName[..^4]);
        }

        public static bool EqualMethodName(this MonoMethodInfoDTO methodInfoDTO, MonoDescriptionMethodDTO descriptionMethodDTO)
        {
            return methodInfoDTO.Utf8Name.SequenceEqual(descriptionMethodDTO.Utf8Name);
        }
        public static bool EqualMethodReturnType(this MonoMethodInfoDTO methodInfoDTO, MonoDescriptionMethodDTO descriptionMethodDTO)
        {
            if (descriptionMethodDTO.Utf8ReturnType is null)
            {
                return true;
            }
            return methodInfoDTO.ReturnType.Utf8FullName.SequenceEqual(descriptionMethodDTO.Utf8ReturnType);

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
                if (false == fullName.SequenceEqual(searchName))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool EqualFieldName(this MonoFieldInfoDTO fieldInfoDTO, MonoDescriptionFieldDTO descriptionFieldDTO)
        {
            return fieldInfoDTO.Utf8Name.SequenceEqual(descriptionFieldDTO.Utf8Name);
        }
        public static bool EqualFieldType(this MonoFieldInfoDTO fieldInfoDTO, MonoDescriptionFieldDTO descriptionFieldDTO)
        {
            if (descriptionFieldDTO.Utf8FieldType is null)
            {
                return true;
            }
            return fieldInfoDTO.FieldType.Utf8FullName.SequenceEqual(descriptionFieldDTO.Utf8FieldType);
        }

        public static IEnumerable<MonoFieldInfoDTO> EnumMemberFieldInfos(this MonoClassMetadataCollection classMetadataCollection)
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

using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.Model;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

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
                var searchName = searchArray[i % rawCount];
                if (searchName is not null)
                {
                    var fullName = parameterTypes[i % rawCount].Utf8FullName;

                    if (false == MemoryExtensions.SequenceEqual(fullName, searchName))
                    {
                        return false;
                    }
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


        public static bool TryGetFieldMetadata(this MonoClassMetadataCollection classMetadata, MonoDescriptionFieldDTO descriptionFieldDTO, [MaybeNullWhen(false)] out MonoFieldInfoDTO fieldInfoDTO)
        {
            Unsafe.SkipInit(out fieldInfoDTO);

            IEnumerable<MonoFieldInfoDTO> fieldInfoDTOs =
                descriptionFieldDTO.IsStatic
                ? classMetadata.EnumStaticFieldInfos()
                : classMetadata.EnumMemberFieldInfos();

            foreach (var field in fieldInfoDTOs)
            {
                if (field.EqualFieldName(descriptionFieldDTO)
                    && field.EqualFieldType(descriptionFieldDTO))
                {
                    fieldInfoDTO = field;
                    return true;
                }
            }
            return false;
        }

        public static bool TryGetMethodMetadata(this MonoClassMetadataCollection classMetadata, MonoDescriptionMethodDTO descriptionMethodDTO, [MaybeNullWhen(false)] out MonoMethodInfoDTO methodInfoDTO)
        {
            Unsafe.SkipInit(out methodInfoDTO);
            foreach (var method in classMetadata.MethodInfos)
            {
                if (method.EqualMethodName(descriptionMethodDTO)
                    && method.EqualMethodReturnType(descriptionMethodDTO)
                    && method.EqualMethodParameterTypes(descriptionMethodDTO))
                {
                    methodInfoDTO = method;
                    return true;
                }
            }
            return false;

        }
        public static bool TryGetMethodPointer(this MonoRuntimeContext @this, MonoMethodInfoDTO methodInfoDTO, out nint pointer)
        {
            pointer = @this.RuntiemProvider.GetMonoMethodAddress(methodInfoDTO.Pointer);
            return pointer != nint.Zero;
        }

        public static MonoClassMetadataCollection GetMonoClassMetadataCollection(this MonoRuntimeContext runtimeContext, PMonoClass pMonoClass)
        {
            var classInfoDTO = runtimeContext.GetMonoClassInfoDTO(pMonoClass);
            return new MonoClassMetadataCollection()
            {
                ClassInfo = classInfoDTO,
                MethodInfos = [.. runtimeContext.EnumMonoMethods(pMonoClass, classInfoDTO.IsValueType)],
                FieldInfos = [.. runtimeContext.EnumMonoFields(pMonoClass, EnumMonoFieldOptions.None)],
            };
        }


    }
}

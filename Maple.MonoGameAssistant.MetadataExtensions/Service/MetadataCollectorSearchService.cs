using Maple.MonoGameAssistant.Model;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.MetadataExtensions.Service
{
    public class MetadataCollectorSearchService
    {
        public List<MonoDescriptionClassDTO> DescriptionClasses { get; } = new List<MonoDescriptionClassDTO>(256);
        public List<MonoDescriptionMethodDTO> DescriptionMethods { get; } = new List<MonoDescriptionMethodDTO>(256);
        public List<MonoDescriptionFieldDTO> DescriptionFields { get; } = new List<MonoDescriptionFieldDTO>(256);

        public void UpdateMetadata(MonoDescriptionCollectionDTO descriptionCollectionDTO)
        {
            ClearMetadata();
            if (descriptionCollectionDTO.Classes is not null)
            {
                DescriptionClasses.AddRange(descriptionCollectionDTO.Classes);
            }
            if (descriptionCollectionDTO.Methods is not null)
            {
                DescriptionMethods.AddRange(descriptionCollectionDTO.Methods);
            }
            if (descriptionCollectionDTO.Fields is not null)
            {
                DescriptionFields.AddRange(descriptionCollectionDTO.Fields);
            }
        }

        public void ClearMetadata()
        {
            DescriptionClasses.Clear();
            DescriptionMethods.Clear();
            DescriptionFields.Clear();
        }

        public bool TrySearchClass(ulong code, [MaybeNullWhen(false)] out MonoDescriptionClassDTO descriptionClassDTO)
        {
            descriptionClassDTO = DescriptionClasses.Find(p => p.Code == code);
            return descriptionClassDTO is not null;
        }

        public bool TrySearchMethod(ulong code, [MaybeNullWhen(false)] out MonoDescriptionMethodDTO descriptionMethodDTO)
        {
            descriptionMethodDTO = DescriptionMethods.Find(p => p.Code == code);
            return descriptionMethodDTO is not null;
        }

        public bool TrySearchField(ulong code, [MaybeNullWhen(false)] out MonoDescriptionFieldDTO descriptionFieldDTO)
        {
            descriptionFieldDTO = DescriptionFields.Find(p => p.Code == code);
            return descriptionFieldDTO is not null;
        }



    }
}

using Maple.MonoGameAssistant.Model;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public class MetadataCollectorSearchService
    {
        public List<MonoDescriptionClassDTO> DescriptionClasses { get; } = new List<MonoDescriptionClassDTO>(256);
        public List<MonoDescriptionMethodDTO> DescriptionMethods { get; } = new List<MonoDescriptionMethodDTO>(256);
        public List<MonoDescriptionFieldDTO> DescriptionFields { get; } = new List<MonoDescriptionFieldDTO>(256);

        public void UpdateMetadata(MonoDescriptionCollectionDTO descriptionCollectionDTO)
        {
            this.ClearMetadata();
            if (descriptionCollectionDTO.Classes is not null)
            {
                this.DescriptionClasses.AddRange(descriptionCollectionDTO.Classes);
            }
            if (descriptionCollectionDTO.Methods is not null)
            {
                this.DescriptionMethods.AddRange(descriptionCollectionDTO.Methods);
            }
            if (descriptionCollectionDTO.Fields is not null)
            {
                this.DescriptionFields.AddRange(descriptionCollectionDTO.Fields);
            }
        }

        public void ClearMetadata()
        {
            this.DescriptionClasses.Clear();
            this.DescriptionMethods.Clear();
            this.DescriptionFields.Clear();
        }

        public bool TrySearchClass(long code, [MaybeNullWhen(false)] out MonoDescriptionClassDTO descriptionClassDTO)
        {
             descriptionClassDTO = this.DescriptionClasses.Find(p => p.Code == code);
            return descriptionClassDTO is not null;
        }

        public bool TrySearchMethod(long code, [MaybeNullWhen(false)] out MonoDescriptionMethodDTO descriptionMethodDTO)
        {
            descriptionMethodDTO = this.DescriptionMethods.Find(p => p.Code == code);
            return descriptionMethodDTO is not null;
        }

        public bool TrySearchField(long code, [MaybeNullWhen(false)] out MonoDescriptionFieldDTO descriptionFieldDTO)
        {
            descriptionFieldDTO = this.DescriptionFields.Find(p => p.Code == code);
            return descriptionFieldDTO is not null;
        }



    }
}

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

        public void UpdateMetadata(MonoSearchCollectionDTO searchCollectionDTO)
        {
            this.ClearMetadata();
            if (searchCollectionDTO.Classes is not null)
            {
                this.DescriptionClasses.AddRange(searchCollectionDTO.Classes);
            }
            if (searchCollectionDTO.Methods is not null)
            {
                this.DescriptionMethods.AddRange(searchCollectionDTO.Methods);
            }
            if (searchCollectionDTO.Fields is not null)
            {
                this.DescriptionFields.AddRange(searchCollectionDTO.Fields);
            }
        }

        public void ClearMetadata()
        {
            this.DescriptionClasses.Clear();
            this.DescriptionMethods.Clear();
            this.DescriptionFields.Clear();
        }

        public bool TrySearchClass(long code, [MaybeNullWhen(false)] out MonoDescriptionClassDTO searchClassDTO)
        {
            searchClassDTO = this.DescriptionClasses.Find(p => p.Code == code);
            return searchClassDTO is not null;
        }

        public bool TrySearchMethod(long code, [MaybeNullWhen(false)] out MonoDescriptionMethodDTO searchMethodDTO)
        {
            searchMethodDTO = this.DescriptionMethods.Find(p => p.Code == code);
            return searchMethodDTO is not null;
        }

        public bool TrySearchField(long code, [MaybeNullWhen(false)] out MonoDescriptionFieldDTO searchFieldDTO)
        {
            searchFieldDTO = this.DescriptionFields.Find(p => p.Code == code);
            return searchFieldDTO is not null;
        }



    }
}

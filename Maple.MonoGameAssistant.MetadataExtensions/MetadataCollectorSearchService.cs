using Maple.MonoGameAssistant.Model;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.MetadataExtensions
{
    public class MetadataCollectorSearchService
    {
        public List<MonoSearchClassDTO> SearchClasses { get; } = new List<MonoSearchClassDTO>(256);
        public List<MonoSearchMethodDTO> SearchMethods { get; } = new List<MonoSearchMethodDTO>(256);
        public List<MonoSearchFieldDTO> SearchFields { get; } = new List<MonoSearchFieldDTO>(256);

        public void UpdateMetadata(MonoSearchCollectionDTO searchCollectionDTO)
        {
            this.ClearMetadata();
            if (searchCollectionDTO.Classes is not null)
            {
                this.SearchClasses.AddRange(searchCollectionDTO.Classes);
            }
            if (searchCollectionDTO.Methods is not null)
            {
                this.SearchMethods.AddRange(searchCollectionDTO.Methods);
            }
            if (searchCollectionDTO.Fields is not null)
            {
                this.SearchFields.AddRange(searchCollectionDTO.Fields);
            }
        }

        public void ClearMetadata()
        {
            this.SearchClasses.Clear();
            this.SearchMethods.Clear();
            this.SearchFields.Clear();
        }

        public bool TryGetClass(long code, [MaybeNullWhen(false)] out MonoSearchClassDTO searchClassDTO)
        {
            searchClassDTO = this.SearchClasses.Find(p => p.Code == code);
            return searchClassDTO is not null;
        }

        public bool TryGetMethod(long code, [MaybeNullWhen(false)] out MonoSearchMethodDTO searchMethodDTO)
        {
            searchMethodDTO = this.SearchMethods.Find(p => p.Code == code);
            return searchMethodDTO is not null;
        }

        public bool TryGetField(long code, [MaybeNullWhen(false)] out MonoSearchFieldDTO searchFieldDTO)
        {
            searchFieldDTO = this.SearchFields.Find(p => p.Code == code);
            return searchFieldDTO is not null;
        }



    }
}

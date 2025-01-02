namespace Maple.MonoGameAssistant.Model
{
    public class MonoDescriptionCollectionDTO
    {
        public MonoDescriptionClassDTO[]? Classes { get; set; }
        public MonoDescriptionFieldDTO[]? Fields { get; set; }
        public MonoDescriptionMethodDTO[]? Methods { get; set; }
    }
}

namespace Maple.MonoGameAssistant.Core
{
    public interface IMonoMetadataCollector
    {
        MonoRuntimeContext RuntimeContext { get; }
        EnumMonoRuntimeType TypeVersion { get; }
        string ApiVersion { get; }
    }
}

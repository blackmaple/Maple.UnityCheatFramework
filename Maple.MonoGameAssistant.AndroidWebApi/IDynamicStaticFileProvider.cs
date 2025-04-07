using Microsoft.Extensions.FileProviders;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public interface IDynamicStaticFileProvider : IFileProvider
    {
        IReadOnlyList<PhysicalFileProvider> ReadOnlyFileProviders { get; }
        void AddDirectory(string path);
        void RemoveDirectory(string path);
    }

}

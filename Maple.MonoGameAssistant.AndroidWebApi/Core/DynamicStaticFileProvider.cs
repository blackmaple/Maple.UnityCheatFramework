using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public class DynamicStaticFileProvider : IFileProvider
    {
        private List<PhysicalFileProvider> FileProviders { get; } = [];

        public IReadOnlyList<PhysicalFileProvider> ReadOnlyFileProviders => FileProviders;

        public bool AddDirectory(string? path)
        {
            if (Directory.Exists(path))
            {
                FileProviders.Add(new PhysicalFileProvider(path));
                return true;
            }
            return false;
        }

        public bool RemoveDirectory(string? path)
        {
            var fileProvider = FileProviders.Find(fp => fp.Root.Equals(path, System.StringComparison.OrdinalIgnoreCase));
            if (fileProvider != null)
            {
                FileProviders.Remove(fileProvider);
                return true;
            }
            return false;

        }

        public IDirectoryContents GetDirectoryContents(string subpath)
        {
            foreach (var provider in FileProviders)
            {
                var contents = provider.GetDirectoryContents(subpath);
                if (contents.Exists)
                {
                    return contents;
                }
            }
            return new NotFoundDirectoryContents();
        }

        public IFileInfo GetFileInfo(string subpath)
        {
            foreach (var provider in FileProviders)
            {
                var fileInfo = provider.GetFileInfo(subpath);
                if (fileInfo.Exists)
                {
                    return fileInfo;
                }
            }
            return new NotFoundFileInfo(subpath);
        }

        public IChangeToken Watch(string filter)
        {
            return new CompositeChangeToken([.. FileProviders.Select(p => p.Watch(filter))]);
        }
    }

}

using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public class DynamicStaticFileProvider :  IDynamicStaticFileProvider
    {
        private List<PhysicalFileProvider> FileProviders { get; } = [];

        public IReadOnlyList<PhysicalFileProvider> ReadOnlyFileProviders => FileProviders;

        public void AddDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                FileProviders.Add(new PhysicalFileProvider(path));
            }
        }

        public void RemoveDirectory(string path)
        {
            var fileProvider = FileProviders.Find(fp => fp.Root.Equals(path, System.StringComparison.OrdinalIgnoreCase));
            if (fileProvider != null)
            {
                FileProviders.Remove(fileProvider);
            }
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

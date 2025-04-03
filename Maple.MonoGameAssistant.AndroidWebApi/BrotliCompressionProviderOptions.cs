using Microsoft.Extensions.Options;
using System.IO.Compression;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public class BrotliCompressionProviderOptions : IOptions<BrotliCompressionProviderOptions>
    {
 
        public CompressionLevel Level { get; set; } = CompressionLevel.Optimal;

         BrotliCompressionProviderOptions IOptions<BrotliCompressionProviderOptions>.Value => this;
    }
}

using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Options;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;

namespace Maple.MonoGameAssistant.AndroidWebApi
{



    [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
    public class BrotliCompressionProvider : ICompressionProvider
    {
        /// <summary>
        /// Creates a new instance of <see cref="BrotliCompressionProvider"/> with options.
        /// </summary>
        /// <param name="options">The options for this instance.</param>
        [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(BrotliCompressionProvider))]
        public BrotliCompressionProvider(IOptions<BrotliCompressionProviderOptions> options)
        {
            ArgumentNullException.ThrowIfNull(options);

            Options = options.Value;
        }

        private BrotliCompressionProviderOptions Options { get; }

        /// <inheritdoc />
        public string EncodingName { get; } = "br";

        /// <inheritdoc />
        public bool SupportsFlush { get; } = true;

        /// <inheritdoc />
        public Stream CreateStream(Stream outputStream)
        {
            return new BrotliStream(outputStream, Options.Level, leaveOpen: true);
        }
    }
}

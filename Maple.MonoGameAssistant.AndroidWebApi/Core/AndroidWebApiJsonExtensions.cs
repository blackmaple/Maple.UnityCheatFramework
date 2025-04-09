using Maple.MonoGameAssistant.AndroidModel.ExceptionData;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Microsoft.AspNetCore.Http;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public static class AndroidWebApiJsonExtensions
    {
        public const string JsonContentTypeWithCharset = "application/json; charset=utf-8";

        static JsonSerializerOptions Options { get; }
        static AndroidWebApiJsonExtensions()
        {

            Options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            };
            Options.AddMonoJsonContext();
            Options.TypeInfoResolverChain.Insert(0, GameJsonContext.Default);
        }
        static JsonTypeInfo GetJsonTypeInfoThrowIfNotFound<T>() where T : class
        {
            if (Options.TryGetTypeInfo(typeof(T), out var jsonTypeInfo))
            {
                return jsonTypeInfo;
            }
            return AndroidServiceException.Throw<JsonTypeInfo>($"{typeof(T).FullName}:NOT FOUND JSON METADATA");
        }


        public static T Json2Object<T>(ReadOnlySpan<char> json) where T : class
        {
            var jsonTypeInfo = GetJsonTypeInfoThrowIfNotFound<T>();
            if (System.Text.Json.JsonSerializer.Deserialize(json, jsonTypeInfo) is T jsonObject)
            {
                return jsonObject;
            }
            return AndroidServiceException.Throw<T>($"{typeof(T).FullName}:FROM JSON IS NULL");
        }

        public static string Json4Object<T>(T obj) where T : class
        {
            var jsonTypeInfo = GetJsonTypeInfoThrowIfNotFound<T>();
            return System.Text.Json.JsonSerializer.Serialize(obj, jsonTypeInfo);
        }

        public static Task WriteAsJsonAsync<TValue>(this HttpResponse response, TValue value, CancellationToken cancellationToken = default) where TValue : class
        {
            ArgumentNullException.ThrowIfNull(response);
            var jsonTypeInfo = GetJsonTypeInfoThrowIfNotFound<TValue>();
            return response.WriteAsJsonAsync(value, jsonTypeInfo, cancellationToken);
        }
        public static Task WriteAsJsonAsync<TValue>(this HttpResponse response, TValue value, JsonTypeInfo jsonTypeInfo, CancellationToken cancellationToken = default) where TValue : class
        {
            ArgumentNullException.ThrowIfNull(response);
            response.ContentType = JsonContentTypeWithCharset;

            // if no user provided token, pass the RequestAborted token and ignore OperationCanceledException
            if (!cancellationToken.CanBeCanceled)
            {
                return WriteAsJsonAsyncSlow(response, value, jsonTypeInfo, response.HttpContext.RequestAborted);
            }



            return JsonSerializer.SerializeAsync(response.Body, value, jsonTypeInfo, cancellationToken);

            static async Task WriteAsJsonAsyncSlow(HttpResponse response, TValue value, JsonTypeInfo jsonTypeInfo,
                CancellationToken cancellationToken)
            {
                try
                {
                    await JsonSerializer.SerializeAsync(response.Body, value, jsonTypeInfo, cancellationToken).ConfigureAwait(false);
                }
                catch (OperationCanceledException) { }
            }

        }


        public static Task<TValue?> ReadAsJsonAsync<TValue>(this HttpRequest request, CancellationToken cancellationToken = default)
          where TValue : class
        {
            ArgumentNullException.ThrowIfNull(request);
            var jsonTypeInfo = GetJsonTypeInfoThrowIfNotFound<TValue>();
            return request.ReadAsJsonAsync<TValue>(jsonTypeInfo, cancellationToken);
        }
        public static async Task<TValue?> ReadAsJsonAsync<TValue>(this HttpRequest request, JsonTypeInfo jsonTypeInfo, CancellationToken cancellationToken = default) where TValue : class
        {
            ArgumentNullException.ThrowIfNull(request);
            if (!request.HasJsonContentType(out var charset))
            {
                throw new InvalidOperationException($"Unable to read the request as JSON because the request content type '{request.ContentType}' is not a known JSON content type.");
            }
            var encoding = GetEncodingFromCharset(charset);
            var (inputStream, usesTranscodingStream) = GetInputStream(request.HttpContext, encoding);

            try
            {
                var jsonObj = await JsonSerializer.DeserializeAsync(inputStream, jsonTypeInfo, cancellationToken).ConfigureAwait(false);
                return jsonObj as TValue;
            }
            finally
            {
                if (usesTranscodingStream)
                {
                    await inputStream.DisposeAsync();
                }
            }

        }
        private static bool HasJsonContentType(this HttpRequest request, out string? charset)
        {
            charset = null;
            if (request.ContentType == null)
            {
                return false;
            }

            var contentType = new Microsoft.Net.Http.Headers.MediaTypeHeaderValue(request.ContentType);
            if (contentType.MediaType.Equals("application/json", StringComparison.OrdinalIgnoreCase) ||
                contentType.MediaType.Equals("application/ld+json", StringComparison.OrdinalIgnoreCase))
            {
                charset = contentType.Charset.ToString();
                return true;
            }

            return false;
        }
        private static (System.IO.Stream, bool) GetInputStream(HttpContext httpContext, System.Text.Encoding? encoding)
        {
            var request = httpContext.Request;
            var inputStream = request.Body;

            if (encoding == null || encoding == System.Text.Encoding.UTF8)
            {
                return (inputStream, false);
            }

            var transcodingStream = new System.IO.StreamReader(inputStream, encoding).BaseStream;
            return (transcodingStream, true);
        }
        private static System.Text.Encoding? GetEncodingFromCharset(string? charset)
        {
            if (string.IsNullOrEmpty(charset))
            {
                return null;
            }

            try
            {
                return System.Text.Encoding.GetEncoding(charset);
            }
            catch (ArgumentException)
            {
                throw new InvalidOperationException($"Unable to read the request as JSON because the request content type charset '{charset}' is not a known encoding.");
            }
        }
    }
}

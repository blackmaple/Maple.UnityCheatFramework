using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.UILogic
{
    public static class GameContextExtensions
    {
        public static void AddGameContextService(this IServiceCollection services)
        {
            //  services.AddHttpClient();
            services.AddKeyedSingleton<IHttpClientFactory, NamedPipeHttpClientFactory>(nameof(NamedPipeHttpClientFactory));
            services.AddKeyedSingleton<IHttpClientFactory, NormalHttpClientFactory>(nameof(NormalHttpClientFactory));
            services.AddSingleton<HttpClientFactoryProvider>();

            services.AddMemoryCache();
            services.AddScoped<GameContextFactory>();

        }
    }

    public class HttpClientFactoryProvider(IServiceProvider serviceProvider)
    {
        public HttpClient CreateClient(string key, string args)
        {
            return serviceProvider.GetRequiredKeyedService<IHttpClientFactory>(key).CreateClient(args);
        }
    }

}

using Maple.MonoGameAssistant.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public static class AndroidWebApiServiceExtensions
    {

        static void ConfigureServices(this WebHostBuilder web, MonoGameSettings settings, Action<IServiceCollection> actionAddServices)
        {
            web.ConfigureServices(p =>
            {
                p.AddSingleton<MonoGameSettings>();

                actionAddServices(p);
            });
        }

        static void ConfigureListenIP(this WebHostBuilder web, MonoGameSettings settings)
        {
            if (settings.Http && settings.TryGetRandomPort(out var port))
            {
                settings.BaseAddress = $"http://localhost:{port}";
                web.UseKestrel(p => p.ListenAnyIP(port));
            }
        }

        static void ConfigureWebApiAction(this WebHostBuilder web, MonoGameSettings settings)

        public static WebHostBuilder AsRunWebApiService(
            Action<MonoGameSettings> actionGameSettings,
            Action<IServiceCollection> actionAddServices)
        {
            var web = new WebHostBuilder();
            var settings = new MonoGameSettings()
            {
                MonoDataCollector = true,
                NamedPipe = true,
                Http = false,
                IndexPage = "/index.html",
                //GamePath = slimBuilder.Environment.ContentRootPath,
                //WebRootPath = slimBuilder.Environment.WebRootPath
            };
            actionGameSettings(settings);

            web.ConfigureServices(settings, actionAddServices);
            web.ConfigureListenIP(settings);




            return web;
        }

    }
}

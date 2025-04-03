using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Net.Mime;
using System.Runtime.CompilerServices;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public static class AndroidWebApiServiceExtensions
    {

        static void ConfigureServices(this WebHostBuilder web, MonoGameSettings settings, Action<IServiceCollection> actionAddServices)
        {
            web.ConfigureServices(p =>
            {
                p.AddSingleton(settings);
                p.AddSingleton<AndroidWebApiExceptionHandler>();
                p.AddResponseCompression(options =>
                {
                    options.Providers.Add<BrotliCompressionProvider>();
                });
                p.Configure<BrotliCompressionProviderOptions>(options =>
                {
                    options.Level = CompressionLevel.Optimal;
                });
                p.AddRouting();
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
        static void UseDefaultExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(TryExceptionHandler);
            app.UseStatusCodePages(TryStatusCodePages);

            static void TryExceptionHandler(IApplicationBuilder app)
            {
                app.Run(async context =>
                {
                    var ex = context.Features.Get<IExceptionHandlerFeature>();
                    if (ex is not null)
                    {
                        var exceptionHandler = context.RequestServices.GetRequiredService<AndroidWebApiExceptionHandler>();
                        await exceptionHandler.TryHandleAsync(context, ex.Error, default).ConfigureAwait(false);
                    }
                });

            }
            static void TryStatusCodePages(IApplicationBuilder app)
            {
                app.Run(async context =>
                {
                    var exceptionHandler = context.RequestServices.GetRequiredService<AndroidWebApiExceptionHandler>();
                    await exceptionHandler.TryStatusCodeAsync(context).ConfigureAwait(false);
                });

            }
        }
        static void BuildWebApplication(this IApplicationBuilder app)
        {
            app.UseResponseCompression();
            app.UseDefaultExceptionHandler();

            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                ContentTypeProvider = new FileExtensionContentTypeProvider(new Dictionary<string, string>
                {
                    [".blat"] = "application/octet-stream",
                    [".dll"] = "application/octet-stream",
                    [".webcil"] = "application/octet-stream",
                    [".dat"] = "application/octet-stream",

                    [".wasm"] = "application/wasm",

                    [".json"] = "application/json",

                    [".woff"] = "application/font-woff",
                    [".woff2"] = "application/font-woff",

                }),

            });
            app.UseDefaultFiles();

        }

        static void UseEnumMonoApi(this RouteBuilder routeBuilder, MonoGameSettings settings)
        {
            if (!settings.MonoDataCollector)
            {
                return;
            }

            routeBuilder.MapGet("/mono/getinfo", async (http) =>
            {
                await AndroidWebApiJsonExtensions.WriteAsJsonAsync(http.Response, MonoResultDTO.GetOk(DateTime.Now.ToString("yyyyMMdd"))).ConfigureAwait(false);
            });



        }

        static void UseGameApi(this RouteBuilder routeBuilder, MonoGameSettings settings)
        {
            if (!settings.Http)
            {
                return;
            }
        }

        public static IWebHost AsRunWebApiService(
            Action<MonoGameSettings> actionGameSettings,
            Action<IServiceCollection> actionAddServices)
        {
            var web = new WebHostBuilder();
            var settings = new MonoGameSettings()
            {
                MonoDataCollector = true,
                NamedPipe = true,
                Http = true,
                //IndexPage = "/index.html",
                //GamePath = slimBuilder.Environment.ContentRootPath,
                //WebRootPath = slimBuilder.Environment.WebRootPath
            };
            actionGameSettings(settings);

            web.ConfigureServices(settings, actionAddServices);
            web.ConfigureListenIP(settings);

            web.Configure(p => 
            {
                p.BuildWebApplication();

                var routeBuilder = new RouteBuilder(p);
                routeBuilder.UseEnumMonoApi(settings);
                routeBuilder.UseGameApi(settings);
                var routes = routeBuilder.Build();
                p.UseRouter(routes);
            });


            return web.Build();
        }

    }
}

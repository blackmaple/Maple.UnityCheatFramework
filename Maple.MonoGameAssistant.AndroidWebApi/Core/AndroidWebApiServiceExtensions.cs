using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO.Compression;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public static class AndroidWebApiServiceExtensions
    {
        static TService FromServices<TService>(this HttpContext httpContext) where TService : class
        {
            return httpContext.RequestServices.GetRequiredService<TService>();
        }
        static async Task<T> FromBodyAsync<T>(this HttpContext httpContext) where T : class
        {
            var obj = await httpContext.Request.ReadAsJsonAsync<T>().ConfigureAwait(false);
            if (obj is not null)
            {
                return obj;
            }
            throw new InvalidOperationException("Unable to read the request as JSON.");
        }
        static Task ToBodyAsync<T>(this HttpContext httpContext, T value) where T : class
        {
            return httpContext.Response.WriteAsJsonAsync(MonoResultDTO.GetOk(value));
        }

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
                settings.Port = port;
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

            app.UseDefaultFiles();
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

        }

        static void UseActionApi(this IApplicationBuilder app, MonoGameSettings settings)
        {
            var routeBuilder = new RouteBuilder(app);
            routeBuilder.UseEnumMonoApi(settings);
            routeBuilder.UseGameApi(settings);
            var routes = routeBuilder.Build();
            app.UseRouter(routes);
        }

        static void UseEnumMonoApi(this RouteBuilder routeBuilder, MonoGameSettings settings)
        {
            if (!settings.MonoDataCollector)
            {
                return;
            }

            routeBuilder.MapGet("/mono/EnumImages", async (http) =>
            {
                MonoCollectorApiService apiService = http.FromServices<MonoCollectorApiService>();
                var result = await apiService.EnumMonoImagesAsync().ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });

            routeBuilder.MapPost("/mono/EnumClasses", async (http) =>
            {
                var postDTO = await http.FromBodyAsync<MonoPointerRequestDTO>().ConfigureAwait(false);

                MonoCollectorApiService apiService = http.FromServices<MonoCollectorApiService>();
                var result = await apiService.EnumMonoClassesAsync(postDTO.Pointer).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });

            routeBuilder.MapPost("/mono/EnumObjects", async (http) =>
            {
                var postDTO = await http.FromBodyAsync<MonoPointerRequestDTO>().ConfigureAwait(false);

                MonoCollectorApiService apiService = http.FromServices<MonoCollectorApiService>();
                var result = await apiService.EnumMonoObjectsAsync(postDTO.Pointer).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });

            routeBuilder.MapPost("/mono/EnumClassDetail", async (http) =>
            {
                var postDTO = await http.FromBodyAsync<MonoClassDetailRequestDTO>().ConfigureAwait(false);

                MonoCollectorApiService apiService = http.FromServices<MonoCollectorApiService>();
                var result = await apiService.EnumMonoClassDetailAsync(postDTO.Pointer, postDTO.FieldOptions).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });

        }

        static void UseGameApi(this RouteBuilder routeBuilder, MonoGameSettings settings)
        {
            if (!settings.Http)
            {
                return;
            }

            routeBuilder.MapGet("/game/info", async (http) =>
            {
                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.GetSessionInfoAsync().ConfigureAwait(false);
                await http.ToBodyAsync(result).ConfigureAwait(false);
            });

            routeBuilder.MapPost("/game/LoadResource", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameSessionObjectDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.LoadResourceAsync().ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });

            #region Currency

            routeBuilder.MapPost("/game/GetListCurrencyDisplay", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameSessionObjectDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.GetListCurrencyDisplayAsync().ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });
            routeBuilder.MapPost("/game/GetCurrencyInfo", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameCurrencyObjectDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.GetCurrencyInfoAsync(requestDTO).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });
            routeBuilder.MapPost("/game/UpdateCurrencyInfo", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameCurrencyModifyDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.UpdateCurrencyInfoAsync(requestDTO).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });
            #endregion

            #region Inventory
            routeBuilder.MapPost("/game/GetListInventoryDisplay", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameSessionObjectDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.GetListInventoryDisplayAsync().ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });
            routeBuilder.MapPost("/game/GetInventoryInfo", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameInventoryObjectDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.GetInventoryInfoAsync(requestDTO).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });
            routeBuilder.MapPost("/game/UpdateInventoryInfo", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameInventoryModifyDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.UpdateInventoryInfoAsync(requestDTO).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });
            #endregion

            #region Character
            routeBuilder.MapPost("/game/GetListCharacterDisplay", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameSessionObjectDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.GetListCharacterDisplayAsync().ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });
            routeBuilder.MapPost("/game/GetCharacterStatus", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameCharacterObjectDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.GetCharacterStatusAsync(requestDTO).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });
            routeBuilder.MapPost("/game/UpdateCharacterStatus", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameCharacterModifyDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.UpdateCharacterStatusAsync(requestDTO).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });

            routeBuilder.MapPost("/game/GetCharacterEquipment", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameCharacterObjectDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.GetCharacterEquipmentAsync(requestDTO).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });
            routeBuilder.MapPost("/game/UpdateCharacterEquipment", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameCharacterModifyDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.UpdateCharacterEquipmentAsync(requestDTO).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });

            routeBuilder.MapPost("/game/GetCharacterSkill", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameCharacterObjectDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.GetCharacterSkillAsync(requestDTO).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });
            routeBuilder.MapPost("/game/UpdateCharacterSkill", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameCharacterModifyDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.UpdateCharacterSkillAsync(requestDTO).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });
            #endregion

            #region Monster
            routeBuilder.MapPost("/game/GetListMonsterDisplay", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameSessionObjectDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.GetListMonsterDisplayAsync().ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });
            routeBuilder.MapPost("/game/AddMonsterMember", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameMonsterObjectDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.AddMonsterMemberAsync(requestDTO).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });

            #endregion

            #region Skill
            routeBuilder.MapPost("/game/GetListSkillDisplay", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameSessionObjectDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.GetListSkillDisplayAsync().ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });
            routeBuilder.MapPost("/game/AddSkillDisplay", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameSkillObjectDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.AddSkillDisplayAsync(requestDTO).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });

            #endregion

            #region Switch
            routeBuilder.MapPost("/game/GetListSwitchDisplay", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameSessionObjectDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.GetListSwitchDisplayAsync().ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });
            routeBuilder.MapPost("/game/UpdateSwitchDisplay", async (http) =>
            {
                var requestDTO = await http.FromBodyAsync<GameSwitchModifyDTO>().ConfigureAwait(false);
                requestDTO.ThrowIfGameSessionDiff();

                IGameWebApiControllers apiService = http.FromServices<IGameWebApiControllers>();
                var result = await apiService.UpdateSwitchDisplayAsync(requestDTO).ConfigureAwait(false);

                await http.ToBodyAsync(result).ConfigureAwait(false);
            });

            #endregion
        }

        static void RegisterApplicationStarted(this IApplicationBuilder app)
        {
            var serviceProvider = app.ApplicationServices;
            var lifetime = serviceProvider.GetRequiredService<Microsoft.AspNetCore.Hosting.IApplicationLifetime>();
            lifetime.ApplicationStarted.Register(async (objState) =>
            {
                if (objState is not IServiceProvider service)
                {
                    return;
                }
                await service.GetRequiredService<AndroidWebApiNotifyService>().StartAsync().ConfigureAwait(false);

            }, serviceProvider);
        }


        public static IWebHost AsRunWebApiService(
            AndroidWebApiContext webApiContext,
            Action<IServiceCollection> actionAddServices)
        {

            var web = new WebHostBuilder();

            var contentRoot = webApiContext.ContentRoot;
            if (!string.IsNullOrEmpty(contentRoot))
            {
                web.UseContentRoot(contentRoot);
            }

            var settings = webApiContext.Settings;
            web.ConfigureServices(settings, actionAddServices);
            web.ConfigureListenIP(settings);

            web.Configure(p =>
            {
                p.BuildWebApplication();
                p.UseActionApi(settings);
                p.RegisterApplicationStarted();
            });


            return web.Build();
        }

    }
}

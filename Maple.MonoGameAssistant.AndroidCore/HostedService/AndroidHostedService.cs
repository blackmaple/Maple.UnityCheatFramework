using Maple.MonoGameAssistant.AndroidCore.GameContext;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
namespace Maple.MonoGameAssistant.AndroidCore.HostedService
{
    public class AndroidHostedService(ILogger<AndroidHostedService> logger, IServiceProvider serviceProvider) : IHostedService
    {
        private ValueTask LoadMonoRuntimeFactoryAsync()
        {
            using (logger.Running())
            {
                try
                {
                    var monoRuntimeFactory = serviceProvider.GetService<MonoRuntimeFactory>();
                    if (monoRuntimeFactory is not null)
                    {
                        var init = monoRuntimeFactory.CreateMonoRuntime(out var runtimeType);
                        logger.LogInformation("{serviceName}=>{status}=>{runtimeType}", nameof(MonoRuntimeFactory), init, runtimeType);
                    }
                }
                catch (MonoRuntimeException ex)
                {
                    logger.LogError("{serviceName}=>{err}", nameof(MonoRuntimeFactory), ex.Message);
                }
                catch (Exception ex)
                {
                    logger.LogError("{serviceName}=>{err}", nameof(MonoRuntimeFactory), ex);
                }
            }
            return ValueTask.CompletedTask;
        }
        private async Task LoadGameContextServiceAsync()
        {
            using (logger.Running())
            {
                try
                {
                    var gameContextService = serviceProvider.GetService<IGameContextService>();
                    if (gameContextService is not null)
                    {
                        await gameContextService.StartAsync().ConfigureAwait(false);
                    }
                }
                catch (Exception ex)
                {
                    logger.LogError("{serviceName}=>{methodName}=>{err}", nameof(IGameContextService), nameof(IGameContextService.StartAsync), ex);
                }
            }
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await LoadMonoRuntimeFactoryAsync().ConfigureAwait(false);
            await LoadGameContextServiceAsync().ConfigureAwait(false);
        }

        private async Task UnloadGameContextServiceAsync()
        {
            using (logger.Running())
            {
                try
                {
                    var gameContextService = serviceProvider.GetService<IGameContextService>();
                    if (gameContextService is not null)
                    {
                        await gameContextService.StopAsync().ConfigureAwait(false);
                    }
                }
                catch (Exception ex)
                {
                    logger.LogError("{serviceName}=>{err}", nameof(IGameContextService), ex);
                }
            }
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            return UnloadGameContextServiceAsync();
        }
    }

}

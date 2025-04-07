using Maple.MonoGameAssistant.AndroidModel;
using Maple.MonoGameAssistant.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public class AndroidWebApiService(Action<MonoGameSettings> actionGameSettings,
        Action<IServiceCollection> actionAddServices) : IAndroidHost
    {
        IWebHost WebHost { get; } = AndroidWebApiServiceExtensions.AsRunWebApiService(actionGameSettings, actionAddServices);

        public void Run()
        {
            WebHost.Run();
        }
    }
}

using Maple.Hook.Imp.Dobby.Static;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Maple.MonoGameAssistant.DllProxyDobbyHook
{
    public static class MonoInternalCallExtensions
    {
        extension(IServiceCollection @this)
        {
            public IServiceCollection AddMonoInternalCallService()
            {
                @this.TryAddSingleton<MonoInternalCallService>();
                @this.AddDobbyHookNativeFactory();
                return @this;
            }
        }
    }
}

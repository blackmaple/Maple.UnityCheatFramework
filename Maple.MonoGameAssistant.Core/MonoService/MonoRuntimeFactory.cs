using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
namespace Maple.MonoGameAssistant.Core
{

    public sealed class MonoRuntimeFactory(IMonoRuntiemProvider runtiemProvider/*ILogger<MonoRuntimeFactory> logger, MonoRuntimeModuleView runtimeModuleView*/)
    {
        //Lock LockObject { get; } = new Lock();

        IMonoRuntiemProvider MonoRuntimeService { get; } = runtiemProvider;
        //  ILogger Logger { get; } = logger;
        //  MonoRuntimeApi RuntimeApi { get; } = new MonoRuntimeApi(logger, runtimeModuleView);


        public bool CreateMonoRuntime(out EnumMonoRuntimeType runtimeType)
        {
            runtimeType = this.MonoRuntimeService.RuntimeType;
            return true;
        }

        public IMonoRuntiemProvider GetProvider()
        {
            return this.MonoRuntimeService;
        }

        public bool TryCreateMonoRuntime([MaybeNullWhen(false)] out IMonoRuntiemProvider monoRuntiemProvider, out EnumMonoRuntimeType runtimeType)
        {
            runtimeType = this.MonoRuntimeService.RuntimeType;
            monoRuntiemProvider = this.MonoRuntimeService;
            return true;
        }

        //bool TryCreateMonoRuntime_Imp([MaybeNullWhen(false)] out IMonoRuntiemProvider monoRuntiemProvider, out EnumMonoRuntimeType runtimeType)
        //{
        //    lock (LockObject)
        //    {
        //        var init = this.RuntimeApi.TryLoadMonoRuntimeApi();
        //        if (init)
        //        {
        //            this.MonoRuntimeService ??= RuntimeApi.RuntimeType switch
        //            {
        //                EnumMonoRuntimeType.MONO => GetMonoRuntime_MONO(),
        //                EnumMonoRuntimeType.IL2CPP => GetMonoRuntime_IL2CPP(),
        //                _ => GetMonoRuntime_ERROR(),
        //            };
        //        }
        //        monoRuntiemProvider = this.MonoRuntimeService;
        //        runtimeType = this.RuntimeApi.RuntimeType;
        //        return init;
        //    }
        //}

        //MonoRuntiemProvider_MONO GetMonoRuntime_MONO()
        //{

        //    return new MonoRuntiemProvider_MONO(this.Logger, this.RuntimeApi);
        //}

        //MonoRuntiemProvider_IL2CPP GetMonoRuntime_IL2CPP()
        //{

        //    return new MonoRuntiemProvider_IL2CPP(this.Logger, this.RuntimeApi);
        //}

        //IMonoRuntiemProvider GetMonoRuntime_ERROR()
        //{
        //    return MonoRuntimeException.Throw<IMonoRuntiemProvider>($"Mono Runtime Type is {this.RuntimeApi.RuntimeType} Error");
        //}

        static IMonoRuntiemProvider CreateMonoRuntiemProvider(IServiceProvider provider)
        {
            var view = provider.GetRequiredService<MonoRuntimeModuleView>();
            var loggerFactory = provider.GetRequiredService<ILoggerFactory>();
            var logger = loggerFactory.CreateLogger<MonoRuntimeFactory>();
            var runtime = new MonoRuntimeApi(logger, view);
            var init = runtime.TryLoadMonoRuntimeApi();
            if (init)
            {
                if (runtime.RuntimeType == EnumMonoRuntimeType.MONO)
                {
                    return new MonoRuntiemProvider_MONO(logger, runtime);
                }
                else if (runtime.RuntimeType == EnumMonoRuntimeType.IL2CPP)
                {

                    return new MonoRuntiemProvider_IL2CPP(logger, runtime);
                }
            }
            return MonoRuntimeException.Throw<IMonoRuntiemProvider>($"Mono Runtime Type is {runtime.RuntimeType} Error");
        }

        public static MonoRuntimeFactory Create(IServiceProvider provider)
            => new(CreateMonoRuntiemProvider(provider));
    }
}

using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.DllProxyDobbyHook;
using Maple.MonoGameAssistant.MetadataUnity;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
namespace Maple.MonoGameAssistant.MonoDataCollector
{
    internal sealed partial class MonoDataCollectorService(
        ILogger<MonoDataCollectorService> logger,
        MonoRuntimeContext runtimeContext,
        MonoTaskScheduler monoTaskScheduler,
        MonoGameSettings gameSettings,
        HookWinMsgFactory hookWinMsgFactory,
        MonoInternalCallService monoInternalCallService)
        : GameContextService<MonoDataCollectorContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)
    {

        #region LoadService
        MonoInternalCallService InternalCallService { get; } = monoInternalCallService;

        protected sealed override MonoDataCollectorContext LoadGameContext()
           => new MonoDataCollectorContext(this.RuntimeContext, MonoCollectorExtensionsV2.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.Collector, this.Logger, "2025");
        protected sealed override ValueTask LoadGameDataAsync()
        {
            using (this.Logger.Running())
            {
                foreach (var v in InternalCallService.InternalCalls)
                {
                    this.Logger.LogInformation("InternalCall: {k} => 0x{v:X}", v.Key, v.Value);
                }

                //    this.Logger.LogInformation("MonoString:{p}", MonoStringExtensions.GetMonoStringStructLayout());
                ///    this.Logger.LogInformation("MonoArray:{p}", MonoArrayExtensions.GetMonoArrayStructLayout());
                return ValueTask.CompletedTask;
            }
        }

        protected override IUnityPlayerNativeMethods? LoadUnityEngineContext()
        {
            return UnityMetadataContext.CreateUnityMetadataContext(this.RuntimeContext, this.Logger);
        }


        protected override void HookWindowMessage()
        {
            // base.HookWindowMessage();
        }
        #endregion






    }

  

}


    

   

     





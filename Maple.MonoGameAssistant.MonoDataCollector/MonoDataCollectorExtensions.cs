using Maple.Hook.Imp.Dobby.Static;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.DllProxyDobbyHook;
using Maple.MonoGameAssistant.WebApi;
using Maple.MonoGameAssistant.Windows.Service;
using Maple.UnmanagedExtensions;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace Maple.MonoGameAssistant.MonoDataCollector
{
    internal static partial class MonoDataCollectorExtensions
    {


        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)/*, typeof(CallConvSuppressGCTransition)*/], EntryPoint = nameof(Maple))]
        [return: MarshalAs(UnmanagedType.I4)]
        public static int Maple()
        {
            var webapp = WebApiServiceExtensions.AsRunWebApiService(p =>
            {
                p.GameName = "MonoDataCollector";
                p.QQ = "0";
            }, services =>
            {
                services.AddMonoInternalCallService();
                services.UseGameContextService<MonoDataCollectorService>();
            });

            //延迟启动

           

            Thread.Sleep(8000);
            //using (Logger.MonoDefaultLogger.Default.Running())
            //{
            //    foreach (var v in GetInternalCallCollection())
            //    {
            //        Logger.MonoDefaultLogger.Default.Info($"[MonoDataCollector] InternalCall: {v.Key} => 0x{v.Value:X}");
            //    }
            //}
            webapp.Run();

            return 1;
        }

        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicMethods, nameof(MonoInternalCallNativeMethods), "Maple.MonoGameAssistant.DllProxyDobbyHook")]
        static MonoDataCollectorExtensions() { }


    }
}

using Maple.MonoGameAssistant.WebApi;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Maple.MonoGameAssistant.Windows.Service;
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
                services.UseGameContextService<MonoDataCollectorService>();
            });

            //延迟启动
            Thread.Sleep(8000);
            webapp.Run();

            return 1;
        }



    }

}

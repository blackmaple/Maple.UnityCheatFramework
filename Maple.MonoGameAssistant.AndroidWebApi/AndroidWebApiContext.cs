using Maple.MonoGameAssistant.AndroidCore;
using Maple.MonoGameAssistant.AndroidCore.Api;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using Maple.MonoGameAssistant.Model;
using Microsoft.AspNetCore.Http;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public class AndroidWebApiContext(JavaVirtualMachineContext virtualMachineContext)
    {
        public JavaVirtualMachineContext VirtualMachineContext { get; } = virtualMachineContext;
        public MonoGameSettings Settings { get; } = new MonoGameSettings() { Http = true, MonoDataCollector = true };
        public string? ContentRoot { get; set; }

        public TaskCompletionSource<AndroidWebApiNotifyArgs> CompletionSource { get; } = new TaskCompletionSource<AndroidWebApiNotifyArgs>();


        public string ErrorPage { get; init; } = "/index.html";
        public string[] ApiPaths { get; init; } = ["/mono", "/game"];
        public bool ExistsWebApiPath(PathString pathString)
        {
            return this.ApiPaths.Any(p => pathString.StartsWithSegments(p));
        }


        public static AndroidWebApiContext CreateContext(PTR_JAVA_VM javaVM)
        {
            return new AndroidWebApiContext(new JavaVirtualMachineContext(javaVM));
        }

        public bool TrySetNotifyArgs(AndroidWebApiNotifyArgs args)
        {
            return this.CompletionSource.TrySetResult(args);
        }

        public Task<AndroidWebApiNotifyArgs> WaitAndGetNotifyArgsAsync()
        {
            return CompletionSource.Task;
        }

        public AndroidSessionInfoDTO GetAndroidSessionInfo()
        {

            return new AndroidSessionInfoDTO()
            {
                DisplayImage = this.Settings.GetGameDefaultPngUrl(),
                ObjectId = Environment.ProcessId.ToString(),
                DisplayName = this.Settings.GameName,
                DisplayDesc = string.Empty,
                ApiVer = "202504101640",
                QQ = this.Settings.QQ,
                Address = this.Settings.BaseAddress,

            };
        }
    }
}

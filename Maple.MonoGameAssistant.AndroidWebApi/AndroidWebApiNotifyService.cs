using Maple.MonoGameAssistant.AndroidCore.AndroidTask;
using Maple.MonoGameAssistant.AndroidModel.ExceptionData;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Model;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
    public class AndroidWebApiNotifyService(ILogger<AndroidWebApiNotifyService> logger, AndroidWebApiContext webApiContext, AndroidTaskScheduler taskScheduler)
         : IAndroidTaskScheduler<AndroidWebApiNotifyService>
    {
        public ILogger Logger { get; } = logger;
        public AndroidWebApiContext WebApiContext { get; } = webApiContext;
        public TaskScheduler AndroidScheduler => Scheduler;
        public AndroidTaskScheduler Scheduler { get; } = taskScheduler;
        public AndroidWebApiNotifyService Context => this;


        public Task StartAsync()
        {
            return ExecuteAsync();
        }

        public async Task<bool> ExecuteAsync()
        {
            using (this.Logger.Running())
            {
                var arg = await this.WebApiContext.CallbackNotifyArgsAsync().ConfigureAwait(false);
                if (arg is null)
                {
                    this.Logger.LogInformation("ExecuteAsync:TIMEOUT");
                    return false;
                }

                try
                {
                    var requestData = await GetRequiredData4ApiJsonAsync<AndroidWebApiNotifyDTO>(arg).ConfigureAwait(false);
                    var add = this.WebApiContext.AddStaticFile(requestData.Path);
                    var resData = this.WebApiContext.GetAndroidSessionInfo();
                    resData.Status = add;
                    return await TryCallback2ApiJsonAsync(arg, resData.GetOk()).ConfigureAwait(false);
                }
                catch (MonoCommonException ex)
                {
                    Logger.LogError("COMMONERROR:{ex}", ex);
                    return await TryCallback2ApiJsonAsync(arg, MonoResultDTO.GetBizError(ex)).ConfigureAwait(false);
                }
                catch (AndroidCommonException ex)
                {
                    Logger.LogError("JNIERROR:{ex}", ex);
                    return await TryCallback2ApiJsonAsync(arg, MonoResultDTO.GetBizError<bool>((int)EnumMonoCommonCode.BIZ_ERROR, ex.Message)).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Logger.LogError("SYSTEMERROR:{ex}", ex);
                    return await TryCallback2ApiJsonAsync(arg, MonoResultDTO.GetSystemError(ex.Message)).ConfigureAwait(false);
                }
            }
        }

        Task<T> GetRequiredData4ApiJsonAsync<T>(AndroidWebApiNotifyArgs arg) where T : class
        {
            return this.AndroidTaskAsync(static (p, args) => p.AndroidTask_GetRequiredData4ApiJson<T>(args), arg);
        }
        T AndroidTask_GetRequiredData4ApiJson<T>(AndroidWebApiNotifyArgs arg)
            where T : class
        {

            var jniEnvironmentContext = this.Scheduler.CurrJniEnv;
            var javaJson = arg.Json;
            var pString = jniEnvironmentContext.JNI_ENV.GetStringChars(javaJson);
            var strSize = jniEnvironmentContext.JNI_ENV.GetStringLength(javaJson);
            try
            {
                return AndroidWebApiJsonExtensions.Json2Object<T>(pString.AsReadOnlySpan(strSize));
            }
            finally
            {
                jniEnvironmentContext.JNI_ENV.ReleaseStringChars(javaJson, pString);
            }
        }


        bool AndroidTask_Callback2ApiJson<T>(AndroidWebApiNotifyArgs arg, T data) where T : class
        {

            var jniEnvironmentContext = this.Scheduler.CurrJniEnv;
            if (false == AndroidWebApiNotifyInstance.TryCreate(jniEnvironmentContext, arg.Instance, out var callback))
            {
                return AndroidJNIException.Throw<bool>($"{nameof(AndroidWebApiNotifyInstance)}:CREATE ERROR");
            }
            using (callback)
            {
                var jsonData = AndroidWebApiJsonExtensions.Json4Object(data);
                var javaJson = jniEnvironmentContext.JNI_ENV.CreateStringUnicode(jsonData);
                try
                {
                    return callback.Callback_NotifyStatus(javaJson);
                }
                finally
                {
                    jniEnvironmentContext.JNI_ENV.DeleteLocalRef(javaJson);
                }
            }



        }
        async Task<bool> TryCallback2ApiJsonAsync<T>(AndroidWebApiNotifyArgs arg, T data) where T : class
        {
            try
            {
                return await this.AndroidTaskAsync(static (p, args) => p.AndroidTask_Callback2ApiJson(args.arg, args.data), (arg, data));
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex);
            }
            return false;
        }
    }
}

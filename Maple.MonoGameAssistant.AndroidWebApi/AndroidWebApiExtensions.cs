using Maple.MonoGameAssistant.AndroidCore.AndroidTask;
using Maple.MonoGameAssistant.AndroidCore.Api;
using Maple.MonoGameAssistant.AndroidCore.GameContext;
using Maple.MonoGameAssistant.AndroidCore.HostedService;
using Maple.MonoGameAssistant.AndroidJNI.Classes;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Logger;
using Maple.MonoGameAssistant.Model;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using unsafe ApiActionDelegate = delegate* unmanaged<Maple.MonoGameAssistant.AndroidJNI.JNI.Value.PTR_JNI_ENV, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JOBJECT, Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive.JINT, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JSTRING, Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive.JBOOLEAN>;
using unsafe TestActionDelegate = delegate* unmanaged<Maple.MonoGameAssistant.AndroidJNI.JNI.Value.PTR_JNI_ENV, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JOBJECT, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JSTRING, Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive.JBOOLEAN>;
using unsafe WebApiActionDelegate = delegate* unmanaged<Maple.MonoGameAssistant.AndroidJNI.JNI.Value.PTR_JNI_ENV, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JOBJECT, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JSTRING, Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive.JINT>;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public static unsafe class AndroidWebApiExtensions
    {
        const string JavaClassFullName = "com/android/maple/service/MapleService";



        static AndroidWebApiContext? ApiContext { get; set; }

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad))]
        internal static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            return JNI_OnLoadImp(javaVM, reserved, static api => api.CreateDefaultAndroidService(propa => { }, propa => { }));
        }

        public static JINT JNI_OnLoadImp(PTR_JAVA_VM javaVM, JOBJECT _, Func<AndroidWebApiContext, AndroidWebApiContext> createHost)
        {
            ApiContext = createHost(AndroidWebApiContext.CreateContext(javaVM));

            if (ApiContext.VirtualMachineContext.TryGetEnv(out var jniEnvironmentContext))
            {
                jniEnvironmentContext.RegisterNativeMethod(JavaClassFullName, nameof(TestAction), "(Ljava/lang/String;)Z", new Ptr_Func_TestAction(&TestAction));
                jniEnvironmentContext.RegisterNativeMethod(JavaClassFullName, nameof(ApiAction), "(ILjava/lang/String;)Z", new Ptr_Func_ApiAction(&ApiAction));
                jniEnvironmentContext.RegisterNativeMethod(JavaClassFullName, nameof(WebApiAction), "(Ljava/lang/String;)I", new Ptr_Func_WebApiAction(&WebApiAction));

            }
            return JavaVirtualMachineContext.JNI_VERSION_1_6;
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnUnload))]
        internal static void JNI_OnUnload(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            JNI_OnUnloadImp(javaVM, reserved);
        }

        public static void JNI_OnUnloadImp(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(ApiAction))]
        internal static JBOOLEAN ApiAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JINT actionIndex, JSTRING json)
        {
            return ApiActionImp(jniEnv, instance, actionIndex, json);
        }
        public static JBOOLEAN ApiActionImp(PTR_JNI_ENV jniEnv, JOBJECT instance, JINT actionIndex, JSTRING json)
        {

            return default;
            //  return ApiContext?.TryWrite(AndroidApiArgs.Create(jniEnv, instance, actionIndex, json)) ?? false;
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(TestAction))]
        internal static JBOOLEAN TestAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING text)
        {
            return TestActionImp(jniEnv, instance, text);
        }
        public static JBOOLEAN TestActionImp(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING text)
        {
            if (JniEnvironmentContext.TryCreateJniEnvironmentContext(jniEnv, out var jniEnvironmentContext))
            {
                var androidToast = AndroidToastReference.CreateReference(in jniEnvironmentContext);
                androidToast.Show(instance, jniEnvironmentContext.JNI_ENV.ConvertStringUnicode(text), false);
                return true;
            }
            return false;
        }


        [UnmanagedCallersOnly(EntryPoint = nameof(WebApiAction))]
        internal static JINT WebApiAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING text)
        {
            return WebApiActionImp(jniEnv, instance, text);
        }
        public static JINT WebApiActionImp(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING text)
        {
            const int ErrorPort = -1;

            if (ApiContext is null)
            {
                return ErrorPort;
            }
            if (false == JniEnvironmentContext.TryCreateJniEnvironmentContext(jniEnv, out var jniEnvironmentContext))
            {
                return ErrorPort;
            }
            var path = jniEnvironmentContext.JNI_ENV.ConvertStringUnicode(text);
            if (false == ApiContext.StaticFileProvider.AddDirectory(path))
            {
                return ErrorPort;
            }

            return ApiContext.Settings.Port;

        }




        readonly struct Ptr_Func_ApiAction(ApiActionDelegate ptr)
        {
            readonly ApiActionDelegate _ptr = ptr;
            public static implicit operator nint(Ptr_Func_ApiAction func) => (nint)func._ptr;
        }
        readonly struct Ptr_Func_TestAction(TestActionDelegate ptr)
        {
            readonly TestActionDelegate _ptr = ptr;
            public static implicit operator nint(Ptr_Func_TestAction func) => (nint)func._ptr;
        }
        readonly struct Ptr_Func_WebApiAction(WebApiActionDelegate ptr)
        {
            readonly WebApiActionDelegate _ptr = ptr;
            public static implicit operator nint(Ptr_Func_WebApiAction func) => (nint)func._ptr;
        }


        public static IServiceCollection AddGameContextService<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T_GAMECONTEXTSERVICE>
          (this IServiceCollection serviceDescriptors)
         where T_GAMECONTEXTSERVICE : class, IGameContextService
        {

            serviceDescriptors.AddMonoRuntimeService(android: true);
            serviceDescriptors.AddSingleton<IGameContextService, T_GAMECONTEXTSERVICE>();
            serviceDescriptors.AddSingleton<IGameWebApiControllers>(p => p.GetRequiredService<IGameContextService>());
            return serviceDescriptors;
        }

        private static IWebHost CreateWebApiService(this AndroidWebApiContext androidApiContext
            , Action<MonoGameSettings> actionGameSettings,
            Action<IServiceCollection> actionAddServices)
        {
            var settings = androidApiContext.Settings;
            actionGameSettings(settings);
            return AndroidWebApiServiceExtensions.AsRunWebApiService(
                settings,
                services =>
                {
                    services.AddLogging(p => p.AddOnlyMonoGameLogger());
                    services.AddSingleton(androidApiContext);
                    services.AddSingleton(androidApiContext.StaticFileProvider);
                    services.AddHostedService<AndroidHostedService>();
                    services.AddSingleton<AndroidTaskScheduler>();
                    services.AddSingleton(androidApiContext.VirtualMachineContext);

                    actionAddServices(services);
                });
        }

        public static AndroidWebApiContext CreateDefaultAndroidService(
            this AndroidWebApiContext androidApiContext
            , Action<MonoGameSettings> actionGameSettings,
            Action<IServiceCollection> actionAddServices)
        {
            var webHost = androidApiContext.CreateWebApiService(actionGameSettings, actionAddServices);
            _ = Task.Factory.StartNew(AndroidServiceTask, webHost, TaskCreationOptions.LongRunning);
            return androidApiContext;
            static void AndroidServiceTask(object? obj)
            {
                if (obj is not IWebHost host)
                {
                    return;
                }
                host.Run();
            }
        }

    }





}

using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Opaque;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using System.Reflection;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    internal sealed class AndroidWebApiNotifyMetadata : JavaClassMetadata<AndroidWebApiNotifyMetadata>
    {
        JMETHODID Method_INFO;
        public JMETHODID Method_getContentRoot;
        protected sealed override void FindMethods(in JniEnvironmentContext context)
        {
            context.JNI_ENV.TryGetMethodId(this.GlobalClass, "INFO\0"u8, "(Ljava/lang/String;)Z\0"u8, out Method_INFO);
            context.JNI_ENV.TryGetStaticMethodId(this.GlobalClass, "getContentRoot\0"u8, "()Ljava/lang/String;\0"u8, out Method_getContentRoot);
        }

        public JBOOLEAN Callback_INFO(PTR_JNI_ENV context, JOBJECT @this, JSTRING json) => context.CallBooleanMethod(@this, Method_INFO, json);

        public JSTRING GetContentRoot(PTR_JNI_ENV context) => context.CallStaticObjectMethod<JSTRING>(this.GlobalClass, Method_getContentRoot);


        public static AndroidWebApiNotifyMetadata CreateMetadata(in JniEnvironmentContext context) => CreateMetadata(context, AndroidExtensions.JavaClassFullName);
    }
}
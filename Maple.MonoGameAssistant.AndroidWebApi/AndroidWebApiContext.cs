using Maple.MonoGameAssistant.AndroidCore.Api;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using Maple.MonoGameAssistant.Model;

namespace Maple.MonoGameAssistant.AndroidWebApi
{
    public class AndroidWebApiContext(JavaVirtualMachineContext virtualMachineContext)
    {
        public JavaVirtualMachineContext VirtualMachineContext { get; } = virtualMachineContext;
        public DynamicStaticFileProvider StaticFileProvider { get; } = new DynamicStaticFileProvider();
        public MonoGameSettings Settings { get; } = new MonoGameSettings() { Http = true, MonoDataCollector = true };
        public static AndroidWebApiContext CreateContext(PTR_JAVA_VM javaVM)
        {
            return new AndroidWebApiContext(new JavaVirtualMachineContext(javaVM));
        }


    }

}

using Maple.MonoGameAssistant.AndroidJNI.Context;
namespace Maple.MonoGameAssistant.AndroidCore.Api
{
    [Obsolete("use web api")]
    public interface IAndroidContext
    {
        JavaVirtualMachineContext VirtualMachineContext { get; }
    }
}

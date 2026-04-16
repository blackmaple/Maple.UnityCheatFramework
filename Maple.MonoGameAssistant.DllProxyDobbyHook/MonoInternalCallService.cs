namespace Maple.MonoGameAssistant.DllProxyDobbyHook
{
    public partial class MonoInternalCallService
    {
        public IReadOnlyDictionary<string, nint> InternalCalls { get; } = MonoInternalCallNativeMethods.GetInternalCallCollection();

        public bool TryGetInternalCall(string name, out nint method)
        {
            return this.InternalCalls.TryGetValue(name, out method) && method != nint.Zero;
        }

        public nint TryGetInternalCall(string name)
        {
            if (this.TryGetInternalCall(name, out var ptr))
            {
                return ptr;
            }
            return nint.Zero;
        }
    }


}

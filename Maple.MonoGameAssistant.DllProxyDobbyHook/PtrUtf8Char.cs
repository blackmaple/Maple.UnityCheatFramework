using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Maple.MonoGameAssistant.DllProxyDobbyHook
{
    [StructLayout(LayoutKind.Sequential)]
    unsafe readonly struct PtrUtf8Char(nint ptr)
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator nint(PtrUtf8Char ptr) => ptr._ptr;
        public static implicit operator PtrUtf8Char(nint ptr) => new(ptr);
        public unsafe static implicit operator PtrUtf8Char(byte* ptr) => new nint(ptr);
        public unsafe static implicit operator PtrUtf8Char(void* ptr) => new nint(ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string? ToString() => GetRawString();

        public ReadOnlySpan<byte> AsReadOnlySpan()
        {
            if (false == Valid())
            {
                return default;
            }
            var span = MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)_ptr);
            return span;
        }

        public string? GetRawString()
        {
            if (false == Valid())
            {
                return default;
            }
            return Encoding.UTF8.GetString(this.AsReadOnlySpan());
        }

        public byte[] ToArray()
             => AsReadOnlySpan().ToArray();

    }

    [StructLayout(LayoutKind.Sequential)]
    readonly unsafe struct PtrOut<T>(scoped ref T data) where T : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = new(Unsafe.AsPointer(ref data));

        public ref T Raw => ref Unsafe.AsRef<T>(_ptr.ToPointer());

        public static implicit operator nint(PtrOut<T> o) => o._ptr;

        public static PtrOut<T> FromOut(out T data)
        {
            Unsafe.SkipInit(out data);
            return new PtrOut<T>(ref data);
        }
    }
}

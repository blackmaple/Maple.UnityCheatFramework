using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct MetadataRefValue<T>(T data)
        where T : unmanaged
    {
        readonly T _value = data;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator MetadataRefValue<T>(T data) => new(data);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator T(MetadataRefValue<T> data) => data._value;

        public ref readonly T Ref => ref Unsafe.AsRef(in _value);
        public readonly T Val => _value;
    }
}

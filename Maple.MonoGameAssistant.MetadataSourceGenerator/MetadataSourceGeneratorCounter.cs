using System.Text;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{
    public static class MetadataSourceGeneratorCounter
    {
        private static ulong Value { set; get; }
        private static ulong AddNumber { set; get; }
        static MetadataSourceGeneratorCounter()
        {
            var dt = DateTime.Now;
            Value = (ulong)(dt.Year + dt.Month + dt.Day + dt.DayOfYear);
            AddNumber = (ulong)(dt.Hour + dt.Minute + dt.Second + dt.Millisecond);
        }


        private readonly static object s_lock = new();


        public static ulong Increment()
        {
            lock (s_lock)
            {
                Value += AddNumber;
                return Value;
            }
        }

        public static ulong IncrementClass(string classDisplayName)
        {
            return CalculateFNV1AHash(classDisplayName);
        }
        static ulong CalculateFNV1AHash(string text)
        {
            const ulong fnvOffsetBasis = 14695981039346656037UL; // FNV-1a 64-bit offset basis
            const ulong fnvPrime = 1099511628211UL; // FNV-1a 64-bit prime

            ulong hash = fnvOffsetBasis;
            byte[] textBytes = Encoding.UTF8.GetBytes(text);

            foreach (byte b in textBytes)
            {
                hash ^= b;
                hash *= fnvPrime;
            }

            return hash;
        }
    }
}

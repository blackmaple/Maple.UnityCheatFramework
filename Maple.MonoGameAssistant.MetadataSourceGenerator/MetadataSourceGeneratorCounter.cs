using System.Reflection.PortableExecutable;

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


    }


}

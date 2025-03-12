using System.Text;

namespace Maple.MonoGameAssistant.MetadataSourceGenerator
{

    public static class MetadataSourceGeneratorHashAlgorithm
    {
        private readonly static object s_lock = new();
        static Dictionary<ulong, string> ClassHashCache { get; } = new Dictionary<ulong, string>(128);
        static Dictionary<ulong, string> FieldHashCache { get; } = new Dictionary<ulong, string>(128);
        static Dictionary<ulong, string> MethodHashCache { get; } = new Dictionary<ulong, string>(128);



        public static bool TryAddMemberHashCache(Dictionary<ulong, string> cache, ulong hash, string txt, out string oldText)
        {
            lock (s_lock)
            {
                if (cache.TryGetValue(hash, out oldText))
                {
                    return oldText == txt;
                }
                cache.Add(hash, txt);
                return true;
            }
        }

        private static bool TryAddClassHashCache(ulong hash, string txt, out string oldText) => TryAddMemberHashCache(ClassHashCache, hash, txt, out oldText);
        private static bool TryAddFieldHashCache(ulong hash, string txt, out string oldText) => TryAddMemberHashCache(FieldHashCache, hash, txt, out oldText);
        private static bool TryAddMethodHashCache(ulong hash, string txt, out string oldText) => TryAddMemberHashCache(MethodHashCache, hash, txt, out oldText);

        public static bool TryGetClassHash(string classDisplayName, out ulong hash, out string oldClassDisplayName)
        {
            hash = CalculateFNV1AHash_64(classDisplayName);
            return TryAddClassHashCache(hash, classDisplayName, out oldClassDisplayName);
        }

        public static bool TryGetFieldHash(string fieldDisplayName, out ulong hash, out string oldFieldDisplayName)
        {

            hash = CalculateFNV1AHash_64(fieldDisplayName);
            return TryAddFieldHashCache(hash, fieldDisplayName, out oldFieldDisplayName);
        }

        public static bool TryGetMethodHash(string methodDisplayName, out ulong hash, out string oldMethodDisplayName)
        {
            hash = CalculateFNV1AHash_64(methodDisplayName);
            return TryAddMethodHashCache(hash, methodDisplayName, out oldMethodDisplayName);
        }

        static ulong CalculateFNV1AHash_64(string text)
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

namespace Maple.MonoGameAssistant.MetadataDemo
{
    public static partial class Program
    {
        static void Main() {

            List<int> a = [1, 2, 3];
            var t = a.Find(p=>p==1);
            var tt = a.FirstOrDefault(p => p == 1);
            
        }
    }
}


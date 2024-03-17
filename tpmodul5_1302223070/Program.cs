// See https://aka.ms/new-console-template for more information

internal class HaloGeneric
{
    class SapaUser
    {
        public static void Print<T>(T X)
        {
            Console.WriteLine("Halo user " + X);
        }
    }
    private static void Main(string[] args)
    {
        SapaUser.Print<string>("Gina Soraya");
    }
}


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
    class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T input)
        {
            this.data = input;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
    private static void Main(string[] args)
    {
        SapaUser.Print<string>("Gina Soraya");
        DataGeneric<string> input1 = new DataGeneric<string>("1302223070");
        input1.PrintData();
    }
}

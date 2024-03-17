
internal class HaloGeneric
{
    private static void Main(string[] args)
    {
        DataGeneric<string> input1 = new DataGeneric<string>("1302223070");
        input1.PrintData();
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
}

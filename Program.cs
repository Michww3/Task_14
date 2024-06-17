class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main1");
        Task.Run(() => Parallel.Invoke(Method1, Method2));
        //Thread.Sleep(1000);
        Console.WriteLine("Main2");
        Console.ReadLine();
        static void Method1()
        {
            Console.WriteLine("Method 1");
        }
        static void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
}
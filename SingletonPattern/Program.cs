
namespace SingletonPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Counter counter1 = Counter.Create();
            Counter counter2 = Counter.Create();
            Console.WriteLine(counter1.count);
            Console.WriteLine(counter2.count);

            counter1.Add();
           

            Console.WriteLine(counter1.count);
            Console.WriteLine(counter2.count);

            counter2.Add();

            Console.WriteLine(counter1.count);
            Console.WriteLine(counter2.count);
        }
    }

}


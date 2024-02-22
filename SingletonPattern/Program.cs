
namespace SingletonPattern
{
    class Program
    {
        public static void Main(string[] args)
        {

            Task task1 = Task.Factory.StartNew(() =>
            {
                Counter counter1 = Counter.Create();
                counter1.Add();
                Console.WriteLine(counter1.count);
            });

            Task task2 = Task.Factory.StartNew(() =>
            {
                Counter counter2 = Counter.Create();
                counter2.Add();
                Console.WriteLine(counter2.count);
            });

            Console.ReadKey();
        }
    }

}


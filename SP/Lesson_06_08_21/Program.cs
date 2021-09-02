using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


namespace Lesson_06_08_21
{
    class Program
    {
        static async void DoSomething()
        {
            var num = await GetSomeNumber();
            Console.WriteLine($"WHoo Hooo YEs! Result: {num}");
            for (int i = 100; i < 150; i++)
            {
                Console.WriteLine($"\tB: {i}");
            }
        }

        static Task<int> GetSomeNumber()
        {
           
            var t = new Task<int>(() =>
            {
                for (int i = 0; i < 500; i++)
                {
                    Console.WriteLine($"\t\tDo something!{i}");
                }
                return 10;
            });
            t.Start();

            return t;
        }

        static void Main(string[] args)
        {
            //var str = await File.ReadAllBytesAsync("");

            DoSomething();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"A: {i}");
            }
        }
    }
}

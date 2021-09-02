using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_05_08_21
{
    class Program
    {
        static void Main(string[] args)
        {

            //var t = Task.Run(() =>
            //{
            //    return "sdaas";
            //});

            //Console.WriteLine(t.Result);

            var tsk = new Task(()=> { });

            Task<string> task = File.ReadAllTextAsync("");

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(task.Result);

            Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine($"\t\t\t{i}");
                }
            });

            Task.Run(() =>
            {
                for (int i = 1000; i < 2000; i++)
                {
                    Console.WriteLine($"\t\t{i}");
                }
            });

            for (int i = 0; i < 3000; i++)
            {
                Console.WriteLine(i);
            }


            //int i = 0;
            //var obj = new object();
            //Thread th1 = new Thread(() =>
            //{
            //    for (; i < 1000;)
            //    {
            //        lock (obj)
            //        {
            //            Console.WriteLine($"\t{i++}");
            //        }                    
            //    }
            //});

            //Thread th2 = new Thread(() =>
            //{
            //    for (; i < 1000;)
            //    {
            //        lock (obj)
            //        {
            //            Console.WriteLine($"\t\t{i++}");
            //        }                   
            //    }
            //});

            //Thread th3 = new Thread(() =>
            //{
            //    for (int j = 2000; j < 3000; j++)
            //    {
            //        Console.WriteLine(j);
            //    }
            //});

            //Mutex mutex = new Mutex();

            //Thread th1 = new Thread(() =>
            //{
            //    for (; i < 1000; )
            //    {
            //        mutex.WaitOne();
            //        Console.WriteLine($"\t{i++}");
            //        mutex.ReleaseMutex();                    
            //    }
            //});

            //Thread th2 = new Thread(() =>
            //{
            //    for (; i < 1000; i++)
            //    {
            //        mutex.WaitOne();
            //        Console.WriteLine($"\t\t{i}");
            //        mutex.ReleaseMutex();
            //    }
            //});

            //Thread th3 = new Thread(() =>
            //{
            //    for (int j = 2000; j < 3000; j++)
            //    {
            //        Console.WriteLine(j);
            //    }
            //});

            //th1.Start();
            //th2.Start();
            //th3.Start();
        }
    }
}

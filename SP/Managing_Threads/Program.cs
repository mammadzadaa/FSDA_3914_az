using System;
using System.Threading;

namespace Managing_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
           
            ThreadPool.QueueUserWorkItem((arg) =>
            {
                Console.WriteLine("Thread 1 Started");
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine($"num is {i}");
                }
                Console.WriteLine("Thread 1 ended");
            });

            ThreadPool.QueueUserWorkItem((arg) =>
            {
                Console.WriteLine("Thread 2 Started");
                for (int i = 100; i < 200; i++)
                {
                    Console.WriteLine($"\tnum is {i}");
                }
                Console.WriteLine("Thread 2 ended");
            });

            ThreadPool.QueueUserWorkItem((arg) =>
            {
                Console.WriteLine("Thread 3 Started");
                for (int i = 200; i < 300; i++)
                {
                    Console.WriteLine($"\t\tnum is {i}");
                }
                Console.WriteLine("Thread 3 ended");
            });

            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine($"\t\t\t{i}");
            }

            ThreadPool.QueueUserWorkItem((arg) =>
            {                
                Console.WriteLine("Thread 4 Started");
                for (int i = 300; i < 400; i++)
                {
                    Console.WriteLine($"\t\tnum is {i}");
                }
                Console.WriteLine("Thread 4 ended");
            });

            for (int i = 500; i < 1000; i++)
            {
                Console.WriteLine($"\t\t\t{i}");
            }

            //Thread t = new Thread(()=> 
            //{
            //    Console.WriteLine("Thread Started");
            //    for (int i = 0; i < 2000; i++)
            //    {
            //        Console.WriteLine($"Num is {i}");
            //    }
            //    Console.WriteLine("Thread Ended");                        
            //});
            //t.IsBackground = true;
            //t.Start();
            //for (int i = 2000; i < 2200; i++)
            //{
            //    Console.WriteLine($"\tMNum is {i}");
            //}

            Console.WriteLine("Main Thread Ended");



            //Console.WriteLine("Before Thread Started");
            //Thread th = new Thread(() =>
            //{
            //    Console.WriteLine("Thread Started");
            //    for (int i = 0; i < 2000; i++)
            //    {
            //        Console.WriteLine($"Th1 num {i}");
            //    }
            //    Console.WriteLine("Thread Ended");
            //});
            
            //th.Start();
            //Console.WriteLine("After Thread Started");
            //for (int i = 2000; i < 3000; i++)
            //{
            //    Console.WriteLine($"Main num {i}");
            //}

            //th.Join();
            //Console.WriteLine("After Thread Joined");
            //for (int i = 3000; i < 4000; i++)
            //{
            //    Console.WriteLine($"Main after join num {i}");
            //}
        }
    }
}

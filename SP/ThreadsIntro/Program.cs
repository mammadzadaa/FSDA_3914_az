using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace ThreadsIntro
{
    class Program
    {
        static void foo1() 
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Hello for the {i} time");
            }
        }

        static void foo2()
        {
            for (int i = 1000; i < 2000; i++)
            {
                Console.WriteLine($"And than hello for the {i} time");
            }
        }
        static void Main(string[] args)
        {
            var thread = new Thread(foo2);
            thread.Start();

            //Thread.Sleep(1);
            foo1();

            var thread2 = new Thread(() =>
            {
                
            });

            


            // Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome");
            //var processes = Process.GetProcessesByName("notepad");
            //foreach (var p in processes)
            //{
            //    p.Kill();
            //}
            //var process = new Process()
            //{ 
            //    StartInfo = new ProcessStartInfo()
            //    {
            //        FileName = "notepad",
            //        //Arguments = "day.az"
            //    }
            //};
            //process.Start();
            //Console.WriteLine(process.StartTime);
            //Console.ReadKey();
            //var handle = process.MainWindowHandle;
            //PInvoke.User32.MessageBox(handle, "Senan necedu?", "MB box for Senan",PInvoke.User32.MessageBoxOptions.MB_OKCANCEL);

        }
    }
}

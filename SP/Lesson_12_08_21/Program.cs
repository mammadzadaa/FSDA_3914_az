using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_12_08_21
{
    class Program
    {

        public volatile int a;
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            num.Add(12);
            num.Add(1);
            num.Add(9);
            num.Add(234);
            num.Add(78);
            Parallel.ForEach(num, n => Console.WriteLine(n));

            num.AsParallel().AsOrdered().ToList();
            System.Timers.Timer timer = new System.Timers.Timer();
            
            Timer t = new Timer((c) => 
            {
                //var l = c as List<int>;                
                Console.WriteLine("Hello");
            },null,1000,500);
            while (true)
            {
                Console.WriteLine("1");
            }
            
        }
    }
}

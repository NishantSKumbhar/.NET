using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StopWatch
    {
        public static DateTime t1;
        public static DateTime t2;
        public static void start()
        {
            Console.WriteLine("Stopwatch Started !");
            t1 = DateTime.Now;
        }

        public static void stop() 
        {
            Console.WriteLine("Stopwatch Stopped !");
            t2 = DateTime.Now;
        }

        
    }
}

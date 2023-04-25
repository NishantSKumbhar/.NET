using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String
{
    internal class BasicsStrings
    {
        public void printStrings()
        {
            int[] arr = new int[4] { 1, 4, 6, 2 };
            string arrname = string.Join(",", arr);
            Console.WriteLine(arrname);
            Console.WriteLine(arrname.Length);
            for(int i = 0; i < arrname.Length; i++)
            {
                Console.WriteLine(arrname[i]);
            }

            string name = string.Format("{0} {1}", "Nishant", "Kumbhar");
            Console.WriteLine(name);

            string url = @"https://github.com/NishantSKumbhar";
            Console.WriteLine(url); 
        }
    }
}

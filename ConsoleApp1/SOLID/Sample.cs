using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SOLID
{
    internal class Sample
    {
        public static void printArray(params int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);  
            }
        }

        public static int add(int n1, int n2)
        {
            return n1 + n2;
        }


        public static float add(float n1, float n2)
        {
            return n1 + n2;
        }
    }
}

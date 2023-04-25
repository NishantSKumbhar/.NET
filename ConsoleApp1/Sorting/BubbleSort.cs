using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sorting
{
    internal class BubbleSort
    {
        public void bubbleSort(int[] arr)
        {
            Console.WriteLine("\nBefore sorting : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            

            for(int i = 0; i < arr.Length - 1; i++)
            {
                Boolean flag = true;
                for(int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        arr[j] = arr[j] ^ arr[j + 1];
                        arr[j +1] = arr[j] ^ arr[j + 1];
                        arr[j] = arr[j] ^ arr[j + 1];
                        flag = false;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Sorted in mid : so breaking : efficient : at iteration : " + i);
                    break;
                }
            }
            Console.WriteLine("\nAfter sorting, using Bubble Sort : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

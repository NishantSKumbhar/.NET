using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sorting
{
    internal class InsertionSort
    {
        public void insertionSort(int[] arr)
        {
            Console.WriteLine("\nBefore sorting : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }


            for (int i = 0; i < arr.Length - 1; i++)
            {
                int temp = arr[i + 1];
                for (int j = i; j >= 0; j--)
                {
                    if (arr[j+1] < arr[j])
                    {
                        arr[j] = arr[j+1] ^ arr[j];
                        arr[j+1] = arr[j + 1] ^ arr[j];
                        arr[j] = arr[j + 1] ^ arr[j];
                    }
                    
                }
                
            }
            Console.WriteLine("\nAfter sorting, using Insertion Sort : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

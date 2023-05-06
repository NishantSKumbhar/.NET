using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sorting
{
    internal class SelectionSort
    {

        public void selectionSort(int[] arr)
        {

            Console.WriteLine("\nBefore sorting : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }


            for (int i = 0; i < arr.Length - 1; i++)
            {
                
                
                int minIndx = i;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] <= arr[minIndx])
                    {
                       
                        minIndx = j;
                    }
                }
                if(minIndx != i)
                {
                    arr[i] = arr[i] ^ arr[minIndx];
                    arr[minIndx] = arr[i] ^ arr[minIndx];
                    arr[i] = arr[i] ^ arr[minIndx];
                }
                
            }
            Console.WriteLine("\nAfter sorting, using Selection Sort : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

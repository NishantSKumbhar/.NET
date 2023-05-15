using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public static void m1()
        {
            Console.WriteLine("\nInside the Class1");

            int[] arr = new int[10] { 10, 1, 5, 2, 9, 3, 4, 8, 7, 6 };
            int[] brr = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] crr = new int[5] { 1, 100, 3, 2, 5 };
            //bubble(brr);
            //insertion(crr);
            selection(crr);
        }


        public static void selection(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                
                int minIndx = i;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndx])
                    {
                       
                        minIndx= j;
                    }
                }
                int temp = arr[minIndx];
                arr[minIndx] = arr[i];
                arr[i] = temp;
                //arr[i] = arr[i] ^ arr[minIndx];
                //arr[minIndx] = arr[i] ^ arr[minIndx];
                //arr[i] = arr[i] ^ arr[minIndx];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }


        public static void insertion(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                //int temp = arr[i];
                for(int j = i-1; j >= 0; j--)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        arr[j] = arr[j] ^ arr[j + 1];
                        arr[j+1] = arr[j] ^ arr[j + 1];
                        arr[j] = arr[j] ^ arr[j + 1];
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }


        public static void bubble(int[] arr)
        {
            for(int i = 0; i < arr.Length-1; i++)
            {
                for(int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        arr[j] = arr[j] ^ arr[j + 1];
                        arr[j+1] = arr[j] ^ arr[j + 1];
                        arr[j] = arr[j] ^ arr[j + 1];
                    }
                }
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

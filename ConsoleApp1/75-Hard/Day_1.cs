using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._75_Hard
{

    // May 22, 2023

    internal class Day_1
    {
        // https://www.techiedelight.com/data-structures-and-algorithms-problems/
        // Find a pair with the given sum in an array
        // 1
        public static void PairSumArray(int[] arr, int target)
        {
            bool ansFound = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        Console.WriteLine($"Got Pair : {arr[i]} and {arr[j]}");
                        ansFound = true;
                    }
                }
            }

            if (!ansFound)
            {
                Console.WriteLine("Not found any pair.");
            }
            // The time complexity of the above solution is O(n2) and doesn’t require any extra space, where n is the size of the input.
        }

        // 2
        public static void PairSumArraySort(int[] arr, int target)
        {
            Array.Sort(arr);

            int low = arr[0];
            int high = arr.Length - 1;
            bool ansFound = false;
            while (low < high)
            {
                if (arr[low] + arr[high] == target)
                {
                    Console.WriteLine($"Got Pair : {arr[low]} and {arr[high]}");
                    ++low;
                    --high;
                    ansFound = true;
                }
                else if (arr[low] + arr[high] < target)
                {
                    low = low + 1;
                }
                else
                {
                    high = high - 1;
                }
            }
            if (!ansFound)
            {
                Console.WriteLine("Not found any pair.");
            }
            // The time complexity of the above solution is O(n.log(n)) and doesn’t require any extra space.
        }


        // 3
        public static void PairSumArrayHash(int[] arr, int target)
        {
            Hashtable d = new Hashtable();
            bool ansFound = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (d.ContainsKey(target - arr[i]))
                {
                    int a = arr[(int)d[target - arr[i]]];
                    Console.WriteLine($"Got Pair : {a} and {arr[i]}");
                    ansFound = true;
                }
                else
                {
                    d.Add(arr[i], i);
                }
            }
            if (!ansFound)
            {
                Console.WriteLine("Not found any pair.");
            }

            //The time complexity of the above solution is O(n) and requires O(n) extra space, where n is the size of the input.
        }


        // 4
        // Sort binary array in linear time

        public static void SortBinaryArray(int[] arr)
        {
            int zCount = 0;

             for(int i = 0; i < arr.Length; i++)
             {
                if (arr[i] == 0)
                {
                    zCount++;
                }
             }
            for (int i = 0; i < zCount; i++)
            {
                arr[i] = 0;
            }
            for (int i = zCount; i < arr.Length; i++)
            {
                arr[i] = 1;
            }

            Console.WriteLine("After sorting : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //The time complexity of the above solution is O(n) and doesn’t require any extra space, where n is the size of the input.
        }

        // 5
        public static void SortBinaryArrayQuick(int[] arr)
        {
            int pivot = 1;
            int j = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < pivot)
                {
                    // swap arr[i] , arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
            }
            Console.WriteLine("After sorting : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //The time complexity of the above solution is O(n) and doesn’t require any extra space, where n is the size of the input.
        }

        // Find the maximum product of two integers in an array
        // 6
        public static void findMaximumProduct(int[] arr)
        {
            int maxValue = int.MinValue;
            int max_i = -1;
            int max_j = -1;
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i+ 1; j < arr.Length; j++) 
                {

                    if ((arr[i] * arr[j]) > maxValue)
                    {
                        maxValue = arr[i] * arr[j];
                        max_i = i;
                        max_j = j;
                    }
                }
            }

            Console.WriteLine($"Maximum value : {maxValue} with {arr[max_i]} & {arr[max_j]}");
            // The time complexity of the above solution is O(n2) and doesn’t require any extra space, where n is the size of the input.
        }

        // 7
        public static void findMaximumProductSort(int[] arr)
        {
            Array.Sort(arr);

            if (arr[0] * arr[1] > arr[arr.Length -1 ] * arr[arr.Length - 2])
            {
                Console.WriteLine($"Maximum value : {arr[0] * arr[1]} with {arr[0]} & {arr[1]}");
            }
            else
            {
                Console.WriteLine($"Maximum value : {arr[arr.Length - 1] * arr[arr.Length - 2]} with {arr[arr.Length - 1]} & {arr[arr.Length - 2]}");
            }

            // The time complexity of the above solution is O(n.log(n)) and doesn’t require any extra space.
        }

        // 8
        public static void findMaximumProductWithoutSort(int[] arr)
        {
            // try to get the values
            // max , second max
            // min , second min
            // In linear

            //int max = arr[0];
            //int smax = 
        }
    }
}

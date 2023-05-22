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
        // https://www.techiedelight.com/find-pair-with-given-sum-array/
        // Find a pair with the given sum in an array
        public static void PairSumArray(int[] arr, int target)
        {
            bool ansFound = false;
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        Console.WriteLine($"Got Pair : {arr[i]} and {arr[j]}");
                        ansFound = true;
                    }
                }
            }

            if(!ansFound ) 
            {
                Console.WriteLine("Not found any pair.");
            }
            // The time complexity of the above solution is O(n2) and doesn’t require any extra space, where n is the size of the input.
        }


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
                else if(arr[low] + arr[high] < target)
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

    }
}

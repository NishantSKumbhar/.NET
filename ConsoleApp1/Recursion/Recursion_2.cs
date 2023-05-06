using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Recursion
{
    internal class Recursion_2
    {

        public int josephus(int n, int k)
        {
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = i;
                
            }
            
            
            int gunIndex = 0;
            int deathIndex = (gunIndex + (k - 1)) % n;

            for (int i = 0; i < n - 1; i++)
            {

                arr[deathIndex] = -1;

                gunIndex = (deathIndex + 1) % n;
                while (arr[gunIndex] == -1)
                {
                    gunIndex = (gunIndex + 1) % n;
                }

                int cnt = 0;
                deathIndex = (gunIndex + 1) % n;
                while(cnt < k-1)
                {
                    if (arr[deathIndex] != -1)
                    {
                        cnt++;
                        if(cnt == k-1)
                        {
                            break;
                        }
                    }

                    deathIndex = (deathIndex + 1) % n;
                    
                }
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("At " + (i + 1) + " Round : ");
                printArray(arr);
                Console.WriteLine("--------------------------------------");
            }
            printArray(arr);
            Console.WriteLine("Death Index : " + deathIndex);
            return gunIndex;

        }


        // Josephus using recursion

        public int josephusRec(int n, int k)
        {

            if (n == 1) return 0;

            int ans = (josephusRec(n - 1, k) + k) % n;
            return ans;

        }


        public static void printArray(int[] arr)
        {
            Console.Write("\nArray : ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
        }

        // ways of traversing matrix from start to end : Condition only right and bottom
        public int waysInMNMatrixRec(int m, int n)
        {
            if(m == 1 || n == 1) return 1;
            int ans = waysInMNMatrixRec(m-1, n) + waysInMNMatrixRec(m, n-1);
            return ans;

        }
    }
}

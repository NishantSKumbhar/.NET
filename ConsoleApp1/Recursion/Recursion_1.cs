using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Recursion
{
    internal class Recursion_1
    {
        // https://www.w3resource.com/c-programming-exercises/recursion/index.php


        public string reverseStringRec(string str, int i)
        {
            if(i < 0)
            {
                return "";
            }

            string ans = str[i] + reverseStringRec(str, --i);
            return ans;
            
        }
       

        public int largestInArrayRec(int[] arr,int i, int l)
        {
            if(i == arr.Length)
            {
                return l;
            }
            if (arr[i] > l)
            {
                l = arr[i];
            }
            int ans = largestInArrayRec(arr, ++i, l);
            return ans;
        }


        public int gcdOfNumberRecc(int n1, int n2)
        {
            if(n2 == 0) return n1;

            int ans = gcdOfNumberRecc(n2, n1%n2);
            return ans;
        }


        public int sumOfDigitsOfNumberRec(int number)
        {
            if(number == 0) return 0;

            int d = number % 10;

            number /= 10;

            int sum = d + sumOfDigitsOfNumberRec(number);
            return sum;
        }
        public int countDigitsRec(int n)
        {
            if(n == 0)
            {
                return 0;
            }

            n = n / 10;

            int cnt = 1 + countDigitsRec(n);
            return cnt;
        }


        public void printArrayRevRec(int[] arr, int l, int i) 
        {
            if(i < 0)
            {
                return;
            }

            Console.WriteLine(arr[i] + " ");
            printArrayRevRec(arr, l, i - 1);
        }

        public void fibonacciRec(int n1, int n2, int count)
        {
            if(count < 1)
            {
                return;
            }
            Console.Write(n1 + " ");
            int temp = n1;
            n1 = n2;
            n2 = temp + n2;
            fibonacciRec(n1, n2, --count);
        }


        public int factorialOfNumbersRec(int n)
        {
            if(n == 1) {  return 1;}

            int ans = n * factorialOfNumbersRec(n - 1);
            return ans;
        }
        public int sumOfNumbersRec(int n)
        {
            if(n == 0) return 0;

            int ans = n + sumOfNumbersRec(n - 1);

            return ans;
        }
    }
}

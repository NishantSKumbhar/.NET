using ConsoleApp1.Math;
using ConsoleApp1.Recursion;
using ConsoleApp1.Sorting;
using ConsoleApp1.String;
using ConsoleApp1.Enum;
using ConsoleApp1.SOLID;
using ConsoleApp1.Inheritance;
using ConsoleApp1.ExceptionInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;
using ConsoleApp1.Exception;

// https://www.techiedelight.com/

namespace ConsoleApp1
{

    public class Mobile
    {
        public string name;
        public int price;
        public int id;
        public string color;
        public Mobile()
        {
            Console.WriteLine("Mobile Default Constructor is called.");
        }

        public Mobile(string name, int price, int id, string color)
        {
            this.name = name;
            this.price = price;
            this.id = id;
            this.color = color;
        }

        public void display()
        {
            Console.WriteLine($"Id : {this.id}");
            Console.WriteLine($"Name : {this.name}");
            Console.WriteLine($"Price : {this.price}");
            Console.WriteLine($"Color : {this.color}");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            int i = 8;
            //try
            //{

            //    int ans = arr[i];
            //}
            ////catch( Exception e)
            ////{
            ////    Console.WriteLine(e.Message);
            ////}
            //catch(IndexOutOfRangeException ie) when(i < 0)
            //{
            //    throw new ArgumentOutOfRangeException("Index can not be negative.", ie);
            //}
            //catch (IndexOutOfRangeException ie)
            //{
            //    throw new ArgumentOutOfRangeException("Index can not be grater than size of array.", ie);
            //}

            //Employee e1 = new Employee
            //{
            //    name = "Mosh",
            //    id = 2,
            //    gender = "Male",
            //    isWorking = true
            //};

            //e1.show();
            //Class2 c2 = Class2.getInstance();
            //Console.WriteLine(c2); // return : ConsoleApp1.Class2 
            //Class2 c3 = Class2.getInstance();
            //Console.WriteLine(c3); // return : ConsoleApp1.Class2 

            ExceptionMainStart.start();



        }


        // FastPower
        static int fastPower(int a, int b)
        {
            int res = 1;

            while (b > 0)
            {
                
                if ((b & 1) == 1)
                {
                    res = res * a;
                }

                a = a * a;
                b = b / 2;
            }

            return res;

        }


        // GCD of a number
        static int gcd(int num1, int num2)
        {
            if(num2 == 0)
            {
                return num1;
            }

            int ans = gcd(num2, num1 % num2);

            return ans;
        }


        // Trailing zeros of a factorial of number;
        static int trailingZeros(int number)
        {
            int ans = 0;

            for(int i = 5; i <= number; i *= 5)
            {
                ans = ans + (number / i);
            }

            return ans;
        }


        static Boolean[] sieveOfEratosthenes(Boolean[] brr)
        {
            brr[0] = false; brr[1] = false;

            for (int i = 2; i * i < brr.Length; i++)
            {
                for(int j = 2*i; j < brr.Length; j += 2 * i)
                {
                    brr[j] = false;
                }
            }

            return brr;

        }

    }


    
}

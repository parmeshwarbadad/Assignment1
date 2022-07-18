using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class No25_15
    {
        static void Main(string[] args)
        {
            for (int i = 25; i >= 15; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    class No350_400

    {
        static void Main(string[] args)
        {
            for (int i = 350; i <= 400; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class OddNo15_30
    {
        static void Main(string[] args)
        {
            for (int i = 15; i <= 30; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class NoOfOddNo1_20
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("the num of counts are: " + count++);
        }
    }
    class EvenNo1_10
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine(" Enter a number ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sum; i++)
            {
                if (i % 2 == 0)
                    sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
    class Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num +" X "+i +" = " +i*num);
            }
        }
    }
    class FibonacciSeries
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, sum = 0;
            //Console.WriteLine(n1+" "+n2);
            for(int i= 2; i < 10; i++)
            {
                sum = n1 + n2;
                Console.WriteLine(" "+ sum);
                n1 = n2;
                n2 = sum;

            }
        }
    }

}


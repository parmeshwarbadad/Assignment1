using System;
using System.Collections.Generic;
using System.Text;

namespace AbsValue
{
    class Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + "X " + i + "=" + i * num);

            }

        }
    }
    class Factor
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);

                }
            }

        }

    }
    class FactorsOf50
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number")

            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Red Blue");
                }
                else if(i%3==0 && i%5!=0)
                {
                    Console.WriteLine("Blue");
                }
                else if(i%3!=0 && i%5==0)
                {
                    Console.WriteLine("Red");
                }
                else
                {
                    Console.WriteLine(i);
                }


            }


        }
    }
}

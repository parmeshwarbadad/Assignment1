using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{      
    // 4 3 2 1
    // 4 3 2
    // 4 3 
    // 4
    //

    class PatternNumber1
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++) 
            {
                for (int j = 4; j>=i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
    }
    // 1 2 3 4
    // 1 2 3
    // 1 2
    // 1
    class PatternNumber2
    {
        static void Main(string[] args)
        {
          //  int num;
            //Console.WriteLine(" Enter a number");
            //num = int.Parse(Console.ReadLine());
            for(int i=4;i>=1;i--)
            {
                for(int j = 1; j<=i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
    // 1
    // 2 3
    // 4 5 6
    // 7 8 9 10
    class PatternNumber3
    {
        static void Main(string[] args)
        {
            int num = 0;
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    num = num + 1;

                    Console.Write(num);
                }
                Console.WriteLine();

            }
        } 
    }

    // 1 2 3 4
    // 2 3 4
    // 3 4 
    // 4
    class PatternNumber4
    {
        static void Main(string[] args)
        {
            int num = 0;
            for(int i = 4; i<=1; i++)
            {
                for(int j = 1;j<=i; j++)
                {
                    Console.Write(num);
                    num = num + 1;

                }
                Console.WriteLine();
            }
        }
    }
}

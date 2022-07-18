using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int r, sum = 0;
            int temp = num;
            while (num > 0)
            {
                r = num % 10;
                sum = sum + r * r * r;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine(temp + " is a Armstrong number");
            }
            else
            {
                Console.WriteLine(temp + " is not a Armstrong number");
            }
        }
    }
    class Palindrome
    {
        static void Main(string[] args)
        {
            int num, r, rev = 0;
            Console.WriteLine("Enter a number ");
            num = int.Parse(Console.ReadLine());
            int temp = num;
            while (num > 0)
            {
                r = num % 10;
                rev = rev * 10 + r;
                num = num / 10;
            }
            if (rev == temp)
            {
                Console.WriteLine(temp + " Number is palindromen");
            }
            else
            {
                Console.WriteLine(temp + " Number is not palindromen");

            }
        }
    }
    class Table1_5
    {
        static void Main(string[] args)
        {
            int i, j = 1;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i * j);
                }
                Console.WriteLine();

            }

        }
    }
    // * pattern
    //    *        
    //    **
    //    ***
    //    ****
    class Pattern1
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
    //   *Pattern
    // ****
    // ***
    // **
    // *

    class Pattern2
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
    //  *pattern
    //   *
    //  **
    // ***
    //****

    class Pattern3
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=3;j>=i;j--)
                {
                    Console.Write(" ");
                }for(int k=1;k<=i;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
    //  *Pattern
    //*       *
    //* *     *
    //*   *   *
    //*     * *
    //*       *

    class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 8; i++)
            {
                for(int j = 1; j <= 8; j++)
                {
                    if(j==1 || j==8 || i==j)
                       Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
    
            }
        }
    }
    //   *Patterm
    //        *
    //        *
    //        *
    //  * * * * * * *   
    //        *
    //        *
    //        *  
    class Pattern5
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    if(j==5 || i==5)
                       Console.Write(" *");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();

            }
        }
    }
    //  *Pattern
    //  *
    //  * *
    //  *  *
    //  *   *
    //  *    *
    //  ******* 
    class Pattern6
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    if(j==1 || i==j || i==5)
                       Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }
    }
    //  *Pattern

    // * * * * * 
    // *       *
    // *       *
    // *       *
    // * * * * *
    class Pattern7
    {
        static void Main(string[] args)
        {
            for(int i = 1;i <= 8; i++)
            {
                for(int j = 1; j <= 8; j++)
                {
                    if(i==1 || j==1 || i==8 || j==8)
                    Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();

            }
        }
    }

}




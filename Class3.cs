using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class ReversNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int revers = 0;
            while (num > 0)
            {
                int r = num % 10;
                revers = revers * 10 + r;
                num = num / 10;
            }
            Console.WriteLine(revers);
        }
    }
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            int p = 0;
            int sum = 0;
            Console.WriteLine("Enter the binary number");
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                int power = (int)(Math.Pow(2, p));
                sum = sum + (power * (num % 10));
                num = num / 10;
                p++;
            }
            Console.WriteLine(sum);
        }
    }
    class MathCalculation
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("Enter a frist number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a 2nd number");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("1. Addition \n 2. Subtraction" +
                    " \n 3. Multiplication \n 4.Division");
                Console.WriteLine("Enter your choises");
                int choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("addition of two number are " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("substraction of two number is " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine(" multiplication of two numbers are " + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("division of two numbers are " + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }
                Console.WriteLine("Do you want to continue... ");
                ch = Console.ReadLine()[0];
            } while (ch == 'y' || ch == 'Y');

        }
    }
    /*class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal nuumber");
            int num = int.Parse(Console.ReadLine());
            int rev = 0;
            int rem = 0;

            string binary = "";
            while (num > 0)
            {
                  rem = num % 2;
                binary = binary + rem ;
                num = num / 2;

            }
            Console.WriteLine(binary );
            while (rem>0)
            {
                rev = rev * 10 + rem%10;
                rem = rem/10;
            }
        }
    }*/
    class DecimalBinTo
    {
        static void Main(string[] args)
        {
            int n, r = 0, bin = 0, base1 = 1; ;
            Console.WriteLine("Enter a decimal number");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                r = n % 2;
                bin = bin + r * base1;
                n = n / 2;
                base1 = base1 * 10;
            }
            Console.WriteLine(bin);

        }
    }
    class Print1_10
    {
        static void Main(string[] args)
        {
            int n = 1;
            /*Console.WriteLine(" Enter a number ");
            n = int.Parse(Console.ReadLine());*/
            while (n <= 10)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine(n * n);
                }
                n++;
            }
        }
    }
           // series 2 5 10 17 26......
    class Series1
    {
        static void Main(string[] args)
        {
            int n = 1, series=0;
            //int n=10, series = 0; ;
            while (n < 10)
            //for (int i = 1; i <= n; i++)
            {
                series = n * n + 1;
                //series = i * i + 1;
                 n++;
                Console.WriteLine(series);
            }

        }
    }
        //series : 2 12 36 80...
    class Series2
    {
        static void Main(string[] args)
        {
            int n = 1, series = 0;
            while (n < 10)
            {
                series = n * n + n * n * n;
                n++;
                Console.WriteLine(series);
            }

        }
    }
        //series : 0 3 8 15 24...
    class Series3
    {
        static void Main(string[] args)
        {
            int n = 1, series = 0; ;
            while (n < 10)
            {
                series = n * n - 1;
                n++;
                    Console.WriteLine(series);
            }
        }
    }
    class SPYorNot
    {
        static void Main(string[] args)
        {
            int n, sum =0,prod =1;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            int orgnum = n;
            while (n!=0)
            {
                {
                   int rem = n % 10;
                    sum = sum + rem;
                
                    prod = prod *rem;
                    n= n / 10;
                }
                
            }

            if (sum == prod)
            {
                Console.WriteLine(orgnum+" Number is spy ");
            }
            else
            {
                Console.WriteLine(orgnum+" Number is not spy ");
            }
        }
    }
}

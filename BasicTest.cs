using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTest

{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int y = int.Parse(Console.ReadLine());
            if ((y % 400 == 0) || ((y % 4 == 0) && (y % 100 != 0)))

                Console.WriteLine("Is Leap year");
            else
                Console.WriteLine("Is not a lea year");
        }
    }
    class Divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("A number is divisible by 5 and 11 ");
            }
            else
            {
                Console.WriteLine("A number is not divisible by 5 and 11 ");

            }
        }
    }
    class Maximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 1st numbers");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a 2nd numbers");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a 3rd numbers");
            int num3 = int.Parse(Console.ReadLine());


            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine(" num1 is maximum");
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                Console.WriteLine(" num2 is maximum");
            }
            else if ((num3 > num1) && (num3 > num2))
            {
                Console.WriteLine(" num3 is maximum");
            }
            else
            {
                Console.WriteLine("All are equal numbers ");

            }
        }
    }
    class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a charector");
            char cha = char.Parse(Console.ReadLine());
            if ((cha == 'a') || (cha == 'e') || (cha == 'i') || (cha == 'o') || (cha == 'u'))
            {
                Console.WriteLine(" is a vowel");
            }
            else
            {
                Console.WriteLine(" is a consonent");
            }

        }

    }
    class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter 1st nmber ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd nmber ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("arithmatics operations are \n 1. addition \n 2. subtraction \n 3. multiplication \n 4 division \n");
            Console.WriteLine("enter choise ");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {

                case 1:
                    Console.WriteLine("addition of two number is :" + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("subtraction of two nmber is : " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("multiplicatioon of two nmber is " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("division of two nmber is " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("envalid nmber ");
                    break;
            }
        }
    }
    class AlphabateDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a char");
            char cha = Convert.ToChar(Console.ReadLine());
            if ((cha >= 'a' && cha <= 'z') || (cha >= 'A' && cha <= 'Z'))
            {
                Console.WriteLine("You intered charector ");
            }
            else if ((cha > '0') && (cha <= '9'))
            {
                Console.WriteLine("You intered digit ");
            }
            else
            {
                Console.WriteLine("You intered special char ");
            }


        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class AreaQuestion

    {
        public static void Main(string[] args)
        {
            bool YNchoice;
            /*   Console.WriteLine("enter 1st nmber ");
               int num1 = int.Parse(Console.ReadLine());
               Console.WriteLine("enter 2nd nmber ");
               int num2 = int.Parse(Console.ReadLine());*/
            do
            {
                Console.WriteLine("Let me know which area you want to Calculate " +
                    "\n 1. Area of Circle" +
                    " \n 2. Area of Square \n " +
                    "3. Area of Right Angle Triangle" +
                    " \n 4. Area of Rectangle " +
                    "\n 5. Circumference of Circle" +
                    " \n 6. Perimeter of Square");
                Console.WriteLine("Please Enter Your Choise ");
                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Please give me your Circle's radius value:");
                        int rad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Circle is :" + (22 / 7) * rad * rad);
                        break;
                    case 2:
                        Console.WriteLine("Please give me your Sqare's side value:");
                        int side = int.Parse(Console.ReadLine());


                        Console.WriteLine("Area of Square : " + side * side);
                        break;
                    case 3:
                        Console.WriteLine("Please give me your  right angle trangle's Base and hight's value:");
                        int bes = int.Parse(Console.ReadLine());
                        int hight = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Right Angle Triangle : " + bes * hight * 0.5);
                        break;
                    case 4:
                        Console.WriteLine("Please give me your  Rectangle's width and Length's value:");
                        int width = int.Parse(Console.ReadLine());
                        int length = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Rectangle : " + width * length);
                        break;
                    case 5:
                        Console.WriteLine("Please give me your  Circle's radius value:");
                        int radius = int.Parse(Console.ReadLine());
                        Console.WriteLine("Circumference of Circle : " + radius * 44 / 7);
                        break;
                    case 6:
                        Console.WriteLine("Please give me your Square's side value:");
                        int sq_side = int.Parse(Console.ReadLine());
                        Console.WriteLine("Perimeter : " + 4 * sq_side);
                        break;
                    default:
                        Console.WriteLine("OOPS: Sorry You have given Wrong input ");
                        break;
                }

                Console.WriteLine("If you want to calculate more then Please enter: 1");
                Console.WriteLine("If you want to Exit the process then Please enter: 0");

                int yn = int.Parse(Console.ReadLine());



                if (yn == 1)
                    YNchoice = true;
                else
                    YNchoice = false;

            } while (YNchoice);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniLessonMathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 4;
            double total = Math.Pow(num, 10);
            Console.WriteLine(total); //1048576



            double number = 4.8039340293912;
            double shorterNum = Math.Truncate(number);
            Console.WriteLine(shorterNum);  //4



            double roundDown = Math.Floor(number);
            Console.WriteLine(roundDown); //4

            double roundUp = Math.Ceiling(number);
            Console.WriteLine(roundUp); //5



            double numnum = 44;
            double squareroot = Math.Sqrt(numnum);
            Console.WriteLine(squareroot); //12



            int dividend = 56;
            int divisor = 9;
            int remainder;
            int quotient = Math.DivRem(dividend, divisor, out remainder);
            Console.WriteLine(quotient); //6
            Console.WriteLine(remainder); //2


            Console.WriteLine(Math.Max(563044930, 494940239301203)); //494940239301203

            //Given a cone with a height of 15.389 and radius of 2.345, calculate the surface area of the cone. Use the built in constant and methods in the Math Class.
            // A =  pi * r ( r + sqrt(h^2 + r^2))   Truncate the resulting SA. 


            double r = 2.345;
            double h = 15.389;

            double SA = Math.PI * r * (r + Math.Sqrt(Math.Pow(h, 2) + Math.Pow(r, 2)));

            Console.WriteLine(Math.Truncate(SA));































































            //Round the number 6.89344 to 4 digits using Math.Round(). Then, provide the ceiling and floor for the resulting number. 


            double number2 = 6.89344;

            double total2 = Math.Round(number2, 4);

            Console.WriteLine(total2);

            Console.WriteLine(Math.Ceiling(number2));
            Console.WriteLine(Math.Floor(number2));





















            double rounder = Math.Round(6.89344, 4);
            Console.WriteLine(rounder);

            Console.WriteLine(Math.Floor(rounder));
            Console.WriteLine(Math.Ceiling(rounder));



        }
    }
}

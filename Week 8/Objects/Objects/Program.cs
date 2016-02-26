using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program which generates and prints on the console 10 random numbers in the range [100,200].

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int num = random.Next(100, 201);
                Console.WriteLine(num);
            }

            //Write a program that prints on the console which day of the week is today.

            DateTime date = new DateTime();

            Console.WriteLine(date.DayOfWeek);


            //Write a program which calculates the area for 2 different triangles with the following given:
            //length of one side(7) and the height(4)
            //lengths of two sides(24 & 32) and the angle between them(37 degrees) hint: side - angle - side

            double area = (7 * 4) / 2;
            Console.WriteLine(area);


            double area2 = (24 * 32 * Math.Sin(.65)) / 2;
            Console.WriteLine(area2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace declaring_classes
{
    class Chairs
    {
        string fabric;
        bool mobility;
        string color;

        public bool RollieChair()
        {
            Console.WriteLine("Does it move?");
            string input = Console.ReadLine();

            if (input == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RacingChairs()
        {
            if (mobility == true)
            {
                Console.WriteLine("that's a racin' chair");
            }
            else
            {
                Console.WriteLine("visit coolcasters.com to make it a racin' chair");
            }
        }
        

    }
}

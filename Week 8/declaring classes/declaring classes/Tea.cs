using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace declaring_classes
{
    class Tea
    {
        int temp; 
        string flavor;
        string name;
        int brewTime; 

        public void Brew(int brewTime)
        {
            for (int i = 0; i < brewTime; i++)
            {
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine("Tea is done!");
        }
        
        public bool IsItTeaTime()
        {
            Console.WriteLine("Is it tea time?");
            string input = Console.ReadLine();

            if (input == "yes" || input == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace declaring_classes
{
    class Book
    {
        string coverArt;
        int pageCount;
        bool binding;
        bool openOrClosed;

        public string Open()
        {
            if (openOrClosed == true)
            {
                return "yes";
            }
            else
            {
                return "no";
            }
        }

       public bool BindingType()
        {
            Console.WriteLine("Is it hard or soft?");
            string input = Console.ReadLine();

            if (input =="hard")
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

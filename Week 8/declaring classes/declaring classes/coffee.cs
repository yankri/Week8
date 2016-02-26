using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace declaring_classes
{
    class coffee
    {
        string notes;
        int temp;

        public coffee ()
        {
            notes = "pear, nougat, round";
            temp = 200;
        }

        public coffee (string note, int temp1)
        {
            notes = note;
            temp = temp1;

        }

    }
}

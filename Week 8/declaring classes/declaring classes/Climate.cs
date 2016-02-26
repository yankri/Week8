using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace declaring_classes
{
    class Climate
    {
        int temp;
        double humidity;
        string lighting; 

        public string GetDay()
        {
            DateTime day = new DateTime();
            string dayOfWeek = day.DayOfWeek.ToString();

            return dayOfWeek;
        }

        public bool AreTheLightsBright()
        {
            string day = GetDay();

            if (day == "Saturday" || day == "Sunday")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

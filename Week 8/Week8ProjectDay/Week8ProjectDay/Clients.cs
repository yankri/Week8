using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay
{
    class Clients
    {
        string name = "Sam Winchester";
        uint acctNumber = GetAcctNumber();
        List<string> transactions = new List<string>();

        public string AccountHolder { get; set; }
        public uint AcctNumber { get; set; }
        public List<string> TransactionHistory { get; set; }

        public Clients ()
        {
            AccountHolder = name;
            AcctNumber = acctNumber;
            TransactionHistory = transactions;
        }

        public static uint GetAcctNumber ()
        {
            Random random = new Random();

            uint acctNum = (uint)random.Next(100000, 1000000);

            return acctNum;
        }

        public void PrintClientInfo()
        {
            Console.WriteLine("Account Holder: " + this.name);
            Console.WriteLine("Account Number: " + this.acctNumber);
            Console.ReadKey();
        }
    }
}

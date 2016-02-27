using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay
{
    class Clients
    {
        private string name = "Sam Winchester";
        private uint acctNumber = GetAcctNumber();
        private List<string> transactions = new List<string>();

        public string AccountHolder { get; set; }
        public uint AcctNumber { get; set; }
        public List<string> TransactionHistory { get; set; }

        public Clients ()
        {
            AccountHolder = name;
            AcctNumber = acctNumber;
            TransactionHistory = transactions;
        }

        public static uint GetAcctNumber () //gets a random 6 digit number for the account number
        {
            Random random = new Random();

            uint acctNum = (uint)random.Next(100000, 1000000);

            return acctNum;
        }

        public void PrintClientInfo() //prints the client's info to the console
        {
            Console.WriteLine("Account Holder: " + this.name);
            Console.WriteLine("Account Number: " + this.acctNumber);
            Console.ReadKey();
        }
    }
}

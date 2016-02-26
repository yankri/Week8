using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay
{
    class Accounts
    {
        uint acctNum;
        decimal balance = 100;

        public uint AcctNum { get; set; }
        private Clients client { get; set; }
        public decimal Balance { get; set; }

        public Accounts (Clients client)
        {
            this.client = client;
            acctNum = client.AcctNumber;
            Balance = balance;
        }

        public void GetBalance()
        {
            Console.WriteLine("Current Balance: $" + Balance);
            Console.ReadKey();
        }

        public string GetShortAcctNum() //shortens the account num replaced by asterisks for privacy
        {
            string acctNumAsString = client.AcctNumber.ToString();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < acctNumAsString.Length; i++)
            {
                if (i < 3)
                {
                    sb.Append("*");
                }
                else
                {
                    sb.Append(acctNumAsString[i]);
                }
            }

            return sb.ToString();
        }

        public string AcctFileHeader()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Account Summary");
            sb.AppendLine();
            sb.AppendLine("Account Holder: " + client.AccountHolder);
            sb.AppendLine();
            sb.AppendLine("Account Number: " + acctNum);
            sb.AppendLine();
            sb.AppendLine("Date/Time\tTransaction Type\tAmount\tCurrent Balance");

            return sb.ToString();
        }

        public void Withdraw () 
        {
            decimal amount;
            while (true)
            {
                Console.WriteLine("Enter the amount you want to withdrawal: ");
                string input = Console.ReadLine();
                bool result = decimal.TryParse(input, out amount);

                if (result == true)
                {
                    Balance = Balance - amount;
                    decimal totalToPrint = Balance;

                    string header = AcctFileHeader();
                    string file = WithdrawLineMaker(amount, totalToPrint);

                    client.TransactionHistory.Add(file);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        public string WithdrawLineMaker (decimal amount, decimal totalToPrint)
        {
            string amt = amount.ToString();
            string total = totalToPrint.ToString();

            StringBuilder sb = new StringBuilder();

            string time = DateTime.Now.ToString();

            sb.Append(time);
            sb.Append("\t");
            sb.Append(" - ");
            sb.Append("\t");
            sb.Append(amt);
            sb.Append("\t");
            sb.Append(total);
            sb.AppendLine();

            return sb.ToString();
        }

        public void Deposit() //add check to make sure it's a number
        {
            Console.WriteLine("Enter the amount you want to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            Balance = Balance + amount;
            decimal totalToPrint = Balance;

            string file = DepositLineMaker(amount, totalToPrint);

            client.TransactionHistory.Add(file);
        }

        public string DepositLineMaker(decimal amount, decimal totalToPrint)
        {
            string amt = amount.ToString();
            string total = totalToPrint.ToString();

            StringBuilder sb = new StringBuilder();

            string time = DateTime.Now.ToString();

            sb.Append(time);
            sb.Append("\t");
            sb.Append(" + ");
            sb.Append("\t");
            sb.Append(amt);
            sb.Append("\t");
            sb.Append(total);
            sb.AppendLine();

            return sb.ToString();
        }

        public void FileWriter (List<string> transactions)
        {
            string header = AcctFileHeader();

            StreamWriter writer = new StreamWriter("AccountSummary.txt");
            using (writer)
            {
                writer.WriteLine(header);

                if (transactions.Count > 0)
                {
                    foreach (string line in transactions)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8ProjectDay
{
    class MainMenu
    {

        public void PrintMenu()
        {
            Console.Title = "*******BANKING SYSTEM*******";

            Console.WriteLine(Console.Title + "\n\n");
            Console.WriteLine("Enter a number to select an option: \n");
            List<string> menu = new List<string>() { "1 - View Client Information", "2 - View Account Balance", "3 - Deposit Funds", "4 - Withdraw Funds", "5 - Exit" };

            foreach (string option in menu)
            {
                Console.WriteLine(option);
            }
        }

        public void Menu()
        {
            bool close = false;
            Clients client = new Clients();
            Accounts account = new Accounts(client);

            while (close == false)
            {
                Console.Clear();
                PrintMenu();

                int choice;
                string menuChoice = Console.ReadLine();

                if (int.TryParse(menuChoice, out choice))
                {
                    switch(choice)
                    {
                        case 1:
                            //view client info
                            client.PrintClientInfo();
                            break;
                        case 2:
                            //view acct balance
                            account.GetBalance();
                            break;
                        case 3:
                            //deposit
                            account.Deposit();
                            break;
                        case 4:
                            //withdraw
                            account.Withdraw();
                            break;
                        case 5:
                            Console.WriteLine("\nQuitting...");
                            close = true;
                            break;
                        default:
                            continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            account.FileWriter(client.TransactionHistory);
        }
    }
}

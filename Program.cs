using System;

namespace ATM
{
    class BankATM
    {
        private int curr;

        public BankATM()
        {
            curr = 0;
        }

        public void Deposit()
        {
            Console.WriteLine("Amount to Deposit: ");
            if (int.TryParse(Console.ReadLine(), out int amt) && amt > 0)
            {
                curr += amt;
                Console.WriteLine("Current Balance = " + curr);
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
        }

        public void Withdraw()
        {
            Console.WriteLine("Amount to Withdraw: ");
            if (int.TryParse(Console.ReadLine(), out int amt) && amt > 0)
            {
                if (curr >= amt)
                {
                    curr -= amt;
                    Console.WriteLine("Current Balance = " + curr);
                }
                else
                {
                    Console.WriteLine("Insufficient Funds");
                }
            }
            else
            {
                Console.WriteLine("Invalid Request");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine("Current Balance = " + curr);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM!");
            Console.Write("Enter your Account Name: ");
            string user = Console.ReadLine();
            Console.Write("Enter your PIN: ");
            string pin = Console.ReadLine();
            Console.WriteLine($"Welcome {user}!");

            BankATM bankATM = new BankATM(); // Persisting the instance

            while (true)
            {
                Console.WriteLine("\nSelect your choice:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Balance");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        bankATM.Deposit();
                        break;
                    case "2":
                        bankATM.Withdraw();
                        break;
                    case "3":
                        bankATM.ShowBalance();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using our ATM!");
                        return;
                    default:
                        Console.WriteLine("Enter a valid choice.");
                        break;
                }
            }
        }
    }
}

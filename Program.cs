using System;

namespace bankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a banking related console application");
            Console.WriteLine("It uses a class called BankTeller");

            /* creating an instance of the class
             * and calling all methods once 
             * for the purpose of this exercise */

            Console.WriteLine("Enter your name: ");
            string client = Console.ReadLine();

            BankTeller Ava = new BankTeller();
            Ava.Name = "Ava";

            Ava.welcomeUser(client);
            Ava.RegisterNewClient();
            Ava.ConfirmWithdrawal();

            Console.WriteLine("Your current account balance is " + "\n" + Ava.CheckClientBalance(client));
        }
    }

    class BankTeller
    {
        public string Name { get; set; }


        public void welcomeUser(string clientName)
        {
            Console.WriteLine("Hello! " + clientName + " I'm " + Name + "\nI will be your bank assistant for this session.");
        }

        public void RegisterNewClient()
        {
            //collect the clients details and uses phone number as account number

            Console.WriteLine("Please enter your preferred account name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            string phone = Console.ReadLine();

            Console.WriteLine("Congrats " + name + "! your new account number is " + phone);
        }

        public string CheckClientBalance(string clientName)
        {
            //returns a statement with clients name and balance
            //given that the balance is set for the purpose of this exercise

            double clientBalance = 23400.00;

            return clientName + ": $" + clientBalance;
        }

        public void ConfirmWithdrawal()
        {
            Console.WriteLine("How much would you like to withdraw? ");
            double withdrawalAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Withdrawal of $" + withdrawalAmount+ " successful!");
        }
    }
}

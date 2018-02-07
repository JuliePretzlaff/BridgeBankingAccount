using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //greeting and creating new accounts:
            Console.WriteLine("Thanks for choosing Julie's Bank. \nTo create an account please give your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("When is your birthday?");
            string birthday = Console.ReadLine();
            Console.WriteLine("How much will you be using to open your checking account?");
            double checkingBalance = double.Parse(Console.ReadLine());
            Console.WriteLine("How much will you be using to open your savings acocunt?  You must have at least $200.00 in your acocunt at all times.");
            double userSavings = double.Parse(Console.ReadLine());
            double savingsBalance;

            while (userSavings < 200)
            {
                Console.WriteLine("\nYou must have at least $200.00 in your acocunt at all times.");
                Console.WriteLine("How much will you be using to open your savings account?");
                userSavings = double.Parse(Console.ReadLine());
            }
            savingsBalance = userSavings;

            //create client's checking account & savings account number w random number:
            int checkingAccount;
            int savingsAccount;
            Random r = new Random();
            int[] numbersArray = new int[2];
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = r.Next(11111111, 99999999);
            }
            checkingAccount = numbersArray[0];
            savingsAccount = numbersArray[1];


            //creating instance of client with the info provided:
            Client client1 = new Client(name, birthday, checkingAccount, savingsAccount);

    
            //Console.WriteLine(checkingAccount + " + " + savingsAccount);

            //create instance of client's checking account:
            Checking checkClient1 = new Checking(checkingAccount, checkingBalance);

            //use that number to create the client's savings account instance:
            Savings savingsClient1 = new Savings(savingsAccount, savingsBalance);




            //declare a variable for user to select a menu option
            int userChoice;

            //menu within do while loop to give option of quitting:
            do
            {
                Console.WriteLine("\nPlease make a choice from the following menu: ");
                Console.WriteLine("View Client Information: 1");
                Console.WriteLine("View Account Balance: 2");
                Console.WriteLine("Deposit Funds: 3");
                Console.WriteLine("Withdraw Funds: 4");
                Console.WriteLine("Exit: 5");

                userChoice = int.Parse(Console.ReadLine());

                //switch case
                switch (userChoice)
                {
                    case 1:
                        client1.ClientInfo();
                        Console.WriteLine("Checking account number: " + client1.checkingAccount);
                        Console.WriteLine("Savings account number: " + client1.savingsAccount);
                        break;

                    case 2:
                        Console.WriteLine("Type \"1\" for checking account and type \"2\" for savings account.");
                        string choice = Console.ReadLine().ToLower();
                        if (choice == "1")
                        {
                            Console.WriteLine("Your current account balance is $" + checkClient1.ReturnBalance(checkingBalance));
                        }
                        else if (choice == "2")
                        {
                            Console.WriteLine("Your current account balance is $" + checkClient1.ReturnBalance(savingsBalance));
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid choice.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Type \"1\" for checking account and type \"2\" for savings account.");
                        choice = Console.ReadLine().ToLower();
                        if (choice == "1")
                        {
                            checkClient1.DepositMoney();
                        }
                        else if (choice == "2")
                        {
                            savingsClient1.DepositMoney();
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid choice.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Type \"1\" for checking account and type \"2\" for savings account.");
                        choice = Console.ReadLine().ToLower();
                        if (choice == "1")
                        {
                            checkClient1.WithdrawMoney();
                        }
                        else if (choice == "2")
                        {
                            savingsClient1.WithdrawMoney();
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid choice.");
                        }
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Please enter a valid choice");
                        break;
                }
            } while (userChoice != 5);
            Console.WriteLine("You have quit the program.");
        }
    }
}

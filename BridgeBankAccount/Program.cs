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

            //creating instance of client with the info provided:
            Client client1 = new Client(name, birthday, checkingBalance, savingsBalance);

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
                switch(userChoice)
                {
                    case 1:
                        client1.ClientInfo();
                        break;

                    case 2:
                        Console.WriteLine("Would you like to view your checking or savings balance?");
                        string choice = Console.ReadLine().ToLower();
                        if (choice == "checking")
                        {
                            checkClient1.ReturnBalance(checkingBalance);
                        }
                        else if (choice == "Savings")
                        {
                            checkClient1.ReturnBalance(savingsBalance);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid choice.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Would you like to deposit to your checking or savings account?");
                        choice = Console.ReadLine().ToLower();
                        if (choice == "checking")
                        {
                            //call method
                        }
                        else if (choice == "Savings")
                        {
                            //call method
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid choice.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Would you like to withdraw from your checking or savings account?");
                        choice = Console.ReadLine().ToLower();
                        if (choice == "checking")
                        {
                            //call method
                        }
                        else if (choice == "Savings")
                        {
                            //call method
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
        }
    }
}

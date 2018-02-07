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
            
            Console.WriteLine("Thanks for choosing Julie's Bank. \nTo create an account please give your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("How much will you be using to open your checking account?");
            double checkingBalance = double.Parse(Console.ReadLine());
            Console.WriteLine("How much will you be using to open your savings acocunt?  You must have at least $200.00 in your acocunt at all times.");
            double userSavings = double.Parse(Console.ReadLine());
            double savingsBalance;

            while (userSavings < 200)
            {
                Console.WriteLine("You must have at least $200.00 in your acocunt at all times.");
                Console.WriteLine("How much will you be using to open your savings account?");
                userSavings = double.Parse(Console.ReadLine());
            }
            savingsBalance = userSavings;
        }
    }
}

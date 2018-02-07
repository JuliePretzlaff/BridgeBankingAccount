using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeBankAccount
{
    public class Checking : Account
    {
        //properties:


        public Checking(int accountNum, double initBalance)
        {
            this.AccountNumber = accountNum;
            this.AccountBalance = initBalance;
            this.AccountType = "checking";
        }

        //methods:
        public override double ReturnBalance(double balance)
        {
            return balance;
        }

        public override void DepositMoney()
        {
            Console.WriteLine("How much would you like to deposit?");
            double deposit = double.Parse(Console.ReadLine());
            AccountBalance = AccountBalance + deposit;
            Console.WriteLine("Your current checking account balance is: $" + AccountBalance);
        }

        public override void WithdrawMoney()
        {
            Console.WriteLine("How much would you like to withdraw?");
            double withdraw = double.Parse(Console.ReadLine());
            AccountBalance = AccountBalance - withdraw;
            Console.WriteLine("Your current checking account balance is: $" + AccountBalance);
        }




    }
}

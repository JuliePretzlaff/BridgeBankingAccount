using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeBankAccount
{
    public class Savings : Account
    {
        public Savings(int accountNum, double initBalance)
        {
            this.AccountNumber = accountNum;
            this.AccountBalance = initBalance;
            this.AccountType = "savings";
        }

        //methods:
        public override double ReturnBalance(double balance)
        {
            return balance;
        }

        public override void DepositMoney(double deposit)
        {
            AccountBalance = AccountBalance + deposit;
        }

        public override void WithdrawMoney(double withdraw)
        {
            AccountBalance = AccountBalance - withdraw;
        }
    }
}

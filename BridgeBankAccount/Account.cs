using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeBankAccount
{
    public abstract class Account
    {
        //properties:
        public int AccountNumber { get; }
        public double AccountBalance { get; set; }
        public string AccountType { get; }


        //methods:
        public abstract double ReturnBalance(int balance);

        public abstract void DepositMoney(int deposit);

        public abstract void WithdrawMoney(int withdraw);

    }
}

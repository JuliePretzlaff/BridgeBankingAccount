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
        public int AccountNumber { get; set; }
        public double AccountBalance { get; set; }
        public string AccountType { get; set; }


        //methods:
        public abstract double ReturnBalance(double balance);

        public abstract void DepositMoney(double deposit);

        public abstract void WithdrawMoney(double withdraw);

    }
}

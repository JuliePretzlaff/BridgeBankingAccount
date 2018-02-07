using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeBankAccount
{
    public class Client
    {
        //properties:

        public string ClientName {get; set;}
        public string Address { get; set; }
        public string Birthday { get; set; }
        public double StartingCheckingBalance { get; set; }
        public double StartingSavingsBalance { get; set; }


        //constructors:
        public Client ()
        {
            //default constructor
        }

        public Client(string name, double checking, double savings)
        {
            this.ClientName = name;
            this.StartingCheckingBalance = checking;
            this.StartingSavingsBalance = savings;
        }

        //method:
        public void ClientInfo(string name, double checking, double savings)
        {
            Console.WriteLine("Client name: " + name);
            Console.WriteLine("Current Checking Account Balance: " + checking);
            Console.WriteLine("Current Savings Account Balance: " + savings);
        }

    }
}

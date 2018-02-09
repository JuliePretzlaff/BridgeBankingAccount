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
        public string Birthday { get; set; }
        public double CheckingAccount { get; set; }
        public double SavingsAccount { get; set; }


        //constructors:
        public Client ()
        {
            //default constructor
        }

        public Client(string name, string birthday, int checkingNumber, int savingsNumber)
        {
            this.ClientName = name;
            this.Birthday = birthday;
            this.CheckingAccount = checkingNumber;
            this.SavingsAccount = savingsNumber;
        }

        //method:
        public void ClientInfo()
        {
            Console.WriteLine("\nClient personal info: ");
            Console.WriteLine("Client name: " + ClientName);
            Console.WriteLine("Client birthday: " + Birthday);
            Console.WriteLine("Checking account number: " + CheckingAccount);
            Console.WriteLine("Savings account number: " + SavingsAccount);
        }

    }
}

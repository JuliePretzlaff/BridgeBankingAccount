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
        public double checkingAccount { get; set; }
        public double savingsAccount { get; set; }


        //constructors:
        public Client ()
        {
            //default constructor
        }

        public Client(string name, string birthday, int checkingNumber, int savingsNumber)
        {
            this.ClientName = name;
            this.Birthday = birthday;
            this.checkingAccount = checkingNumber;
            this.savingsAccount = savingsNumber;
        }

        //method:
        public void ClientInfo()
        {
            Console.WriteLine("\nClient personal info: ");
            Console.WriteLine("Client name: " + ClientName);
            Console.WriteLine("Client birthday: " + Birthday);
        }

    }
}

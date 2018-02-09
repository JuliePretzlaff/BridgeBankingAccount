using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeBankAccount
{
    class Practice
    {
        //fields
        //invisible

        //properties
        //using objects you've already created within lists, dictionaries, arrays, constructors, etc.

            //having a list of objects as a property**** weekend project
        public List<Client> AllClients { get; set;}
        public List<Checking> AllCheckings { get; set; }
        public List<Savings> AllSavings { get; set; }


        //methods
        public List<string> DisplayClientNames()  //method to return client names (only names, not entire client objects)
        {
            List<string> clientNames = new List<string>(); //create new empty list
            foreach (Client client in AllClients) //goes through each client object in list AllClients
            {
                clientNames.Add(client.ClientName); //take Name property and add it to clientNames list.
            }
            return clientNames; //return list of clientNames
            }
        //list AllClients has all client names, addresses, bdays, 
        //will return entire client object, will return list of OBJECTS
           //list clientNames just grabs Name property
        }


    }


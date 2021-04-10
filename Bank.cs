using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Bank
    {
        public List<Account> AccountList { get; set; }
        public Bank()
        {
            AccountList = new List<Account>();
        }

        public void CreateAnAccount(double openingBalance, string owner)
        {
            AccountList.Add(new Account(openingBalance, owner));
        }

        public IAccount FindAccount(string owner)
        {
            Account accountToFind;

            if (AccountList.Any(i => i.Owner == owner))
            {
                accountToFind = AccountList.Find(x => x.Owner == owner);
                return accountToFind as IAccount;
            }
            Console.WriteLine("V bance není účet s tímto vlastníkem.");
            return null;    // Dá se vyřešit lépe? 
            
            
        }
    }
}

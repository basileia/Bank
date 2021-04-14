using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank
{
    class Bank
    {
        public List<Account> AccountList { get; set; }
        public Bank()
        {
            Console.WriteLine("VIRTUÁLNÍ BANKA\n");
            AccountList = new List<Account>();
        }

        public void CreateAnAccount(double openingBalance, string owner)
        {
            AccountList.Add(new Account(openingBalance, owner));
        }

        public IAccount FindAccount(string owner)
        {
            IAccount accountToFind;

            if (AccountList.Any(i => i.Owner == owner))
            {
                accountToFind = AccountList.Find(x => x.Owner == owner);
                return accountToFind;
            }
            Console.WriteLine("V bance není účet s tímto vlastníkem.");
            return null;    // Dá se vyřešit lépe?             
        }

        public void DepositMoney(double deposit, string owner)
        {
            Account account = (Account)FindAccount(owner);
            if(account != null)
            {
                account.Balance += Math.Max(0, deposit); ;
            }
        }

        public void ViewAccountInfo()
        {
            AccountList.ForEach(i => Console.Write($"{i}"));
        }
    }
}

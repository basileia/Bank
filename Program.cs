using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Random rnd = new Random();
            List<string> nameList = new List<string>() { "Pepa Vlastník", "Karel Zahradník", "Pavel Lesník" };
            
            for(int i = 0; i < 3; i++)
            {
                bank.CreateAnAccount(rnd.Next(100, 10000), nameList[i]);
            }

            bank.ViewAccountInfo();
            bank.DepositMoney(rnd.Next(100, 10000), "Pepa Vlastník");
            IAccount account = bank.FindAccount("Karel Zahradník");
            // account.Balance = 500; Je pouze pro čtení, nepůjde
            bank.DepositMoney(account.Balance, account.Owner);
            Console.WriteLine("Stav účtů po vložení peněz:\n");
            bank.ViewAccountInfo();

            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account : IAccount
    {
        public double Balance { get; set; }

        public string Owner { get; private set; }

        public Account(double openingBalance, string owner)
        {
            Balance = openingBalance;
            Owner = owner;
        }

        public override string ToString()
        {
            return $"Vlastník účtu: {Owner}\nZůstatek: {Balance}";
        }
    }
}

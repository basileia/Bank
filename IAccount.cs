using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    interface IAccount
    {
        double Balance { get; }
        string Owner { get; }
    }
}

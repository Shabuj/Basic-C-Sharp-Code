using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class SavingsAccount:BankAccount
    {
        public double InterestAmount { get; set; }

        public override string WithDraw(double amount)
        {
            if(Balance<amount)
            {
                return "Insufficent Account";
            }
           return base.WithDraw(amount);
        }
    }
}

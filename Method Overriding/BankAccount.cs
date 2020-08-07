using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class BankAccount
    {
        public string AccountNo { set; get; }
        public string CustomerName { set; get; }
        public double Balance { private set; get; }

        public string Deposit(double amount)
        {
            Balance += amount;
            return " Deposit Successfully Done";
        }
        public virtual string WithDraw(double amount)
        {
            Balance -= amount;
            return "Withdraw Successfull";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {

            SavingsAccount sv1 = new SavingsAccount();
            sv1.AccountNo = "SV00001";
            sv1.CustomerName = "Shabuj Hossain";
            sv1.InterestAmount = 1000;

            Console.WriteLine(sv1.Deposit(4000));
            Console.WriteLine(sv1.WithDraw(30000));

            CheckingAccount ck1 = new CheckingAccount();
            ck1.AccountNo = "CK0001";
            ck1.CustomerName = "Arif Khan";
            ck1.ServiceCharge = 100;
            Console.WriteLine(ck1.Deposit(40000));
            Console.WriteLine(ck1.WithDraw(5000));
            Console.ReadKey();
        }
    }
}

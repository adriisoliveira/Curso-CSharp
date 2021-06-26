using Herança.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bcc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //Upcasting
            Account acc1 = bcc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //Downcasting
            BusinessAccount bcc1 = (BusinessAccount)acc2;
            bcc1.Loan(100.00);


            //BusinessAccount bcc2 = (BusinessAccount)acc3;

            if (acc3 is BusinessAccount)
            {
                BusinessAccount bcc5 = (BusinessAccount)acc3;
            }
                


        }
    }
}

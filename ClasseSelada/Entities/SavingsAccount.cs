using ClasseSelada.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseSelada.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //Esse métodoi não pode ser selado novamente
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}

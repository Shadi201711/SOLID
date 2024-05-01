using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Account_LSP
{
    public class Account
    {
        public decimal Balance { get; protected set; }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
        }
    }

    public class SavingsAccount : Account
    {

        // Override the base Withdraw method without adding any extra behavior
        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
        }
    }
}

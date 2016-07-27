using System;
using System.Collections;

namespace ParallelInheritance.Src
{
    public class SettlementAccount : Account
    {
        private float owing;

        public Transaction LastTransaction => (Transaction)transactions[transactions.Count - 1];

        public void Borrow(float amount)
        {
            owing += amount;
        }

        public void Settle()
        {
            this.Balance -= owing;
        }
    }
}
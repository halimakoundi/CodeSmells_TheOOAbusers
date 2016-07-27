using System;
using System.Collections;

namespace ParallelInheritance.Src
{
    public class SettlementAccount : Account
    {
        private float _owing;

        public Transaction LastTransaction => (Transaction)Transactions[Transactions.Count - 1];

        public void Borrow(float amount)
        {
            _owing += amount;
        }

        public void Settle()
        {
            this.Balance -= _owing;
        }
    }
}
using System;
using System.Collections;

namespace ParallelInheritance.Src
{
    public class SettlementAccount
    {
        private readonly IList transactions = new ArrayList();

        private float owing;

        public float Balance { get; private set; }

        public Transaction LastTransaction => (Transaction)transactions[transactions.Count - 1];

        public string LastTransactionDate { get; private set; }

        public void Credit(float amount)
        {
            ExecuteTransaction(amount);
        }

        public void Debit(float amount)
        {
            ExecuteTransaction(-amount);
        }

        public void Borrow(float amount)
        {
            owing += amount;
        }

        public void Settle()
        {
            this.Balance -= owing;
        }

        private void ExecuteTransaction(float amount)
        {
            this.Balance += amount;
            RecordTransaction(amount);
            UpdateLastTransactionDate();
        }

        private void RecordTransaction(float amount)
        {
            transactions.Add(new Transaction(true, amount));
        }

        private void UpdateLastTransactionDate()
        {
            var now = DateTime.Now;
            this.LastTransactionDate = now.Date + "/" + now.Month + "/" + now.Year;
        }
    }
}
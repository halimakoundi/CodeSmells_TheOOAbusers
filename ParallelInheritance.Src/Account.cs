using System;
using System.Collections;

namespace ParallelInheritance.Src
{
    public class Account
    {
        protected readonly IList transactions = new ArrayList();
        public float Balance { get; set; }
        public string LastTransactionDate { get; private set; }

        protected void ExecuteTransaction(float amount)
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
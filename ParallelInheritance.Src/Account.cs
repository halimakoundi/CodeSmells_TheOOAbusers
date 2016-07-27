using System;
using System.Collections;

namespace ParallelInheritance.Src
{
    public class Account
    {
        protected readonly IList Transactions = new ArrayList();
        public float Balance { get; set; }
        public string LastTransactionDate { get; private set; }

        protected void ExecuteTransaction(float amount)
        {
            Balance += amount;
            RecordTransaction(amount);
            UpdateLastTransactionDate();
        }

        private void RecordTransaction(float amount)
        {
            Transactions.Add(new Transaction(true, amount));
        }

        private void UpdateLastTransactionDate()
        {
            var now = DateTime.Now;
            this.LastTransactionDate = now.Date + "/" + now.Month + "/" + now.Year;
        }

        public void Debit(float amount)
        {
            ExecuteTransaction(-amount);
        }

        public virtual void Credit(float amount)
        {
            ExecuteTransaction(amount);
        }
    }
}
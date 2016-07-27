namespace ParallelInheritance.Src
{
    public class LoyaltyAccount : Account
    {
        private int loyaltyPoints;

        public Transaction LastTransaction
        {
            get
            {
                return (Transaction)transactions[transactions.Count - 1];
            }
        }

        public void Credit(float amount)
        {
            ExecuteTransaction(amount);
            loyaltyPoints++;
        }
    }
}
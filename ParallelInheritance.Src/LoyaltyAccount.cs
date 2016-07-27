namespace ParallelInheritance.Src
{
    public class LoyaltyAccount : Account
    {
        private int _loyaltyPoints;

        public Transaction LastTransaction
        {
            get
            {
                return (Transaction)Transactions[Transactions.Count - 1];
            }
        }

        public override void Credit(float amount)
        {
            ExecuteTransaction(amount);
            _loyaltyPoints++;
        }
    }
}
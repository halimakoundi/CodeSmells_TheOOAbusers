namespace SwitchStatements
{
    public class InsuranceQuote
    {
        private Motorist motorist;

        public InsuranceQuote(Motorist motorist)
        {
            this.motorist = motorist;
        }

        public Motorist Motorist => motorist;

        public double CalculateInsurancePremium(double insuranceValue)
        {
            return motorist.GetRiskPremium(insuranceValue);
        }
    }
}
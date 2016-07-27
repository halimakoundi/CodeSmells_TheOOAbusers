namespace SwitchStatements
{
    public class InsuranceQuote
    {
        private Motorist motorist;

        public InsuranceQuote(Motorist motorist)
        {
            this.motorist = MotoristFactory.MotoristWithAgeAndPoints(motorist.Age, motorist.PointsOnLicense);
        }

        public Motorist Motorist => motorist;

        public double CalculateInsurancePremium(double insuranceValue)
        {
            return motorist.GetRiskPremium(insuranceValue);
        }
    }
}
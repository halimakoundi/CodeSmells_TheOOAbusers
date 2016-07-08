namespace SwitchStatements
{
    public class InsuranceQuote
    {
        private readonly Motorist motorist;

        public InsuranceQuote(Motorist motorist)
        {
            this.motorist = motorist;
        }

        public Motorist Motorist
        {
            get { return motorist; }
        }

        public double CalculateInsurancePremium(double insuranceValue)
        {
            var riskFactor = motorist.CalculateMotoristRisk();

            switch (riskFactor)
            {
                case RiskFactor.LOW_RISK:
                    return LowRiskMotorist.GetLowRiskPremium(insuranceValue);
                case RiskFactor.MODERATE_RISK:
                    return ModerateRiskMotorist.GetModerateRiskPremium(insuranceValue);
                default:
                    return HighRiskMotorist.GetHighRiskPremium(insuranceValue);
            }
        }
    }
}
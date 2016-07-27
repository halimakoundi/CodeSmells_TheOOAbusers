using System;

namespace SwitchStatements
{
    public class InsuranceQuote
    {
        private readonly Motorist motorist;

        public InsuranceQuote(Motorist motorist)
        {
            this.motorist = motorist;
        }

        public Motorist Motorist => motorist;

        public double CalculateInsurancePremium(double insuranceValue)
        {
            var riskFactor = motorist.CalculateMotoristRisk();

            switch (riskFactor)
            {
                case RiskFactor.LOW_RISK:
                    var riskTypeMotorist = new LowRiskMotorist(DateTime.Now.AddYears(-motorist.Age), motorist.PointsOnLicense);
                    return riskTypeMotorist.GetRiskPremium(insuranceValue);
                case RiskFactor.MODERATE_RISK:
                    return ModerateRiskMotorist.GetRiskPremium(insuranceValue);
                default:
                    return HighRiskMotorist.GetRiskPremium(insuranceValue);
            }
        }
    }
}
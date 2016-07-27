using System;

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
            var riskFactor = motorist.CalculateMotoristRisk();

            switch (riskFactor)
            {
                case RiskFactor.LOW_RISK:
                    motorist = new LowRiskMotorist(DateTime.Now.AddYears(-motorist.Age),
                                                    motorist.PointsOnLicense);
                    return motorist.GetRiskPremium(insuranceValue);
                case RiskFactor.MODERATE_RISK:
                    motorist = new ModerateRiskMotorist(DateTime.Now.AddYears(-motorist.Age),
                                                        motorist.PointsOnLicense);
                    return motorist.GetRiskPremium(insuranceValue);
                default:
                    return HighRiskMotorist.GetRiskPremium(insuranceValue);
            }
        }
    }
}
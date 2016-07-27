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
            motorist = MotoristWithAgeAndPoints(motorist);
            return motorist.GetRiskPremium(insuranceValue);
        }

        private Motorist MotoristWithAgeAndPoints(Motorist motorist1)
        {
            var riskFactor = motorist1.CalculateMotoristRisk();

            switch (riskFactor)
            {
                case RiskFactor.LOW_RISK:
                    motorist = new LowRiskMotorist(DateTime.Now.AddYears(-motorist1.Age),
                        motorist1.PointsOnLicense);
                    break;
                case RiskFactor.MODERATE_RISK:
                    motorist = new ModerateRiskMotorist(DateTime.Now.AddYears(-motorist1.Age),
                        motorist1.PointsOnLicense);
                    break;
                default:
                    motorist = new HighRiskMotorist(DateTime.Now.AddYears(-motorist1.Age),
                        motorist1.PointsOnLicense);
                    break;
            }
            return Motorist;
        }
    }
}
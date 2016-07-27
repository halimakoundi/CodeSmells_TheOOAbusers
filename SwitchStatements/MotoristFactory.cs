using System;

namespace SwitchStatements
{
    public class MotoristFactory
    {
        public static Motorist MotoristWithAgeAndPoints(Motorist motorist)
        {
            var riskFactor = motorist.CalculateMotoristRisk();

            switch (riskFactor)
            {
                case RiskFactor.LOW_RISK:
                    motorist = new LowRiskMotorist(DateTime.Now.AddYears(-motorist.Age),
                        motorist.PointsOnLicense);
                    break;
                case RiskFactor.MODERATE_RISK:
                    motorist = new ModerateRiskMotorist(DateTime.Now.AddYears(-motorist.Age),
                        motorist.PointsOnLicense);
                    break;
                default:
                    motorist = new HighRiskMotorist(DateTime.Now.AddYears(-motorist.Age),
                        motorist.PointsOnLicense);
                    break;
            }
            return motorist;
        }
    }
}
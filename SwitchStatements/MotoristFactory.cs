using System;

namespace SwitchStatements
{
    public class MotoristFactory
    {
        public static Motorist MotoristWithAgeAndPoints(Motorist motorist)
        {
            if (motorist.PointsOnLicense > 3 || motorist.Age < 25)
            {
                motorist = new HighRiskMotorist(DateTime.Now.AddYears(-motorist.Age),
                    motorist.PointsOnLicense);
            }
            else if (motorist.PointsOnLicense > 0)
            {
                motorist = new ModerateRiskMotorist(DateTime.Now.AddYears(-motorist.Age),
                        motorist.PointsOnLicense);
            }
            else
            {
                motorist = new LowRiskMotorist(DateTime.Now.AddYears(-motorist.Age),
                        motorist.PointsOnLicense);
            }

            return motorist;
        }
    }
}
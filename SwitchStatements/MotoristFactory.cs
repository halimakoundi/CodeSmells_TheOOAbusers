using System;

namespace SwitchStatements
{
    public class MotoristFactory
    {
        private const int HighRiskAgeTheshold = 25;

        public static Motorist MotoristWithAgeAndPoints(Motorist motorist, int motoristAge, int
             pointsOnLicense)
        {
            if (HasTooManyPoints(pointsOnLicense) || IsMotoristMature(motoristAge))
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

        private static bool HasTooManyPoints(int motoristPointsOnLicense)
        {
            return motoristPointsOnLicense > 3;
        }

        private static bool IsMotoristMature(int motoristAge)
        {
            return motoristAge < HighRiskAgeTheshold;
        }
    }
}
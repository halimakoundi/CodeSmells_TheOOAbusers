using System;

namespace SwitchStatements
{
    public class MotoristFactory
    {
        private const int HighRiskAgeTheshold = 25;

        public static Motorist MotoristWithAgeAndPoints(int motoristAge, int pointsOnLicense)
        {
            Motorist motorist;
            motorist = new LowRiskMotorist(DateTime.Now.AddYears(-motoristAge),
                pointsOnLicense);
            if (HasTooManyPoints(pointsOnLicense) || IsMotoristMature(motoristAge))
            {
                motorist = new HighRiskMotorist(DateTime.Now.AddYears(-motoristAge),
                    pointsOnLicense);
            }
            else if (pointsOnLicense > 0)
            {
                motorist = new ModerateRiskMotorist(DateTime.Now.AddYears(-motoristAge),
                        pointsOnLicense);
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
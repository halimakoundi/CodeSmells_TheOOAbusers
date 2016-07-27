using System;

namespace SwitchStatements
{
    public class MotoristFactory
    {
        private const int HighRiskAgeTheshold = 25;

        public static Motorist MotoristWithAgeAndPoints(int pointsOnLicense, DateTime dateOfBirth)
        {
            Motorist motorist;
            motorist = new LowRiskMotorist(dateOfBirth,
                pointsOnLicense);
            if (HasTooManyPoints(pointsOnLicense) || IsMotoristMature(motorist.Age))
            {
                motorist = new HighRiskMotorist(dateOfBirth,
                    pointsOnLicense);
            }
            else if (pointsOnLicense > 0)
            {
                motorist = new ModerateRiskMotorist(dateOfBirth,
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
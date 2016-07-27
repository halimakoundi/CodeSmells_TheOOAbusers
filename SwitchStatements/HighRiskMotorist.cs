using System;

namespace SwitchStatements
{
    public class HighRiskMotorist:Motorist
    {
        public static double GetRiskPremium(double insuranceValue)
        {
            return insuranceValue * 0.06;
        }

        public HighRiskMotorist(DateTime dateOfBirth, int pointsOnLicense) : base(dateOfBirth, pointsOnLicense)
        {
        }
    }
}
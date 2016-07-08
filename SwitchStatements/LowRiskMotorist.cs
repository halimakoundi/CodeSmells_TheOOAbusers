using System;

namespace SwitchStatements
{
    public class LowRiskMotorist:Motorist
    {
        public static double GetLowRiskPremium(double insuranceValue)
        {
            return insuranceValue * 0.02;
        }

        public LowRiskMotorist(DateTime dateOfBirth, int pointsOnLicense) : base(dateOfBirth, pointsOnLicense)
        {
        }
    }
}
using System;

namespace SwitchStatements
{
    public class ModerateRiskMotorist:Motorist
    {
        public static double GetModerateRiskPremium(double insuranceValue)
        {
            return insuranceValue * 0.04;
        }

        public ModerateRiskMotorist(DateTime dateOfBirth, int pointsOnLicense) : base(dateOfBirth, pointsOnLicense)
        {
        }
    }
}
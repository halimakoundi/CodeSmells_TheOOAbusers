using System;

namespace SwitchStatements
{
    public class LowRiskMotorist:Motorist
    {
        public override double  GetRiskPremium(double insuranceValue)
        {
            return insuranceValue * 0.02;
        }

        public LowRiskMotorist(DateTime dateOfBirth, int pointsOnLicense) : base(dateOfBirth, pointsOnLicense)
        {
        }
    }
}
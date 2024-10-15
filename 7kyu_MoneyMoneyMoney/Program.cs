using System;
public class Kata
{
    public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
    {
        double sumRes = principal;
        int years = 0;
        if (principal >= desiredPrincipal)
        {
            return 0;
        }
        while (sumRes < desiredPrincipal)
        {
            double yearlyInterest = sumRes * interest;
            double netInterest = yearlyInterest * (1 - tax);
            sumRes += netInterest;
            years++;
        }

        return years;
    }
}

using System;

public class Kata
{
    public static bool IsSquare(int n)
    {
        if (n < 0)
        {
            return false;
        }
        double sqrt = Math.Sqrt(n);
        return sqrt == (int)sqrt;
    }
}
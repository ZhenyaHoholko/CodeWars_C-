using System;

public static class Kata
{
    public static int Factorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(n));
        }
        if (n <= 0 || n == 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}

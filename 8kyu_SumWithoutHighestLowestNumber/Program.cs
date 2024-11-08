using System;
using System.Linq;

public static class Kata
{
    public static int Sum(int[] numbers)
    {
        if (numbers == null || numbers.Length <= 1)
        {
            return 0;
        }
        int sum = numbers.Sum();
        int min = numbers.Min();
        int max = numbers.Max();
        return sum - min - max;
    }
}
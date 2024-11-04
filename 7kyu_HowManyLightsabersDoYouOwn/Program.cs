using System;
using System.Linq;

public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        int[] nums = numbers.Split(' ').Select(int.Parse).ToArray();
        int max = nums.Max();
        int min = nums.Min();
        return $"{max} {min}";
    }
}

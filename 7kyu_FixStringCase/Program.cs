using System;
using System.Linq;

public class Kata
{
    public static string Solve(string s)
    {
        int upperCount = s.Count(char.IsUpper);
        int lowerCount = s.Count(char.IsLower);
        if (upperCount > lowerCount)
        {
            return s.ToUpper();
        }
        else
        {
            return s.ToLower();
        }
    }
}

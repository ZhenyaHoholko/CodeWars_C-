using System;

public class Kata
{
    public static string Problem(string a)
    {
        if (double.TryParse(a, out var result))
        {
            return ((result * 50) + 6).ToString();
        }
        else
        {
            return "Error";
        }
    }
}

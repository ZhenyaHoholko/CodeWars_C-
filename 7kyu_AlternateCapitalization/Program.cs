using System;

public static class Kata
{
    public static string[] Capitalize(string s)
    {
        string evenIndexed = "";
        string oddIndexed = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenIndexed += char.ToUpper(s[i]);
                oddIndexed += s[i];
            }
            else
            {
                evenIndexed += s[i];
                oddIndexed += char.ToUpper(s[i]);
            }
        }

        return new string[] { evenIndexed, oddIndexed };
    }
}
using System;

public class Kata
{
    public static int FindShort(string s)
    {
        string[] words = s.Split(' ');
        int shortestLength = int.MaxValue;
        foreach (string word in words)
        {
            if (word.Length < shortestLength)
            {
                shortestLength = word.Length;
            }
        }
        return shortestLength;
    }
}

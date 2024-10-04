using System;
using System.Collections.Generic;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        str = str.ToLower();
        foreach (char c in str)
        {
            if (char.IsLetterOrDigit(c))
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
        }
        int duplicateCount = 0;
        foreach (var count in charCount.Values)
        {
            if (count > 1)
            {
                duplicateCount++;
            }
        }

        return duplicateCount;
    }
}

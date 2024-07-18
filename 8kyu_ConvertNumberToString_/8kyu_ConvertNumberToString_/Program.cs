using System;
using System.Collections.Generic;
using System.Linq;


/*
We need a function that can transform a number (integer) into a string.

What ways of achieving this do you know?

Examples (input --> output):
123  --> "123"
999  --> "999"
-100 --> "-100"
*/

namespace _8kyu_ConvertNumberToString
{
    public class Kata
    {
        public static string NumberToString(int num)
        {
            return num.ToString();
        }
    }
}
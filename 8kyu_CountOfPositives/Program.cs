using System;
using System.Collections.Generic;
using System.Linq;


/*
Given an array of integers.
Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.
If the input is an empty array or is null, return an empty array.
Example
For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65]
*/

namespace _8kyu_CountOfPositives
{
    public class Kata
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0) return new int[0];
            int sumCount = 0;
            int sumNegative = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 0:
                        continue;
                    case int num when num > 0:
                        sumCount += 1;
                        break;
                    case int num when num < 0:
                        sumNegative += num;
                        break;
                }
            }
            return new int[] { sumCount, sumNegative };
        }
    }
}

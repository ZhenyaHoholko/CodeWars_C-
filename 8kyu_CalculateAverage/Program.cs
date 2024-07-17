using System;
/*
Write a function which calculates the average of the numbers in a given list.
Note: Empty arrays should return 0. 
 */
namespace _8kyu_CalculateAverage
{
    public class AverageSolution
    {
        public static double FindAverage(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return 0;
            }
            else
            {
                double sum = 0;
                foreach (var item in array)
                {
                    sum += item;
                }
                return sum / array.Length;
            }
        }
    }
}
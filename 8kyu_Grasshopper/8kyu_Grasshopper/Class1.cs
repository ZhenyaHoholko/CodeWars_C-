using System;

namespace _8kyu_Grasshopper
{
    public class Program
    {
        public static void Main()
        {
            int[] array = { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
            double result = AverageSolution.FindAverage(array);
            Console.WriteLine(result);
        }
    }
}
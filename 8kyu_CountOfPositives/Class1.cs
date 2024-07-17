using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kyu_CountOfPositives
{
    public class Program
    {
        public static void Main()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] result = Kata.CountPositivesSumNegatives(input);
            Console.WriteLine($"[{result[0]}, {result[1]}]");
        }
    }
}

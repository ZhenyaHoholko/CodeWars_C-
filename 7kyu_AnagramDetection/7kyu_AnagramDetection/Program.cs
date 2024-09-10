using System;
using System.Linq;
namespace MyNamespace
{
    public class Kata
    {
        public static bool IsAnagram(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            var sortedA = new string(a.ToLower().OrderBy(c => c).ToArray());
            var sortedB = new string(b.ToLower().OrderBy(c => c).ToArray());
            return sortedA == sortedB;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

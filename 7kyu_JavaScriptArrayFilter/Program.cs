//Starting with .NET Framework 3.5, C# supports a Where (in the System.Linq namespace) method which allows a user to filter arrays based on a predicate. 
//Use the Where method to complete the function given.
//The solution would work like the following:
//Kata.GetEvenNumbers(new int[] { 2, 4, 5, 6 }) => new int[] { 2, 4, 6 }

using System;
using System.Linq;

public class Kata
{
    public static int[] GetEvenNumbers(int[] numbers)
    {
        return numbers.Where(number => number % 2 == 0).ToArray();
    }
}
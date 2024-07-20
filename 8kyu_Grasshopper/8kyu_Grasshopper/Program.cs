using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*
Complete the function to return his total number of goals in all three leagues.
Note: the input will always be valid.
For example:
5, 10, 2  -->  17 
 */
namespace _8kyu_Grasshopper
{
    public class Kata
    {
        public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals)
        {
            int result = 0;
            result = laLigaGoals + copaDelReyGoals+championsLeagueGoals;
            return result;
        }
    }
}
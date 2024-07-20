using System;

/*
Write function RemoveExclamationMarks which removes all exclamation marks from a given string.
*/

namespace _8kyu_RemoveExclamationMarks
{
    public class Kata
    {
        public static string RemoveExclamationMarks(string s)
        {
            return s.Replace("!", "");
        }
    }
}
using System;

/*
 Complete the solution so that it reverses the string passed into it.
'world'  =>  'dlrow'
'word'   =>  'drow'
*/
public static class Kata
{
    public static string Solution(string str)
    {
        char[] oldStr = str.ToCharArray();
        char[] newStr = new char[oldStr.Length];
        for (int i = 0; i < oldStr.Length; i++)
        {
            newStr[oldStr.Length - 1 - i] = oldStr[i];
        }
        return new string(newStr);
        throw new NotImplementedException("TODO: Kata.Solution(string) => string");
    }
}
using System.Linq;
public class Kata
{
    public static string DuplicateEncode(string word)
    {
        string result = "";
        char[] characters = word.ToLower().ToCharArray();

        foreach (char character in characters)
        {
            if (characters.Count(c => c == character) > 1)
            {
                result += ")";
            }
            else
            {
                result += "(";
            }
        }
        return result;
    }
}
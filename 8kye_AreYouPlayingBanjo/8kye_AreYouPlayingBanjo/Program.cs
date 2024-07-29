using System;

public class Kata
{
    public static string AreYouPlayingBanjo(string name)
    {
        if (name == null)
        {
            return "Invalid input";
        }
        if (name.ToLower()[0] == 'r')
        {
            return name + " plays banjo";
        }
        else
        {
            return name + " does not play banjo";
        }
    }
}

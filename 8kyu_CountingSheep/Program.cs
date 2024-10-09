using System;
using System.Linq;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        if (sheeps == null) return 0;
        return sheeps.Count(sheep => sheep == true);
    }
}
public class Kata
{
    public static bool IsValidWalk(string[] walk)
    {
        int nCount = 0, eCount = 0, wCount = 0, sCount = 0;
        if (walk.Length != 10)
        {
            return false;
        }
        for (int i = 0; i < walk.Length; i++)
        {
            if (walk[i] == "n") { nCount++; }
            if (walk[i] == "s") { sCount++; }
            if (walk[i] == "e") { eCount++; }
            if (walk[i] == "w") { wCount++; }
        }
        return nCount == sCount && eCount == wCount;
    }
}

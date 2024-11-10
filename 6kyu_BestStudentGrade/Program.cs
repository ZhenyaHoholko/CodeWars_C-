//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class DropWorst
//{
//    public static bool CalculateScores(int numberToDrop, string[] examResults)
//    {
//        List<int> numberList = examResults.Select(int.Parse).ToList();
//        numberList.Sort();
//        int middleSizeBefore = MidleSize(numberList);
//        for (int i = 0; i < numberToDrop; i++)
//        {
//            if (numberList.Count <= 2) break;
//            int minScore = numberList.Min();
//            int maxScore = numberList.Max();
//            numberList.RemoveAll(x => x == minScore);
//            numberList.RemoveAll(x => x == maxScore);
//        }
//        int middleSizeAfter = MidleSize(numberList);
//        return middleSizeAfter > middleSizeBefore;
//    }
//    public static int MidleSize(List<int> numberList)
//    {
//        int sum = numberList.Sum();
//        return sum / numberList.Count;
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
public class DropWorst
{
    public static bool CalculateScores(int numberToDrop, string[] examResults)
    {
        List<int> numberList = examResults.Select(int.Parse).ToList();
        double middleSizeBefore = MidleSize(numberList);

        for (int i = 0; i < numberToDrop; i++)
        {
            if (numberList.Count <= 2) break;
            int minScore = numberList.Min();
            int maxScore = numberList.Max();
            numberList.Remove(minScore);
            numberList.Remove(maxScore);
        }
        double middleSizeAfter = MidleSize(numberList);
        return middleSizeAfter > middleSizeBefore;
    }
    public static double MidleSize(List<int> numberList)
    {
        double sum = numberList.Sum();
        return sum / numberList.Count;
    }
}

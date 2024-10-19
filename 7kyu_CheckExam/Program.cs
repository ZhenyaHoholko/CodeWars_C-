using System;

public static class Kata
{
    public static int CheckExam(string[] arr1, string[] arr2)
    {
        int score = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr2[i] == "")
            {
                continue;
            }
            else if (arr1[i] == arr2[i])
            {
                score += 4;
            }
            else // Неправильный ответ
            {
                score -= 1;
            }
        }
        return score < 0 ? 0 : score;
    }
}

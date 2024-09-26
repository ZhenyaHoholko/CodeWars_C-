using System;

public static class Kata
{
    public static int[] CountBy(int x, int n)
    {
        int[] z = new int[n];
        int counter = 0;
        for (int i = 1;; i++)
        {
            if(i%x== 0)
            {
                z[counter] = i;
                counter++;
            }
            if (counter>= n)
            {
                break;
            }
        }
        return z;
    }
}
using System;

public static class Kata
{
    public static int OtherAngle(int a, int b)
    {
        if((a+b)>0 && (a + b) < 180)
        {
            return 180-(a + b);
        }
        else { throw new NotImplementedException(); }
        
    }
}
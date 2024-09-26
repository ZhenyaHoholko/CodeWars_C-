using System;
namespace Solution
{
    class Kata
    {
        public  static int Calculate(int n,int numb)
        {
            return n * (int)Math.Pow(2, numb);
        }
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            int lengthArr = BinaryArray.Length;
            int finalNumber = 0;
            for (int i = 0; i < lengthArr; i++)
            {
                finalNumber += Calculate(BinaryArray[lengthArr - i - 1], i);
            }
            return finalNumber;
        }
    }
}
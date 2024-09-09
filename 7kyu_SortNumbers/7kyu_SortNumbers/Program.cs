/*
Finish the solution so that it sorts the passed in array of numbers. 
If the function passes in an empty array or null/nil value then it should return an empty array.
For example:

SortNumbers(new int[] { 1, 2, 10, 50, 5 }); // should return new int[] { 1, 2, 5, 10, 50 }
SortNumbers(null); // should return new int[] { }
*/

public class Kata
{
  public static int[] SortNumbers(int[] nums)
  {
        if (nums == null || nums.Length == 0)
        {
            return new int[] {};
        }
        for (int i = 0; i < nums.Length - 1; i++)
        {

        for (int j = 0; j < nums.Length - 1; j++)
        {
            if(nums[j] > nums[j + 1])
            {
                int a = nums[j];
                nums[j] = nums[j + 1];
                nums[j + 1] = a;
            }
        }
  }
        return nums;
  }
}
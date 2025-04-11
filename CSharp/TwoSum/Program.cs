using System;

class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        throw new ArgumentException("No two sum solution");
    }

    static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = Solution.TwoSum(nums, target);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}
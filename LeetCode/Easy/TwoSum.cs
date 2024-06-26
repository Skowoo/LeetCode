﻿namespace LeetCode.Easy
{
    internal class TwoSum
    {
        public static int[] TwoSumFunc(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target && i != j)
                        return new int[] { i, j };

            return new int[] { 0, 0 };
        }
    }
}

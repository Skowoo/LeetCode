using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class MoveZeroes
    {
        public void MoveZeroesFunc(int[] nums) // Wrong solution - pointer issue.
        {
            var usableLength = nums.Length;
            var numsList = new List<int>(nums);
            for (int i = 0; i < usableLength; i++)
                if (nums[i] == 0)
                {
                    numsList.RemoveAt(i);
                    numsList.Add(0);
                    usableLength--;
                }

            nums = [.. numsList];
        }
    }
}

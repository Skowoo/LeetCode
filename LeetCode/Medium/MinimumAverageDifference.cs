namespace LeetCode.Medium
{
    internal class MinimumAverageDifference
    {

        public static int MinimumAverageDifference_Func(int[] nums)
        {
            int targetIndex = 0;
            long minResult = long.MaxValue,
                 leftSum = 0,
                 rightSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
                rightSum += nums[i];

            for (int i = 0; i < nums.Length; i++)
            {
                leftSum += nums[i];
                rightSum -= nums[i];

                long leftAverage = leftSum / (i + 1);
                long rightAverage = (nums.Length - i - 1) == 0 ? 0 : rightSum / (nums.Length - i - 1);
                long currentResult = Math.Abs(leftAverage - rightAverage);
                if (currentResult < minResult)
                {
                    targetIndex = i;
                    minResult = currentResult;
                }
            }

            return targetIndex;
        }

        public static int MinimumAverageDifference_TLE(int[] nums)
        {
            int result = int.MaxValue,
                targetIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int leftSide = (int)Math.Floor(nums.Take(i + 1).Average());
                var rightQuery = nums.Skip(i + 1);
                int rightSide = rightQuery.Any() ? (int)Math.Floor(rightQuery.Average()) : 0;
                if (Math.Abs(leftSide - rightSide) < result)
                {
                    result = Math.Abs(leftSide - rightSide);
                    targetIndex = i;
                }
            }

            return targetIndex;
        }
    }
}

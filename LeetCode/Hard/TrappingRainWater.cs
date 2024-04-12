namespace LeetCode.Hard
{
    internal class TrappingRainWater
    {
        public static int Trap(int[] height)
        {
            int borderSize = 0,
                leftBorderIndex = 0,
                totalQuantity = 0,
                currentQuantity = 0;

            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] < borderSize)
                {
                    currentQuantity += borderSize - height[i];
                }
                else if (height[i] >= borderSize)
                {
                    totalQuantity += currentQuantity;
                    currentQuantity = 0;
                    borderSize = height[i];
                    leftBorderIndex = i;
                }
            }

            currentQuantity = 0;
            borderSize = 0;

            for (int i = height.Length - 1; i >= leftBorderIndex; i--)
            {
                if (height[i] < borderSize)
                {
                    currentQuantity += borderSize - height[i];
                }
                else if (height[i] >= borderSize)
                {
                    totalQuantity += currentQuantity;
                    currentQuantity = 0;
                    borderSize = height[i];
                }
            }

            return totalQuantity;
        }
    }
}

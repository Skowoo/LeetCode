namespace LeetCode.Medium
{
    internal class MagneticForceBetweenTwoBalls
    {
        public static int MaxDistance(int[] position, int m)
        {
            Array.Sort(position);

            int result = 0,
                low = 1,
                high = position[^1] - position[0];

            while (low <= high)
            {
                int middle = low + (high - low) / 2;
                if (Check(middle))
                {
                    result = middle;
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }

            return result;

            bool Check(int candidate)
            {
                int count = 1;
                int prevPos = position[0];

                for (int i = 1; i < position.Length; i++)
                    if (position[i] - prevPos >= candidate)
                    {
                        prevPos = position[i];
                        count++;

                        if (count == m)
                            return true;
                    }

                return false;
            }
        }
    }
}

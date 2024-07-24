using System.Text;

namespace LeetCode.Medium
{
    internal class SortTheJumbledNumbers
    {
        public static int[] SortJumbled(int[] mapping, int[] nums)
        {
            int[] comparer = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                string str = nums[i].ToString();

                StringBuilder sb = new();
                for (int j = 0; j < str.Length; j++)
                    sb.Append(mapping[str[j] - '0']);

                comparer[i] = int.Parse(sb.ToString());
            }

            Array.Sort(comparer, nums);

            return nums;
        }
    }
}

// Console.WriteLine(SortJumbled([8, 9, 4, 0, 2, 1, 3, 5, 7, 6], [991, 338, 38]));
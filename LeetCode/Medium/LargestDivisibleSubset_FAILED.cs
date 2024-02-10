//namespace LeetCode
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            var test = LargestDivisibleSubset(new int[] { 5325, 2541254, 345, 34345, 53452355, 65756747, 765343242, 5236437, 2353145, 2345412, 634441, 3435734, 1, 2, 3, 4, 5, 6, 7, 89, 4321, 23 });

//            foreach (int i in test)
//                Console.Write($"{i}, ");

//            Console.ReadLine();
//        }

//        public static IList<int> LargestDivisibleSubset(int[] nums)
//        {
//            if (nums.Length == 1)
//                return nums;

//            bool[] taken = new bool[nums.Length];
//            List<int> result = new();

//            for (int i = 0; i < nums.Length; i++)
//            {
//                if (taken[i])
//                    continue;

//                for (int j = 0; j < nums.Length; j++)
//                {
//                    if (taken[j] || taken[i] || i == j)
//                        continue;

//                    if (nums[i] % nums[j] == 0 || nums[j] % nums[i] == 0)
//                    {
//                        result.Add(nums[i]);
//                        result.Add(nums[j]);
//                        taken[i] = true;
//                        taken[j] = true;
//                        break;
//                    }
//                }
//            }

//            return result.ToArray();
//        }
//    }
//}

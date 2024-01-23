using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class ContainsDuplicate
    {
        public static bool ContainsDuplicateFunc(int[] nums) => nums.Length != nums.Distinct().Count();
    }
}

using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class PathSum
    {
        public static bool HasPathSum(TreeNode root, int targetSum)
        {
            return Recurse(root, 0);

            bool Recurse(TreeNode root, int currSum)
            {
                if (root is null)
                    return false;

                currSum += root.val;

                if (root.left is null && root.right is null)
                    return currSum == targetSum;

                if (Recurse(root.left!, currSum))
                    return true;

                if (Recurse(root.right, currSum))
                    return true;

                return false;
            }
        }
    }
}

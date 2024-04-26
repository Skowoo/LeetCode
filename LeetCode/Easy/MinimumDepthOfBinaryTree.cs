using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class MinimumDepthOfBinaryTree
    {
        public static int MinDepth(TreeNode root)
        {
            if (root is null)
                return 0;

            int leftResult = MinDepth(root.left),
                rightResult = MinDepth(root.right);

            if (leftResult == 0 || rightResult == 0)
                return Math.Max(leftResult, rightResult);
            else
                return Math.Min(leftResult, rightResult);
        }
    }
}

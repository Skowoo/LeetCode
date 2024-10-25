using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root is null)
                return 0;

            int left = MaxDepth(root.left),
                right = MaxDepth(root.right);

            return Math.Max(left, right) + 1;
        }
    }
}

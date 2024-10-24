using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class FlipEquivalentBinaryTrees
    {
        public static bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            if (root1 is null || root2 is null)
                return root1 is null && root2 is null;

            if (root1.val != root2.val)
                return false;

            return (FlipEquiv(root1.right, root2.left) && FlipEquiv(root1.left, root2.right))
                || (FlipEquiv(root1.right, root2.right) && FlipEquiv(root1.left, root2.left));
        }
    }
}

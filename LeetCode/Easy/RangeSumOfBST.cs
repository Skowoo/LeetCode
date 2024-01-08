#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.

namespace LeetCode.Easy
{
    internal class RangeSumOfBST
    {
        public static int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root is null)
                return 0;

            int currentVal = (root.val >= low && root.val <= high) ? root.val : 0;

            int leftSum = RangeSumBST(root.left, low, high);
            int rightSum = RangeSumBST(root.right, low, high);

            return currentVal + leftSum + rightSum;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}

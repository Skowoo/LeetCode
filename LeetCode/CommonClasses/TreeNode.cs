#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.


namespace LeetCode.CommonClasses
{
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

// new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(5, null, new TreeNode(6)))
// new TreeNode(1, new TreeNode(12, new TreeNode(24), new TreeNode(25)), new TreeNode(13, new TreeNode(26), new TreeNode(27)))
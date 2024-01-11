#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8603 // Possible null reference return.

namespace LeetCode.Medium
{
    internal class DeleteLeafesWithaGivenValue
    {
        public static TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            void Recurse(TreeNode node)
            {
                if (node.left is not null)
                    if (node.left.left is null && node.left.right is null && node.left.val == target)
                    {
                        node.left = null;
                        Recurse(root);
                    }
                    else Recurse(node.left);

                if (node.right is not null)
                    if (node.right.left is null && node.right.right is null && node.right.val == target)
                    {
                        node.right = null;
                        Recurse(root);
                    }
                    else Recurse(node.right);
            }

            Recurse(root);

            if (root.left is null && root.right is null && root.val == target)
                return null;
            else
                return root;
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

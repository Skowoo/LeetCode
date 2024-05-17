#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8603 // Possible null reference return.

using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class DeleteLeavesWithAGivenValue
    {
        public static TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            Recurse(root);
            void Recurse(TreeNode node)
            {
                if (node.left is not null && (node.left.left is not null || node.left.right is not null))
                    Recurse(node.left);

                if (node.left is not null)
                    if (node.left.left is null && node.left.right is null && node.left.val == target)
                        node.left = null;

                if (node.right is not null && (node.right.left is not null || node.right.right is not null))
                    Recurse(node.right);

                if (node.right is not null)
                    if (node.right.left is null && node.right.right is null && node.right.val == target)
                        node.right = null;
            }
            if (root.left is null && root.right is null && root.val == target)
                return null;
            else
                return root;
        }
    }
}

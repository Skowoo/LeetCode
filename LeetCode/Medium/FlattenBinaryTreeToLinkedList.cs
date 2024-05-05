#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.

using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class FlattenBinaryTreeToLinkedList
    {
        public static void Flatten(TreeNode root)
        {
            if (root is null || (root.left is null && root.right is null))
                return;

            List<int> values = new();
            void Recurse(TreeNode node)
            {
                values.Add(node.val);

                if (node.left is not null)
                    Recurse(node.left);
                if (node.right is not null)
                    Recurse(node.right);
            }
            Recurse(root);

            TreeNode tempNode = root;
            tempNode.left = null;
            for (int i = 1; i < values.Count; i++)
            {
                TreeNode newNode = new(values[i]);
                tempNode.right = newNode;
                tempNode = newNode;
            }
        }
    }
}

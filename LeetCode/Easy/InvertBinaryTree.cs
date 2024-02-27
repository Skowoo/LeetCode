using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class InvertBinaryTree
    {
        public static TreeNode? InvertTree(TreeNode root)
        {
            if (root is null)
                return null;

            Reverse(root);

            static void Reverse(TreeNode node)
            {
                // Tuple reverse
                (node.right, node.left) = (node.left, node.right);

                if (node.left is not null)
                    Reverse(node.left);

                if (node.right is not null)
                    Reverse(node.right);
            }

            return root;
        }
    }
}

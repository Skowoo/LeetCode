using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class BinaryTreeInorderTraversal
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            List<int> ints = new();

            if (root is not null)
                Recure(root);

            void Recure(TreeNode node)
            {
                if (node.left is not null)
                    Recure(node.left);

                ints.Add(node.val);

                if (node.right is not null)
                    Recure(node.right);
            }

            return ints.ToArray();
        }
    }
}

using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class BinaryTreePreorderTraversal
    {
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> result = new();

            if (root is not null)
                Preorder(root);

            void Preorder(TreeNode root)
            {
                result.Add(root.val);

                if (root.left is not null)
                    Preorder(root.left);
                if (root.right is not null)
                    Preorder(root.right);
            }

            return result;
        }
    }
}

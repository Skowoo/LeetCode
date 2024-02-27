using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class BinaryTreePostorderTraversal
    {
        public static IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> result = new();

            if (root is not null)
                PostOrder(root);

            void PostOrder(TreeNode root)
            {
                if (root.left is not null)
                    PostOrder(root.left);
                if (root.right is not null)
                    PostOrder(root.right);

                result.Add(root.val);
            }

            return result;
        }
    }
}

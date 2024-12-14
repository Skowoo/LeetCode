using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal static class CountCompleteTreeNodes
    {
        public static int CountNodes(TreeNode root)
        {
            int result = 0;

            IsNode(root);

            void IsNode(TreeNode node)
            {
                if (node is null)
                    return;

                if (node.left is not null)
                    IsNode(node.left);

                if (node.right is not null)
                    IsNode(node.right);

                result++;
            }

            return result;
        }
    }
}

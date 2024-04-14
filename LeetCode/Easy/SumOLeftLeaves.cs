using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class SumOLeftLeaves
    {
        public static int SumOfLeftLeaves(TreeNode root)
        {
            if (root is null)
                return 0;

            int result = 0;

            Recurse(root);
            void Recurse(TreeNode node)
            {
                if (node.left is not null)
                    Recurse(node.left);

                if (node.right is not null)
                    Recurse(node.right);

                if (node.left is not null && node.left.right is null && node.left.left is null)
                    result += node.left.val;
            }

            return result;
        }
    }
}

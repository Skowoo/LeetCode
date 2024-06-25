using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    // Valid also for LeetCode 538. Convert BST to Greater Tree.
    internal class BinarySearchTreeToGreaterSumTree
    {
        public static TreeNode BstToGst(TreeNode root)
        {
            int totalSum = 0;

            Recurse(root);

            return root;

            void Recurse(TreeNode node)
            {
                if (node is null)
                    return;

                Recurse(node.right);

                totalSum += node.val;
                node.val = totalSum;

                Recurse(node.left);
            }
        }
    }
}

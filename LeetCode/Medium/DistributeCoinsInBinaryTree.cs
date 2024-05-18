using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class DistributeCoinsInBinaryTree
    {
        public static int DistributeCoins(TreeNode root)
        {
            int result = 0;
            int Recurse(TreeNode node)
            {
                if (node is null)
                    return 0;

                int currentDifference = node.val - 1 + Recurse(node.left) + Recurse(node.right);
                result += Math.Abs(currentDifference);
                return currentDifference;
            }
            Recurse(root);
            return result;
        }
    }
}

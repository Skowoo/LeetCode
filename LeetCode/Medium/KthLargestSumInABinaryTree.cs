using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class KthLargestSumInABinaryTree
    {
        public static long KthLargestLevelSum(TreeNode root, int k)
        {
            long currSum;
            List<long> results = [];
            List<TreeNode> currentLevel = [root];
            List<TreeNode> nextLevel = [];

            while (currentLevel.Count > 0)
            {
                currSum = 0;
                foreach (TreeNode node in currentLevel)
                {
                    currSum += node.val;
                    if (node.left is not null)
                        nextLevel.Add(node.left);
                    if (node.right is not null)
                        nextLevel.Add(node.right);
                }
                results.Add(currSum);
                currentLevel = nextLevel;
                nextLevel = [];
            }

            if (results.Count < k)
                return -1;

            return results.OrderByDescending(x => x).ElementAt(k - 1);
        }
    }
}

// Console.WriteLine(KthLargestLevelSum(new TreeNode(1, new TreeNode(1), new TreeNode(1)), 3));

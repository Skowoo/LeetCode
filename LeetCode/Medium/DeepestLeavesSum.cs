using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal static class DeepestLeavesSum
    {
        public static int DeepestLeavesSumFunc(TreeNode root)
        {
            List<TreeNode> currentLevel = [root],
                nextLevel;

            int currentLevelSum;

            do
            {
                nextLevel = [];
                currentLevelSum = 0;

                foreach (var node in currentLevel)
                {
                    if (node.right is not null)
                        nextLevel.Add(node.right);

                    if (node.left is not null)
                        nextLevel.Add(node.left);

                    currentLevelSum += node.val;
                }

                currentLevel = nextLevel;
            }
            while (nextLevel.Count > 0);

            return currentLevelSum;
        }
    }
}

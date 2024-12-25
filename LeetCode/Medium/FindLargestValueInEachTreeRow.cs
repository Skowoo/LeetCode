using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal static class FindLargestValueInEachTreeRow
    {
        public static IList<int> LargestValues(TreeNode root)
        {
            if (root is null)
                return [];

            List<int> result = [];
            List<TreeNode> currentLevel = [root],
                nextLevel = [];

            while (currentLevel.Count > 0)
            {
                int currentMax = int.MinValue;

                foreach (TreeNode node in currentLevel)
                {
                    if (node.left is not null)
                        nextLevel.Add(node.left);

                    if (node.right is not null)
                        nextLevel.Add(node.right);

                    currentMax = Math.Max(currentMax, node.val);
                }

                result.Add(currentMax);
                currentLevel = nextLevel;
                nextLevel = [];
            }

            return result;
        }
    }
}

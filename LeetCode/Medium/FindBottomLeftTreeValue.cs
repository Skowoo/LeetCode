using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class FindBottomLeftTreeValue
    {
        public static int FindBottomLeftValue(TreeNode root)
        {
            List<TreeNode> nodeLevels = new() { root };

            while (true)
            {
                List<TreeNode> nextLevel = new();

                foreach (TreeNode node in nodeLevels)
                {
                    if (node.left is not null)
                        nextLevel.Add(node.left);

                    if (node.right is not null)
                        nextLevel.Add(node.right);
                }

                if (nextLevel.Count == 0)
                    break;

                nodeLevels = nextLevel;
            }

            return nodeLevels.First().val;
        }
    }
}

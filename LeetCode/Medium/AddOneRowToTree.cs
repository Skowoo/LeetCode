#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.

using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class AddOneRowToTree
    {
        public static TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            if (depth == 1)
                return new(val, root);

            int level = 1;
            List<TreeNode> currentLevel = new() { root };
            List<TreeNode> newLevel = new();
            do
            {
                newLevel.Clear();

                level++;

                if (level == depth)
                {
                    foreach (TreeNode node in currentLevel)
                    {
                        node.left = new TreeNode(val, node.left);
                        node.right = new TreeNode(val, null, node.right);
                    }
                    break;
                }
                else
                {
                    foreach (TreeNode node in currentLevel)
                    {
                        if (node.left is not null)
                            newLevel.Add(node.left);

                        if (node.right is not null)
                            newLevel.Add(node.right);
                    }
                }

                currentLevel.Clear();
                currentLevel.AddRange(newLevel);
            }
            while (newLevel.Count > 0);

            return root;
        }
    }
}

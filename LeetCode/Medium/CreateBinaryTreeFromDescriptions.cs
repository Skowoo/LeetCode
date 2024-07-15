#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class CreateBinaryTreeFromDescriptions
    {
        public static TreeNode CreateBinaryTree(int[][] descriptions)
        {
            Dictionary<int, TreeNode> tree = [];
            HashSet<int> childs = [];
            foreach (var node in descriptions)
            {
                int parentValue = node[0];
                if (!tree.ContainsKey(parentValue))
                    tree[parentValue] = new TreeNode(parentValue);

                int childValue = node[1];
                childs.Add(childValue);

                if (!tree.ContainsKey(childValue))
                    tree[childValue] = new TreeNode(childValue);

                if (node[2] == 1)
                    tree[parentValue].left = tree[childValue];

                else
                    tree[parentValue].right = tree[childValue];
            }

            TreeNode result = null;

            foreach (var node in tree)
                if (!childs.Contains(node.Key))
                    result = node.Value;

            return result!;
        }
    }
}

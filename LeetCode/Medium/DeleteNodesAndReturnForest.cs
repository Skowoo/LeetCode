using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class DeleteNodesAndReturnForest
    {
        public static IList<TreeNode> DelNodes(TreeNode? root, int[] to_delete)
        {
            HashSet<int> targetsSet = [.. to_delete];
            List<TreeNode> result = [];

            Recurse(root, true);

            return result;

            TreeNode? Recurse(TreeNode? node, bool haveParent)
            {
                if (node is null)
                    return null;

                var deleted = targetsSet.Contains(node.val);

                if (haveParent && !deleted)
                    result.Add(node);

                node.left = Recurse(node.left, deleted)!;
                node.right = Recurse(node.right, deleted)!;

                return deleted ? null : node;
            }
        }
    }
}

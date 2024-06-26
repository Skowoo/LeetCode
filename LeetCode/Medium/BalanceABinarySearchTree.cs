using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class BalanceABinarySearchTree
    {
        public static TreeNode BalanceBST(TreeNode root)
        {
            List<TreeNode> nodeList = [];

            void AddToList(TreeNode node)
            {
                if (node == null)
                    return;

                AddToList(node.left);
                nodeList.Add(node);
                AddToList(node.right);
            }
            AddToList(root);

            TreeNode? CreateTree(int start, int end)
            {
                if (start > end)
                    return null;

                int pivot = start + (end - start) / 2;
                TreeNode node = nodeList[pivot];
                node.left = CreateTree(start, pivot - 1)!;
                node.right = CreateTree(pivot + 1, end)!;
                return node;
            }
            var result = CreateTree(0, nodeList.Count - 1);
            return result!;
        }
    }
}

using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class SmallestStringStartingFromLeaf
    {
        public static string SmallestFromLeaf(TreeNode root)
        {
            Queue<TreeNode> nodeQueue = new();
            Dictionary<TreeNode, string> nodesWords = new();

            string? result = null;

            nodeQueue.Enqueue(root);
            nodesWords.Add(root, new string(new char[] { (char)(97 + root.val) }));

            while (nodeQueue.Count > 0)
            {
                TreeNode currentNode = nodeQueue.Dequeue();
                string previousWord = nodesWords[currentNode];

                if (currentNode.left is null && currentNode.right is null)
                {
                    if (result is null || previousWord.CompareTo(result) < 0)
                        result = previousWord;
                }

                if (currentNode.left is not null)
                {
                    nodeQueue.Enqueue(currentNode.left);
                    nodesWords.Add(currentNode.left, ((char)(97 + currentNode.left.val) + previousWord));
                }

                if (currentNode.right is not null)
                {
                    nodeQueue.Enqueue(currentNode.right);
                    nodesWords.Add(currentNode.right, ((char)(97 + currentNode.right.val) + previousWord));
                }
            }

            return result!;
        }
    }
}

using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class SumRootToLeafNumbers
    {
        public static int SumNumbers(TreeNode root)
        {
            int result = 0;
            Queue<TreeNode> nodesQueue = new();
            Queue<int> sumQueue = new();

            nodesQueue.Enqueue(root);
            sumQueue.Enqueue(root.val);

            while (sumQueue.Count > 0)
            {
                TreeNode currNode = nodesQueue.Dequeue();
                int currSum = sumQueue.Dequeue();

                if (currNode.right is null && currNode.left is null)
                    result += currSum;

                if (currNode.left is not null)
                {
                    nodesQueue.Enqueue(currNode.left);
                    sumQueue.Enqueue(currSum * 10 + currNode.left.val);
                }

                if (currNode.right is not null)
                {
                    nodesQueue.Enqueue(currNode.right);
                    sumQueue.Enqueue(currSum * 10 + currNode.right.val);
                }
            }

            return result;
        }
    }
}


//Console.WriteLine("25:");
//Console.WriteLine(SumNumbers(new TreeNode(1, new TreeNode(2), new TreeNode(3))));
//Console.WriteLine("\n1026:");
//Console.WriteLine(SumNumbers(new TreeNode(4, new TreeNode(9, new TreeNode(5), new TreeNode(1)), new TreeNode(0))));
//Console.WriteLine("\n262:");
//Console.WriteLine(SumNumbers(new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3))));
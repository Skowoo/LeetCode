using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class NumberOfGoodLeafNodesPairs
    {
        public static int CountPairs(TreeNode root, int distance)
        {
            int result = 0;
            Recurse(root, distance);
            return result;

            List<int> Recurse(TreeNode node, int distance)
            {
                if (node is null)
                    return [];

                if (node.left is null && node.right is null)
                    return [1];

                var leftLengths = Recurse(node.left!, distance);
                var rightLengths = Recurse(node.right!, distance);

                foreach (int i in leftLengths)
                    foreach (int j in rightLengths)
                        if (i + j <= distance)
                            result++;

                leftLengths.AddRange(rightLengths);
                return leftLengths.Select(i => i += 1).ToList();
            }
        }
    }
}

using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class EvenOddTree
    {

        public static bool IsEvenOddTree(TreeNode root)
        {
            List<TreeNode> level = new() { root };

            if (root.val % 2 == 0)
                return false;

            bool even = false;

            while (true)
            {
                List<TreeNode> nextLevel = new();

                foreach (TreeNode node in level)
                {
                    if (node.left is not null)
                        nextLevel.Add(node.left);

                    if (node.right is not null)
                        nextLevel.Add(node.right);
                }

                if (nextLevel.Count == 0)
                    break;

                even = !even;
                int previousNodeValue = nextLevel[0].val;

                for (int i = 0; i < nextLevel.Count; i++)
                    if (even)
                    {
                        if (nextLevel[i].val % 2 != 0)
                            return false;

                        if (i != 0 && nextLevel[i].val >= previousNodeValue)
                            return false;

                        previousNodeValue = nextLevel[i].val;
                    }
                    else
                    {
                        if (nextLevel[i].val % 2 == 0)
                            return false;

                        if (i != 0 && nextLevel[i].val <= previousNodeValue)
                            return false;

                        previousNodeValue = nextLevel[i].val;
                    }

                level = nextLevel;
            }

            return true;
        }
    }
}

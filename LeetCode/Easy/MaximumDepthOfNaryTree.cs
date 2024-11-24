using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal static class MaximumDepthOfNaryTree
    {
        public static int MaxDepth(Node root)
        {
            return GetDepth(root, 0);

            static int GetDepth(Node root, int value)
            {
                if (root is null)
                    return value;

                value = value + 1;

                int maxDepth = value;

                if (root.children is not null)
                    foreach (var c in root.children)
                        if (GetDepth(c, value) > maxDepth)
                            maxDepth = GetDepth(c, value);

                return maxDepth;
            }
        }
    }
}

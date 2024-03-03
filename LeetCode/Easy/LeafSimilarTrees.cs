#pragma warning disable CS8604 // Possible null reference argument.

using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class LeafSimilarTrees
    {
        public static bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            static void FindAndSaveLeafs(TreeNode root, IList<int> leafesSet)
            {
                if (root is null)
                    return;

                if (root.left == null && root.right == null)
                    leafesSet.Add(root.val);

                FindAndSaveLeafs(root.left, leafesSet);
                FindAndSaveLeafs(root.right, leafesSet);
            }

            List<int> firstLeafesSet = new();
            List<int> secondLeafesSet = new();
            FindAndSaveLeafs(root1, firstLeafesSet);
            FindAndSaveLeafs(root2, secondLeafesSet);

            return Enumerable.SequenceEqual(firstLeafesSet, secondLeafesSet);
        }
    }
}

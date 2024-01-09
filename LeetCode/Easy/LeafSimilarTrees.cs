#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8604 // Possible null reference argument.

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

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}

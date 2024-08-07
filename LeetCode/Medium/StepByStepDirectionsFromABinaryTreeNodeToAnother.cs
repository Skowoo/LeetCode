using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class StepByStepDirectionsFromABinaryTreeNodeToAnother
    {

        public static string GetDirections(TreeNode root, int startValue, int destValue)
        {
            string start = string.Empty,
                   dest = string.Empty;
            List<char> path = [];
            Recurse(root);

            int prefix = 0;
            while (start.Length > prefix && dest.Length > prefix && start[prefix] == dest[prefix])
                prefix++;

            return new string('U', start.Length - prefix) + dest[prefix..];

            void Recurse(TreeNode currNode)
            {
                if (!string.IsNullOrEmpty(start) && !string.IsNullOrEmpty(dest))
                    return;

                if (currNode.val == startValue)
                    start = new string(path.ToArray());

                if (currNode.val == destValue)
                    dest = new string(path.ToArray());

                if (currNode.left is not null)
                {
                    path.Add('L');
                    Recurse(currNode.left);
                    path.RemoveAt(path.Count - 1);
                }

                if (currNode.right is not null)
                {
                    path.Add('R');
                    Recurse(currNode.right);
                    path.RemoveAt(path.Count - 1);
                }
            }
        }
    }
}

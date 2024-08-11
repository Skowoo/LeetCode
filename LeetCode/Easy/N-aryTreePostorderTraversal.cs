#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace LeetCode.Easy
{
    internal class N_aryTreePostorderTraversal
    {
        // Definition for a Node.
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }

        public IList<int> Postorder(Node root)
        {
            List<int> result = [];
            Recurse(root);
            return result;

            void Recurse(Node node)
            {
                if (node is null)
                    return;

                if (node.children.Count != 0)
                    foreach (var child in node.children)
                        Recurse(child);

                result.Add(node.val);
            }
        }
    }
}

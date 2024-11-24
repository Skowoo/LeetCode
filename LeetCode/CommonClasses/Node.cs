namespace LeetCode.CommonClasses
{
    /// <summary>
    /// LeetCode base class which represents N-ary tree in some problems.
    /// </summary>
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
}

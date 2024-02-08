namespace LeetCode.Medium
{
    public class MinStack
    {
        public List<Tuple<int, int>> _values = new();

        public MinStack() { }

        public void Push(int val) => _values.Add(Tuple.Create(val, _values.Count + 1));

        public void Pop() => _values.RemoveAt(_values.Count - 1);

        public int Top() => _values[^1].Item1;

        public int GetMin() => _values.Min(x => x.Item1);
    }
}

namespace LeetCode.Medium
{
    public class MinStack //Faster version using Tuple stack
    {
        Stack<(int value, int currentMinValue)> _stack = new();

        int _minValue = int.MaxValue;

        public MinStack() { }

        public void Push(int val)
        {
            if (val < _minValue)
                _minValue = val;

            _stack.Push((val, _minValue));
        }

        public void Pop()
        {
            _stack.Pop();
            if (_stack.Count == 0)
                _minValue = int.MaxValue;
            else
                _minValue = _stack.Peek().currentMinValue; ;
        }

        public int Top() => _stack.Peek().value;

        public int GetMin() => _stack.Peek().currentMinValue;
    }

    public class SlowMinStack // Original slow version using LINQ
    {
        public List<Tuple<int, int>> _values = new();

        public SlowMinStack() { }

        public void Push(int val) => _values.Add(Tuple.Create(val, _values.Count + 1));

        public void Pop() => _values.RemoveAt(_values.Count - 1);

        public int Top() => _values[^1].Item1;

        public int GetMin() => _values.Min(x => x.Item1);
    }
}

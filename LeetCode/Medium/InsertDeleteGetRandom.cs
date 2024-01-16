namespace LeetCode.Medium
{
    internal class InsertDeleteGetRandom
    {
        public class RandomizedSet
        {
            List<int> _values;

            public RandomizedSet()
            {
                _values = new List<int>();
            }

            public bool Insert(int val)
            {
                if (_values.Contains(val))
                    return false;

                _values.Add(val);
                return true;
            }

            public bool Remove(int val)
            {
                if (!_values.Contains(val))
                    return false;

                _values.Remove(val);
                return true;
            }

            public int GetRandom()
            {
                Random rnd = new();
                return _values.ElementAt(rnd.Next(0, _values.Count));
            }
        }
    }
}

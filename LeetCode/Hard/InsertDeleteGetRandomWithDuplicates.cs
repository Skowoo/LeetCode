namespace LeetCode.Hard
{
    internal class InsertDeleteGetRandomWithDuplicates
    {
        public static void TestMain()
        {
            var a = new RandomizedCollection();
            a.Insert(1);
            a.Insert(1);
            a.Remove(1);
            Console.WriteLine(a.GetRandom() == 1);
        }

        public class RandomizedCollection
        {

            List<int> _values;

            public RandomizedCollection()
            {
                _values = new List<int>();
            }

            public bool Insert(int val)
            {
                bool exists = _values.Contains(val);
                _values.Add(val);
                return !exists;
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

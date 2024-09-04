namespace LeetCode.Easy
{
    public class KthLargest
    {
        PriorityQueue<int, int> pq = new();
        int k;

        public KthLargest(int k, int[] nums)
        {
            this.k = k;

            foreach (var num in nums)
                Add(num);
        }

        public int Add(int val)
        {
            pq.Enqueue(val, val);

            while (pq.Count > k)
                pq.Dequeue();

            return pq.Peek();
        }
    }
}

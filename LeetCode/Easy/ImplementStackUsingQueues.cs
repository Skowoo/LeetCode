namespace LeetCode.Easy
{
    internal static class ImplementStackUsingQueues
    {
        public class MyStack
        {
            readonly private Queue<int> queue = [];

            public void Push(int x)
            {
                queue.Enqueue(x);
                for (int i = 0; i < queue.Count - 1; i++)
                    queue.Enqueue(queue.Dequeue());
            }

            public int Pop() => queue.Dequeue();

            public int Top() => queue.Peek();

            public bool Empty() => queue.Count == 0;
        }
    }
}

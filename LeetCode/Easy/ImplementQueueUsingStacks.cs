#pragma warning disable IDE0044 // Add readonly modifier

namespace LeetCode.Easy
{
    public class MyQueue
    {
        private Stack<int> main;
        private Stack<int> temp;

        public MyQueue()
        {
            main = new Stack<int>();
            temp = new Stack<int>();
        }

        public void Push(int x)
        {
            if (main.Count == 0)
                main.Push(x);
            else
            {
                while (!(main.Count == 0))
                    temp.Push(main.Pop());

                main.Push(x);

                while (!(temp.Count == 0))
                    main.Push(temp.Pop());
            }
        }

        public int Pop() => main.Pop();

        public int Peek() => main.Peek();

        public bool Empty() => main.Count == 0;
    }

    //static void Main()
    //{
    //    var test = new MyQueue();
    //    test.Push(1);
    //    test.Push(2);
    //    test.Push(3);
    //    test.Push(4);
    //    test.Push(5);
    //    Console.WriteLine(test.Peek());
    //    Console.WriteLine(test.Pop());
    //    Console.WriteLine(test.Pop());
    //    Console.WriteLine(test.Pop());
    //    Console.WriteLine(test.Pop());
    //    Console.WriteLine(test.Pop());
    //}
}

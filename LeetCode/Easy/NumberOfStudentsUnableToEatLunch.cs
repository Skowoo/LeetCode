namespace LeetCode.Easy
{
    internal class NumberOfStudentsUnableToEatLunch
    {
        public static int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> queue = new(students);
            Array.Reverse(sandwiches);
            Stack<int> stack = new(sandwiches);

            int noTaken = 0;

            while (noTaken <= stack.Count)
            {
                bool stackEmpty = !stack.TryPeek(out int currentCookie);
                bool queueEmpty = !queue.TryPeek(out int currentStudent);

                if (stackEmpty)
                    return queue.Count;

                if (queueEmpty)
                    return 0;

                if (currentCookie == currentStudent)
                {
                    stack.Pop();
                    queue.Dequeue();
                    noTaken = 0;
                }
                else
                {
                    currentStudent = queue.Dequeue();
                    queue.Enqueue(currentStudent);
                    noTaken++;
                }
            }

            return queue.Count;
        }
    }
}

// Console.WriteLine(CountStudents(new int[] { 1, 1, 0, 0 }, new int[] { 0, 1, 0, 1 }));
// Console.WriteLine(CountStudents(new int[] { 1, 1, 1, 0, 0, 1 }, new int[] { 1, 0, 0, 0, 1, 1 }));
using System.Text;

namespace LeetCode.Medium
{
    internal class OpenTheLock
    {
        public static int OpenLock(string[] deadends, string target)
        {
            HashSet<string> deadendsSet = new(deadends);
            HashSet<string> visited = new();
            Queue<string> queue = new(new string[] { "0000" });
            int result = 0;

            while (queue.Count > 0)
            {
                int currentQueueSize = queue.Count;
                for (int i = 0; i < currentQueueSize; i++)
                {
                    string currentCombination = queue.Dequeue();

                    if (deadendsSet.Contains(currentCombination) || visited.Contains(currentCombination))
                        continue;

                    if (currentCombination == target)
                        return result;

                    visited.Add(currentCombination);

                    for (int j = 0; j < 4; j++)
                    {
                        StringBuilder sb = new(currentCombination);
                        int currentRoll = sb[j];

                        sb[j] = (char)(currentRoll - 1 == 47 ? 57 : currentRoll - 1);

                        if (!visited.Contains(sb.ToString()))
                            queue.Enqueue(sb.ToString());

                        sb[j] = (char)(currentRoll + 1 == 58 ? 48 : currentRoll + 1);

                        if (!visited.Contains(sb.ToString()))
                            queue.Enqueue(sb.ToString());
                    }
                }
                result++;
            }

            return -1;
        }
    }
}

// Console.WriteLine(OpenLock(new string[] { "0201", "0101", "0102", "1212", "2002" }, "0202"));
namespace LeetCode.Medium
{
    internal class MostProfitAssigningWork
    {
        public static int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
        {
            Dictionary<int, int> jobs = [];
            for (int i = 0; i < difficulty.Length; i++)
                if (!jobs.TryGetValue(difficulty[i], out int currentVal))
                    jobs.Add(difficulty[i], profit[i]);
                else
                    jobs[difficulty[i]] = Math.Max(currentVal, profit[i]);

            int result = 0;
            int workerIndex = worker.Length - 1;
            Array.Sort(worker);

            foreach (var pair in jobs.OrderByDescending(x => x.Value))
                while (workerIndex >= 0 && worker[workerIndex] >= pair.Key)
                {
                    result += pair.Value;
                    workerIndex--;
                }

            return result;
        }
    }
}

namespace LeetCode.Hard
{
    internal class MinimumCostToHireKWorkers
    {
        public static double MincostToHireWorkers(int[] quality, int[] wage, int k)
        {
            var efficiency = new (double costEfficiency, double quality)[quality.Length];

            for (var i = 0; i < quality.Length; ++i)
                efficiency[i] = ((double)wage[i] / quality[i], quality[i]);

            Array.Sort(efficiency, (x, y) => x.costEfficiency.CompareTo(y.costEfficiency));

            PriorityQueue<double, double> priorityQueue = new();
            double result = double.MaxValue,
                   sum = 0;

            foreach (var man in efficiency)
            {
                sum += man.quality;

                priorityQueue.Enqueue(-man.quality, -man.quality);

                if (priorityQueue.Count > k)
                    sum += priorityQueue.Dequeue();

                if (priorityQueue.Count == k)
                    result = Math.Min(result, sum * man.costEfficiency);
            }

            return result;
        }
    }
}

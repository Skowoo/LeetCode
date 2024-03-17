namespace LeetCode.Medium
{
    internal class InsertInterval
    {
        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> resultList = new();
            int[]? newBoard = null;
            bool inserted = false;

            if (intervals.Length == 0 || intervals[0][0] > newInterval[1])
            {
                resultList.Add(newInterval);
                foreach (int[] interval in intervals)
                    resultList.Add(interval);
                return resultList.ToArray();
            }
            else if (intervals[intervals.Length - 1][1] < newInterval[0])
            {
                foreach (int[] interval in intervals)
                    resultList.Add(interval);
                resultList.Add(newInterval);
                return resultList.ToArray();
            }

            foreach (int[] interval in intervals)
            {
                if (interval[0] > newInterval[1] && !inserted)
                {
                    inserted = true;
                    resultList.Add(newInterval);
                    resultList.Add(interval);
                }
                else if (interval[1] < newInterval[0] || interval[0] > newInterval[1])
                {
                    resultList.Add(interval);
                    continue;
                }
                else if (newBoard is null)
                {
                    inserted = true;
                    newBoard = new int[2];
                    newBoard[0] = Math.Min(interval[0], newInterval[0]);
                    newBoard[1] = Math.Max(interval[1], newInterval[1]);
                    resultList.Add(newBoard);
                }
                else
                {
                    newBoard[1] = Math.Max(interval[1], newInterval[1]);
                }
            }

            return resultList.ToArray();
        }
    }
}

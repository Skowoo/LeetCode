namespace LeetCode.Medium
{
    internal class FurthestBuildingYouCanReach
    {
        // As long as there are less differences to jump up than ladders, remember them in Priority queue
        // If there are more differences than ladders start to use brick for the smallest ones (ladders will remain for biggest gaps)
        // If there are no more bricks = return current builidng (current loop index)
        // Otherwise return last index as you reached last building without running out of bricks.
        public static int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            PriorityQueue<int, int> priorityQueue = new();

            for (int i = 0; i < heights.Length - 1; i++)
            {
                int currentDiff = heights[i + 1] - heights[i];

                if (currentDiff > 0)
                    priorityQueue.Enqueue(currentDiff, currentDiff);

                if (priorityQueue.Count > ladders)
                    bricks -= priorityQueue.Dequeue();

                if (bricks < 0)
                    return i;
            }

            return heights.Length - 1;
        }
    }
}

// Console.WriteLine(FurthestBuilding(new int[] { 4, 12, 2, 7, 3, 18, 20, 3, 19 }, 10, 2));
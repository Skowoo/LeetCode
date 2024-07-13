namespace LeetCode.Hard
{
    internal class RobotCollisions
    {
        public static IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions)
        {
            Dictionary<int, int> robots = [];

            for (int i = 0; i < positions.Length; i++)
                robots.Add(positions[i], i);

            Array.Sort(positions);

            Stack<int> stack = new();

            for (var i = 0; i < positions.Length; i++)
            {
                int position = positions[i];
                int currIndex = robots[position];

                while (stack.Count > 0 && directions[stack.Peek()] == 'R' && directions[currIndex] == 'L' && healths[currIndex] > 0)
                {
                    int topRobo = stack.Peek();
                    if (healths[topRobo] < healths[currIndex])
                    {
                        stack.Pop();
                        healths[currIndex]--;
                        healths[topRobo] = 0;
                    }
                    else if (healths[topRobo] > healths[currIndex])
                    {
                        healths[topRobo]--;
                        healths[currIndex] = 0;
                    }
                    else
                    {
                        stack.Pop();
                        healths[topRobo] = 0;
                        healths[currIndex] = 0;
                    }
                }

                if (healths[currIndex] > 0)
                    stack.Push(currIndex);
            }

            return healths.Where(x => x > 0).ToList();
        }
    }
}

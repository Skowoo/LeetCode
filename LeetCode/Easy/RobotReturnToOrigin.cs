namespace LeetCode.Easy
{
    internal static class RobotReturnToOrigin
    {
        public static bool JudgeCircle(string moves)
        {
            int horizontal = 0,
                vertical = 0;

            foreach (var move in moves)
                if (move == 'U')
                    vertical++;
                else if (move == 'D')
                    vertical--;
                else if (move == 'R')
                    horizontal++;
                else if (move == 'L')
                    horizontal--;

            return horizontal == vertical && vertical == 0;
        }
    }
}

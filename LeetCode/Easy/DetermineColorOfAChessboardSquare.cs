namespace LeetCode.Easy
{
    internal static class DetermineColorOfAChessboardSquare
    {
        public static bool SquareIsWhite(string coordinates)
        {
            if (coordinates[0] % 2 == 1)
            {
                if (coordinates[1] % 2 == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (coordinates[1] % 2 == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

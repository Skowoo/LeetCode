namespace LeetCode.Easy
{
    internal class MinimumNumberOfMovesToSeatEveryone
    {
        public static int MinMovesToSeat(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);

            int result = 0;

            for (int i = 0; i < seats.Length; i++)
                result += Math.Abs(seats[i] - students[i]);

            return result;
        }
    }
}

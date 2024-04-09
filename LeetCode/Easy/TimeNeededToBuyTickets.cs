namespace LeetCode.Easy
{
    internal class TimeNeededToBuyTickets
    {
        public static int TimeRequiredToBuy(int[] tickets, int k)
        {
            int timer = 0;
            while (true)
                for (int i = 0; i < tickets.Length; i++)
                    if (tickets[i] > 0)
                    {
                        timer++;
                        tickets[i]--;

                        if (i == k && tickets[i] == 0)
                            return timer;
                    }
        }
    }
}

namespace LeetCode.Easy
{
    internal class LemonadeChange
    {
        public static bool LemonadeChange_Func(int[] bills)
        {
            int fives = 0,
                tens = 0;

            foreach (int bill in bills)
                if (bill == 5)
                {
                    fives++;
                }
                else if (bill == 10)
                {
                    tens++;
                    fives--;

                    if (fives < 0)
                        return false;
                }
                else
                {
                    if (tens >= 1 && fives >= 1)
                    {
                        tens--;
                        fives--;
                    }
                    else if (fives >= 3)
                    {
                        fives -= 3;
                    }
                    else
                    {
                        return false;
                    }
                }

            return true;
        }
    }
}

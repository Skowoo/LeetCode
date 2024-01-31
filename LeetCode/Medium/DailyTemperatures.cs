namespace LeetCode.Medium
{
    internal class DailyTemperatures
    {
        public static int[] DailyTemperaturesFunc(int[] temperatures)
        {
            int[] result = new int[temperatures.Length];

            for (int i = 0; i < temperatures.Length; i++)
            {
                result[i] = 0;
                int counter = 0;
                for (int j = i; j < temperatures.Length; j++)
                {
                    if (temperatures[j] > temperatures[i])
                    {
                        result[i] = counter;
                        break;
                    }
                    counter++;
                }
            }

            return result;
        }
    }
}

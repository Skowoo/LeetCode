namespace LeetCode.Easy
{
    internal class CrawlerLogFolder
    {
        public static int MinOperations(string[] logs)
        {
            int result = 0;
            foreach (var log in logs)
            {
                switch (log)
                {
                    case "../":
                        if (result > 0)
                            result--;
                        break;
                    case "./":
                        break;
                    default:
                        result++;
                        break;
                }
            }
            return result;
        }
    }
}

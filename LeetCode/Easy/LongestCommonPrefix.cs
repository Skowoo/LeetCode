namespace LeetCode.Easy
{
    internal class LongestCommonPrefix
    {
        public static string LongestCommonPrefixFunc(string[] strs)
        {
            string result = strs[0];
            if (string.IsNullOrEmpty(result))
                return "";

            for (int i = 1; i < strs.Length; i++)
            {
                if (string.IsNullOrEmpty(strs[i]))
                    return "";

                if (strs[i].Length < result.Length)
                    result = result.Remove(strs[i].Length);

                for (int j = 0; j < strs[i].Length; j++)
                {
                    if (j >= result.Length)
                        break;

                    if (strs[i][j] != result[j])
                    {
                        if (j == 0)
                            return "";

                        result = result.Remove(j);
                    }
                }

                if (string.IsNullOrEmpty(result))
                    return "";
            }

            return result;
        }
    }
}

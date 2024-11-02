namespace LeetCode.Easy
{
    internal class CircularSentence
    {
        public static bool IsCircularSentence(string sentence)
        {
            var words = sentence.Split(' ');
            if (sentence[0] != sentence[^1])
                return false;

            for (int i = 1; i < words.Length; i++)
                if (words[i - 1][^1] != words[i][0])
                    return false;

            return true;
        }
    }
}

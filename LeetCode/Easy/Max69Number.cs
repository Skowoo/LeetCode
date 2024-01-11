namespace LeetCode.Easy
{
    internal class Max69Number
    {

        public static int Maximum69Number(int num)
        {
            var numString = num.ToString().ToCharArray();

            for (int i = 0; i < numString.Length; i++)
                if (numString[i] == '6')
                {
                    numString[i] = '9';
                    return int.Parse(numString);
                }

            return int.Parse(numString);
        }
    }
}

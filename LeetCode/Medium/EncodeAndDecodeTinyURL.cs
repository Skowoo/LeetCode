namespace LeetCode.Medium
{
    internal class EncodeAndDecodeTinyURL
    {
        public class Codec
        {
            Dictionary<int, string> storedLinks = [];
            int counter = 0;

            public string encode(string longUrl)
            {
                counter++;
                storedLinks.Add(counter, longUrl);
                return counter.ToString();
            }


            public string decode(string shortUrl)
            {
                var validKey = int.TryParse(shortUrl, out int number);
                if (validKey)
                    return storedLinks[number];

                return "Error";
            }
        }
    }
}

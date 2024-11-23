namespace LeetCode.Medium
{
    internal class RotatingTheBox
    {
        public static char[][] RotateTheBox(char[][] box)
        {
            foreach (var arr in box)
            {
                bool fallen = true;
                while (fallen) // BAD solution. BAD.
                {
                    fallen = false;
                    for (int i = arr.Length - 2; i >= 0; i--)
                        if (arr[i] == '#' && arr[i + 1] == '.')
                        {
                            (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                            fallen = true;
                        }
                }
            }

            char[][] result = new char[box[0].Length][];
            for (int i = 0; i < result.Length; i++)
                result[i] = new char[box.Length];

            for (int i = 0; i < box.Length; i++)
                for (int j = 0; j < result.Length; j++)
                    result[j][i] = box[^(i + 1)][j];

            return result;
        }
    }
}

//char[][] test = [['#','#','*','.','*','.'],
//              ['#','#','#','*','.','.'],
//              ['#','#','#','.','#','.']];

//var result = RotateTheBox(test);

//foreach (var c in result)
//{
//    foreach (var e in c)
//        Console.Write(e + ",");
//    Console.Write(Environment.NewLine);
//}
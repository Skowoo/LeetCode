using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            int result = 0, step = 0;
            var array = s.ToUpper().ToCharArray();
            Array.Reverse(array);

            foreach (char c in array)
            {
                switch (c)
                {
                    case 'I':
                        if (step > 0)
                            result--;
                        else
                            result++;
                        break;
                    case 'V':
                        if (step < 1)
                            step = 1;
                        if (step > 1)
                            result -= 5;
                        else
                            result += 5;
                        break;
                    case 'X':
                        if (step < 2)
                            step = 2;
                        if (step > 2)
                            result -= 10;
                        else
                            result += 10;
                        break;
                    case 'L':
                        if (step < 3)
                            step = 3;
                        if (step > 3)
                            result -= 50;
                        else
                            result += 50;
                        break;
                    case 'C':
                        if (step < 4)
                            step = 4;
                        if (step > 4)
                            result -= 100;
                        else
                            result += 100;
                        break;
                    case 'D':
                        if (step < 5)
                            step = 5;
                        if (step > 5)
                            result -= 500;
                        else
                            result += 500;
                        break;
                    case 'M':
                        if (step < 6)
                            step = 6;
                        if (step > 6)
                            result -= 1000;
                        else
                            result += 1000;
                        break;
                }
            }

            return result;
        }
    }
}


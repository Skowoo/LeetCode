namespace LeetCode.Medium
{
    internal class BoatsToSavePeople
    {
        // Good solution - two pointer on array
        public static int NumRescueBoats(int[] people, int limit)
        {
            int result = 0,
                frontPointer = 0,
                backPointer = people.Length - 1;

            Array.Sort(people);

            while (frontPointer <= backPointer)
            {
                if (people[backPointer] == limit)
                {
                    result++;
                    backPointer--;
                }
                else if (people[backPointer] < limit)
                {
                    if (frontPointer == backPointer)
                    {
                        result++;
                        break;
                    }
                    else if (people[frontPointer] + people[backPointer] <= limit)
                    {
                        result++;
                        backPointer--;
                        frontPointer++;
                    }
                    else
                    {
                        result++;
                        backPointer--;
                    }
                }
            }

            return result;
        }

        // Inefficient (yet accepted) solution due to List<int> usage!
        public static int NumRescueBoats__Bad(int[] people, int limit)
        {
            int result = 0;
            List<int> passangers = people.ToList();
            passangers.Sort();

            while (passangers.Count > 0)
            {
                int frontPointer = 0,
                    backPointer = passangers.Count - 1;

                if (frontPointer == backPointer)
                {
                    result++;
                    break;
                }

                if (passangers[backPointer] == limit)
                {
                    result++;
                    passangers.RemoveAt(backPointer);
                }
                else if (passangers[backPointer] < limit)
                {
                    while (passangers[frontPointer + 1] + passangers[backPointer] <= limit && frontPointer < backPointer - 1)
                        frontPointer++;

                    if (passangers[frontPointer] + passangers[backPointer] <= limit)
                    {
                        result++;
                        passangers.RemoveAt(backPointer);
                        passangers.RemoveAt(frontPointer);
                    }
                    else
                    {
                        result++;
                        passangers.RemoveAt(backPointer);
                    }
                }
            }

            return result;
        }
    }
}

// Console.WriteLine(NumRescueBoats(new int[] { 1, 2 }, 3));
// Console.WriteLine(NumRescueBoats(new int[] { 11, 2, 2, 8, 8 }, 11));
// Console.WriteLine(NumRescueBoats(new int[] { 3, 2, 2, 1 }, 3));
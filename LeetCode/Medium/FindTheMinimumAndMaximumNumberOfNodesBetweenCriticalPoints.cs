using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class FindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints
    {
        public static int[] NodesBetweenCriticalPoints(ListNode head)
        {
            int[] result = [-1, -1];
            if (head is null)
                return result;

            int curVal = head.val;
            if ((head = head.next) == null)
                return result;

            int nextVal = head.val;
            int min = int.MaxValue, max = int.MinValue;
            for (int index = 0, prevIndex = -1, firstIndex = -1; (head = head.next) != null; index++)
            {
                int prevVal = curVal;
                curVal = nextVal;
                nextVal = head.val;
                if (prevVal < curVal && curVal > nextVal || prevVal > curVal && curVal < nextVal)
                {
                    if (prevIndex >= 0)
                    {
                        min = Math.Min(min, index - prevIndex);
                        max = index - firstIndex;
                    }

                    prevIndex = index;

                    if (firstIndex < 0)
                        firstIndex = index;
                }
            }
            if (max > 0)
            {
                result[0] = min;
                result[1] = max;
            }

            return result;
        }
    }
}

// NodesBetweenCriticalPoints(new ListNode(1, new ListNode(100000, new ListNode(1, new ListNode(100000, new ListNode(1, new ListNode(100000, new ListNode(1, new ListNode(100000, new ListNode(1, new ListNode(100000)))))))))));
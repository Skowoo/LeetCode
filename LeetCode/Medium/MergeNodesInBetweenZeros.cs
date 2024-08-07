#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.

using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class MergeNodesInBetweenZeros
    {
        public static ListNode MergeNodes(ListNode head)
        {
            ListNode prevZero = head,
                pointer = head.next;

            int currSum = 0;

            while (pointer is not null)
            {
                if (pointer.val != 0)
                    currSum += pointer.val;
                else
                {
                    prevZero.val = currSum;
                    prevZero.next = pointer;
                    currSum = 0;

                    if (pointer.next is null)
                    {
                        prevZero.next = null;
                        break;
                    }

                    prevZero = pointer;
                }

                pointer = pointer.next;
            }

            return head;
        }
    }
}

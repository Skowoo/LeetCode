#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8601 // Possible null reference assignment.

using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class SwapNodesInPairs
    {
        public static ListNode SwapPairs(ListNode head)
        {
            if (head is null)
                return null;

            ListNode newHead = new() { val = -1, next = head };
            head = newHead;

            while (true)
            {
                ListNode? first, second, third;

                if (head.next is not null)
                    first = head.next;
                else
                    first = null;

                if (head.next is not null && head.next.next is not null)
                    second = head.next.next;
                else
                    second = null;

                if (head.next is not null && head.next.next is not null && head.next.next.next is not null)
                    third = head.next.next.next;
                else
                    third = null;

                if (first is null || second is null)
                    break;
                else
                {
                    first.next = third;
                    second.next = first;
                    head.next = second;
                }

                if (third is null)
                    break;

                head = first;
            }

            return newHead.next;
        }
    }
}

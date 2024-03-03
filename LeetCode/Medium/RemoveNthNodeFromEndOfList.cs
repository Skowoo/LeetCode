#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8603 // Possible null reference return.

using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class RemoveNthNodeFromEndOfList
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next is null)
                return null;

            ListNode newTempHead = new() { val = -1, next = head };

            int totalLength = 0;
            head = newTempHead;
            while (head.next is not null)
            {
                head = head.next;
                totalLength++;
            }
            head = newTempHead;

            int targetIndex = totalLength - n;

            for (int i = 0; i < targetIndex; i++)
                head = head.next;

            if (head.next is null)
                return newTempHead.next;
            if (head.next.next is null)
                head.next = null;
            else
                head.next = head.next.next;

            return newTempHead.next;
        }
    }
}

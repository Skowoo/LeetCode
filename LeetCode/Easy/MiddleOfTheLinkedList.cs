using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class MiddleOfTheLinkedList
    {
        public static ListNode MiddleNodeTwoPointer(ListNode head)
        {
            if (head is null || head.next is null)
                return head!;

            ListNode slow = head;
            ListNode fast = head.next;

            while (fast.next is not null && fast.next.next is not null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow.next;
        }

        public static ListNode MiddleNodeCounter(ListNode head)
        {
            ListNode oriHead = head;
            int counter = 0;

            while (head.next is not null)
            {
                counter++;
                head = head.next;
            }

            for (int i = 0; i < Math.Ceiling(1.0D * counter / 2); i++)
                oriHead = oriHead.next;

            return oriHead;
        }
    }
}

using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class MiddleOfTheLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
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

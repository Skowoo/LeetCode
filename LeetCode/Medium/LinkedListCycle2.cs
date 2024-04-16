using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class LinkedListCycle2
    {
        public static ListNode? DetectCycle(ListNode head)
        {
            if (head is null || head.next is null)
                return null;

            ListNode slow = head, 
                fast = head;

            while (fast is not null && fast.next is not null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                    break;
            }

            if (fast is null || fast.next is null)
                return null;

            slow = head;

            while (fast != slow)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return slow;
        }


        public static ListNode? DetectCycle_Naive(ListNode head)
        {
            if (head is null)
                return null;

            List<ListNode> visited = new();
            ListNode temp = head;
            while (temp.next is not null)
                if (!visited.Contains(temp))
                {
                    visited.Add(temp);
                    temp = temp.next;
                }
                else
                    return temp;

            return null;
        }
    }
}

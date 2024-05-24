using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class LinkedListCycle
    {
        // Rabbit & Hare solution
        public static bool HasCycle(ListNode head)
        {
            if (head is null || head.next is null)
                return false;

            ListNode slow = head,
                     fast = head;

            while (fast.next is not null && fast.next.next is not null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow)
                    return true;
            }
            return false;
        }

        // Extremely uneffective solution - beats 5% :<
        public static bool HasCycleBAD(ListNode head)
        {
            List<ListNode> visitedNodes = new();

            while (head.next is not null)
            {
                if (visitedNodes.Contains(head.next))
                    return true;
                visitedNodes.Add(head.next);

                head = head.next;
            }

            return false;
        }
    }
}

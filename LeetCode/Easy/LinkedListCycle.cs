using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class LinkedListCycle
    {
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

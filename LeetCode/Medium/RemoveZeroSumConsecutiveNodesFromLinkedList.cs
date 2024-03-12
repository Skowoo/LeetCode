#pragma warning disable CS8603 // Possible null reference return.


using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class RemoveZeroSumConsecutiveNodesFromLinkedList
    {
        public static ListNode RemoveZeroSumSublists(ListNode head)
        {
            while (true)
            {
                bool canBreak = true;

                ListNode end = SumZero(head);

                if (end != null)
                {
                    head = end.next;
                    continue;
                }

                if (head is null)
                    return null;

                ListNode previousNode = head;

                for (ListNode node = head.next; node is not null; node = node.next)
                {
                    end = SumZero(node);
                    if (end is not null)
                    {
                        previousNode.next = end.next;
                        canBreak = false;
                        break;
                    }
                    previousNode = node;
                }

                if (canBreak)
                    break;
            }

            return head;
        }

        static ListNode SumZero(ListNode firstNode)
        {
            int currSum = 0;

            while (firstNode != null)
            {
                currSum += firstNode.val;

                if (currSum == 0)
                    return firstNode;

                firstNode = firstNode.next;
            }

            return null;
        }
    }
}

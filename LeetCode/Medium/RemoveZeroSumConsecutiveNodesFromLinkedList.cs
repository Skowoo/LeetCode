#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.


using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class RemoveZeroSumConsecutiveNodesFromLinkedList
    {
        public static ListNode RemoveZeroSumSublists(ListNode head)
        {
            List<int> listedInput = new();
            while (head is not null)
            {
                listedInput.Add(head.val);
                head = head.next;
            }

            // TBD: remove subarrays which sums to 0


            ListNode result = new(2000, null);
            ListNode temp = result;
            foreach (int i in listedInput)
            {
                ListNode newNode = new(i, null);
                temp.next = newNode;
                temp = temp.next;
            }

            return result.next;
        }
    }

    internal class RemoveZeroSumConsecutiveNodesFromLinkedList_InListApproach
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

using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class DeleteNodesFromLinkedListPresentInArray
    {
        public static ListNode ModifiedList(int[] nums, ListNode head)
        {
            HashSet<int> numsSet = [.. nums];
            ListNode previousNode = null!;
            ListNode currentNode = head;

            while (currentNode != null)
            {
                if (!numsSet.Contains(currentNode.val))
                    (previousNode, currentNode) = (currentNode, currentNode.next);
                else if (previousNode is null)
                    (head, currentNode) = (currentNode.next, currentNode.next);
                else if (currentNode.next is null)
                    (currentNode, previousNode.next) = (currentNode.next!, null!);
                else
                    (previousNode.next, currentNode) = (currentNode.next, currentNode.next);
            }

            return head;
        }
    }
}

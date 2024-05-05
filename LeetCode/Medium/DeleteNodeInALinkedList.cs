using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class DeleteNodeInALinkedList
    {
        public static void DeleteNode(ListNode node)
        {
            ListNode currentNode = node,
                previousNode = null;

            while (currentNode.next is not null)
            {
                currentNode.val = currentNode.next.val;
                previousNode = currentNode;
                currentNode = currentNode.next;
            }

            if (previousNode is not null)
                previousNode.next = null;
        }
    }
}

using LeetCode.CommonClasses;
using System.Numerics;

namespace LeetCode.Medium
{
    internal static class InsertGreatestCommonDivisorsInLinkedList
    {
        public static ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            ListNode currentNode = head;
            ListNode nextNode;

            while (currentNode.next is not null)
            {
                nextNode = currentNode.next;
                int newNodeValue = (int)BigInteger.GreatestCommonDivisor(currentNode.val, nextNode.val);
                currentNode.next = new ListNode(newNodeValue, nextNode);
                currentNode = nextNode;
            }

            return head;
        }
    }
}

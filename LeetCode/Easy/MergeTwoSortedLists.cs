#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8602 // Dereference of a possibly null reference.

using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 is null && list2 is null)
                return null;
            else if (list1 is null)
                return list2;
            else if (list2 is null)
                return list1;

            ListNode headNode = new(0);
            ListNode currentNode = headNode;

            while (true)
            {
                if (list1 is null && list2 is not null)
                {
                    currentNode.val = list2.val;
                    list2 = list2.next;
                }
                else if (list1 is not null && list2 is null)
                {
                    currentNode.val = list1.val;
                    list1 = list1.next;
                }
                else if (list1.val < list2.val)
                {
                    currentNode.val = list1.val;
                    list1 = list1.next;
                }
                else if (list1.val >= list2.val)
                {
                    currentNode.val = list2.val;
                    list2 = list2.next;
                }

                if (list1 is null && list2 is null)
                    return headNode;

                currentNode.next = new ListNode(0);
                currentNode = currentNode.next;
            };
        }
    }
}

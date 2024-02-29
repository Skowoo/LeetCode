#pragma warning disable CS8603
#pragma warning disable CS8625

using LeetCode.CommonClasses;

namespace LeetCode.Hard
{
    internal class MergeKSortedLists
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists is null || lists.Length == 0 || lists.All(x => x is null))
                return null;

            ListNode resultHead = new(0, null);
            ListNode lastNode = resultHead;

            PriorityQueue<ListNode, int> listHeads = new();

            foreach (ListNode head in lists)
                if (head is not null)
                    listHeads.Enqueue(head, head.val);

            while (listHeads.Count > 0)
            {
                ListNode current = listHeads.Dequeue();

                if (current.next is not null)
                    listHeads.Enqueue(current.next, current.next.val);

                lastNode.next = current;
                lastNode = lastNode.next;
            }

            return resultHead.next;
        }
    }
}


//ListNode[] test = new ListNode[] { new ListNode(1, new ListNode(4, new ListNode(5, null))), new ListNode(1, new ListNode(3, new ListNode(4, null))), new ListNode(2, new ListNode(6, null)) };
//var result = MergeKLists(test);

//Console.WriteLine(result);

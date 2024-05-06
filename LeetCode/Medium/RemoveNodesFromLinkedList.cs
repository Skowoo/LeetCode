using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class RemoveNodesFromLinkedList
    {
        // Ineffective solution
        public static ListNode RemoveNodes(ListNode head)
        {
            List<int> values = new();
            while (head is not null)
            {
                values.Add(head.val);
                head = head.next;
            }
            int currValue = values.Last();
            for (int i = values.Count - 1; i >= 0; i--)
            {
                if (values[i] > currValue)
                    currValue = values[i];
                else if (values[i] < currValue)
                    values.RemoveAt(i);
            }

            ListNode result = new(values.First()),
                pointer = result;
            values.RemoveAt(0);

            while (values.Count > 0)
            {
                pointer.next = new ListNode(values.First());
                values.RemoveAt(0);
                pointer = pointer.next;
            }

            return result;
        }
    }
}

// Console.WriteLine(RemoveNodes(new ListNode(5, new ListNode(2, new ListNode(13, new ListNode(3, new ListNode(8)))))));

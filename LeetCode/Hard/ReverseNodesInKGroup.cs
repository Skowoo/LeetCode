using LeetCode.CommonClasses;

namespace LeetCode.Hard
{
    internal class ReverseNodesInKGroup
    {
        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            if (k == 1) return head;

            List<int> sourceList = new();
            while (head is not null)
            {
                sourceList.Add(head.val);
                head = head.next;
            }

            int swapCounter = sourceList.Count / k;
            List<int> finalList = new();
            for (int i = 0; i < swapCounter; i++)
            {
                int[] temp = sourceList.Skip(i * k).Take(k).ToArray();
                Array.Reverse(temp);
                finalList.AddRange(temp);
            }
            finalList.AddRange(sourceList.Skip(swapCounter * k));

            ListNode result = new();
            ListNode pointer = result;

            foreach (int i in finalList)
            {
                ListNode newNode = new(i);
                pointer.next = newNode;
                pointer = newNode;
            }
            return result.next;
        }
    }
}

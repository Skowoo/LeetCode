using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class ReverseLinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head is null || head.next is null)
                return head!;

            Stack<int> stack = new();

            while (head is not null)
            {
                stack.Push(head.val);
                head = head.next;
            }

            ListNode result = new();
            ListNode pointer = result;

            while (stack.Count > 0)
            {
                ListNode ln = new(stack.Pop());
                pointer.next = ln;
                pointer = pointer.next;
            }

            return result.next;
        }
    }
}

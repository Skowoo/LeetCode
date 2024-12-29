using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal static class RemoveDuplicatesFromSortedList
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head is null)
                return null!;

            var pointer = head;

            while (pointer.next is not null)
                if (pointer.val == pointer.next.val)
                    pointer.next = pointer.next.next;
                else
                    pointer = pointer.next;

            return head;
        }
    }
}

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.

namespace LeetCode.CommonClasses
{
    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}

// Example Declarations:
// 4:   new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
// 10:  new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, new ListNode(7, new ListNode(8, new ListNode(9, new ListNode(10))))))))));
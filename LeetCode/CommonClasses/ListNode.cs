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

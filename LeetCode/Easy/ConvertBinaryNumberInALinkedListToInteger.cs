using LeetCode.CommonClasses;
using System.Text;

namespace LeetCode.Easy
{
    internal static class ConvertBinaryNumberInALinkedListToInteger
    {
        public static int GetDecimalValue_String(ListNode head)
        {
            StringBuilder sb = new();
            while (head is not null)
            {
                sb.Append(head.val);
                head = head.next;
            }
            return Convert.ToInt32(sb.ToString(), 2);
        }
    }
}

using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class PalindromeLinkedList
    {
        public static bool IsPalindrome(ListNode head)
        {
            List<int> list = new();
            while (head is not null)
            {
                list.Add(head.val);
                head = head.next;
            }
            for (int i = 0; i < list.Count / 2; i++)
                if (list[i] != list[list.Count - i - 1])
                    return false;

            return true;
        }
    }
}

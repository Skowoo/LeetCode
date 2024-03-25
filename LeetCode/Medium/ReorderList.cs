using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class ReorderList
    {
        public static void ReorderListFunc(ListNode head)
        {
            List<int> values = new();
            ListNode pointer = head.next;
            while (pointer is not null)
            {
                values.Add(pointer.val);
                pointer = pointer.next;
            }
            var frontPart = values.Take(values.Count / 2).ToList();
            var backPart = values.Skip(values.Count / 2).Reverse().ToList();

            pointer = head;
            while (true)
            {
                if (backPart.Count > 0)
                {
                    int backValue = backPart.First();
                    ListNode newBackNode = new(backValue);
                    backPart.Remove(backValue);
                    pointer.next = newBackNode;
                    pointer = pointer.next;
                }

                if (frontPart.Count > 0)
                {
                    int frontValue = frontPart.First();
                    ListNode newFrontNode = new(frontValue);
                    frontPart.Remove(frontValue);
                    pointer.next = newFrontNode;
                    pointer = pointer.next;
                }
                else
                    return;
            }
        }
    }
}

// ReorderList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))));
// ReorderList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, new ListNode(7, new ListNode(8, new ListNode(9, new ListNode(10)))))))))));
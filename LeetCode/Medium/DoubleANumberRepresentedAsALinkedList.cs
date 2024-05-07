using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class DoubleANumberRepresentedAsALinkedList
    {
        // Good
        public static ListNode DoubleIt(ListNode head)
        {
            ListNode pointer = head;

            if (pointer.val > 4)
                head = new ListNode(1, pointer);

            while (pointer.next is not null)
            {
                pointer.val = (pointer.val * 2 + (pointer.next.val > 4 ? 1 : 0)) % 10;
                pointer = pointer.next;
            }
            pointer.val = (pointer.val * 2) % 10;

            return head;
        }

        // Bad
        public static ListNode DoubleIt_Brute(ListNode head)
        {
            Stack<int> inputNumber = new();
            while (head is not null)
            {
                inputNumber.Push(head.val);
                head = head.next;
            }

            Stack<int> outputNumber = new();
            bool rest = false;

            while (inputNumber.Count > 0)
            {
                int currentNodeVal = inputNumber.Pop();
                int currentDoubled = rest ? currentNodeVal * 2 + 1 : currentNodeVal * 2;
                rest = currentDoubled / 10 > 0;
                outputNumber.Push(currentDoubled % 10);
            }

            if (rest)
                outputNumber.Push(1);

            ListNode result = new(outputNumber.Pop()),
                pointer = result;
            while (outputNumber.Count > 0)
            {
                pointer.next = new(outputNumber.Pop());
                pointer = pointer.next;
            }

            return result;
        }
    }
}

// var let = DoubleIt(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, new ListNode(7, new ListNode(8, new ListNode(9, new ListNode(10)))))))))));
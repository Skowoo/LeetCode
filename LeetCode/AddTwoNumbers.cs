#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type - external code generates warning

namespace LeetCode
{
    internal class AddTwoNumbers
    {
        public static ListNode AddTwoNumbersFunc(ListNode l1, ListNode l2)
        {
            bool remainder = false, l1Done = false, l2Done = false;
            int operationResult, firstValue, secondValue, remainderValue;
            ListNode headNode = new(), currentNode, previousNode = headNode;

            while (true)
            {
                if (!l1Done)
                    firstValue = l1.val;
                else
                    firstValue = 0;

                if (!l2Done)
                    secondValue = l2.val;
                else
                    secondValue = 0;

                if (!remainder)
                    remainderValue = 0;
                else
                    remainderValue = 1;

                operationResult = firstValue + secondValue + remainderValue;
                if (operationResult > 9)
                {
                    remainder = true;
                    operationResult -= 10;
                }
                else
                    remainder = false;

                if (l1.next is null)
                    l1Done = true;
                else
                    l1 = l1.next;

                if (l2.next is null)
                    l2Done = true;
                else
                    l2 = l2.next;

                currentNode = new ListNode(operationResult);

                if (previousNode == headNode)
                    headNode.val = operationResult;

                previousNode.next = currentNode;

                previousNode = currentNode;

                if (!remainder && l1Done && l2Done)
                    return headNode.next;
            }
        }
    }
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


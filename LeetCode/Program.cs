namespace LeetCode
{
    internal class Program
    {
        static void Main()
        {

        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            bool remainder = false, l1Done = false, l2Done = false;
            int operationResult, firstValue, secondValue, remainderValue;
            ListNode result = null, newNode;

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

                newNode = new ListNode(operationResult);
                newNode.next = result;
                result = newNode;

                if (!remainder && l1Done && l2Done)
                    return newNode;                
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
}

using LeetCode.CommonClasses;

namespace LeetCode.Medium
{
    internal class MergeInBetweenLinkedLists
    {
        // In-place solution
        public static ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            ListNode result = list1;

            ListNode newListEnd = list2;
            while (newListEnd.next is not null)
                newListEnd = newListEnd.next;

            ListNode hook = new();

            for (int i = 1; i <= b + 1; i++)
            {
                if (i == a)
                    hook = list1;
                list1 = list1.next;
            }
            hook.next = list2;
            newListEnd.next = list1;

            return result;
        }

        // Time and space consuming (bad) solution
        public static ListNode MergeInBetweenSlow(ListNode list1, int a, int b, ListNode list2)
        {
            Queue<int> resultQueue = new();

            ListNode OriHead = list1;
            ListNode current = OriHead;
            bool inserted = false;

            int indexer = 0;
            while (current is not null)
            {
                if (indexer < a || indexer > b)
                {
                    resultQueue.Enqueue(current.val);
                }
                else
                {
                    if (!inserted)
                    {
                        while (true)
                        {
                            resultQueue.Enqueue(list2.val);

                            if (list2.next is null)
                                break;

                            list2 = list2.next;
                        }
                        inserted = true;
                    }
                }

                indexer++;

                current = current.next;
            }

            ListNode result = new ListNode();
            ListNode resultPointer = result;
            while (resultQueue.Count > 0)
            {
                resultPointer.next = new ListNode(resultQueue.Dequeue());
                resultPointer = resultPointer.next;
            }

            return result.next;
        }
    }
}

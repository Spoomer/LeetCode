using LeetCode.DataStructures;

namespace LeetCode.Problems
{
    public class MergedkLinkedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists is null || lists.Length == 0) return null;
            int smallestIndex = 0;
            int smallestVal = 10001;
            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] is null) continue;
                if (smallestVal > lists[i].val)
                {
                    smallestVal = lists[i].val;
                    smallestIndex = i;
                }
            }
            if (smallestVal == 10001) return null;
            ListNode result = lists[smallestIndex];
            ListNode currentResult = result;
            lists[smallestIndex] = lists[smallestIndex].next;

            while (lists.Length > 0)
            {
                smallestIndex = 0;
                smallestVal = 10001;
                for (int i = 0; i < lists.Length; i++)
                {
                    if (lists[i] is null) continue;
                    if (smallestVal > lists[i].val)
                    {
                        smallestVal = lists[i].val;
                        smallestIndex = i;
                    }
                }
                if (smallestVal == 10001) break;
                currentResult.next = lists[smallestIndex];
                currentResult = currentResult.next;
                lists[smallestIndex] = lists[smallestIndex].next;

            }
            return result;

        }
    }
}
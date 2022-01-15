namespace LeetCode.Problems;

public class Merge2SortedLinkedListsProb
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if (l1 is null) return l2;
        if (l2 is null) return l1;
        ListNode? currentl1 = l1;
        ListNode? currentl2 = l2;
        ListNode? result;

        if (l2.val < l1.val)
        {
            result = l2;
            currentl2 = currentl2.next;
        }
        else
        {
            result = l1;
            currentl1 = currentl1.next;
        }
        ListNode currentResult = result;
        while (currentl1 is null == false)
        {
            if (currentl2 is null == false)
            {
                if (currentl2.val < currentl1.val)
                {
                    currentResult.next = currentl2;
                    currentl2 = currentl2.next;
                }
                else
                {
                    currentResult.next = currentl1;
                    currentl1 = currentl1.next;
                }
            }
            else
            {
                currentResult.next = currentl1;
                break;
            }
            currentResult = currentResult.next;
        }
        if (currentl2 is null == false)
        {
            currentResult.next = currentl2;
        }
        return result;
    }
}

namespace LeetCode.Problems;

public class SwapPaisProb
{
    public static ListNode? SwapPairs(ListNode? head)
    {
        bool second = true;
        if (head is null) return null;
        ListNode currentNodeHead = head;
        ListNode? result = new(head.val);
        ListNode currentNodeResult = result;
        while (currentNodeHead.next is not null)
        {
            if (second)
            {
                result = new ListNode(head.next.val, result);
                currentNodeResult = result.next;
                currentNodeHead = head.next;
                second = false;
            }
            else if (currentNodeHead.next.next is not null)
            {
                ListNode? temptail = null;
                if (currentNodeHead.next.next.next is not null)
                {
                    temptail = currentNodeHead.next.next.next;
                }
                currentNodeResult.next = currentNodeHead.next.next;
                currentNodeResult.next.next = currentNodeHead.next;
                currentNodeResult.next.next.next = null;
                currentNodeResult = currentNodeResult.next.next;
                currentNodeHead = new ListNode(next: temptail);
            }
            else
            {
                currentNodeResult.next = currentNodeHead.next;
                currentNodeHead = currentNodeHead.next;
            }

        }
        return result;
    }
}

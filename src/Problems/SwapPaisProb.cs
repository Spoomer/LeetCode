namespace LeetCode.Problems;

public class SwapPaisProb
{
    public static ListNode? SwapPairs(ListNode? head)
    {
        bool second = true;
        if (head is null) return null;
        ListNode currentNodeHead = head;
        ListNode result = new(head.val);
        ListNode currentNodeInResult = result;
        while (currentNodeHead.next is not null)
        {
            if (second && head.next is not null)
            {
                result = new ListNode(head.next.val, result);
                if (result.next is not null)
                {
                    currentNodeInResult = result.next;
                }   
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
                currentNodeInResult.next = currentNodeHead.next.next;
                currentNodeInResult.next.next = currentNodeHead.next;
                currentNodeInResult.next.next.next = null;
                currentNodeInResult = currentNodeInResult.next.next;
                currentNodeHead = new ListNode(next: temptail);
            }
            else
            {
                currentNodeInResult.next = currentNodeHead.next;
                currentNodeHead = currentNodeHead.next;
            }

        }
        return result;
    }
}

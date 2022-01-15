namespace LeetCode.Problems;

class AddTwoNumberProb
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode? solution = new();
        ListNode? currentSolutionNode = solution;
        ListNode? lastSolutionNode = solution;
        int overflow = 0;
        ListNode? currentl1 = l1;
        ListNode? currentl2 = l2;
        while (currentl1 is null == false && currentl2 is null == false)
        {

            currentSolutionNode.val = currentl1.val + currentl2.val;
            if (overflow > 0)
            {
                currentSolutionNode.val += overflow;
                overflow = 0;
            }
            if (currentSolutionNode.val >= 10)
            {
                currentSolutionNode.val -= 10;
                overflow = 1;
            }
            currentSolutionNode.next = new ListNode();
            lastSolutionNode = currentSolutionNode;
            currentSolutionNode = currentSolutionNode.next;
            currentl1 = currentl1.next;
            currentl2 = currentl2.next;
        }
        while (currentl1 is null == false)
        {
            // if+else is slower than adding + setting zeros
            currentSolutionNode.val = currentl1.val + overflow;
            overflow = 0;

            if (currentSolutionNode.val >= 10)
            {
                currentSolutionNode.val -= 10;
                overflow = 1;
            }
            currentSolutionNode.next = new ListNode();
            lastSolutionNode = currentSolutionNode;
            currentSolutionNode = currentSolutionNode.next;
            currentl1 = currentl1.next;
        }
        while (currentl2 is null == false)
        {
            currentSolutionNode.val = currentl2.val + overflow;
            overflow = 0;

            if (currentSolutionNode.val >= 10)
            {
                currentSolutionNode.val -= 10;
                overflow = 1;
            }
            currentSolutionNode.next = new ListNode();
            lastSolutionNode = currentSolutionNode;
            currentSolutionNode = currentSolutionNode.next;
            currentl2 = currentl2.next;
        }
        if (overflow > 0)
        {
            currentSolutionNode.val = overflow;
        }
        else lastSolutionNode.next = null;
        return solution;
    }
}

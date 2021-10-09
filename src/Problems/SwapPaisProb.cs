using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeetCode.DataStructures;

namespace LeetCode.Problems
{
    public class SwapPaisProb
    {
        public ListNode SwapPairs(ListNode head)
        {
            int pos = 1;
            if (head is null) return null;
            ListNode currentNodeHead = head;
            ListNode result = new ListNode(head.val);
            ListNode currentNodeResult = result;
            while (currentNodeHead.next is not null)
            {
                pos++;
                if (pos == 2)
                {
                    result = new ListNode(head.next.val,result);
                    currentNodeResult = result.next;
                    currentNodeHead = head.next;
                }
                else if (pos % 2 != 0)
                {
                    currentNodeResult.next = currentNodeHead.next;
                    currentNodeHead = currentNodeHead.next;
                }
                else if (pos % 2 == 0)
                {
                    currentNodeResult.next = currentNodeHead.next.next;
                    currentNodeResult.next.next = currentNodeHead.next;
                    currentNodeResult = currentNodeResult.next.next;
                    currentNodeHead = currentNodeHead.next.next;
                }
                
            }
            return result;
        }
    }
}
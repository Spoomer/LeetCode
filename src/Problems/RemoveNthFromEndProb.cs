using System.Collections.Generic;
using LeetCode.DataStructures;

namespace LeetCode.Problems
{
    public class RemoveNthFromEndProb
    {
        public ListNode? RemoveNthFromEnd(ListNode head, int n)
        {
            List<ListNode> allNodes = new();
            ListNode? current = head;
            do
            {
                allNodes.Add(current);
                current = current.next;
            } while (current is null == false);
            if (allNodes.Count == 1)
            {
                return null;
            }
            else if (allNodes.Count == n)
            {
                return allNodes[1];
            }
            else if (allNodes.Count == 2)
            {
                allNodes[0].next = null;
            }
            else if (n == 1)
            {
                allNodes[^2].next = null;
            }
            else
            {
                allNodes[^(n + 1)].next = allNodes[^(n - 1)];
            }

            return head;

        }
    }
}
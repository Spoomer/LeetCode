using System;
using LeetCode.Problems;
using LeetCode.DataStructures;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var threeSumProb = new RemoveNthFromEndProb();
            ListNode head = new ListNode(1, new ListNode(2));
            var result = threeSumProb.RemoveNthFromEnd(head,1);
        }

    }
}

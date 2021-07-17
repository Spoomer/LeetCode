using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumberProb addTwoNumberProb = new AddTwoNumberProb();

            ListNode l1 = new ListNode(new int[] {9});

            ListNode l2 = new ListNode(new int[] {1, 9, 9, 9, 9, 9, 9, 9, 9, 9});
            addTwoNumberProb.AddTwoNumbers(l1, l2);
        }
    }
}

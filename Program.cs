using System;
using LeetCode.Problems;
using LeetCode.DataStructures;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode[] nodes = new ListNode[3];
            nodes[0] = new ListNode(new int[] { 1, 4, 5 });
            nodes[1] = new ListNode(new int[] { 1, 3, 4 });
            nodes[2] = new ListNode(new int[] { 2,6 });
            var obj = new MergedkLinkedLists();
            var result = obj.MergeKLists(nodes);
        }

    }
}

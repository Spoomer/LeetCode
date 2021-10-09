using System;
using LeetCode.DataStructures;
using LeetCode.Problems;
using Xunit;

namespace LeetCode.Test
{
    public class SwapPairsProbTests
    {
        [Fact]
        public void SwapPairsProbTest1()
        {
            int[] values = new int[] { 1 };
            ListNode head = new ListNode(values);
            SwapPaisProb prob = new SwapPaisProb();
            ListNode result = prob.SwapPairs(head);
            Assert.Equal(new int[] { 1 }, ListNode.GetValues(result));
        }
        [Fact]
        public void SwapPairsProbTest2()
        {
            int[] values = new int[] { 1, 4 };
            ListNode head = new ListNode(values);
            SwapPaisProb prob = new SwapPaisProb();
            ListNode result = prob.SwapPairs(head);
            Assert.Equal(new int[] { 4, 1 }, ListNode.GetValues(result));
        }
        [Fact]
        public void SwapPairsProbTest3()
        {
            int[] values = new int[] { 1, 4, 5 };
            ListNode head = new ListNode(values);
            SwapPaisProb prob = new SwapPaisProb();
            ListNode result = prob.SwapPairs(head);
            Assert.Equal(new int[] { 4, 1, 5 }, ListNode.GetValues(result));
        }
        [Fact]
        public void SwapPairsProbTest4()
        {
            int[] values = new int[] { 1, 4, 5, 6 };
            ListNode head = new ListNode(values);
            SwapPaisProb prob = new SwapPaisProb();
            ListNode result = prob.SwapPairs(head);
            Assert.Equal(new int[] { 4, 1, 6, 5 }, ListNode.GetValues(result));
        }
    }
}
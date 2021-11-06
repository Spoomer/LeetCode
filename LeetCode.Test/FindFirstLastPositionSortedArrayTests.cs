using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Problems;
using Xunit;

namespace LeetCode.Test
{
    public class FindFirstLastPositionSortedArrayTests
    {
        [Fact]
        public void FindFirstLastPositionSortedArrayTest1()
        {
            int[] input = new[] {5,7,7,8,8,10};
            FindFirstLastPositionSortedArrayProb obj = new();
            int[] result = obj.SearchRange(input,8);
            Assert.Equal(new int[]{3,4},result);
        }
        [Fact]
        public void FindFirstLastPositionSortedArrayTest2()
        {
            int[] input = new[] {5,7};
            FindFirstLastPositionSortedArrayProb obj = new();
            int[] result = obj.SearchRange(input,6);
            Assert.Equal(new int[]{-1,-1},result);
        }
        [Fact]
        public void FindFirstLastPositionSortedArrayTest3()
        {
            int[] input = Array.Empty<int>();
            FindFirstLastPositionSortedArrayProb obj = new();
            int[] result = obj.SearchRange(input,0);
            Assert.Equal(new int[]{-1,-1},result);
        }
        [Fact]
        public void FindFirstLastPositionSortedArrayTest4()
        {
            int[] input = new[] {5};
            FindFirstLastPositionSortedArrayProb obj = new();
            int[] result = obj.SearchRange(input,5);
            Assert.Equal(new int[]{0,0},result);
        }
        [Fact]
        public void FindFirstLastPositionSortedArrayTest5()
        {
            int[] input = new[] {5,7,7,8,8,10};
            FindFirstLastPositionSortedArrayProb obj = new();
            int[] result = obj.SearchRange(input,6);
            Assert.Equal(new int[]{-1,-1},result);
        }
        [Fact]
        public void FindFirstLastPositionSortedArrayTest6()
        {
            int[] input = new[] {5,7,7,8,8,10};
            FindFirstLastPositionSortedArrayProb obj = new();
            int[] result = obj.SearchRange(input,10);
            Assert.Equal(new int[]{5,5},result);
        }
        [Fact]
        public void FindFirstLastPositionSortedArrayTest7()
        {
            int[] input = new[] {5,7,7,8,8,10};
            FindFirstLastPositionSortedArrayProb obj = new();
            int[] result = obj.SearchRange(input,5);
            Assert.Equal(new int[]{0,0},result);
        }
    }
}
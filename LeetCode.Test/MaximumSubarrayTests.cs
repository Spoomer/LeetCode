namespace LeetCode.Test
{
    public class MaximumSubarrayTests
    {
        [Fact]
        public void ShouldBeEqual_NineNumbers()
        {
            int expected = 6;
            int[] input = new int[] {-2,1,-3,4,-1,2,1,-5,4};
            int actual = MaximumSubarrayProb.MaxSubArray(input);
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void ShouldBeEqual_OnlyNegative()
        {
            int expected = -1;
            int[] input = new int[] {-2,-1,-3,-4,-1,-2,-1,-5,-4};
            int actual = MaximumSubarrayProb.MaxSubArray(input);
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void ShouldBeEqual_OnePositive()
        {
            int expected = 1;
            int[] input = new int[] {-2,-1,-3,-4,1,-2,-1,-5,-4};
            int actual = MaximumSubarrayProb.MaxSubArray(input);
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void ShouldBeEqual_OneNumber()
        {
            int expected = 1;
            int[] input = new int[] {1};
            int actual = MaximumSubarrayProb.MaxSubArray(input);
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void ShouldBeEqual_OneBigPositive()
        {
            int expected = 50;
            int[] input = new int[] {-2,-1,-3,50,-1,-2,-1,-5,-4};
            int actual = MaximumSubarrayProb.MaxSubArray(input);
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void ShouldBeEqual_OneNegativeNumber()
        {
            int expected = -4;
            int[] input = new int[] {-4};
            int actual = MaximumSubarrayProb.MaxSubArray(input);
            Assert.Equal(expected,actual);
        }
    }
}
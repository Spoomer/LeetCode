namespace LeetCode.Test
{
    public class BestTimeToBuyAndSellTests
    {
        [Fact]
        public void ShouldBeEqual_Example()
        {
            int[] input = new[] { 7, 1, 5, 3, 6, 4 };
            int expected = 5;
            int actual = BestTimeToBuyAndSellProb.MaxProfit(input);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ShouldBeEqual_OneNumber()
        {
            int[] input = new[] { 7 };
            int expected = 0;
            int actual = BestTimeToBuyAndSellProb.MaxProfit(input);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ShouldBeEqual_OnlyFalling()
        {
            int[] input = new[] { 7, 6, 5 };
            int expected = 0;
            int actual = BestTimeToBuyAndSellProb.MaxProfit(input);
            Assert.Equal(expected, actual);
        }
    }
}
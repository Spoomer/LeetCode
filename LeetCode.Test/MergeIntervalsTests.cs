namespace LeetCode.Test;

public class MergeIntervalsTests
{
    [Fact]
    public void MergeTest1()
    {
        int[][] intervals = new int[3][];
        intervals[0] = new[] {1, 3};
        intervals[1] = new[] {2, 6};
        intervals[2] = new[] {8, 10};
        var result = MergeIntervals.Merge(intervals);
        Assert.Equal(1,result[0][0]);
        Assert.Equal(6,result[0][1]);
        Assert.Equal(8,result[1][0]);
    }
}
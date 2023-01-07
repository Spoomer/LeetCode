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
    [Fact]
    public void MergeTest2()
    {
        int[][] intervals = new int[2][];
        intervals[0] = new[] {1, 4};
        intervals[1] = new[] {0, 4};
        var result = MergeIntervals.Merge(intervals);
        Assert.Equal(0,result[0][0]);
        Assert.Equal(4,result[0][1]);
    }
    [Fact]
    public void MergeTest3()
    {
        int[][] intervals = new int[3][];
        intervals[0] = new[] {1, 4};
        intervals[1] = new[] {0, 5};
        intervals[2] = new[] {0, 4};
        var result = MergeIntervals.Merge(intervals);
        Assert.Equal(0,result[0][0]);
        Assert.Equal(5,result[0][1]);
    }
    [Fact]
    public void MergeTest4()
    {
        int[][] intervals = new int[2][];
        intervals[0] = new[] {1, 4};
        intervals[1] = new[] {4, 5};
        var result = MergeIntervals.Merge(intervals);
        Assert.Equal(1,result[0][0]);
        Assert.Equal(5,result[0][1]);
    }
    [Fact]
    public void MergeTest5()
    {
        int[][] intervals = new int[2][];
        intervals[0] = new[] {6, 7};
        intervals[1] = new[] {1, 6};
        var result = MergeIntervals.Merge(intervals);
        Assert.Equal(1,result[0][0]);
        Assert.Equal(7,result[0][1]);
    }
    [Fact]
    public void MergeTest6()
    {
        int[][] intervals = new int[2][];
        intervals[0] = new[] {1, 2};
        intervals[1] = new[] {3, 4};
        var result = MergeIntervals.Merge(intervals);
        Assert.Equal(1,result[0][0]);
        Assert.Equal(2,result[0][1]);
        Assert.Equal(3,result[1][0]);
        Assert.Equal(4,result[1][1]);
    }

    [Fact]
    public void MergeTest7()
    {
        int[][] intervals = new int[5][];
        intervals[0] = new[] {2, 3};
        intervals[1] = new[] {4, 5};
        intervals[2] = new[] {6, 7};
        intervals[3] = new[] {8, 9};
        intervals[4] = new[] {1, 10};
        var result = MergeIntervals.Merge(intervals);
        Assert.Equal(1,result[0][0]);
        Assert.Equal(10,result[0][1]);
        Assert.Single(result);
    }
    

    [Fact]
    public void MergeTest8()
    {
        int[][] intervals = new int[4][];
        intervals[0] = new[] {2, 3};
        intervals[1] = new[] {4, 6};
        intervals[2] = new[] {5, 7};
        intervals[3] = new[] {3, 4};
        var result = MergeIntervals.Merge(intervals);
        Assert.Equal(2,result[0][0]);
        Assert.Equal(7,result[0][1]);
        Assert.Single(result);
    }
}
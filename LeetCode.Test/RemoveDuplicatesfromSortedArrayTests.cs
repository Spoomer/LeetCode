namespace LeetCode.Test;

public class RemoveDuplicatesfromSortedArrayTests
{
    [Fact]
    public void RemoveDuplicatesfromSortedArrayTest1()
    {
        int[] values = new int[] { 1 };
        RemoveDuplicatesfromSortedArray sol = new();
        Assert.Equal(1, sol.RemoveDuplicates(values));
        Assert.Equal(new int[] { 1 }, values);

    }
    [Fact]
    public void RemoveDuplicatesfromSortedArrayTest2()
    {
        int[] values = new int[] { 1, 2 };
        RemoveDuplicatesfromSortedArray sol = new();
        int uniques = sol.RemoveDuplicates(values);
        Assert.Equal(2, uniques);
        Assert.Equal(new int[] { 1, 2 }, values[0..uniques]);

    }
    [Fact]
    public void RemoveDuplicatesfromSortedArrayTest3()
    {
        int[] values = new int[] { 1, 1, 2 };
        RemoveDuplicatesfromSortedArray sol = new();
        int uniques = sol.RemoveDuplicates(values);
        Assert.Equal(2, uniques);
        Assert.Equal(new int[] { 1, 2 }, values[0..uniques]);

    }
    [Fact]
    public void RemoveDuplicatesfromSortedArrayTest4()
    {
        int[] values = new int[] { 1, 1, 1, 1, 2 };
        RemoveDuplicatesfromSortedArray sol = new();
        int uniques = sol.RemoveDuplicates(values);
        Assert.Equal(2, uniques);
        Assert.Equal(new int[] { 1, 2 }, values[0..uniques]);

    }
}

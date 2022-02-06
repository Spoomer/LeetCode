namespace LeetCode.Test;

public class SpiralMatrixTests
{
    [Fact]
    public void Check3x3Matrix()
    {
        int[][] matrix = new int[3][];
        matrix[0] = new int[] { 1, 2, 3 };
        matrix[1] = new int[] { 4, 5, 6 };
        matrix[2] = new int[] { 7, 8, 9 };
        IList<int> actual = SpiralMatrixProb.SpiralOrder(matrix);
        List<int> expected = new() { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Check3x4Matrix()
    {
        int[][] matrix = Tools.GetMatrix(3, 4);
        IList<int> actual = SpiralMatrixProb.SpiralOrder(matrix);
        List<int> expected = new() { 0, 1, 2, 3, 7, 11, 10, 9, 8, 4, 5, 6 };
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Check4x3Matrix()
    {
        int[][] matrix = Tools.GetMatrix(4, 3);
        IList<int> actual = SpiralMatrixProb.SpiralOrder(matrix);
        List<int> expected = new() { 0, 1, 2, 5, 8, 11, 10, 9, 6, 3, 4, 7 };
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Check1x1Matrix()
    {
        int[][] matrix = Tools.GetMatrix(1, 1);
        IList<int> actual = SpiralMatrixProb.SpiralOrder(matrix);
        List<int> expected = new() { 0 };
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Check2x2Matrix()
    {
        int[][] matrix = Tools.GetMatrix(2, 2);
        IList<int> actual = SpiralMatrixProb.SpiralOrder(matrix);
        List<int> expected = new() { 0, 1, 3, 2 };
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void CheckEmptyMatrix()
    {
        int[][] matrix = Tools.GetMatrix(2, 2);
        IList<int> actual = SpiralMatrixProb.SpiralOrder(matrix);
        List<int> expected = new() { 0, 1, 3, 2 };
        Assert.Equal(expected, actual);
    }
}

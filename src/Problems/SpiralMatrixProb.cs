namespace LeetCode.Problems;

public class SpiralMatrixProb
{
    public static IList<int> SpiralOrder(int[][] matrix)
    {
        IList<int> result = new List<int>();
        // right matrix[i][+] right.min = 0 right.max=matrix[i].Count
        // down matrix[+][j] down.min = 0 down.max=matrix.count
        // left matrix[i][-] left.min = right.max left.max = right.min
        // up matrix[-][j] up.min = down.max up.max = down.min
        if (matrix.Length == 0)
        {
            return result;
        }
        MaxMin right = new() { Min = 0, Max = matrix[0].Length };
        MaxMin down = new() { Min = 0, Max = matrix.Length };
        while (right.Min< right.Max && down.Min < down.Max)
        {
            for (int i = right.Min; i < right.Max; i++)
            {
                result.Add(matrix[down.Min][i]);
            }
            if(down.Min+1 >= down.Max)
            {
                break;
            }
            for (int j = down.Min + 1; j < down.Max; j++)
            {
                result.Add(matrix[j][right.Max-1]);
            }
            if(right.Max -2 < right.Min)
            {
                break;
            }
            for (int i = right.Max - 2; i >= right.Min; i--)
            {
                result.Add(matrix[down.Max-1][i]);
            }
            if(down.Max -2 <= down.Min)
            {
                break;
            }
            for (int j = down.Max - 2; j > down.Min; j--)
            {
                result.Add(matrix[j][right.Min]);
            }
            right.Min += 1;
            right.Max -= 1;
            down.Min += 1;
            down.Max -= 1;
        }
        return result;
    }

    private struct MaxMin
    {
        public int Max { get; set; }
        public int Min { get; set; }
    }
}

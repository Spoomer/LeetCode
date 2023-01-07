namespace LeetCode.Problems;

public class MergeIntervals
{
    public static int[][] Merge(int[][] intervals)
    {
        List<int[]> result = new();
        result.Add(intervals[0]);
        for (int i = 1; i < intervals.Length; i++)
        {
            int[] current = intervals[i];
            if (i + 1 < intervals.Length)
            {
                int[] next = intervals[i + 1];
                if (current[1] >= next[0])
                {
                    if (result[^1][1] >= current[0])
                    {
                        result[^1][1] = next[1];
                        continue;
                    }
                    result.Add(new[] {current[0], next[1]});
                    continue;
                }
            }

            if (result[^1][1] >= current[0])
            {
                result[^1][1] = current[1];
            }
            else
            {
                result.Add(new[] {current[0], current[1]});
            }
        }

        return result.ToArray();
    }
}
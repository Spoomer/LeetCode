namespace LeetCode.Problems;

public class MergeIntervals
{
    public static int[][] Merge(int[][] intervals)
    {
        var sorted = intervals.OrderBy(x => x[0]).ThenByDescending(x => x[1]);
        List<int[]> result = new();
        foreach (int[] current in sorted)
        {
            if (result.Count == 0)
            {
                result.Add(current);
                continue;
            }
            int[]? foundIntervall = result.Find(resultItem => current[0] <= resultItem[1] && current[0] >= resultItem[0] || resultItem[0] <= current[1] && resultItem[0] >= current[0]);
            if (foundIntervall is null)
            {
                result.Add(current);
                continue;
            }

            foundIntervall[0] = foundIntervall[0] <= current[0]
                ? foundIntervall[0]
                : current[0];
            foundIntervall[1] = foundIntervall[1] >= current[1]
                ? foundIntervall[1]
                : current[1];
            
        }

        return result.ToArray();
        // while (true)
        // {
        //     bool somethingMerge = false;
        //     
        //     result.Add(intervals[0]);
        //     for (int i = 1; i < intervals.Length; i++)
        //     {
        //         int[] current = intervals[i];
        //         int[]? foundIntervall = result.Find(resultItem => current[0] <= resultItem[1] && current[0] >= resultItem[0] || resultItem[0] <= current[1] && resultItem[0] >= current[0]);
        //         if (foundIntervall is null)
        //         {
        //             result.Add(current);
        //             continue;
        //         }
        //
        //         foundIntervall[0] = foundIntervall[0] <= current[0]
        //             ? foundIntervall[0]
        //             : current[0];
        //         foundIntervall[1] = foundIntervall[1] >= current[1]
        //             ? foundIntervall[1]
        //             : current[1];
        //         somethingMerge = true;
        //     }
        //
        //     intervals = result.ToArray();
        //     if (!somethingMerge)
        //     {
        //         return intervals;
        //     }
        // }
    }
}
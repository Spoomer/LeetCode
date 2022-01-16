namespace LeetCode.Problems;

public class ThreeSumProb
{
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        HashSet<IList<int>> result = new(new IntListComparer());
        if (nums.Length < 3) return Array.Empty<IList<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            int j = i + 1;
            int k = nums.Length - 1;
            while (k > j)
            {
                int sum = nums[i] + nums[k] + nums[j];
                if (sum == 0)
                {
                    result.Add(new int[] { nums[i], nums[k], nums[j] });

                }
                if (sum < 0)
                {
                    j++;
                }
                else k--;
            }
        }
        return result.ToArray();

    }

}
public class IntListComparer : IEqualityComparer<IList<int>>
{
    public bool Equals(IList<int>? x, IList<int>? y)
    {
        if (x is null & y is null)
        {
            return true;
        }
        else if (x is null & y is not null)
        {
            return false;
        }
        else if (x is not null & y is null)
        {
            return false;
        }
        else if (x.Count != y.Count)
        {
            return false;
        }
        else
        {
            for (var i = 0; i < x.Count; i++)
            {
                if (x[i] == y[i])
                {
                    continue;
                }
                else return false;
            }
            return true;
        }

    }

    public int GetHashCode(IList<int> obj)
    {
        int hashCode = 0;
        for (var i = 0; i < obj.Count; i++)
        {
            hashCode += i * obj[i];
        }
        return hashCode;
    }
}

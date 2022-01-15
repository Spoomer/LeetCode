namespace LeetCode.Problems;

public class GroupAnagramsProb
{
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, int> indexlist = new();
        List<IList<string>> result = new();
        if (strs.Length == 0)
        {
            result.Add(new List<string>() { "" });
            return result;
        }
        foreach (string str in strs)
        {
            string sortedStr = Tools.SortString(str);
            if (indexlist.TryGetValue(sortedStr, out int i))
            {
                result[i].Add(str);
            }
            else
            {
                result.Add(new List<string>() { str });
                indexlist.Add(sortedStr, result.Count - 1);
            }
        }
        return result;
    }

}

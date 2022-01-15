using System.Text;

namespace LeetCode.Problems;

class LongestCommonPrefixProp
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0 || string.IsNullOrEmpty(strs[0])) return "";

        StringBuilder prefix = new();
        prefix.Append(strs[0][0]);
        bool prefixStillValid = true;
        string lastValidPrefix = "";
        while (prefixStillValid == true)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].StartsWith(prefix.ToString()) == false)
                {
                    prefixStillValid = false;
                    break;
                }
            }
            if (prefixStillValid == true)
            {
                lastValidPrefix = prefix.ToString();
                if (strs[0].Length > prefix.Length)
                {
                    prefix.Append(strs[0].AsSpan(prefix.Length, 1));
                }
                else
                {
                    prefixStillValid = false;
                }

            }

        }

        return lastValidPrefix;



    }
}

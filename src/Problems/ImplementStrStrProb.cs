namespace LeetCode.Problems;

public class ImplementStrStrProb
{
    public int StrStr(string haystack, string needle)
    {
        if (String.IsNullOrEmpty(needle))
        {
            return 0;
        }
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                int end = i + needle.Length;
                if (haystack[i..].Length >= needle.Length && haystack[i..end] == needle)
                {
                    return i;
                }
            }
        }
        return -1;
    }
}

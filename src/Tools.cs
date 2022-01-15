namespace LeetCode;

internal static class Tools
{
    internal static string SortString(string input)
    {
        char[] characters = input.ToArray();
        Array.Sort(characters);
        return new string(characters);
    }
}

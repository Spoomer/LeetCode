using System;
using LeetCode.Problems;
using LeetCode.DataStructures;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestCommonPrefixProp longestCommonPrefixProp = new LongestCommonPrefixProp();
            Console.WriteLine(longestCommonPrefixProp.LongestCommonPrefix(new string[] { "a", ""}));
        }
    }
}

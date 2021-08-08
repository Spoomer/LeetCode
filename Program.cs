using System;
using LeetCode.Problems;
using LeetCode.DataStructures;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new ValidParenthesesProb();
            var result = obj.IsValid("(]");
            var result1 = obj.IsValid("([)]");
            var result2 = obj.IsValid("{[]}");
            var result3 = obj.IsValid("{");
            var result4 = obj.IsValid("}");
        }

    }
}

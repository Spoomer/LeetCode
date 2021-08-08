using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class ValidParenthesesProb
    {
        public bool IsValid(string s)
        {
            Dictionary<char, int> charCounter = new Dictionary<char, int>()
                                                        {
                                                            {'(',0},
                                                            {')',0},
                                                            {'{',0},
                                                            {'}',0},
                                                            {'[',0},
                                                            {']',0},
                                                        };
            for (var i = 0; i < s.Length; i++)
            {
                charCounter[s[i]]++;
            }
        }
    }
}
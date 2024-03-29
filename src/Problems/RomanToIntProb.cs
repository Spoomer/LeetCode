﻿namespace LeetCode.Problems;

class RomanToIntProb
{
    readonly Dictionary<char, int> RomanDic = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    public int RomanToInt(string s)
    {
        int sum = 0;
        int currentInt;
        int lastInt = 0;
        for (int i = 0; i < s.Length; i++)
        {
            currentInt = RomanDic.GetValueOrDefault<char, int>(s[i]);
            if (currentInt > lastInt)
            {
                sum = sum - lastInt * 2 + currentInt;
            }
            else sum += currentInt;
            lastInt = currentInt;
        }
        return sum;
    }


}

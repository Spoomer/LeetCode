using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    class MyAtoiProb
    {
        public int MyAtoi(string s)
        {
            s = s.TrimStart();
            if (s == "") return 0;
            string solution = "";
            if (s[0] == '-' || s[0] == '+')
            {
                if (s[0] == '-') solution += '-';
                s = s[1..];
            }
            for (int i = 0; i < s.Length; i++)
            {

                if (char.IsDigit(s[i]))
                {
                    solution += s[i];
                }
                else break;

            }
            if (solution == "" || solution == "-")
            {
                return 0;
            }
            if (Int32.TryParse(solution, out int solutionInt))
            {
                return solutionInt;
            }
            else
            {
                if ( solution[0] == '-')
                {
                    return Int32.MinValue;
                }
                else return Int32.MaxValue;
            }

        }
    }
}

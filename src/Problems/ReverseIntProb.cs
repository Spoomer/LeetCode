using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    class ReverseIntProb
    {
        public int Reverse(int x)
        {
            bool isNegative = false;
            string numberStr = x.ToString();
            if (numberStr[0] == '-')
            {
                isNegative = true;
                numberStr = numberStr[1..];
            }
            char[] numberChar = numberStr.ToCharArray();
            Array.Reverse(numberChar);
            if (Int32.TryParse(String.Concat(numberChar), out int number) == false)
            {
                return 0;
            }
            if (isNegative)
            {
                number *= -1;
            }
            return number;
        }
    }
}

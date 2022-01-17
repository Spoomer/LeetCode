using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class BestTimeToBuyAndSellProb
    {
        //Kadane Algo
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length < 2) return 0;
            int result = 0;
            int min = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                int diff = prices[i] - min;
                if (diff > result)
                {
                    result = diff;
                }
            }

            return result;
        }
    }
}
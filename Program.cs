using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoSumProb twoSumClass = new TwoSumProb();
            int[] solution = twoSumClass.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            foreach (var item in solution)
            {
                Console.WriteLine(item);
            }
        }
    }
}

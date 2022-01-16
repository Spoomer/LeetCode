namespace LeetCode.Problems
{
    public class MaximumSubarrayProb
    {
        public static int MaxSubArray(int[] nums)
        {
            int max = int.MinValue;
            int n = nums.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += nums[i];
                max = Math.Max(sum, max);

                if (sum < 0) sum = 0;
            }
            return max;
        }
        /* 
        too slow
        public static int MaxSubArray(int[] nums)
        {
            int result = int.MinValue;
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    int sum = nums[i..j].Sum();
                    if (sum > result)
                    {
                        result = sum;
                    }
                }
            }
            return result;
        } */

    }
}
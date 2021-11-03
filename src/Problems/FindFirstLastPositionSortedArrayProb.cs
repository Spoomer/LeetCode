using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Problems
{
    public class FindFirstLastPositionSortedArrayProb
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[] {-1,-1};
            if (nums is null || nums.Length == 0 || nums[0]>target || nums.Last()< target) return result;
            int i = 0;
            int z = nums[nums.Length-1];
            int searchIndex = nums.Length/2;
            bool notFound = true;
            while(notFound)
            {
                if (nums[i]==target)
                {
                    result[0] = i;

                }
                else if (nums[i] < target)
                {
                    i = i + searchIndex;
                }
                else
                {
                    i = i - searchIndex;
                }
            }
            
            
        }
    }
}
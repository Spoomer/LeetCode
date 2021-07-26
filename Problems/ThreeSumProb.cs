using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problems
{
    public class ThreeSumProb
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums.Length < 3) return result;
            Dictionary<string, IList<int>> tripleDic = new Dictionary<string, IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums.Length-1 == j) continue;
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            List<int> temp = new List<int>();
                            temp.Add(nums[i]);
                            temp.Add(nums[j]);
                            temp.Add(nums[k]);
                            temp.Sort();

                            if (tripleDic.ContainsKey(CreateKey(temp)) == false)
                            {
                                tripleDic.Add(CreateKey(temp), temp);
                            }

                        }
                        else continue;
                    }
                    
                    
                    
                }
            }
            return tripleDic.Values.ToList();

        }
        string CreateKey(List<int> intList)
        {
            string result ="";
            foreach (var i in intList)
            {
                result +=$"{i},";
            }
            return result;
        }
    }
}

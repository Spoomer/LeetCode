﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace LeetCode.Problems
{
    public class ThreeSumProb
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            HashSet<IList<int>> result = new HashSet<IList<int>>(new IntListComparer());
            if (nums.Length < 3) return new IList<int>[0];
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;
                while (k > j)
                {
                    int sum = nums[i] + nums[k] + nums[j];
                    if (sum == 0)
                    {
                        result.Add(new int[] { nums[i], nums[k], nums[j] });

                    }
                    if (sum < 0)
                    {
                        j++;
                    }
                    else k--;
                }
            }
            return result.ToArray();

        }

    }
    public class IntListComparer : IEqualityComparer<IList<int>>
    {
        public bool Equals(IList<int> x, IList<int> y)
        {
            if (x is null && y is null == false)
            {
                return false;
            }
            else if (x is null == false && y is null)
            {
                return false;
            }
            else if (x is null && y is null)
            {
                return true;
            }

            if (x.Count != y.Count)
            {
                return false;
            }

            for (var i = 0; i < x.Count; i++)
            {
                if (x[i] == y[i])
                {
                    continue;
                }
                else return false;
            }
            return true;
        }

        public int GetHashCode(IList<int> obj)
        {
            int hashCode = 0;
            for (var i = 0; i < obj.Count; i++)
            {
                hashCode += i * obj[i];
            }
            return hashCode;
        }
    }
}

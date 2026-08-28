using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePrefixSufixSolutions.Easy.RunningSumOf1dArray
{
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            int sum = 0;
            int[] res = new int[nums.Length];

            for (int i=0;i<nums.Length; i++)
            {
                sum += nums[i];
                res[i] = sum; 
            }

            return res;
        }
    }
}

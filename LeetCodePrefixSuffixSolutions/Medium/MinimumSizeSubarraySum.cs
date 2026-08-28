using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePrefixSufixSolutions.Medium.MinimumSizeSubarraySum
{
    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int currentSum = 0;
            int left = 0;
            int minLength = int.MaxValue;


            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];
                while (currentSum >= target)
                {
                    minLength = Math.Min(minLength, i + 1 - left);
                    currentSum -= nums[left];
                    left++;
                }
            }

            return minLength == int.MaxValue ? 0 : minLength;
        }
    }
}

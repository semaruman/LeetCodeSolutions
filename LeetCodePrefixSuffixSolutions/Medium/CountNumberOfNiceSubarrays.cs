using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePrefixSufixSolutions.Medium.CountNumberofNiceSubarrays
{
    public class Solution
    {
        public int NumberOfSubarrays(int[] nums, int k)
        {
            var transformedArray = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                transformedArray[i] = nums[i] % 2;
            }

            int sum = 0;
            int result = 0;

            var dict = new Dictionary<int, int>();
            dict[0] = 1;

            for (int i = 0; i < transformedArray.Length; i++)
            {
                sum += transformedArray[i];

                if (dict.ContainsKey(sum - k))
                {
                    result += dict[sum - k];
                }

                if (dict.ContainsKey(sum))
                {
                    dict[sum]++;
                }
                else
                {
                    dict[sum] = 1;
                }
            }

            return result;
        }
    }
}

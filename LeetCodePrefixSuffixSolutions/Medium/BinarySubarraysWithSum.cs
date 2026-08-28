using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePrefixSufixSolutions.Medium.BinarySubarraysWithSum
{
    public class Solution
    {
        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict[0] = 1;

            int sum = 0;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (dict.TryGetValue(sum - goal, out int value))
                {
                    count += value;
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

            return count;
        }
    }
}

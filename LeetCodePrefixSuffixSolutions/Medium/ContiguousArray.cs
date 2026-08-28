using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePrefixSufixSolutions.Medium.ContiguousArray
{
    public class Solution
    {
        public int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict[0] = -1;

            int maxLength = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    sum += -1;
                }
                else
                {
                    sum += 1;
                }

                if (dict.ContainsKey(sum))
                {
                    maxLength = Math.Max(maxLength, i - dict[sum]);
                }
                else
                {
                    dict[sum] = i;
                }
            }

            return maxLength;
        }
    }
}

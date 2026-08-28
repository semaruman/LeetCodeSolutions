using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePrefixSufixSolutions.Easy.FindPivotIndex
{
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            int prefixSum = 0;
            int suffixSum = 0;
            int n = nums.Length;

            if (n <= 1)
            {
                return 0;
            }

            int[] prefix = new int[n];
            int[] suffix = new int[n];

            for (int i = 0; i < n; i++)
            {
                prefixSum += nums[i];
                suffixSum += nums[n - i - 1];

                prefix[i] = prefixSum;
                suffix[i] = suffixSum;
            }
            //Console.WriteLine(string.Join(" ", nums));
            //Console.WriteLine(string.Join(" ", prefix));
            //Console.WriteLine(string.Join(" ", suffix));

            if (suffix[n - 2] == 0)
            {
                return 0;
            }

            for (int i = 1; i < n - 1; i++)
            {
                if (prefix[i - 1] == suffix[n - i - 2])
                {
                    return i;
                }
            }

            if (prefix[n - 2] == 0)
            {
                return n - 1;
            }

            return -1;
        }
    }
}

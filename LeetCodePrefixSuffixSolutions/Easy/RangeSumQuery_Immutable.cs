using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePrefixSufixSolutions.Easy.RangeSumQuery_Immutable
{
    public class NumArray
    {
        private readonly int[] prefix;
        public NumArray(int[] nums)
        {
            int sum = 0;
            prefix = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                prefix[i] = sum;
            }
        }

        public int SumRange(int left, int right)
        {
            if (left == 0)
            {
                return prefix[right];
            }
            return prefix[right] - prefix[left - 1];
        }
    }
}

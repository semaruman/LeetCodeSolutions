using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePrefixSufixSolutions.Medium.PartitionArrayIntoDisjointIntervals
{
    public class Solution
    {
        public int PartitionDisjoint(int[] nums)
        {
            int n = nums.Length;
            var minFromRigth = new int[n];
            minFromRigth[n - 1] = nums[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                minFromRigth[i] = Math.Min(nums[i], minFromRigth[i + 1]);
            }

            int currentMax = nums[0];
            for (int i = 0; i < n - 1; i++)
            {
                currentMax = Math.Max(currentMax, nums[i]);

                if (currentMax <= minFromRigth[i + 1])
                {
                    return i + 1;
                }
            }

            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTwoPointersSolutions.Medium.RemoveDuplicates
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums.Length;
            }

            int currentPointer = 2;
            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[currentPointer - 2] != nums[i])
                {
                    nums[currentPointer] = nums[i];
                    currentPointer++;
                }
            }

            return currentPointer;
        }
    }
}

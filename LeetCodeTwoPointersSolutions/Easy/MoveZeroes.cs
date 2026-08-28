using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTwoPointersSolutions.Easy.MoveZeroes
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int lastNonZeroPointer = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[lastNonZeroPointer] = nums[i];
                    lastNonZeroPointer++;
                }
            }

            for (int i = lastNonZeroPointer; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTwoPointersSolutions.Medium.SortColors
{
    public class Solution
    {
        public void SortColors(int[] nums)
        {
            int redPointer = 0;
            int bluePointer = nums.Length - 1;
            int currentPointer = 0;

            while (currentPointer <= bluePointer)
            {
                if (nums[currentPointer] == 0)
                {
                    (nums[currentPointer], nums[redPointer]) = (nums[redPointer], nums[currentPointer]);
                    redPointer++;
                    currentPointer++;
                }
                else if (nums[currentPointer] == 1)
                {
                    currentPointer++;
                }
                else
                {
                    (nums[currentPointer], nums[bluePointer]) = (nums[bluePointer], nums[currentPointer]);
                    bluePointer--;
                }
            }
        }
    }
}

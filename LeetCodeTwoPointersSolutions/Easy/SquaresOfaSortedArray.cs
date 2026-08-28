using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTwoPointersSolutions.Easy
{
    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            int[] sortedSquares = new int[nums.Length];
            int pointer = nums.Length - 1;

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                if (nums[left] * nums[left] < nums[right] * nums[right])
                {
                    sortedSquares[pointer] = nums[right] * nums[right];
                    right--;
                }
                else
                {
                    sortedSquares[pointer] = nums[left] * nums[left];
                    left++;
                }
                pointer--;
            }

            return sortedSquares;
        }
    }
}

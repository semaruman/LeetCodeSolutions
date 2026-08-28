using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeBinarySearchSolutions.Medium.FindFirstAndLastPositionOfElementInSortedArray
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) return new int[] { -1, -1 };

            int left = 0;
            int right = nums.Length - 1;
            int leftResult = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2; 

                if (nums[mid] >= target)  
                {
                    if (nums[mid] == target)
                        leftResult = mid;
                    right = mid - 1; 
                }
                else 
                {
                    left = mid + 1;   
                }
            }

            if (leftResult == -1)
                return new int[] { -1, -1 };

            left = 0;
            right = nums.Length - 1;
            int rightResult = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2; 

                if (nums[mid] <= target)  
                {
                    if (nums[mid] == target)
                        rightResult = mid;
                    left = mid + 1; 
                }
                else 
                {
                    right = mid - 1; 
                }
            }

            return new int[] { leftResult, rightResult };
        }
    }
}

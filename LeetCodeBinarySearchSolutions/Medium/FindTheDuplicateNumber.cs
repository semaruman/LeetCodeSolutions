using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeBinarySearchSolutions.Medium.FindTheDuplicateNumber
{
    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            Array.Sort(nums);
            int left, right, mid;
            bool isDuplicate = false;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                left = i + 1;
                right = nums.Length - 1;

                while (left <= right)
                {
                    mid = left + (right - left) / 2;
                    if (nums[i] == nums[mid])
                    {
                        isDuplicate = true;
                        break;
                    }
                    else if (nums[i] < nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1; 
                    }
                }
                
                if (isDuplicate)
                {
                    return nums[i];
                }
            }

            return -1;
        }
    }
}

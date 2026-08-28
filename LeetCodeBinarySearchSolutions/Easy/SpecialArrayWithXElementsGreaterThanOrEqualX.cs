using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeBinarySearchSolutions.Easy.SpecialArrayWithXElementsGreaterThanOrEqualX
{
    public class Solution
    {
        public int SpecialArray(int[] nums)
        {
            Array.Sort(nums); 
            int n = nums.Length;

            for (int x = 0; x <= n; x++)
            { 
                int left = 0, right = n - 1;
                int firstIndex = n; 

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (nums[mid] >= x)
                    {
                        firstIndex = mid;
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                int count = n - firstIndex;
                if (count == x)
                {
                    return x;
                }
            }

            return -1;
        }
    }
}

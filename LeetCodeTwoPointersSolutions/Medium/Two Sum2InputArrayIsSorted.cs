using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTwoPointersSolutions.Medium.TwoSum2InputArrayIsSorted
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            int sum = 0;

            while (left < right)
            {
                sum = numbers[left] + numbers[right];
                if (sum > target)
                {
                    right--;
                }
                else if ( sum < target)
                {
                    left++;
                }
                else
                {
                    return new int[] {  left + 1, right + 1 };
                }
            }

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTwoPointersSolutions.Medium.ThreeSumClosest
{
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int left;
            int rigth;
            int resSum = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < nums.Length - 2; i++)
            {
                left = i + 1;
                rigth = nums.Length - 1;

                while (left < rigth)
                {
                    int sum = nums[i] + nums[left] + nums[rigth];
                    if (sum == target)
                        return target;

                    if (Math.Abs(sum - target) < Math.Abs(resSum - target))
                    {
                        resSum = sum;
                    }

                    if (sum < target)
                    {
                        left++;
                    }
                    else if (sum > target)
                    {
                        rigth--;
                    }

                }
            }

            return resSum;
        }
    }
}

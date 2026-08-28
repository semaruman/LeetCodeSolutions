using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeArraySolutions.Easy.RemoveElement
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val) //easy
        {
            int k = 0;
            for (int i=0; i<nums.Length; i++ )
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}

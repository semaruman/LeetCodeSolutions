using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeHashTableSolutions.Medium.SubarraySumEqualsK
{
    public class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            var prefixCount = new Dictionary<int, int>();
            prefixCount[0] = 1;

            int resCount = 0;
            int currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];

                int neededSum = currentSum - k;

                if (prefixCount.ContainsKey(neededSum))
                {
                    resCount += prefixCount[neededSum];
                }

                prefixCount[currentSum] = prefixCount.GetValueOrDefault(currentSum, 0) + 1;
            }

            return resCount;
        }
    }
}

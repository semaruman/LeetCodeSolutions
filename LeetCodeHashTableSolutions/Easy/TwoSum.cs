using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeHashTableSolutions.Easy.TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dictNums = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dictNums[nums[i]] = i;
            }

            for (int i = 0; i< nums.Length; i++)
            {
                if (dictNums.TryGetValue(target - nums[i], out int index))
                {
                    if (index == i)
                    {
                        continue;
                    }
                    return new int[] {i, index};
                }
            }
            return null;
        }
    }
}

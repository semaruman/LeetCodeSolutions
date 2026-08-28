using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeHashTableSolutions.Easy.MajorityElement
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            int candidate = nums[0];
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                }

                count += (candidate == nums[i] ? 1 : -1);
            }
            return candidate;
        }

        /*
        public int MajorityElement(int[] nums)
        {
            var map = new Dictionary<int, int>();
            int majorityElement = -1;
            int majorityCount = 0;

            for (int i=0;i<nums.Length;i++)
            {
                int currentNumber = nums[i];
                if (!map.ContainsKey(currentNumber))
                {
                    map[currentNumber] = 0;
                }
                map[currentNumber]++;

                if (map[currentNumber] > majorityCount)
                {
                    majorityElement = currentNumber;
                    majorityCount = map[currentNumber];
                }
            }

            return majorityElement;
        }
        */
    }
}

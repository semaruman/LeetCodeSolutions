using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeHashTableSolutions.Medium.TopKFrequentElements
{
    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = 0;
                }
                dict[nums[i]]++;
            }
            var keys = dict.Keys.ToArray();
            Array.Sort(keys, (x, y) => dict[y].CompareTo(dict[x]));

            return keys.Take(k).ToArray();
        }
    }
}

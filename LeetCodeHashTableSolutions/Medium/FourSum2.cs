using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeHashTableSolutions.Medium.FourSum2
{
    public class Solution
    {
        public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            int n = nums1.Length;
            var dict1 = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int sum = nums1[i] + nums2[j];

                    dict1[sum] = dict1.GetValueOrDefault(sum) + 1;
                }
            }

            int resCounter = 0;
            for (int k = 0; k < n; k++)
            {
                for (int l = 0; l < n; l++)
                {
                    int sum = nums3[k] + nums4[l];
                    if (dict1.TryGetValue(-sum, out int count))
                    {
                        resCounter += count;
                    }        
                }
            }

            return resCounter;
        }
    }
}

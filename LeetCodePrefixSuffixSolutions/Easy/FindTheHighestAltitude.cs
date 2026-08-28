using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePrefixSufixSolutions.Easy.FindTheHighestAltitude
{
    public class Solution
    {
        public int LargestAltitude(int[] gain)
        {
            int max = 0;
            int sum = 0;

            for (int i = 0; i < gain.Length; i++)
            {
                sum += gain[i];
                if (sum > max)
                {
                    max = sum;
                }
            }

            return max;
        }
    }
}

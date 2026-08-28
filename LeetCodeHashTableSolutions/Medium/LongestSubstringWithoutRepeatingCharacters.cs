using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeHashTableSolutions.Medium.LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var dict = new Dictionary<char, int>();
            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char currentChar = s[right];

                if (dict.ContainsKey(currentChar) && dict[currentChar] >= left)
                {
                    left = dict[currentChar] + 1;
                }
                dict[currentChar] = right;

                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}

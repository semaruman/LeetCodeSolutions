using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTwoPointersSolutions.Medium.MinimumLengthOfStringAfterDeletingSimilarEnds
{
    public class Solution
    {
        public int MinimumLength(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right && s[left] == s[right])
            {
                char c = s[left];

                while (left <= right && s[left] == c)
                {
                    left++;
                }
                while (left <= right && s[right] == c)
                {
                    right--;
                }
            }

            return right - left + 1;
        }
    }
}

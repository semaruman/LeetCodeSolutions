using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTwoPointersSolutions.Easy.ValidPalindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }

                while (left < right && !char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        //простое решение без оптимизации (18 ms | Beats 54.91%)
        /*
        public bool IsPalindrome(string s)
        {
            string str = new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
        */
    }
}

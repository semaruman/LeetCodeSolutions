using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTwoPointersSolutions.Easy.AssignCookies
{
    public class Solution
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            int cookiePointer = 0;
            int childPointer = 0;

            while (cookiePointer < s.Length && childPointer < g.Length)
            {
                if (s[cookiePointer] >= g[childPointer])
                {
                    childPointer++;
                }
                cookiePointer++;
            }

            return childPointer;
        }
    }
}

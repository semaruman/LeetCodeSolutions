using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeBinarySearchSolutions.Easy.FirstBadVersion
{
    public class VersionControl
    {
        public bool IsBadVersion(int version)
        {
            return true;
        }
    }

    /* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */
    public class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            int mid;
            while (left < right)
            {
                mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }
    }
}

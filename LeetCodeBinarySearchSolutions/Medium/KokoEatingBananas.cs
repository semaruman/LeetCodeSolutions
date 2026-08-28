using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeBinarySearchSolutions.Medium.KokoEatingBananas
{
    public class Solution
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            int left = 0;
            int right = piles.Max();
            int mid;

            while (left < right)
            {
                mid = left + (right - left) / 2;

                if (CanEat(piles, h, mid))
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
        public static bool CanEat(int[] piles, int h, int k)
        {
            double totalHours = 0;
            foreach (int pile in piles)
            {
                totalHours += Math.Ceiling(1.0 * pile / k);
                if (totalHours > h)
                {
                    return false;
                }
            }

            return totalHours <= h;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeBinarySearchSolutions.Easy.GuessNumberHigherOrLower
{
    /** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */
    public class GuessGame
    {
        public int guess(int num)
        {
            return 0;
        }
    }

    public class Solution : GuessGame
    {
        public int GuessNumber(int n)
        {
            int left = 1;
            int right = n;
            int mid;

            while (left <= right)
            {
                mid = left + (right - left) / 2;

                if (guess(mid) == 0)
                {
                    return mid;
                }
                else if (guess(mid) < 0)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return 0;
        }
    }
}

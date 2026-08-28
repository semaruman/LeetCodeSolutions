using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeBinarySearchSolutions.Medium.Search2DMatrix
{
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int m = matrix[0].Length;
            int left = 0;
            int right = matrix.Length * m - 1;
            int mid;

            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (matrix[mid / m][mid%m] == target)
                {
                    return true;
                }
                if (matrix[mid / m][mid % m] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return false;
        }
    }
}

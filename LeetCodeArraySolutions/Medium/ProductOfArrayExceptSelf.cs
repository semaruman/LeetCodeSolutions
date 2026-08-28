using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeArraySolutions.Medium.ProductOfArrayExceptSelf
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            /*
            алгоритм:
            1) заполняю массив префиксов (произведение всех левых элементов,  не включая текущий)
            2) заполняю массив суффиксов (произведение всех правых элементов,  не включая текущий)
            */

            int[] prefix = new int[nums.Length];
            prefix[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                prefix[i] = prefix[i - 1] * nums[i - 1];
            }

            int[] suffix = new int[nums.Length];
            suffix[nums.Length - 1] = 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                suffix[i] = suffix[i + 1] * nums[i + 1];
            }

            int[] answer = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                answer[i] = prefix[i] * suffix[i];
            }

            return answer;
        }
    }
}

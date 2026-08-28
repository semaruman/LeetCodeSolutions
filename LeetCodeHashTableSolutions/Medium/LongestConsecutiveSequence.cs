using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeHashTableSolutions.Medium.LongestConsecutiveSequence
{
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            var set = new HashSet<int>(nums);
            int longest = 0;
            foreach (int number in set)
            {
                //если текущее число - не начало последовательности
                if (!set.Contains(number - 1))
                {
                    int currentNumber = number + 1;
                    int currentLength = 1;

                    while (set.Contains(currentNumber))
                    {
                        currentLength++;
                        currentNumber++;
                    }

                    longest = Math.Max(longest, currentLength);
                }
            }

            return longest;
        }
    }
}

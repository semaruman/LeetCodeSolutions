using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeArraySolutions.Easy.LongestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs) //easy level
        {
            string etalon = strs[0];

            for (int i = 0; i < etalon.Length; i++)
            {
                char currentChar = etalon[i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j].Length <= i || strs[j][i] != currentChar)
                    {
                        return etalon.Substring(0, i);
                    }
                }
            }
            return etalon;
        }
    }
}

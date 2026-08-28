using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeStackQueueSolutions.Easy.RemoveOutermostParentheses
{
    public class Solution
    {
        public string RemoveOuterParentheses(string s)
        {
            int balance = 0;
            var res = new StringBuilder();

            foreach (char c in s)
            {
                if (c == '('){
                    if (balance > 0)
                    {
                        res.Append('(');
                    }
                    balance++;
                }
                else
                {
                    balance--;
                    if (balance > 0)
                    {
                        res.Append(')');
                    }
                }
            }

            return res.ToString();
        }
    }
}

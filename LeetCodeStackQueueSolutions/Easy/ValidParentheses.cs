using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeStackQueueSolutions.Easy.ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s.Length < 2) return false;

            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (!stack.TryPop(out char popC))
                    {
                        return false;
                    }
                    
                    if (c == ')' && popC == '(')
                    {
                        continue;
                    }
                    else if (c == '}' && popC == '{')
                    {
                        continue;
                    }
                    else if (c == ']' && popC == '[')
                    {
                        continue;
                    }
                    return false;
                }             
            }

            if (stack.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}

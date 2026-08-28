using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeStackQueueSolutions.Medium.SimplifyPath
{
    public class Solution
    {
        public string SimplifyPath(string path)
        {
            var arr = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<string>();


            foreach (string item in arr)
            {
                if (item == ".")
                {
                    continue;
                }
                else if (item == "..")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(item);
                }
            }

            if (stack.Count == 0)
            {
                return "/";
            }

            var result = new StringBuilder();

            var tempStack = new Stack<string>();
            while (stack.Count > 0)
            {
                tempStack.Push(stack.Pop());
            }

            while (tempStack.Count > 0)
            {
                result.Append('/').Append(tempStack.Pop());
            }

            return result.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeStackQueueSolutions.Easy.BaseballGame
{
    public class Solution
    {
        public int CalPoints(string[] operations)
        {
            var stack = new Stack<int>();

            foreach (string operation in operations)
            {
                if (int.TryParse(operation, out int number))
                {
                    stack.Push(number);
                }
                else if (operation == "+")
                {
                    int num = stack.Pop();
                    int sum = stack.Peek() + num;
                    stack.Push(num);
                    stack.Push(sum);
                }
                else if (operation == "D")
                {
                    stack.Push(stack.Peek() * 2);
                }
                else if (operation == "C")
                {
                    stack.Pop();
                }
            }

            int resSum = 0;
            while (stack.Count > 0)
            {
                resSum += stack.Pop();
            }

            return resSum;
        }
    }
}

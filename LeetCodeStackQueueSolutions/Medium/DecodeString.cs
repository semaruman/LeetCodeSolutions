using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeStackQueueSolutions.Medium.DecodeString
{
    public class Solution
    {
        public string DecodeString(string s)
        {
            var strStack = new Stack<string>();
            var numStack = new Stack<int>();

            string currentStr = "";
            int currentNumber = 0;

            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    currentNumber = currentNumber * 10 + (c - '0');
                }
                else if (char.IsLetter(c))
                {
                    currentStr += c;
                }
                else if (c == '[')
                {
                    strStack.Push(currentStr);
                    numStack.Push(currentNumber);

                    currentStr = "";
                    currentNumber = 0;
                }
                else if (c == ']')
                {
                    int repeatCount = numStack.Pop();
                    string str = strStack.Pop();

                    currentStr = str + string.Concat(Enumerable.Repeat(currentStr, repeatCount));
                }
            }

            return currentStr;
        }
    }
}

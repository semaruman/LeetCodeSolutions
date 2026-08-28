using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeStackQueueSolutions.Medium.MinStack
{
    public class MinStack
    {
        private Stack<int[]> minStack;
        public MinStack()
        {
            minStack = new Stack<int[]>();
        }

        public void Push(int val)
        {
            if (minStack.Count > 0)
            {
                minStack.Push(new int[] {val, Math.Min(val, minStack.Peek()[1])});
            }
            else
            {
                minStack.Push(new int[] { val, val });
            }
        }

        public void Pop()
        {
            minStack.Pop();
        }

        public int Top()
        {
            return minStack.Peek()[0];
        }

        public int GetMin()
        {
            return minStack.Peek()[1];
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}

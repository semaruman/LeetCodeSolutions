using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeStackQueueSolutions.Easy.ImplementStackUsingQueues
{
    public class MyStack
    {
        private Queue<int> mainQueue;
        private Queue<int> secondaryQueue;
        public MyStack()
        {
            mainQueue = new Queue<int>();
            secondaryQueue = new Queue<int>();
        }

        public void Push(int x)
        {
            secondaryQueue.Enqueue(x);
            while (mainQueue.Count > 0)
            {
                secondaryQueue.Enqueue(mainQueue.Dequeue());
            }
            var temp = mainQueue;
            mainQueue = secondaryQueue;
            secondaryQueue = temp;
        }

        public int Pop()
        {
            return mainQueue.Dequeue();
        }

        public int Top()
        {
            return mainQueue.Peek();
        }

        public bool Empty()
        {
            return mainQueue.Count == 0;
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}

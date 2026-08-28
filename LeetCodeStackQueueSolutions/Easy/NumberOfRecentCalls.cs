using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeStackQueueSolutions.Easy.NumberOfRecentCalls
{
    public class RecentCounter
    {
        private Queue<int> _recentCalls;
        public RecentCounter()
        {
            _recentCalls = new Queue<int>();
        }

        public int Ping(int t)
        {
            _recentCalls.Enqueue(t);
            int firstLen = _recentCalls.Count;

            int oldRequestsCount = 0;
            while (_recentCalls.Peek() < t - 3000)
            {
                _recentCalls.Dequeue();
                oldRequestsCount++;
            }

            return firstLen - oldRequestsCount;
        }
    }

    /**
     * Your RecentCounter object will be instantiated and called as such:
     * RecentCounter obj = new RecentCounter();
     * int param_1 = obj.Ping(t);
     */
}

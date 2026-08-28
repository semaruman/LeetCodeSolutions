using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeStackQueueSolutions.Easy.NumberOfStudentsUnableToEatLunch
{
    public class Solution
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            int attempts = 0;
            var sandwichesStack = new Stack<int>();
            for (int i = sandwiches.Length - 1; i >= 0; i--)
            {
                sandwichesStack.Push(sandwiches[i]);
            }

            var studentsQueue = new Queue<int>(students);

            while (studentsQueue.Count > 0 && attempts < studentsQueue.Count)
            {
                if (studentsQueue.Peek() == sandwichesStack.Peek())
                {
                    attempts = 0;
                    studentsQueue.Dequeue();
                    sandwichesStack.Pop();
                }
                else
                {
                    studentsQueue.Enqueue(studentsQueue.Dequeue());
                    attempts++;
                }
            }

            return studentsQueue.Count;
        }
    }
}

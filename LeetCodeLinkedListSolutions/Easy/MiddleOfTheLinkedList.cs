using LeetCodeLinkedListSolutions.Easy.ConvertBinaryNumberInALinkedListToInteger;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLinkedListSolutions.Easy.MiddleOfTheLinkedList
{
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            var fast = head;
            var slow = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLinkedListSolutions.Medium.RemoveNthNodeFromEndOfList
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var dummy = new ListNode(0, head);
            var fast = dummy;
            var slow = dummy;

            for (int i = 0; i < n + 1; i++)
            {
                fast = fast.next;
            }

            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;

            return dummy.next;
        }
    }
}

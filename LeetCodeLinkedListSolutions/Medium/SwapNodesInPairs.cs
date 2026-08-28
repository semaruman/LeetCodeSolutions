using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLinkedListSolutions.Medium.SwapNodesInPairs
{
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode current = new ListNode(0, head);
            head = current;

            while (current.next != null && current.next.next != null)
            {
                var first = current.next;
                var second = current.next.next;

                first.next = second.next;
                second.next = first;
                current.next = second;

                current = first;
            }

            return head.next;
        }
    }
}

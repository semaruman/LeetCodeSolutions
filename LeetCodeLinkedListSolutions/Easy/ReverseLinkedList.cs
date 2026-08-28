using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLinkedListSolutions.Easy.ReverseLinkedList
{
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;
            ListNode next = null;
            
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;

                current = next;
            }

            return prev;
        }
    }
}

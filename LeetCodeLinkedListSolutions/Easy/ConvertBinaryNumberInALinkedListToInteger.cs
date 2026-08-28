using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLinkedListSolutions.Easy.ConvertBinaryNumberInALinkedListToInteger
{
    /**
 * Definition for singly-linked list.
 * 
 */
    
    public class Solution
    {
        public int GetDecimalValue(ListNode head)
        {
            StringBuilder sb = new StringBuilder();

            while (head != null)
            {
                sb.Append(head.val);
                head = head.next;
            }

            return Convert.ToInt32(sb.ToString(), 2);
        }
    }
}

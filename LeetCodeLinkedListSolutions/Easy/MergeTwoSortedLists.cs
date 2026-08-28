using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLinkedListSolutions.Easy.MergeTwoSortedLists
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode res = new ListNode();
            ListNode head = res;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    res.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    res.next = list2;
                    list2 = list2.next;
                }
                res = res.next;
            }

            if (list1 != null)
            {
                res.next = list1;
            }
            else
            {
                res.next = list2;
            }

            return head.next;
        }
    }
}

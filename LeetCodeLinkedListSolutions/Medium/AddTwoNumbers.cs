using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeLinkedListSolutions.Medium.AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode number = new ListNode();
            ListNode numberHead = number;

            int advantage = 0;
            int currentNumber = 0;

            while (l1 != null || l2 != null || advantage != 0)
            {
                currentNumber = advantage;

                if (l1 != null)
                {
                    currentNumber += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    currentNumber += l2.val;
                    l2 = l2.next;
                }

                advantage = currentNumber / 10;
                currentNumber = currentNumber % 10;

                number.next = new ListNode(currentNumber);
                number = number.next;
            }

            return numberHead.next;
        }
    }
}

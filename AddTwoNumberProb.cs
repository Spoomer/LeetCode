using System;
using System.Collections.Generic;

namespace LeetCode
{
    class AddTwoNumberProb
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int l1Int = GetNumber(l1);
            int l2Int = GetNumber(l2);
            int solution = l1Int + l2Int;
            return GetLinkedList(solution);
            
        }

        int GetNumber(ListNode listNode)
        {
            int listNodeInt = 0;
            double pot10 = 0;
            ListNode currentNode = listNode;
            do
            {
                listNodeInt += (int)(currentNode.val * Math.Pow(10,pot10));
                pot10 += 1;
                currentNode = currentNode.next;
            } while (currentNode is null == false);
            return listNodeInt;
        }
        ListNode GetLinkedList(int number)
        {
            int rest = number;
            int[] digits = new int[number.ToString().Length];
            while (rest > 0)
            {
                int pot10 = (int)Math.Log10(rest);
                int baseNumber = (int)(rest / Math.Pow(10, pot10));
                digits[pot10] = baseNumber;
                rest -= (int)(baseNumber * Math.Pow(10, pot10));
            }

            return GetListNode(digits);
        }
        ListNode GetListNode(int[] digits)
        {
            ListNode firstNode = new ListNode();
            ListNode currentNode = firstNode;
            for (int i = 0; i < digits.Length - 1; i++)
            {
                currentNode.val = digits[i];
                currentNode.next = new ListNode();
                currentNode = currentNode.next;
            }
            currentNode.val = digits[digits.Length - 1];

            return firstNode;
        }
    }

}

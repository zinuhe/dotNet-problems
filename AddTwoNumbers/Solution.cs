using System;
using System.Numerics;

namespace Problems.AddTwoNumbers
{
    public class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add Two Numbers!");

            ListNode list1Node3 = new ListNode(1);
            ListNode list1Node2 = new ListNode(0);
            ListNode list1Node1 = new ListNode(0, list1Node2);
            list1Node2.next = list1Node3;

            ListNode list2Node3 = new ListNode(2);
            ListNode list2Node2 = new ListNode(0);
            ListNode list2Node1 = new ListNode(0, list2Node2);
            list2Node2.next = list2Node3;

            var solution = new Solution();
            var result = solution.AddTwoNumbers(list1Node1, list2Node1);
            Console.WriteLine("Result: " + result.val
                                + result.next.val
                                + result.next.next.val);
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string number1 = GetNumberFromList(l1);
            string number2 = GetNumberFromList(l2);
            string strNumber = (BigInteger.Parse(number1) + BigInteger.Parse(number2)).ToString();

            //Create new ListNode with the new value
            char[] arrayNumber = strNumber.ToCharArray();

            ListNode head = new ListNode(int.Parse(arrayNumber[0].ToString()));
            for (int c = 1; c < arrayNumber.Length; c++)
            {
                ListNode node = new ListNode(int.Parse(arrayNumber[c].ToString()));
                node.next = head;
                head = node;
            }

            return head;
        }

        public string GetNumberFromList(ListNode lnkList)
        {
            var head = lnkList;
            string number = string.Empty;
            while (head != null) //going through the linked list
            {
                number += head.val;
                head = head.next;
            }

            return ReverseString(number);
        }

        public string ReverseString(string source)
        {
            char[] charArray = source.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}


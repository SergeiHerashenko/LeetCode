/*
 * You are given two non-empty linked lists representing two non-negative integers. 
 * The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
 * You may assume the two numbers do not contain any leading zero, except the number 0 itself.
 *   
 * Example 1:
 * Input: l1 = [2,4,3], l2 = [5,6,4]
 * Output: [7,0,8]
 * Explanation: 342 + 465 = 807.
 *
 * Example 2:
 * Input: l1 = [0], l2 = [0]
 * Output: [0]
 * 
 * Example 3:
 * Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
 * Output: [8,9,9,9,0,0,0,1]
*/
using System;

namespace Add_Two_Numbers
{
    internal class Program
    {
        // Represents a node in a linked list
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null) 
            {
                this.val = val;
                this.next = next;
            }
        }

        // Adds two numbers represented as linked lists and returns the result as a linked list
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // Create a new linked list
            ListNode list = new ListNode(0);
            ListNode curr = list;

            int remainder = 0;

            // Loop until both lists have been traversed and there is no remainder
            while (l1 != null || l2 != null || remainder != 0)
            {
                // Get the value of each node or use 0 if the node is null
                int x;
                if (l1 != null)
                {
                    x = l1.val;
                }
                else
                {
                    x = 0;
                }

                int y;
                if (l2 != null)
                {
                    y = l2.val;
                }
                else
                {
                    y = 0;
                }

                // Add the two values and any remainder from the previous sum
                int sum = remainder + x + y;
                remainder = sum / 10;

                // Add the sum % 10 as a new node to the result list
                curr.next = new ListNode(sum % 10);
                curr = curr.next;

                // Move to the next node in each list, if it exists
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }

            }

            // Return the next node in the result list (the first node was only used to simplify the code)
            return list.next;
        }

        static void Main(string[] args)
        {
            // Get the two numbers from the user as strings
            Console.Write("Enter first number: ");
            string numberOne = Console.ReadLine();

            Console.Write("Enter second number: ");
            string numberTwo = Console.ReadLine();

            // Convert each number string into a linked list of digits in reverse order
            ListNode l1 = null;
            for (int i = numberOne.Length - 1; i >= 0; i--)
            {
                int digit = numberOne[i] - '0';
                ListNode newNode = new ListNode(digit);
                newNode.next = l1;
                l1 = newNode;
            }

            ListNode l2 = null;
            for (int i = numberTwo.Length - 1; i >= 0; i--)
            {
                int digit = numberTwo[i] - '0';
                ListNode newNode = new ListNode(digit);
                newNode.next = l2;
                l2 = newNode;
            }

            // Add the two numbers represented by the linked lists and get the result as a new linked list
            Program program = new Program();
            ListNode result = program.AddTwoNumbers(l1, l2);

            // Print the result as a list of digits in the correct order
            Console.Write("[");
            while (result != null)
            {
                Console.Write($"{result.val}");
                if(result.next == null)
                {
                    break;
                }
                else
                {
                    Console.Write(", ");
                }
                result = result.next;
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}

/*
 * Given a string s, find the length of the longest substring without repeating characters.
 * 
 * 
 * Example 1:
 * Input: s = "abcabcbb"
 * Output: 3
 * Explanation: The answer is "abc", with the length of 3.
 * 
 * 
 * Example 2:
 * Input: s = "bbbbb"
 * Output: 1
 * Explanation: The answer is "b", with the length of 1.
 * 
 * 
 * Example 3:
 * Input: s = "pwwkew"
 * Output: 3
 * Explanation: The answer is "wke", with the length of 3.
 * Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Substring
{
    internal class Program
    {
        // Method to find length of longest substring without repeating characters
        public int LengthOfLongestSubstring(string s)
        {
            // If string length is 0, then return 0.
            if (s.Length == 0) return 0;
            // If string length is 1, then return 1.
            if (s.Length == 1) return 1;

            // Create two lists: StringSymbol to store the characters of the string, and CountNumber to store the count of characters in each substring
            List<string> StringSymbol = new List<string>();
            List<int> CountNumber = new List<int>();

            // Convert the string s to a list StringSymbol containing its characters
            for (int i = 0; i < s.Length; i++)
            {
                StringSymbol.Add(Convert.ToString(s[i]));
            }

            // While the number of elements in the StringSymbol list is greater than 1
            while (StringSymbol.Count > 1)
            {
                // Select the first element of StringSymbol and store it in myString
                string myString = StringSymbol[0];
                // Select the second element of StringSymbol and store it in Symbol
                string Symbol = StringSymbol[1];

                // Initialize the counter variable to 1
                int counter = 1;

                // While myString does not contain Symbol
                while (!myString.Contains(Symbol))
                {
                    // Increase counter by 1
                    counter++;
                    // Add Symbol to the end of myString
                    myString += Symbol;
                    // If counter equals the number of elements in the StringSymbol list
                    if (counter == StringSymbol.Count)
                    {
                        // Add counter to the end of the CountNumber list
                        CountNumber.Add(counter);
                        // Clear the StringSymbol list
                        StringSymbol.Clear();
                        // Jump to the Found label
                        goto Found;
                    }
                    else
                    {
                        // Otherwise, assign the next element of StringSymbol to Symbol
                        Symbol = StringSymbol[counter];
                    }
                }
                // If myString contains Symbol
                // Add counter to the end of the CountNumber list
                CountNumber.Add(counter);
                // Remove the first element of StringSymbol
                StringSymbol.RemoveAt(0);
            }
        // Found label:
        Found:
            // Return the maximum value in the CountNumber list
            return CountNumber.Max();
        }
        static void Main(string[] args)
        {
            // Prompt the user to enter a string
            Console.Write("Enter a string: ");
            string userString = Console.ReadLine();

            // Create an instance of the Program class
            Program program = new Program();
            // Call the LengthOfLongestSubstring method and store the result in the Max variable
            int Max = program.LengthOfLongestSubstring(userString);

            // Print Max to the console
            Console.WriteLine(Max);
        }
    }
}
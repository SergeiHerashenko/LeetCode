/*Given a string s, return the longest palindromic substring in s.
 * 
 * 
 * Example 1:
 * Input: s = "babad"
 * Output: "bab"
 * Explanation: "aba" is also a valid answer.
 * 
 * 
 * Example 2:
 * Input: s = "cbbd"
 * Output: "bb"
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Palindromic
{
    internal class Program
    {
        // Method for finding the longest palindrome in the given string
        public string LongestPalindrome(string s)
        {
            // Initializing a string variable named "Result" with an empty string
            string Result = "";

            // Initializing an integer variable named "counter" with a value of zero
            int counter = 0;

            // Looping through the input string until it becomes empty
            while (s.Length > 0)
            {
                // Initializing a string variable named "Stroka" with the first character of the input string
                string Stroka = Convert.ToString(s[counter]);
                // Looping through the input string until the end or until the current substring is not a palindrome
                while (counter != s.Length)
                {
                    // Checking if the current substring is a palindrome
                    if (Stroka == new string(Stroka.Reverse().ToArray()))
                    {
                        // If the current substring is a palindrome and its length is greater than the length of the current result,
                        // update the result with the current substring
                        if (Result.Length < Stroka.Length)
                        {
                            Result = Stroka;
                        }
                        // Incrementing the counter and adding the next character to the current substring (if it exists)
                        counter++;
                        if (counter != s.Length)
                        {
                            Stroka += Convert.ToString(s[counter]);
                        }
                    }
                    // If the current substring is not a palindrome, increment the counter and add the next character to the current substring (if it exists)
                    else
                    {
                        counter++;
                        if (counter != s.Length)
                        {
                            Stroka += Convert.ToString(s[counter]);
                        }
                    }
                }

                // Resetting the counter and removing the first character from the input string
                counter = 0;
                s = s.Remove(0, 1);
            }
            // Returning the result
            return Result;
        }
        static void Main(string[] args)
        {
            // Ask the user for a string to search for a palindrome
            Console.Write("Enter a string: ");
            string userString = Console.ReadLine();

            // Create an object of the Program class and call the LongestPalindrome method to find the longest palindromic substring
            Program program = new Program();
            string Result = program.LongestPalindrome(userString);

            // Display the longest palindromic substring
            Console.WriteLine(Result);
        }
    }
}
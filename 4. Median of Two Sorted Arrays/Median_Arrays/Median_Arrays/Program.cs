/*
 * Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
 * The overall run time complexity should be O(log (m+n)).
 * 
 * 
 * Example 1:
 * Input: nums1 = [1,3], nums2 = [2]
 * Output: 2.00000
 * Explanation: merged array = [1,2,3] and median is 2.
 * 
 * 
 * Example 2:
 * Input: nums1 = [1,2], nums2 = [3,4]
 * Output: 2.50000
 * Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
 */
using System;
using System.Globalization;
using System.Linq;

namespace Median_Arrays
{
    internal class Program
    {
        // This method takes two sorted integer arrays as input and returns the median of their merged array
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // Declare variables for the result and the merged array
            double Result;
            int[] ResultArray = nums1.Concat(nums2).ToArray();
            // Sort the merged array in ascending order
            Array.Sort(ResultArray);

            // If the length of the merged array is even, calculate the median by taking the average of the middle two numbers
            if (ResultArray.Length % 2 == 0)
            {
                int i;
                int j;
                i = ResultArray[ResultArray.Length / 2 - 1];
                j = ResultArray[ResultArray.Length / 2];
                Result = ((i + j) / 2.0);
            }
            // If the length of the merged array is odd, the median is the middle number
            else
            {
                Result = ResultArray[ResultArray.Length / 2];
            }
            // Return the calculated median
            return Result;
        }
        static void Main(string[] args)
        {
            // Prompt the user to enter the first array
            Console.Write("Enter first mass: ");
            string[] ArrayFirst = Console.ReadLine().Split(' ');

            // Prompt the user to enter the second array
            Console.Write("Enter second mass: ");
            string[] ArraySecond = Console.ReadLine().Split(' ');

            // Convert the input strings into integer arrays
            int[] ArrayOne = new int[ArrayFirst.Length];
            for(int i = 0; i < ArrayFirst.Length; i++)
            {
                ArrayOne[i] = int.Parse(ArrayFirst[i]);
            }

            int[] ArrayTwo = new int[ArraySecond.Length];
            for (int i = 0; i < ArraySecond.Length; i++)
            {
                ArrayTwo[i] = int.Parse(ArraySecond[i]);
            }

            // Create an instance of the Program class and call the FindMedianSortedArrays method with the two integer arrays
            Program program = new Program();
            double Result = program.FindMedianSortedArrays(ArrayOne, ArrayTwo);

            // Print the calculated median to the console
            Console.WriteLine(Result);
        }
    }
}

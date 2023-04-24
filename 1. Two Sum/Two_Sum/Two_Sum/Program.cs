/*
 * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
 * You can return the answer in any order.
 * 
 * Example 1:
 * Input: nums = [2,7,11,15], target = 9
 * Output: [0,1]
 * Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
 *
 * Example 2:
 * Input: nums = [3,2,4], target = 6
 * Output: [1,2]
 *
 * Example 3:
 * Input: nums = [3,3], target = 6
 * Output: [0,1]
 */
using System;

namespace Two_Sum
{
    internal class Program
    {
        // Method to find two numbers in an array that add up to a target sum
        // Inputs:
        //   nums - an array of integers
        //   target - the target sum of two numbers in the array
        // Returns:
        //   an array of two integers representing the indices of the two numbers in the input array that add up to the target sum
        public int[] TwoSum(int[] nums, int target)
        {
            // Initialize an array to store the indices of the two numbers that add up to the target sum
            int[] result = new int[2];

            // Iterate through every possible pair of numbers in the input array
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    // Check that the current pair of indices are not the same
                    if (i != j)
                    {
                        // Check if the sum of the two numbers at the current pair of indices equals the target sum
                        if (nums[i] + nums[j] == target)
                        {
                            // If the current pair of numbers add up to the target sum, store their indices in the result array
                            result[0] = i;
                            result[1] = j;
                        }
                    }
                }
            }

            // Return the array of indices of the two numbers that add up to the target sum
            return result;
        }

        static void Main(string[] args)
        {
            // Prompt the user to input the array of numbers and the target sum
            Console.Write("Enter the array numbers:");
            string[] ArrayNumber = Console.ReadLine().Split(' ');

            Console.WriteLine("Enter integer target:");
            int target = Convert.ToInt32(Console.ReadLine());

            // Convert the input array of numbers from string to integer and store in a new integer array
            int[] ArrayNumberInt = new int[ArrayNumber.Length];

            for(int i = 0; i < ArrayNumber.Length; i++)
            {
                ArrayNumberInt[i] = Convert.ToInt32(ArrayNumber[i]);
            }

            // Create a new instance of the Program class and call the TwoSum method with the input array of numbers and target sum
            Program program = new Program();

            int[] ResultRwoSum = program.TwoSum(ArrayNumberInt, target);

            // Print the indices of the two numbers in the input array that add up to the target sum
            Console.WriteLine("[{0},{1}]", ResultRwoSum[0], ResultRwoSum[1]);
        }
    }
}
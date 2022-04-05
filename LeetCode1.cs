using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LeetCode1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            // Leetcode 1 Two sum (brute force apprach).   
            // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

            //EX:
            //int[] nums = { 3, 2, 3}; 
            //int target = 6;
            //int[] result = TwoSum(nums, target);
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i); // should return [0, 2]
            //}

            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        result[1] = i;
                        result[0] = j;
                    }
                }
            }
            return result;

            // Another method but returns the string location
            string answer;
            for (int i = 0; i < nums.Length; i++)
            {
                int point = nums[i];
                for (int j = 1; j < nums.Length; j++)
                {
                    if (point + nums[j] == target && i != j)
                    {
                        answer = ($"Array positons: {nums[i]}, {nums[j]} equal the target");
                        //return answer;
                    }
                }
            }
            //return "There is no equal to the target";
        }
    }
}

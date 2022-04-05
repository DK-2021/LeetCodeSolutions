using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class IsArrayDistinct
    {
        // Are there any duplicate numbers in a given array
        public static bool DistinctBoolDictionary(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++) // Put the array into a dictionary checking for duplicates
            {
                if (map.ContainsKey(arr[i])) // Check if dictionary contains [i], add to separate integer as result
                {
                    return true;
                }
                map.Add(arr[i], i);
            }
            return false;
        }
        public static int Distinct(int[] arr) // Same method but returns that actual duplicate
        {
            int result = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++) // Put the array into a dictionary checking for duplicates
            {
                if (map.ContainsKey(arr[i])) // Check if dictionary contains [i], add to separate integer as result
                {
                    result = arr[i];
                }
                else
                {
                    map.Add(arr[i], i);
                }
            }
            return result;
        }
        public static bool isDistinctArray(int[] input) // Brute force
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j] == input[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}

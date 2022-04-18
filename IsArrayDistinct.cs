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
        public bool DistinctBoolDictionary(int[] arr)
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

        // Return an of array of number that is duplicated the most, and how many times
        public int[] MostDistinct(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int,int>();

            // Values added to the array
            foreach(int i in arr)
            {
                if (map.ContainsKey(i))
                {
                    map[i]++;
                }
                else
                {
                    map.Add(i, 1);
                }
            }

            //Finding the most common duplicate
            int duplicate = 0;
            int count = 0;
            foreach(var v in map)
            {
                if(v.Value > count)
                {
                    duplicate = v.Key;
                    count = v.Value;
                }
            }
            int[] DistinctArray = new int[] {duplicate, count};
            return DistinctArray;
        }

        // Returns the actual duplicate alone
        public int Distinct(int[] arr) 
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
        // Brute force
        public bool isDistinctArray(int[] input) 
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

        // Checking string for pairs, return number of pairs only counting a pair once.
        public int HowManyDuplicates(string str)
        {
            //Given a string of characters containing only numbers, return how many duplicated numbers you can find in the sequence.
            //Only return a duplicate pair once.

            Dictionary<char, int> map = new Dictionary<char, int>();
            int count = 0;

            foreach (char c in str)
            {
                if (map.ContainsKey(c))
                {
                    map[c]++;
                    if (map.ContainsValue(2)) // added to optimize method and only use loop for whole process
                    {
                        count++;
                    }
                }
                else
                {
                    map.Add(c, 1);
                }
            }
            // ** Original approach with added loop **

            //foreach(var i in map) // if a number occurs 2 or more times, only count it as 1 pair
            //{
            //    if(i.Value >= 2)
            //    {
            //        count++;
            //    }
            //}
            return count;
        }
    }
}

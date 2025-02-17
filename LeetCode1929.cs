﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LeetCode1929
    {
        // LeetCode #1929. Concatenation of an array.
        // Duplicating an array and making into in one single array.
        public int[] ConcateArray(int[] inputArray)
        {
            int[] result = new int[inputArray.Length * 2];
            for (int i = 0; i < inputArray.Length; i++)
            {
                result[i] = inputArray[i];
            }
            for (int j = 0; j < inputArray.Length; j++)
            {
                result[j + inputArray.Length] = inputArray[j]; // Result - at index position (j + arr.length), the remaining value is copied in.
            }
            return result;
        }
        public string[] CombineTwoArrays(string[] str1, string[] str2)
        {
            string[] finalString = new string[str1.Length + str2.Length];

            for (int i = 0; i < str1.Length; i++)
            {
                finalString[i] = str1[i];
            }
            for (int j = 0; j < str2.Length; j++)
            {
                finalString[str1.Length + j] = str2[j];
            }
            return finalString;
        }
    }
}

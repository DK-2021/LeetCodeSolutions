﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LeetCode2160
    {
        public static int minimumSum(int num)
        {
            // LeetCode #2160 Minimum sum of four digit number after splitting digits
            
            int[] arr = new int[4]; // An array for the digits
            int newNum = 0;

            while (num > 0)
            {
                arr[newNum++] = num % 10; 
                num /= 10; 
            }
            Array.Sort(arr);
            int num1 = arr[0] * 10 + arr[2];
            int num2 = arr[1] * 10 + arr[3];

            return num1 + num2;
        }
    }
}

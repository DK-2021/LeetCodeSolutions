using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LeetCode1480
    {
        //LeetCode #1480. Running sum of 1D array.
        public int[] RunningSum2(int[] arr)
        {
            int[] result = new int[arr.Length];
            int len = arr.Length;

            result[0] = arr[0];
            for (int i = 1; i < len; i++) // Begin the loop at position [1]
            {
                result[i] = arr[i] + result[i - 1]; // Adding the value at position [i] and the previous value
            }
            return result;
        }
    }
}

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
        public static bool isDistinctArray(int[] input)
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

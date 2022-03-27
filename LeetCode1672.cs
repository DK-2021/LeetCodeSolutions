using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LeetCode1672
    {
        // LeetCode #1672.
        // Calculating the highest value from a grid.  Used a multi-dimensional array to find the greatest sum of the two value in each array index.
        public static int Wealthiest(int[,] wealth) // Don't include
        {
            //int[,] wealthArray = new int[,] { { 6, 3 }, { 5, 1 }, { 4, 9 }, { 5, 1 }, { 10, 22 } };
            // 1672
            int gateKeeper = 0;
            int highest = 0;
            int length = wealth.Length / 2;

            for (int i = 0; i <= length - 1; i++)
            {
                int num = wealth[i, 0] + wealth[i, 1];

                if (num >= gateKeeper)
                {
                    highest = num;
                    gateKeeper = num;
                }
            }
            return highest;
        }
    }
}

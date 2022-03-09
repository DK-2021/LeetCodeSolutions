using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class AddingTwoDigits
    {
        //Adding two digits of a given integer together 
        public static int AddTwoDigits(int num)
        {
            int totalSum = 0;

            while (num != 0)
            {
                totalSum = totalSum + num % 10;
                num = num / 10;
            }
            return totalSum;
        }
    }
}

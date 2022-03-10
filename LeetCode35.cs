using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LeetCode35
    {
        public static int SearchInsert(int[] nums, int target)
        {
            //int for while loop
            int indexResult = 0;
            //while loop
            while (indexResult < nums.Length)
            {
                //check if target is equal to current index
                if (target == nums[indexResult])
                {
                    return indexResult;
                }
                else if (target < nums[indexResult]) //check to see if target is less than current index
                {
                    return indexResult;
                }
                indexResult++;
            }
            //return index if target is found, if not found, return index it would be in
            return indexResult;
        }
    }
}

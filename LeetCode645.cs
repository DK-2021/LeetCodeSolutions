using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LeetCode645
    {
        public static int[] FindNumberErrors(int[] nums)
        {
            //LeetCode 645 Set Mistmatch

            HashSet<int> map = new HashSet<int>();
            int dupe = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.Add(nums[i]))
                {
                    dupe = nums[i];
                }
            }
            for (int j = 1; j < nums.Length; j++)
            {
                if (!map.Contains(j))
                {
                    return new int[] { dupe, j };
                }
            }
            return new int[] { dupe, nums.Length };
        }
    }
}

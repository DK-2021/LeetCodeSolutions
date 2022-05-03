using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LeetCode136
    {
        public static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (var i in nums)
            {
                if (map.ContainsKey(i))
                {
                    map[i]++;
                }
                else
                {
                    map[i] = 1;
                }
            }
            foreach (var j in map)
            {
                if (j.Value == 1)
                {
                    return j.Key;
                }
            }
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LeetCode169
    {
        //LeetCode #169.  Find the majority element.
        public static int MajorityElements(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int answer = 0, temp = 0;
            foreach (int value in nums)
            {
                if (map.ContainsKey(value))
                {
                    map[value]++;
                }
                else
                    map.Add(value, 1);
            }
            foreach (KeyValuePair<int, int> num in map)
            {
                if (num.Value > temp)
                {
                    temp = num.Value;
                    answer = num.Key;
                }
            }
            return answer;
        }
    }
}

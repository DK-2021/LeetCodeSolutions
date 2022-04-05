using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class RemoveArrayDuplicates
    {
        public static int[] RemoveDuplicatesToArray(int[] original)
        {
            // Removes duplicates from an array and returns a new array with those duplicates
            Dictionary<int, int> map = new Dictionary<int, int>();
            List<int> list = new List<int>();

            foreach (int l in original)
            {
                if (map.ContainsKey(l))
                {
                    list.Add(l);
                }
                else
                {
                    map.Add(l, 1);
                }
            }
            int[] answer = new int[list.Count];
            int j = 0;
            foreach (var i in list)
            {
                answer[j] = i;
                j++;
            }
            return answer;
        }
    }
}

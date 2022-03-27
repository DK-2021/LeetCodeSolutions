using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LeetCode1859
    {
        //Leetocde #1859. Sorting a string that is tied to a number array. (two ways)
        public static string RestoreString(string s, int[] indices)
        {
            StringBuilder answer = new StringBuilder();
            int counter = 0;
            char[] charArr = s.ToCharArray();
            Dictionary<int, char> dic = new Dictionary<int, char>();

            foreach (var i in indices)
            {
                dic.Add(i, charArr[counter]);
                counter++;
            }

            var ordered = dic.OrderBy(x => x.Key).ToDictionary(x => x.Key);

            foreach (var i in ordered.Values)
            {
                answer.Append(i.Value);
            }

            return answer.ToString();

            char[] arr = new char[s.Length];
            for (int i = 0; i < indices.Length; i++)
            {
                arr[indices[i]] = s[i];
            }
            return new string(arr);
        }

    }
}

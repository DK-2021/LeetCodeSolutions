using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class CheckForAnagram
    {
        // Check if two strings are anagram
        public static bool CheckAnagram(string x, string y)
        {
            char[] ch1 = x.ToLower().ToCharArray();
            char[] ch2 = y.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string newStr1 = new string(ch1);
            string newStr2 = new string(ch2);
            return newStr1.Equals(newStr2, StringComparison.OrdinalIgnoreCase);
        }
    }
}

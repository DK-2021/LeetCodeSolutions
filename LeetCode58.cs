using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LeetCode58
    {
        //58 Length of Last Word 
        public int LengthOfLastWord(string s)
        {
            int count = 0, badInput = 0;

            // Check for bad input
            s = s.Trim();
            if (String.IsNullOrWhiteSpace(s) || int.TryParse(s, out badInput) == true)
            {
                return 0;
            }

            // Make array and store string
            string[] userArray = (s.Split(" "));

            // Find length of last index
            foreach (var i in userArray[userArray.Length - 1])
            {
                count++;
            }
            return count;
        }
    }
}

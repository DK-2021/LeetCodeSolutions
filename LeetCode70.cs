using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LeetCode70
    {
        //Leetcode #70. Length of Last Word
        public int LengthOfLastWord(string userInput)
        {
            int count = 0, badInput = 0;

            // Check for bad input
            userInput = userInput.Trim();
            if (String.IsNullOrWhiteSpace(userInput) || int.TryParse(userInput, out badInput) == true)
            {
                return 0;
            }

            // Make array and store string
            string[] userArray = (userInput.Split(" "));

            // Find length of last index
            foreach (var i in userArray[userArray.Length - 1])
            {
                count++;
            }
            return count;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class CheckPalindrome
    {
        //Checking to see if a word is a Palindrome
        public static bool CheckForPalindrome(string userInput)
        {
            int badInput; // Check for bad input
            userInput = userInput.Trim();
            if (String.IsNullOrWhiteSpace(userInput) || int.TryParse(userInput, out badInput) == true)
            {
                return false;
            }
            string strOne = "";
            StringBuilder createdString = new StringBuilder();

            foreach (var i in userInput) // To account for spaces in a word
            {
                if (i == ' ')
                {
                    continue;
                };
                createdString.Append(i);
            }

            strOne = createdString.ToString();

            int j = strOne.Length - 1;
            for (int i = 0; i < strOne.Length; i++)
            {
                if (strOne[i] != strOne[j])
                {
                    return false;
                }
                j--;
            }
            return true;
        }
    }
}

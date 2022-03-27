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
        public static bool CheckForPalindrome(int userInput)
        {
            //int badInput; // Check for bad input if incoming with a string was allowed
            //userInput = userInput.Trim();
            //if (String.IsNullOrWhiteSpace(userInput) || int.TryParse(userInput, out badInput) == true)
            //{
            //    return false;
            //}

            string num = Convert.ToString(userInput); // To check for an incoming string, just remove this.
            int i = 0;
            int j = num.Length - 1;
            while (i < num.Length) // To check for a string, change num to incoming string argument
            {
                if (num[i] != num[j]) // To check for a string, change num to incoming string argument
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}

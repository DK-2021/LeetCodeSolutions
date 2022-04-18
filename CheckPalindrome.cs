using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class CheckPalindrome
    {
        //Checking to see if an Int is a Palindrome
        public static bool CheckForPalindrome(int userInput)
        {
            // check for length here
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

            // Using a stack to solve a Palindrome
            string input = "reverse"; // added for a string to use
            Stack<char> map = new Stack<char>();
            char[] charArr = new char[input.Length];
            foreach(char c in input) // Place chars from string on the stack
            {
                map.Push(c);
            }
            int p = 0, k = 0;
            while (p < map.Count()) // Popping the chars off the stack.  Auto decrements with the char popping off
            {
                charArr[k] = map.Pop();
                k++;
            }
            var newString = String.Join("", charArr); // Joining the chars to create a new string to compare with
            return newString == input;
        }
        // With String input
        private static bool isPalindrome(string str)
        {
            if (String.IsNullOrWhiteSpace(str) || str.Length < 2)
            {
                return true;
            }

            int i = 0, j = str.Length - 1;

            while (i < str.Length)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
        public static bool SubOptimalPalindromeWithStack(string input)
        {
            // Using a stack to solve a Palindrome
            Stack<char> map = new Stack<char>();

            char[] charArr = new char[input.Length];

            // Place chars from string on the stack
            foreach (char c in input) 
            {
                map.Push(c);
            }
            
            int p = 0, k = 0;
            // Popping the chars off the stack.  Auto decrements with the char popping off
            while (p < map.Count()) 
            {
                charArr[k] = map.Pop();
                k++;
            }

            // Joining the chars to create a new string to compare with
            var newString = String.Join("", charArr); 
            return newString == input;
        }
    }
}

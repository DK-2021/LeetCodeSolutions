using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class ReverseString
    {
        private static string ReverseAString(string str)
        {
            string newString = "";

            // push elements on a stack
            Stack<char> stack = new Stack<char>();

            // new string, pop elements off stack and append onto new string
            foreach (char c in str)
            {
                stack.Push(c);
            }
            int i = 0;
            while (i < stack.Count())
            {
                newString += stack.Pop();
            }
            return newString;
        }
        public static string[] ReverseStringArray(string[] str)
        {
            Stack<string> strStack = new Stack<string>();
            string[] newArr = new string[str.Length];
            foreach (var i in str)
            {
                strStack.Push(i);
            }
            int j = 0, k = 0;
            while (j < strStack.Count)
            {
                newArr[k] = strStack.Pop();
                k++;
            }
            return newArr;
        }
    }
}

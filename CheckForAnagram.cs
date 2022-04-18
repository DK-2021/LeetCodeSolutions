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
        public static bool CheckAnagram(string str, string str2)
        {
            // ** Easy Way **
            //char[] ch1 = x.ToLower().ToCharArray();
            //char[] ch2 = y.ToLower().ToCharArray();
            //Array.Sort(ch1);
            //Array.Sort(ch2);
            //string newStr1 = new string(ch1);
            //string newStr2 = new string(ch2);
            //return newStr1.Equals(newStr2, StringComparison.OrdinalIgnoreCase);

            if (str.Length != str2.Length)
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(str) && String.IsNullOrWhiteSpace(str2))
            {
                return true;
            }

            // converts strings to charArrays for sorting 
            char[] char1 = str.ToLower().ToCharArray();
            char[] char2 = str2.ToLower().ToCharArray();

            // sort the char arrays
            InsertionSort(char1);
            InsertionSort(char2);

            // ** ALT use the compare function for the char arrays || compare indexes
            //return char1.SequenceEqual(char2);

            int i = 0;
            while (i < char1.Length)
            {
                if (char1[i] != char2[i])
                {
                    return false;
                }
                i++;
            }
            return true;

            // Insertion Sort
            static char[] InsertionSort(char[] charArray)
            {
                for (int i = 1; i < charArray.Length; i++)
                {
                    var curredntIndex = charArray[i];
                    var j = i - 1;
                    while (j >= 0 && charArray[j] > curredntIndex)
                    {
                        charArray[j + 1] = charArray[j];
                        j--;
                    }
                    charArray[j + 1] = curredntIndex;
                }
                return charArray;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LeetCode2114
    {
        //Leetcode #2114. Number of words found in string.
        //Split the indexes on the spaces and count the spaces - compare.
        public int MostWordsFound(string[] sentences)
        {
            int result = 0;

            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].Split(" ").Length >= result)
                {
                    result = sentences[i].Split(" ").Length;
                }
            }
            return result;
        }
    }
}

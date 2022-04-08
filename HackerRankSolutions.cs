using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class HackerRankSolutions
    {
        // HackerRank Week 1, Day 1, Question 1.
        public static void PlusMinus(int[] arr)
        {
            int arrLength = arr.Length;

            double countA = 0, countB = 0, countC = 0;

            foreach (var i in arr)
            {
                if (i > 0)
                {
                    countA++;
                }
                else if (i < 0)
                {
                    countB++;
                }
                else
                {
                    countC++;
                }
            }
            Console.WriteLine("{0:N6} - This is the positive ratio", countA / arrLength);
            Console.WriteLine("{0:N6} - This is the positive ratio", countB / arrLength);
            Console.WriteLine("{0:N6} - This is the positive ratio", countC / arrLength);
        }
        
        // HackerRank Week 1, Day 1, Question 2.
        public static void miniMaxSum(List<int> arr)
        {
            int[] answer = arr.ToArray();
            long min = 0, max = 0;
            Array.Sort(answer);

            for (int i = 0; i < answer.Length - 1; i++)
            {
                min += answer[i];
            }
            for (int j = 1; j < answer.Length; j++)
            {
                max += answer[j];
            }

            Console.WriteLine($"{min} {max}");
        }
        // HackerRank Week 1, Day 1, Question 3.
        public static string timeConversion(string s)
        {
            string answer;
            string amPm = s.Substring(s.Length - 2);
            string[] arr = s.Split(':');

            if (amPm == "AM" && arr[0] == "12")
            {
                answer = ($"00:{arr[1]}:{arr[2]}");
                return answer.Remove(answer.Length - 2);
            }
            else if (amPm == "AM" && arr[0] != "12")
            {
                answer = ($"{arr[0]}:{arr[1]}:{arr[2]}");
                return answer.Remove(answer.Length - 2);
            }
            else if (amPm == "PM" && arr[0] == "12")
            {
                answer = ($"{arr[0]}:{arr[1]}:{arr[2]}");
                return answer.Remove(answer.Length - 2);
            }
            else if (amPm == "PM" && arr[0] != "12")
            {
                int newHour = Convert.ToInt32(arr[0]) + 12;
                answer = ($"{newHour}:{arr[1]}:{arr[2]}");
                return answer.Remove(answer.Length - 2);
            }
            return "";
        }
        // HackRank Week 1, Day 2, Question 4.
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            int[] result = new int[queries.Count];

            for (int i = 0; i < queries.Count; i++) //ab
            {
                int count = 0;
                for (int j = 0; j < strings.Count; j++) //ab, ab, abc
                {
                    if (queries[i] == strings[j])
                    {
                        count++;
                        result[i] = count;
                    }
                }
            }

            List<int> answer = result.ToList();
            return answer;
        }
        // HackerRank Week 1, Day 2, Question 5.
        public static int lonelyInteger(List<int> a)
        {
            int result = 0;

            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (var i in a)
            {
                if (map.ContainsKey(i))
                {
                    map[i]++;
                }
                else
                {
                    map[i] = 1;
                }
            }
            var answer = map.Where(x => x.Value == 1);

            foreach (var i in answer)
            {
                result = i.Key;
            }

            return result;
        }
        // HackerRank Pangrams
        public static string pangrams(string s)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            string sLower = s.ToLower();

            foreach (char x in abc)
            {
                if (!sLower.Contains(x))
                {
                    return "not pangram";
                }
            }
            return "pangram";
        }
        // Birthday Cake Candles
        public static int birthdayCakeCandles(List<int> candles)
        {
            int answer = 0;
            int currentGreatest = 0;
            foreach (int i in candles)
            {
                if (i > currentGreatest)
                {
                    currentGreatest = i;
                }
            }
            for (int j = 0; j < candles.Count(); j++)
            {
                if (candles[j] == currentGreatest)
                {
                    answer++;
                }
            }
            return answer;
        }
        // SockMerchant
        public static int sockMerchant(int n, List<int> ar)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int answer = 0;
            int total = 0;

            foreach (var i in ar)
            {
                if (!map.ContainsKey(i))
                {
                    map.Add(i, 1);
                }
                else
                {
                    map[i]++;
                }
            }
            foreach (var k in map)
            {
                if (k.Value >= 2)
                {
                    answer = k.Value / 2;
                    total += answer;

                }
            }
            return total;
        }
        // Grading Students Problem
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> answers = new List<int>();
            foreach (int i in grades)
            {
                if (i < 38 || i % 5 == 0)
                {
                    answers.Add(i);
                }
                else if (i % 5 == 3)
                {
                    answers.Add(i + 2);
                }
                else if (i % 5 == 4 && i >= 10)
                {
                    answers.Add(i + 1);
                }
                else if (i < 10)
                {
                    continue;
                }
                else
                {
                    answers.Add(i);
                }
            }
            return answers;
        }
        // Staircase
        public static void staircase(int n)
        {
            int i = 0, j = 1, k = n;

            while (i < n)
            {
                Console.WriteLine(new String(' ', k - 1) + (new String('#', j)));
                k--;
                i++;
                j++;
            }
        }
    }
}

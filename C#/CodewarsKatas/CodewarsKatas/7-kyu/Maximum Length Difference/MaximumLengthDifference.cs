/*
 * LINK: https://www.codewars.com/kata/5663f5305102699bad000056/train/csharp
 * 
 * You are given two arrays a1 and a2 of strings. Each string is composed with letters from a to z. 
 * Let x be any string in the first array and y be any string in the second array.
 * 
 * Find max(abs(length(x) − length(y)))
 * 
 * If a1 and/or a2 are empty return -1 in each language except in Haskell (F#) where you will return Nothing (None).
 * 
 * Example:
 * a1 = ["hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"]
 * a2 = ["cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"]
 * mxdiflg(a1, a2) --> 13
 * Bash note:
 * input : 2 strings with substrings separated by ,
 * output: number as a string
 */

namespace CodewarsKatas._7_kyu.Maximum_Length_Difference
{
   public class MaximumLengthDifference
    {
        public static int Mxdiflg(string[] a1, string[] a2)
        {
            int result = -1;

            if (a1.Length > 0 || a2.Length > 0)
            {
                List<int> values = new List<int>();

                for (int i = 0; i < a1.Length; i++)
                {
                    for (int j = 0; j < a2.Length; j++)
                    {
                        values.Add(Math.Abs(a1[i].Length - a2[j].Length));
                    }
                }
                
                for (int i = 0; i < values.Count; i++) 
                {
                    if (values[i] > result)
                    {
                        result = values[i];
                    }
                }
            }

            return result;
        }
    }
}

/*
 * LINK: https://www.codewars.com/kata/56a5d994ac971f1ac500003e/train/csharp
 * 
 * You are given an array(list) strarr of strings and an integer k. 
 * Your task is to return the first longest string consisting of k consecutive strings taken in the array.
 * 
 * Examples:
 *  strarr = ["tree", "foling", "trashy", "blue", "abcdef", "uvwxyz"], k = 2
 *  
 *  Concatenate the consecutive strings of strarr by 2, we get:
 *  
 *  treefoling   (length 10)  concatenation of strarr[0] and strarr[1]
 *  folingtrashy ("      12)  concatenation of strarr[1] and strarr[2]
 *  trashyblue   ("      10)  concatenation of strarr[2] and strarr[3]
 *  blueabcdef   ("      10)  concatenation of strarr[3] and strarr[4]
 *  abcdefuvwxyz ("      12)  concatenation of strarr[4] and strarr[5]
 *  
 *  Two strings are the longest: "folingtrashy" and "abcdefuvwxyz".
 *  The first that came is "folingtrashy" so 
 *  longest_consec(strarr, 2) should return "folingtrashy".
 *  
 *  In the same way:
 *  longest_consec(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2) --> "abigailtheta"
 *  n being the length of the string array, if n = 0 or k > n or k <= 0 return "" (return Nothing in Elm, "nothing" in Erlang).
 *  
 *  Note
 *  consecutive strings : follow one after another without an interruption
 */

using System.Collections.Generic;

namespace CodewarsKatas._6_kyu.Consecutive_strings
{
    public class ConsecutiveStrings
    {
        public static string LongestConsec(string[] strarr, int k)
        {
            Console.WriteLine(String.Join(",", strarr));
            Console.WriteLine(k);

            List<string> listWords = new List<string>();
            string result = "";


            if (strarr.Length == 0 || k > strarr.Length || k <= 0)
            {
                return result;
            }

            for (int i = 0; i < strarr.Length; i++)
            {
                string newStr = "";

                if (i == strarr.Length - 1)
                {
                    newStr = strarr[i];
                }
                else
                {
                    for (int j = 0; j < k; j++)
                    {
                        if ( i + j < strarr.Length)
                        {
                            newStr = newStr + strarr[i + j];
                        }
                    }
                }

                listWords.Add(newStr);
            }

            int count = 0;

            for (int i = 0; i < listWords.Count; i++)
            {
                if (listWords[i].Length > count)
                {
                    count = listWords[i].Length;
                    result = listWords[i];
                }
            }

            return result;
        }
    }
}

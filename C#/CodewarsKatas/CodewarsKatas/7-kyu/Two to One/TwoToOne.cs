/*
 * LINK: https://www.codewars.com/kata/5656b6906de340bd1b0000ac/train/csharp
 * 
 * Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.
 * 
 * Examples:
 * a = "xyaabbbccccdefww"
 * b = "xxxxyyyyabklmopq"
 * longest(a, b) -> "abcdefklmopqwxy"
 * 
 * a = "abcdefghijklmnopqrstuvwxyz"
 * longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"
 */

using System.Collections.Generic;

namespace CodewarsKatas._7_kyu.Two_to_One
{
    public class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            string newStr = "";

            List<string> listLetters = new List<string>();

            for (int i = 0; i < s1.Length; i++)
            {
                if (!listLetters.Contains(s1[i].ToString()))
                {
                    listLetters.Add(s1[i].ToString());
                }
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (!listLetters.Contains(s2[i].ToString()))
                {
                    listLetters.Add(s2[i].ToString());
                }
            }

            for (int i = 97; i < 123; i++)
            {
                if (listLetters.Contains(((char)i).ToString()))
                {
                    newStr += ((char)i).ToString();
                }
            }
            return newStr;
        }
    }
}

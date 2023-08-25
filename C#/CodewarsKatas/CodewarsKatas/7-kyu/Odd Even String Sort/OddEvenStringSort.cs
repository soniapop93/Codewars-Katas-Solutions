/*
 * LINK: https://www.codewars.com/kata/580755730b5a77650500010c/train/csharp
 * 
 * Given a string s. You have to return another string such that even-indexed and odd-indexed characters of s are grouped and groups are space-separated 
 * (see sample below)
 * 
 * Note: 
 * 0 is considered to be an even index. 
 * All input strings are valid with no spaces
 */

namespace CodewarsKatas._7_kyu.Odd_Even_String_Sort
{
    public class OddEvenStringSort
    {
        public static string SortMyString(string s)
        {
            string odd = "";
            string even = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even += s[i];
                }
                else
                {
                    odd += s[i];
                }
            } 

            return even + " " + odd;
        }
    }
}

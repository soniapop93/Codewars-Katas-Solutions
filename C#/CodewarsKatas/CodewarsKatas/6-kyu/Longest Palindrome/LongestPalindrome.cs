/*
 * LINK: https://www.codewars.com/kata/54bb6f887e5a80180900046b/train/csharp
 * 
 * Find the length of the longest substring in the given string s that is the same in reverse.
 * 
 * As an example, if the input was “I like racecars that go fast”, the substring (racecar) length would be 7.
 * 
 * If the length of the input string is 0, the return value must be 0.
 * 
 * Example:
 *      "a" -> 1 
 *      "aab" -> 2  
 *      "abcde" -> 1
 *      "zzbaabcd" -> 4
 *      "" -> 0
 */

namespace CodewarsKatas._6_kyu.Longest_Palindrome
{
    public class LongestPalindrome
    {
        public static int GetLongestPalindrome(string str)
        {
            string rightStr = "";
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                string leftStr = "";
                rightStr += str[i];

                for (int j = str.Length - 1; j > 0; j--)
                {
                    leftStr += str[j];

                    if (rightStr == leftStr && (!rightStr.Equals("") || !leftStr.Equals("")))
                    {
                        count++;
                    }
                    else
                    {
                        leftStr = "";
                    }
                }
                rightStr = "";
            }
            return count;
        }
    }
}

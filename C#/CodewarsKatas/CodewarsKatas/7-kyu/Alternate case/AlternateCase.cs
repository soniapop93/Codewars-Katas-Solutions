/*
 * LINK: https://www.codewars.com/kata/57a62154cf1fa5b25200031e/train/csharp
 * 
 * Write function alternateCase which switch every letter in string from upper to lower and from lower to upper. E.g: Hello World -> hELLO wORLD
 */

namespace CodewarsKatas._7_kyu.Alternate_case
{
    public class AlternateCase
    {
        public static string alternateCase(string s)
        {
            string newStr = "";

            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] >= 97 && (int)s[i] <= 122) 
                {
                    newStr += (char)(((int)s[i]) - 32);
                }
                else if ((int)s[i] >= 65 && (int)s[i] <= 90)
                {
                    newStr += (char)(((int)s[i]) + 32);
                }
                else
                {
                    newStr += s[i];
                }
            }

            return newStr;
        }
    }
}

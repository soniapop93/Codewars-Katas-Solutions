/*
 * LINK: https://www.codewars.com/kata/5b180e9fedaa564a7000009a/train/csharp
 * 
 * In this Kata, you will be given a string that may have mixed uppercase and lowercase letters and your task is to convert that string to either lowercase only or uppercase only based on:
 * 
 *  - make as few changes as possible.
 *  - if the string contains equal number of uppercase and lowercase letters, convert the string to lowercase.
 * For example:
 * 
 * solve("coDe") = "code". Lowercase characters > uppercase. Change only the "D" to lowercase.
 * solve("CODe") = "CODE". Uppercase characters > lowecase. Change only the "e" to uppercase.
 * solve("coDE") = "code". Upper == lowercase. Change all to lowercase.
 * 
 */

namespace CodewarsKatas._7_kyu.Fix_string_case
{
    public class FixStringCase
    {
        public static string Solve(string s)
        {
            int countLower = 0;
            int countUpper = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 65 && s[i] <= 90)
                {
                    countUpper++;
                }
                else if (s[i] >= 97 && s[i] <= 122)
                {
                    countLower++;
                }
            }

            string result = "";


            for (int i = 0; i < s.Length; i++)
            {
                if ((countUpper == countLower) || (countLower > countUpper))
                {
                    if (s[i] >= 65 && s[i] <= 90)
                    {
                        result += (char)((s[i] + 32));
                    }
                    else
                    {
                        result += s[i];
                    }
                }
                else if (countUpper > countLower)
                {
                    if (s[i] >= 97 && s[i] <= 122)
                    {
                        result += (char)((int)s[i] - 32);
                    }
                    else
                    {
                        result += s[i];
                    }
                }
            }

            return result;
        }
    }
}

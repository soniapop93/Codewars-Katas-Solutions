/*
 * LINK: https://www.codewars.com/kata/52b757663a95b11b3d00062d/train/csharp
 * 
 * 
 * Write a function that accepts a string, and returns the same string with all even indexed characters in each word upper cased, and all odd indexed characters 
 * in each word lower cased. The indexing just explained is zero based, so the zero-ith index is even, therefore that character should be upper cased and you need 
 * to start over for each word.
 * 
 * The passed in string will only consist of alphabetical characters and spaces(' '). Spaces will only be present if there are multiple words. Words will be separated 
 * by a single space(' ').
 * 
 * Examples:
 * "String" => "StRiNg"
 * "Weird string case" => "WeIrD StRiNg CaSe"
 */

namespace CodewarsKatas._6_kyu.Weird_String_Case
{
    public class WeirdStringCase
    {
        public static string ToWeirdCase(string s)
        {
            string result = "";

            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 32) // 32 -> space
                {
                    result += s[i];
                    count = 0;
                    continue;
                }

                if (count % 2 == 0)
                {
                    if (s[i] >= 65 && s[i] <= 90)
                    {
                        result += s[i];
                    }
                    else if (s[i] >= 97 && s[i] <= 122)
                    {
                        result += ((char)(s[i] - 32)).ToString();
                    }
                    else
                    {
                        result += s[i];
                    }
                }
                else
                {
                    if (s[i] >= 97 && s[i] <= 122)
                    {
                        result += s[i];
                    }
                    else if (s[i] >= 65 && s[i] <= 90)
                    {
                        result += ((char)(s[i] + 32)).ToString();
                    }
                    else
                    {
                        result += s[i];
                    }
                }
                count++;
            }

            return result;
        }
    }
}

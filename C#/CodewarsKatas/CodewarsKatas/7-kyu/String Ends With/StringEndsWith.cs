/*
 * LINK: https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d/train/csharp
 * 
 * Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).
 * 
 * Examples:
 * 
 * solution('abc', 'bc') // returns true
 * solution('abc', 'd') // returns false
 * 
 */

namespace CodewarsKatas._7_kyu.String_Ends_With
{
    public class StringEndsWith
    {
        public static bool Solution(string str, string ending)
        {
            bool result = false;

            if (ending.Length <= str.Length)
            {
                string strEnding = "";

                for (int i = str.Length - ending.Length; i < str.Length; i++)
                {
                    strEnding += str[i];
                }

                if (strEnding.Equals(ending))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}

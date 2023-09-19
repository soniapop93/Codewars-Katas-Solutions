/*
 * LINK: https://www.codewars.com/kata/576bb3c4b1abc497ec000065/train/csharp
 * 
 * Compare two strings by comparing the sum of their values (ASCII character code).
 * 
 * For comparing treat all letters as UpperCase
 * null/NULL/Nil/None should be treated as empty strings
 * If the string contains other characters than letters, treat the whole string as it would be empty
 * Your method should return true, if the strings are equal and false if they are not equal.
 * 
 */


namespace CodewarsKatas._7_kyu.Compare_Strings_by_Sum_of_Chars
{
    public class CompareStringsBySumOfChars
    {
        public static bool Compare(string s1, string s2)
        {
            bool result = false;

            int sumS1 = 0;
            int sumS2 = 0;


            if (String.IsNullOrEmpty(s1) && String.IsNullOrEmpty(s2))
            {
                return true;
            }

            s1 = s1.ToUpper();
            s2 = s2.ToUpper();

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] >= 65 && s1[i] <= 90)
                {
                    sumS1 += s1[i];
                }
                else
                {
                    sumS1 = 0;
                    break;
                }
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (s2[i] >= 65 && s2[i] <= 90)
                {
                    sumS2 += s2[i];
                }
                else
                {
                    sumS2 = 0;
                    break;
                }
            }

            if (sumS1 == sumS2)
            {
                result = true;
            }

            return result;
        }
    }
}

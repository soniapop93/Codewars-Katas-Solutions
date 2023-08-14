/*
 * LINK: https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/train/csharp
 * 
 * Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that 
 * occur more than once in the input string. 
 * The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.
 * 
 * Example
 * "abcde" -> 0 # no characters repeats more than once
 * "aabbcde" -> 2 # 'a' and 'b'
 * "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
 * "indivisibility" -> 1 # 'i' occurs six times
 * "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
 * "aA11" -> 2 # 'a' and '1'
 * "ABBA" -> 2 # 'A' and 'B' each occur twice


 * 
 */

using System.Collections.Generic;

namespace CodewarsKatas._6_kyu.Counting_Duplicates
{
    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            int result = 0;

            Dictionary<string, int> countItems = new Dictionary<string, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!countItems.ContainsKey(str[i].ToString().ToLower()))
                {
                    countItems[str[i].ToString().ToLower()] = 1;
                }
                else
                {
                    countItems[str[i].ToString().ToLower()] = countItems[str[i].ToString().ToLower()] + 1;
                }
            }

            for (int j = 0; j < countItems.Count; j++)
            {
                if (countItems.ElementAt(j).Value > 1)
                {
                    result++;
                }
            }

            return result;
        }
    }
}

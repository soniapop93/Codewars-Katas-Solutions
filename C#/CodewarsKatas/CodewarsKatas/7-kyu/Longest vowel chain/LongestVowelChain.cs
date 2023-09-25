/*
 * LINK: https://www.codewars.com/kata/59c5f4e9d751df43cf000035/train/csharp
 * 
 * The vowel substrings in the word codewarriors are o,e,a,io. The longest of these has a length of 2. 
 * Given a lowercase string that has alphabetic characters only (both vowels and consonants) and no spaces,
 * return the length of the longest vowel substring. 
 * Vowels are any of aeiou.
 */

namespace CodewarsKatas._7_kyu.Longest_vowel_chain
{
    public class LongestVowelChain
    {
        public static int Solve(string str)
        {
            int count = 0;
            int longestFound = 0;

            List<string> vowels = new List<string>() { "a", "e", "i", "o", "u" };


            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i].ToString()))
                {
                    count++;

                    if (count > longestFound)
                    {
                        longestFound = count;
                    }
                }
                else
                {
                    if (count > longestFound)
                    {
                        longestFound = count;
                    }

                    count = 0;
                }
            }

            return longestFound;

        }
    }
}

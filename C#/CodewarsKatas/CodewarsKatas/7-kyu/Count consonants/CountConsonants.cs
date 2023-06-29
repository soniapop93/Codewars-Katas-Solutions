/*
 * Link: https://www.codewars.com/kata/564e7fc20f0b53eb02000106/train/csharp
 * 
 * Complete the function that takes a string of English-language text and returns the number of consonants in the string.
 * 
 * Consonants are all letters used to write English excluding the vowels a, e, i, o, u.
 */

using System.Collections.Generic;

namespace CodewarsKatas._7_kyu.Count_consonants
{
    public class CountConsonants
    {
        public static int ConsonantCount(string str)
        {
            List<string> vowels = new List<string> { "a", "e", "i", "o", "u" };
            List<string> consonants = new List<string>();
            str = str.ToLower();

            for (int i = 97; i < 123; i++)
            {
                if(!vowels.Contains(((char)i).ToString()))
                {
                    consonants.Add(((char)i).ToString());
                }
            }

            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (consonants.Contains(str[i].ToString()))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}

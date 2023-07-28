/*
 * LINK: https://www.codewars.com/kata/54ff3102c1bad923760001f3/train/csharp
 * 
 * Return the number (count) of vowels in the given string.
 *  
 * We will consider a, e, i, o, u as vowels for this Kata (but not y).
 * 
 * The input string will only consist of lower case letters and/or spaces.
 */

namespace CodewarsKatas._7_kyu.Vowel_Count
{
    public class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            List<string> vowels = new List<string>() { "a", "e", "i", "o", "u"};

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i].ToString()))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}

/*
 * LINK: https://www.codewars.com/kata/529eef7a9194e0cbc1000255/train/csharp
 * 
 * Complete the function to return true if the two arguments given are anagrams of each other; return false otherwise.
 * 
 * Examples
 * "foefet" is an anagram of "toffee"
 * 
 * "Buckethead" is an anagram of "DeathCubeK"
 */

namespace CodewarsKatas._7_kyu.Anagram_Detection
{
    public class AnagramDetection
    {
        public static bool IsAnagram(string test, string original)
        {
            bool anagram = false;

            if (test.Length == original.Length)
            {
                for (int i = 0; i < original.Length; i++)
                {
                    int count = 0;

                    for (int j = 0; j < test.Length; j++)
                    {
                        if (original[j].ToString().ToLower().Equals(test[i].ToString().ToLower()))
                        {
                            count++;
                        }
                    }

                    if (count > 0)
                    {
                        anagram = true;
                    }
                    else
                    {
                        anagram = false;
                        break;
                    }
                }
            }

            return anagram;
        }
    }
}

/*
 * LINK: https://www.codewars.com/kata/57eb8fcdf670e99d9b000272/train/csharp
 * 
 * Given a string of words, you need to find the highest scoring word.
 * 
 * Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.
 * 
 * For example, the score of abad is 8 (1 + 2 + 1 + 4).
 * 
 * You need to return the highest scoring word as a string.
 * 
 * If two words score the same, return the word that appears earliest in the original string.
 * 
 * All letters will be lowercase and all inputs will be valid.
 */

using System.Collections.Generic;

namespace CodewarsKatas._6_kyu.Highest_Scoring_Word
{
    public class HighestScoringWord
    {
        public static string High(string s)
        {
            string result = "";

            Dictionary<string, int> words = new Dictionary<string, int>();

            string[] splittedS = s.Split(" ");

            for (int k = 0; k < splittedS.Length; k++)
            {
                int wordSum = 0;

                for (int i = 0; i < splittedS[k].Length; i++)
                {
                    int count = 0;

                    for (int j = 97; j <= 122; j++)
                    {
                        count++;

                        if (splittedS[k][i] == j)
                        {
                            wordSum += count;
                            break;
                        }
                    }
                }

                words[splittedS[k]] = wordSum;
            }

            int highestWord = 0;

            foreach (KeyValuePair<string, int> word in words)
            {
                if (word.Value > highestWord)
                {
                    highestWord = word.Value;
                    result = word.Key;
                }
            }

            return result;
        }
    }
}

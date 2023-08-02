/*
 * LINK: https://www.codewars.com/kata/51689e27fe9a00b126000004/train/csharp
 * 
 * Complete the method so that it formats the words into a single comma separated value. The last word should be separated by the word 'and' instead of a comma. The method takes in an array of strings and returns a single formatted string.
 * 
 * Note:
 * 
 * Empty string values should be ignored.
 * Empty arrays or null/nil/None values being passed into the method should result in an empty string being returned.
 * Example: (Input --> output)
 * 
 * ['ninja', 'samurai', 'ronin'] --> "ninja, samurai and ronin"
 * ['ninja', '', 'ronin'] --> "ninja and ronin"
 * [] -->""
 */

using System.Collections.Generic;

namespace CodewarsKatas._6_kyu.Format_words_into_a_sentence
{
    public class FormatWordsIntoASentence
    {
        public static string FormatWords(string[] words)
        {
            string result = "";
            List<string> items = new List<string>();

            if (words != null)
            {
                if (words.Length > 1)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (!words[i].Equals(""))
                        {
                            items.Add(words[i]);
                        }
                    }

                    if (items.Count == 1)
                    {
                        result = items[0];
                    }
                    else
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            if (i == items.Count - 2)
                            {
                                result += items[i] + " and " + items[i + 1];
                                break;
                            }
                            else
                            {
                                result += items[i] + ", ";
                            }
                        }
                    }
                }
                else if (words.Length == 1)
                {
                    result = words[0];
                }
            }

            return result;
        }
    }
}

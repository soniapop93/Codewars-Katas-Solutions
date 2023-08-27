/*
 * LINK: https://www.codewars.com/kata/57eba158e8ca2c8aba0002a0/train/csharp
 * 
 * Given a string of words (x), you need to return an array of the words, sorted alphabetically by the final character in each.
 *
 *If two words have the same last letter, they returned array should show them in the order they appeared in the given string.
 */

using System.Collections.Generic;

namespace CodewarsKatas._7_kyu.SortByLastChar
{
    public class SortByLastChar
    {
        public static string[] Last(string x)
        {
            List<string> result = new List<string>();
            string[] splittedX = x.Split(" ");

            for (int j = 97; j <= 122; j++)
            {
                for (int i = 0; i < splittedX.Length; i++)
                {
                    if (splittedX[i][splittedX[i].Length - 1].ToString().ToLower().Equals(((char)j).ToString()))
                    {
                        result.Add(splittedX[i]);
                    }
                }
            }
            return result.ToArray();
        }
    }
}

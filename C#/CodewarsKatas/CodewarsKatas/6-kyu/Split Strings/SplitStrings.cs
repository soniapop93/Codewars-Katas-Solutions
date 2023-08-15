/*
 * LINK: https://www.codewars.com/kata/515de9ae9dcfc28eb6000001/train/csharp
 * 
 * Complete the solution so that it splits the string into pairs of two characters. 
 * If the string contains an odd number of characters then it should replace the missing second 
 * character of the final pair with an underscore ('_').
 * 
 * Examples:
 * 
 * 'abc' =>  ['ab', 'c_']
 * 'abcdef' => ['ab', 'cd', 'ef']
 */

using System.Collections.Generic;

namespace CodewarsKatas._6_kyu.Split_Strings
{
    public class SplitStrings
    {
        public static string[] Solution(string str)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < str.Length; i+=2)
            {
                string item = "";

                if (i + 1 < str.Length)
                {
                    item = str[i].ToString() + str[i + 1];
                }
                else
                {
                    item = str[i].ToString() + "_";
                }
                result.Add(item);
            }

            return result.ToArray();
        }
    }
}

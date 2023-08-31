/*
 * LINK: https://www.codewars.com/kata/553e8b195b853c6db4000048/train/csharp
 * 
 * Write a program to determine if a string contains only unique characters. Return true if it does and false otherwise.
 * 
 * The string may contain any of the 128 ASCII characters. Characters are case-sensitive, e.g. 'a' and 'A' are considered different characters.
 * 
 */

using System.Collections.Generic;

namespace CodewarsKatas._7_kyu.All_Unique
{
    public class AllUnique
    {
        public static bool HasUniqueChars(string str)
        {
            bool isUnique = false;
            List<char> chars = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!chars.Contains(str[i]))
                {
                    chars.Add(str[i]);
                    isUnique = true;
                }
                else
                {
                    isUnique = false;
                    break;
                }
            }

            return isUnique;
        }
    }
}

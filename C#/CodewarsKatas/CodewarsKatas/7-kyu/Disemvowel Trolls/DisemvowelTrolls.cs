/* 
 * LINK: https://www.codewars.com/kata/52fba66badcd10859f00097e/train/csharp
 * 
 * Trolls are attacking your comment section!
 * 
 * A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
 * 
 * Your task is to write a function that takes a string and return a new string with all vowels removed.
 * 
 * For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
 * 
 */

using System.Collections.Generic;

namespace CodewarsKatas._7_kyu.Disemvowel_Trolls
{
    public class DisemvowelTrolls
    {
        public static string Disemvowel(string str)
        {
            List<string> vowels = new List<string>() { "a", "e", "i", "o", "u"};
            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (!vowels.Contains(str[i].ToString().ToLower()))
                {
                    newStr = newStr + str[i];
                }
            }

            return newStr;
        }
    }
}

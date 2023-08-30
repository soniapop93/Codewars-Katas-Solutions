/*
 * LINK: https://www.codewars.com/kata/5727bb0fe81185ae62000ae3/train/csharp
 * 
 * Assume "#" is like a backspace in string. This means that string "a#bc#d" actually is "bd"
 *  
 * Your task is to process a string with "#" symbols.
 * 
 * Examples
 * "abc#d##c"      ==>  "ac"
 * "abc##d######"  ==>  ""
 * "#######"       ==>  ""
 * ""              ==>  ""
 * 
 */

using CodewarsKatas._4_kyu.Sum_Strings_as_Numbers;

namespace CodewarsKatas._6_kyu.Backspaces_in_string
{
    public class BackspacesInString
    {
        public static string CleanString(string s)
        {
            bool shouldCheck = true;
            int index = 0;

            while (shouldCheck && s.Length > 0)
            {
                if (s[index].ToString().Equals("#"))
                {
                    if (index > 0)
                    {
                        s = s.Remove(index - 1, 2);
                        index -= 2;
                        if (index < 0)
                            index = -1;
                    }
                    else
                    {
                        s = s.Remove(0, 1);
                        index = -1;
                    }
                }

                if (!s.Contains("#"))
                {
                    shouldCheck = false;
                }
                index++;
            }

            return s;
        }
    }
}

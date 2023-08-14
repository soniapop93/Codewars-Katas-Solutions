/*
 * LINK: https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp
 * 
 * The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears 
 * only once in the original string, or ")" if that character appears more than once in the original string. 
 * Ignore capitalization when determining if a character is a duplicate.
 * 
 * Examples
 * "din"      =>  "((("
 * "recede"   =>  "()()()"
 * "Success"  =>  ")())())"
 * "(( @"     =>  "))((" 
 */

namespace CodewarsKatas._6_kyu.Duplicate_Encoder
{
    public class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            string result = "";

            for (int i = 0; i < word.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < word.Length; j++)
                {
                    if (word[i].ToString().ToLower().Equals(word[j].ToString().ToLower()))
                    {
                        count++;
                    }
                }

                if (count > 1)
                {
                    result += ")";
                }
                else
                {
                    result += "(";
                }
            }

            return result;
        }
    }
}

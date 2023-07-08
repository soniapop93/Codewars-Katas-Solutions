/*
 * LINK: https://www.codewars.com/kata/5704aea738428f4d30000914/train/csharp
 * 
 * Create a function that will return a string that combines all of the letters of the three inputed strings in groups. 
 * Taking the first letter of all of the inputs and grouping them next to each other. Do this for every letter, see example below!
 * 
 * E.g. Input: "aa", "bb" , "cc" => Output: "abcabc"
 * 
 * Note: You can expect all of the inputs to be the same length.
 */

namespace CodewarsKatas._8_kyu.Triple_Trouble
{
    public class TripleTroubleKata
    {
        public static string TripleTrouble(string one, string two, string three)
        {
            string newStr = "";
            
            for (int i = 0; i < one.Length; i++)
            {
                newStr += one[i].ToString() + two[i].ToString() + three[i].ToString();
            }
            return newStr;
        }
    }
}

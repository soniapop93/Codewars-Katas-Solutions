/*
 * LINK: https://www.codewars.com/kata/56747fd5cb988479af000028/train/csharp
 * 
 * You are going to be given a word. Your job is to return the middle character of the word. 
 * If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.
 * 
 * #Examples:
 * 
 * Kata.getMiddle("test") should return "es"
 * 
 * Kata.getMiddle("testing") should return "t"
 * 
 * Kata.getMiddle("middle") should return "dd"
 * 
 Kata.getMiddle("A") should return "A"
 */

namespace CodewarsKatas._7_kyu.Get_the_Middle_Character
{
    public class GetTheMiddleCharacter
    {
        public static string GetMiddle(string s)
        {
            string result = "";
            int lenString = s.Length;

            if ((lenString % 2) == 0)
            {
                result = s[(lenString / 2) - 1].ToString() + s[(lenString / 2)].ToString();
            }
            else if (lenString == 1) 
            {
                result = s;
            }
            else
            {
                result = s[((lenString - 1) / 2)].ToString();
            }

            return result;
        }
    }
}

/*
 * LINK: https://www.codewars.com/kata/585b1fafe08bae9988000314/train/csharp
 * 
 * Given a string made of digits [0-9], return a string where each digit is repeated a number of times equals to its value.
 * 
 * Examples
 * "312" should return "333122"
 * "102269" should return "12222666666999999999"
 */

using System.Numerics;

namespace CodewarsKatas._7_kyu.Digits_explosion
{
    public class DigitsExplosion
    {
        public static string explode(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < Int32.Parse(s[i].ToString()); j++)
                {
                    result += s[i];
                }
            }

            return result;
        }
    }
}

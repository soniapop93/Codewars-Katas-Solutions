/*
 * LINK: https://www.codewars.com/kata/598f76a44f613e0e0b000026/train/csharp
 * 
 * Your task in this kata is to implement a function that calculates the sum of the integers inside a string. 
 * For example, in the string "The30quick20brown10f0x1203jumps914ov3r1349the102l4zy dog", 
 * the sum of the integers is 3635.
 * 
 */

namespace CodewarsKatas._7_kyu.Sum_of_integers_in_string
{
    public class SumOfIntegersInStringKata
    {
        public static int SumOfIntegersInString(string s)
        {
            int result = 0;

            string number = "";

            bool foundLetter = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 48 && s[i] <= 57)
                {
                    number += s[i].ToString();

                    if (i == s.Length - 1)
                    {
                        foundLetter = true;
                    }
                }
                else
                {
                    foundLetter = true;
                }

                if (foundLetter)
                {
                    if (!number.Equals(""))
                    {
                        result += Int32.Parse(number);
                    }
                    number = "";
                    foundLetter = false;
                }
                
            }

            return result;
        }
    }
}
